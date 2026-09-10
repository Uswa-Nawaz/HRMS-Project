using System;
using HRMS.Library.BL;
using HRMS.Library.DL;

namespace HRMS.CLI
{
    // Console front end for the HRMS backend.
    //
    // This project talks to HRMS.Library exactly the way HRMS.UI does:
    // it never touches SQL directly, it only calls the same BL/DL classes
    // (UserDL, EmployeeDL, DepartmentDL, LeaveDL, SalaryDL, ScheduleDL)
    // that the WinForms app uses. No changes were needed in HRMS.Library
    // to make this work.
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "HRMS - Command Line Interface";
            ConsoleUI.Header("Human Resource Management System (CLI)");

            try
            {
                RunApp();
            }
            catch (Exception ex)
            {
                // Last-resort catch so a dropped DB connection or similar
                // doesn't just crash the console window shut.
                ConsoleUI.Error("Unexpected error: " + ex.Message);
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }

        private static void RunApp()
        {
            while (true)
            {
                // Mirrors LoginForm_Load: if there is no admin yet, the
                // GUI forces InitSetupForm before anything else can happen.
                if (!UserDL.IsAdminExists())
                {
                    bool created = RunInitialSetup();
                    if (!created)
                    {
                        Console.WriteLine("Setup cancelled. The system cannot run without an admin account.");
                        return;
                    }
                    continue;
                }

                bool keepGoing = RunLogin();
                if (!keepGoing) return;
            }
        }

        // Mirrors InitSetupForm.btnCreate_Click. Returns false only if the
        // user explicitly gives up (equivalent to closing the setup form).
        private static bool RunInitialSetup()
        {
            ConsoleUI.Header("Initial Setup - Create Master Admin Account");
            Console.WriteLine("No admin account exists yet. Let's create one.");

            while (true)
            {
                string name = ConsoleUI.Prompt("Full name");
                string username = ConsoleUI.Prompt("Username");
                string password = ConsoleUI.ReadPassword("Password");
                string confirm = ConsoleUI.ReadPassword("Confirm password");

                if (password != confirm)
                {
                    ConsoleUI.Error("Passwords do not match.");
                    if (!ConsoleUI.Confirm("Try again?")) return false;
                    continue;
                }

                AdminBL admin = new AdminBL();
                admin.SetName(name);
                admin.SetUsername(username);
                admin.SetPassword(password);
                admin.SetRole("Admin");
                admin.SetAdminID("ADM-1001"); // same fixed ID InitSetupForm uses

                string result = UserDL.RegisterAdmin(admin);

                if (result == "True")
                {
                    ConsoleUI.Success("Admin account created successfully! You can now log in.");
                    ConsoleUI.Pause();
                    return true;
                }

                ConsoleUI.Error(result);
                if (!ConsoleUI.Confirm("Try again?")) return false;
            }
        }

        // Mirrors LoginForm.btnLogin_Click. Returns false when the user
        // wants to exit the whole application from the login screen.
        private static bool RunLogin()
        {
            ConsoleUI.Header("Login");
            Console.WriteLine("Type 'exit' as the username to quit.");

            string username = ConsoleUI.Prompt("Username");
            if (username.Equals("exit", StringComparison.OrdinalIgnoreCase))
                return false;

            string password = ConsoleUI.ReadPassword("Password");

            if (username == "" || password == "")
            {
                ConsoleUI.Error("Please enter username and password.");
                return true;
            }

            string role = UserDL.CheckLogin(username, password);

            if (role == "Admin")
            {
                ConsoleUI.Success("Welcome, " + username + " (Admin).");
                AdminMenu.Run(username);
            }
            else if (role == "Employee")
            {
                string empID = UserDL.GetEmpIDByUsername(username);
                if (empID == null)
                {
                    ConsoleUI.Error("Employee record not found. Contact admin.");
                }
                else
                {
                    ConsoleUI.Success("Welcome, " + username + " (Employee).");
                    EmployeeMenu.Run(empID, username);
                }
            }
            else
            {
                ConsoleUI.Error("Invalid credentials. Please try again.");
            }

            return true;
        }
    }
}
