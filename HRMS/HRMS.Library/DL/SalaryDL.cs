using HRMS.Library.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.DL
{
    public class SalaryDL
    {
        static string connString = UserDL.connectionString;

        // Generate salary slip for an employee
        public static string GenerateSlip(SalarySlipBL slip)
        {
            if (string.IsNullOrWhiteSpace(slip.GetEmpID()))
                return "Employee ID is required.";
            if (string.IsNullOrWhiteSpace(slip.GetMonth()))
                return "Month is required.";
            if (slip.GetGrossSalary() <= 0)
                return "Salary must be greater than zero.";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Check if slip already exists for this month
                string checkQuery = @"SELECT COUNT(*) FROM SalarySlips
                                      WHERE EmpID = @id AND Month = @m";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@id", slip.GetEmpID());
                checkCmd.Parameters.AddWithValue("@m", slip.GetMonth());
                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0) return "Salary slip for this month already exists.";

                string query = @"INSERT INTO SalarySlips
                                 (EmpID, GrossSalary, TaxAmount, NetSalary, Month)
                                 VALUES (@id, @gross, @tax, @net, @month)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", slip.GetEmpID());
                cmd.Parameters.AddWithValue("@gross", slip.GetGrossSalary());
                cmd.Parameters.AddWithValue("@tax", slip.GetTaxAmount());
                cmd.Parameters.AddWithValue("@net", slip.GetNetSalary());
                cmd.Parameters.AddWithValue("@month", slip.GetMonth());
                cmd.ExecuteNonQuery();
                return "True";
            }
        }

        // Get all slips for one employee
        public static DataTable GetSlipsByEmpID(string empID)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT SlipID, Month, GrossSalary,
                                        TaxAmount, NetSalary
                                 FROM SalarySlips
                                 WHERE EmpID = @id
                                 ORDER BY SlipID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
