using HRMS.Library.BL; // added this so DL can use BL
using HRMS.Library.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.DL
{
    public class UserDL
    {
        //connection string
        public static string connectionString =
            @"Server=.\SQLEXPRESS;Database=HRMS_DB;Trusted_Connection=True;";

        // Check if any Admin exists, this function is used at app startup
        public static bool IsAdminExists()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Login check, returns Role if match found, else null
        public static string CheckLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username = @u AND Password = @p";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                return null;
            }
        }

        // Get EmpID linked to a username it is used after login
        // so the Employee Dashboard knows who is logged in
        public static string GetEmpIDByUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT e.EmpID FROM Employees e
                                 INNER JOIN Users u ON e.UserID = u.UserID
                                 WHERE u.Username = @u";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                return null;
            }
        }

        // Method to Register first Admin, used by InitSetupForm only
        public static string RegisterAdmin(AdminBL admin)
        {
            // Validate first
            string check = Validations.IsValidNewAdmin(admin);
            if (check != "True") return check;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Check username is unique
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@u", admin.GetUsername());
                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0) return "Username already taken.";

                string query = @"INSERT INTO Users (Username, Password, Role)
                                 VALUES (@u, @p, @r)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", admin.GetUsername());
                cmd.Parameters.AddWithValue("@p", admin.GetPassword());
                cmd.Parameters.AddWithValue("@r", admin.GetRole());
                cmd.ExecuteNonQuery();
                return "True";
            }
        }

        // Update password — used by change password forms
        public static string UpdatePassword(string username,
                                            string oldPassword,
                                            string newPassword)
        {
            // Validate new password format
            string check = Validations.PasswordCheck(newPassword);
            if (check != "True") return check;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Confirm old password matches
                string verifyQuery = "SELECT COUNT(*) FROM Users WHERE Username = @u AND Password = @p";
                SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn);
                verifyCmd.Parameters.AddWithValue("@u", username);
                verifyCmd.Parameters.AddWithValue("@p", oldPassword);
                conn.Open();
                int match = (int)verifyCmd.ExecuteScalar();
                if (match == 0) return "Current password is incorrect.";

                string query = "UPDATE Users SET Password = @newP WHERE Username = @u";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newP", newPassword);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.ExecuteNonQuery();
                return "True";
            }
        }
    }
}
