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
                // Remove old schedule first if exists
                string deleteQuery = "DELETE FROM WorkSchedules WHERE EmpID = @id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@id", empID);
                conn.Open();
                deleteCmd.ExecuteNonQuery();

                // Insert new schedule
                string query = @"INSERT INTO WorkSchedules
                                 (EmpID, ShiftName, StartTime, EndTime)
                                 VALUES (@id, @shift, @start, @end)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empID);
                cmd.Parameters.AddWithValue("@shift", shiftName);
                cmd.Parameters.AddWithValue("@start", startTime);
                cmd.Parameters.AddWithValue("@end", endTime);
                cmd.ExecuteNonQuery();
                return "True";
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
