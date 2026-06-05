using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.DL
{
    public class ScheduleDL
    {
        static string connString = UserDL.connectionString;

        // Assign shift to employee
        public static string AssignSchedule(string empID, string shiftName,
                                    string startTime, string endTime)
        {
            if (string.IsNullOrWhiteSpace(empID) ||
                string.IsNullOrWhiteSpace(shiftName) ||
                string.IsNullOrWhiteSpace(startTime) ||
                string.IsNullOrWhiteSpace(endTime))
                return "All fields are required.";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open(); // open once, keep open for both commands

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Step 1: remove existing schedule if any
                        string deleteQuery = "DELETE FROM WorkSchedules WHERE EmpID = @id";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                        deleteCmd.Parameters.AddWithValue("@id", empID);
                        deleteCmd.ExecuteNonQuery();

                        // Step 2: insert new schedule
                        string insertQuery = @"INSERT INTO WorkSchedules
                                       (EmpID, ShiftName, StartTime, EndTime)
                                       VALUES (@id, @shift, @start, @end)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                        insertCmd.Parameters.AddWithValue("@id", empID);
                        insertCmd.Parameters.AddWithValue("@shift", shiftName);
                        insertCmd.Parameters.AddWithValue("@start", startTime);
                        insertCmd.Parameters.AddWithValue("@end", endTime);
                        insertCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return "True";
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        if (ex.Message.Contains("FOREIGN KEY"))
                            return "Employee ID does not exist.";
                        return "Database error: " + ex.Message;
                    }
                }
            }
        }

        // Get schedule for one employee
        public static DataTable GetScheduleByEmpID(string empID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT ShiftName, StartTime, EndTime
                                 FROM WorkSchedules
                                 WHERE EmpID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Get all schedules — Admin view
        public static DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT e.EmpID, e.Name, ws.ShiftName,
                                        ws.StartTime, ws.EndTime
                                 FROM WorkSchedules ws
                                 INNER JOIN Employees e ON ws.EmpID = e.EmpID
                                 ORDER BY e.Name";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

    }
}
