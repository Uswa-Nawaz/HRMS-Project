using HRMS.Library.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HRMS.Library.Utility
{
    // Static class and is called like Validations.IsValidNewEmployee(emp)
    // Returns "True" if valid, or an error message string if invalid
    // This is Single Responsibility, this class ONLY does validation
    public static class Validations
    {
        // Called by EmployeeDL before inserting a new employee
        public static string IsValidNewEmployee(EmployeeBL emp)
        {
            // Check if anything is empty first
            if (emp.GetName() == "" ||
                emp.GetUsername() == "" ||
                emp.GetPassword() == "" ||
                emp.GetEmail() == "" ||
                emp.GetPhone() == "" ||
                emp.GetAddress() == "" ||
                emp.GetDesignation() == "")
            {
                return "Missing Information!";
            }

            string check;

            check = NameCheck(emp.GetName());
            if (check != "True") return check;

            check = UsernameCheck(emp.GetUsername());
            if (check != "True") return check;

            check = PasswordCheck(emp.GetPassword());
            if (check != "True") return check;

            check = EmailCheck(emp.GetEmail());
            if (check != "True") return check;

            check = PhoneCheck(emp.GetPhone());
            if (check != "True") return check;

            if (emp.GetSalary() < 40000 || emp.GetSalary() > 1000000)
                return "Salary must be between 40,000 and 1,000,000.";

            if (emp.GetDeptID() <= 0)
                return "Please select a department.";

            return "True";
        }

        // Called by AdminDL / UserDL before inserting a new admin
        public static string IsValidNewAdmin(AdminBL admin)
        {
            if (admin.GetName() == "" ||
                admin.GetUsername() == "" ||
                admin.GetPassword() == "")
            {
                return "Missing Information!";
            }

            string check;

            check = NameCheck(admin.GetName());
            if (check != "True") return check;

            check = UsernameCheck(admin.GetUsername());
            if (check != "True") return check;

            check = PasswordCheck(admin.GetPassword());
            if (check != "True") return check;

            return "True";
        }

        // Called when employee updates their own info
        public static string IsValidUpdatedEmployee(EmployeeBL emp)
        {
            if (emp.GetName() == "" ||
                emp.GetEmail() == "" ||
                emp.GetPhone() == "" ||
                emp.GetAddress() == "")
            {
                return "Missing Information!";
            }

            string check;

            check = NameCheck(emp.GetName());
            if (check != "True") return check;

            check = EmailCheck(emp.GetEmail());
            if (check != "True") return check;

            check = PhoneCheck(emp.GetPhone());
            if (check != "True") return check;

            return "True";
        }

        // ---( Individual field checks — each returns "True" or an error )---
        public static string NameCheck(string name)
        {
            if (name.Length > 50)
                return "Name must be less than 50 characters.";

            if (name[0] < 'A' || name[0] > 'Z')
                return "First letter of name must be capital.";

            foreach (char c in name)
                if (!char.IsLetter(c) && c != ' ')
                    return "Name can only contain letters.";

            return "True";
        }

        public static string UsernameCheck(string username)
        {
            if (username.Length < 4 || username.Length > 20)
                return "Username must be between 4 and 20 characters.";

            foreach (char c in username)
                if (!char.IsLetterOrDigit(c) && c != '_')
                    return "Username can only contain letters, digits, and underscores.";

            return "True";
        }

        public static string PasswordCheck(string password)
        {
            if (password.Length < 8 || password.Length > 15)
                return "Password must be between 8 and 15 characters.";

            if (password.Contains(" "))
                return "Password cannot contain spaces.";

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetter(c)) hasSpecial = true;
            }

            if (!hasUpper) return "Password must have at least one capital letter.";
            if (!hasDigit) return "Password must have at least one number.";
            if (!hasSpecial) return "Password must have at least one special character.";

            return "True";
        }

        public static string EmailCheck(string email)
        {
            if (email.Length > 50)
                return "Email must not exceed 50 characters.";

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, pattern))
                return "Email format is not valid.";

            return "True";
        }

        public static string PhoneCheck(string phone)
        {
            if (phone.Length != 11)
                return "Phone number must be exactly 11 digits.";

            foreach (char c in phone)
                if (!char.IsDigit(c))
                    return "Phone number must contain only digits.";

            return "True";
        }

        // Password strength meter — used by UI in real time
        // Returns 0 = Weak, 1 = Medium, 2 = Strong
        public static int GetPasswordStrength(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;

            int score = 0;
            if (input.Length >= 8) score++;
            if (input.Length >= 12) score++;

            foreach (char c in input)
                if (char.IsUpper(c)) { score++; break; }

            foreach (char c in input)
                if (char.IsDigit(c)) { score++; break; }

            foreach (char c in input)
                if (!char.IsLetterOrDigit(c)) { score++; break; }

            if (score <= 2) return 0;
            if (score <= 4) return 1;
            return 2;
        }
    }
}
