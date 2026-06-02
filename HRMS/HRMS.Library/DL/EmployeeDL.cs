using HRMS.Library.BL; // added this so DL can use BL
using HRMS.Library.Interfaces; //added this so DL can use interfaces
using HRMS.Library.Utility; // added this so DL can use Validations
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.DL
{
    // Implements ISaveable and ISearchable from Interfaces DLL
    public class EmployeeDL : ISaveable, ISearchable // This is the Dependency Inversion principle in action
    {
        //used connection string UserDL since they are in the same database
        static string connString = UserDL.connectionString;

        // Generate next EmpID automatically
        public static string GenerateEmpID()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(EmpID, 5, LEN(EmpID)) AS INT)), 1000) FROM Employees";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int maxId = (int)cmd.ExecuteScalar();
                return "EMP-" + (maxId + 1);
            }
        }

        // ISaveable, Saves means (Add new employee)
        // Uses a transaction, both Users and Employees insert
        // must succeed together or both roll back
        public bool Save()
        {
            // This overload exists to satisfy ISaveable interface
            // Actual save uses the overload below with the BL object
            return false;
        }

        public static string Save(EmployeeBL emp)
        {
            // Validate first
            string check = Validations.IsValidNewEmployee(emp);
            if (check != "True") return check;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Insert into Users, get back the new UserID
                        string userQuery = @"INSERT INTO Users (Username, Password, Role)
                                            OUTPUT INSERTED.UserID
                                            VALUES (@u, @p, @r)";
                        SqlCommand userCmd = new SqlCommand(userQuery, conn, transaction);
                        userCmd.Parameters.AddWithValue("@u", emp.GetUsername());
                        userCmd.Parameters.AddWithValue("@p", emp.GetPassword());
                        userCmd.Parameters.AddWithValue("@r", emp.GetRole());
                        int newUserID = (int)userCmd.ExecuteScalar();

                        // Step 2: Insert into Employees using that UserID
                        string empQuery = @"INSERT INTO Employees
                                           (EmpID, UserID, DeptID, Name, Email,
                                            Phone, Address, Salary, Designation)
                                           VALUES
                                           (@id, @uid, @did, @name, @email,
                                            @phone, @addr, @sal, @desig)";
                        SqlCommand empCmd = new SqlCommand(empQuery, conn, transaction);
                        empCmd.Parameters.AddWithValue("@id", emp.GetEmpID());
                        empCmd.Parameters.AddWithValue("@uid", newUserID);
                        empCmd.Parameters.AddWithValue("@did", emp.GetDeptID());
                        empCmd.Parameters.AddWithValue("@name", emp.GetName());
                        empCmd.Parameters.AddWithValue("@email", emp.GetEmail());
                        empCmd.Parameters.AddWithValue("@phone", emp.GetPhone());
                        empCmd.Parameters.AddWithValue("@addr", emp.GetAddress());
                        empCmd.Parameters.AddWithValue("@sal", emp.GetSalary());
                        empCmd.Parameters.AddWithValue("@desig", emp.GetDesignation());
                        empCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return "True";
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        if (ex.Message.Contains("UNIQUE"))
                            return "Username or Email already exists.";
                        return "Database error: " + ex.Message;
                    }
                }
            }
        }

        // ISaveable — Delete employee by EmpID
        public bool Delete(string empID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Get the UserID before deleting employee
                        string getUID = "SELECT UserID FROM Employees WHERE EmpID = @id";
                        SqlCommand getCmd = new SqlCommand(getUID, conn, transaction);
                        getCmd.Parameters.AddWithValue("@id", empID);
                        object result = getCmd.ExecuteScalar();
                        if (result == null) return false;
                        int userID = (int)result;

                        // Delete from Employees first (child)
                        string delEmp = "DELETE FROM Employees WHERE EmpID = @id";
                        SqlCommand delEmpCmd = new SqlCommand(delEmp, conn, transaction);
                        delEmpCmd.Parameters.AddWithValue("@id", empID);
                        delEmpCmd.ExecuteNonQuery();

                        // Then delete from Users (parent)
                        string delUser = "DELETE FROM Users WHERE UserID = @uid";
                        SqlCommand delUserCmd = new SqlCommand(delUser, conn, transaction);
                        delUserCmd.Parameters.AddWithValue("@uid", userID);
                        delUserCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // ISearchable — GetAll employees
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT e.EmpID, e.Name, d.DeptName,
                                        e.Designation, e.Salary, e.Email,
                                        e.Phone, u.Username
                                 FROM Employees e
                                 INNER JOIN Departments d ON e.DeptID = d.DeptID
                                 INNER JOIN Users u       ON e.UserID = u.UserID
                                 ORDER BY e.Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // ISearchable, GetByID (single employee)
        public DataTable GetByID(string empID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT e.EmpID, e.Name, d.DeptName,
                                        e.Designation, e.Salary, e.Email,
                                        e.Phone, e.Address, u.Username
                                 FROM Employees e
                                 INNER JOIN Departments d ON e.DeptID = d.DeptID
                                 INNER JOIN Users u       ON e.UserID = u.UserID
                                 WHERE e.EmpID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Update employee info
        public static string Update(EmployeeBL emp)
        {
            string check = Validations.IsValidUpdatedEmployee(emp);
            if (check != "True") return check;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Employees
                                 SET Name        = @name,
                                     Email       = @email,
                                     Phone       = @phone,
                                     Address     = @addr,
                                     Salary      = @sal,
                                     Designation = @desig,
                                     DeptID      = @did
                                 WHERE EmpID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", emp.GetName());
                cmd.Parameters.AddWithValue("@email", emp.GetEmail());
                cmd.Parameters.AddWithValue("@phone", emp.GetPhone());
                cmd.Parameters.AddWithValue("@addr", emp.GetAddress());
                cmd.Parameters.AddWithValue("@sal", emp.GetSalary());
                cmd.Parameters.AddWithValue("@desig", emp.GetDesignation());
                cmd.Parameters.AddWithValue("@did", emp.GetDeptID());
                cmd.Parameters.AddWithValue("@id", emp.GetEmpID());
                conn.Open();
                cmd.ExecuteNonQuery();
                return "True";
            }
        }

        // Search by name or department
        public static DataTable Search(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT e.EmpID, e.Name, d.DeptName,
                                        e.Designation, e.Salary
                                 FROM Employees e
                                 INNER JOIN Departments d ON e.DeptID = d.DeptID
                                 WHERE e.Name    LIKE @kw
                                    OR d.DeptName LIKE @kw
                                    OR e.EmpID   LIKE @kw";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Promote / Demote — just updates designation
        public static string UpdateDesignation(string empID, string newDesignation)
        {
            if (string.IsNullOrWhiteSpace(newDesignation))
                return "Designation cannot be empty.";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE Employees SET Designation = @d WHERE EmpID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@d", newDesignation);
                cmd.Parameters.AddWithValue("@id", empID);
                conn.Open();
                cmd.ExecuteNonQuery();
                return "True";
            }
        }
    }
}
