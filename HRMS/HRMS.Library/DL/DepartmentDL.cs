using HRMS.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.DL
{
    public class DepartmentDL : ISaveable, ISearchable
    {
        //used connection string UserDL since they are in the same database
        static string connString = UserDL.connectionString;

        // ISaveable —> Add new department
        public bool Save()
        {
            return false; // use overload below
        }

        public static string Save(string deptName)
        {
            if (string.IsNullOrWhiteSpace(deptName))
                return "Department name cannot be empty.";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Check duplicate
                string checkQuery = "SELECT COUNT(*) FROM Departments WHERE DeptName = @n";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@n", deptName);
                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0) return "Department already exists.";

                string query = "INSERT INTO Departments (DeptName) VALUES (@n)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n", deptName);
                cmd.ExecuteNonQuery();
                return "True";
            }
        }

        // ISaveable —> Delete department
        // BL rule: cannot delete if employees are assigned to it
        public bool Delete(string deptID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Check if any employee is in this department
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE DeptID = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", deptID);
                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0) return false; // cannot delete

                string query = "DELETE FROM Departments WHERE DeptID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", deptID);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // ISearchable — GetAll
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Departments ORDER BY DeptName ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // ISearchable — GetByID
        public DataTable GetByID(string deptID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Departments WHERE DeptID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", deptID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
