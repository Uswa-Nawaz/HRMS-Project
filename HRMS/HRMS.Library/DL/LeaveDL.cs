using HRMS.Library.BL;
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
    public class LeaveDL : ISaveable, ISearchable
    {
        static string connString = UserDL.connectionString;

        // ISaveable — Submit new leave request
        public bool Save() { return false; }

        public static string Save(LeaveBL leave)
        {
            if (string.IsNullOrWhiteSpace(leave.GetReason()))
                return "Reason cannot be empty.";
            if (string.IsNullOrWhiteSpace(leave.GetFromDate()))
                return "From date is required.";
            if (string.IsNullOrWhiteSpace(leave.GetToDate()))
                return "To date is required.";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO LeaveRequests
                                 (EmpID, Reason, FromDate, ToDate, Status)
                                 VALUES (@id, @r, @from, @to, 'Pending')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", leave.GetEmpID());
                cmd.Parameters.AddWithValue("@r", leave.GetReason());
                cmd.Parameters.AddWithValue("@from", leave.GetFromDate());
                cmd.Parameters.AddWithValue("@to", leave.GetToDate());
                conn.Open();
                cmd.ExecuteNonQuery();
                return "True";
            }
        }

        // ISaveable — Delete a leave request
        public bool Delete(string leaveID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM LeaveRequests WHERE LeaveID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", leaveID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        // ISearchable — GetAll (Admin sees all)
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT lr.LeaveID, e.Name, lr.Reason,
                                        lr.FromDate, lr.ToDate, lr.Status
                                 FROM LeaveRequests lr
                                 INNER JOIN Employees e ON lr.EmpID = e.EmpID
                                 ORDER BY lr.Status, lr.FromDate";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // ISearchable — GetByID (Employee sees only their own)
        public DataTable GetByID(string empID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT LeaveID, Reason, FromDate, ToDate, Status
                                 FROM LeaveRequests
                                 WHERE EmpID = @id
                                 ORDER BY FromDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Approve or Reject — Admin action
        public static string UpdateStatus(int leaveID, string status)
        {
            if (status != "Approved" && status != "Rejected")
                return "Invalid status.";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE LeaveRequests SET Status = @s WHERE LeaveID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@id", leaveID);
                conn.Open();
                cmd.ExecuteNonQuery();
                return "True";
            }
        }
    }
}
