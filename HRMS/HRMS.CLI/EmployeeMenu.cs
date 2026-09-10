using System;
using HRMS.Library.BL;
using HRMS.Library.DL;

namespace HRMS.CLI
{
    // Mirrors EmployeeDashboard: an employee can view their own profile,
    // salary slips, schedule, and leave requests, plus submit a new leave
    // request and change their password.
    internal static class EmployeeMenu
    {
        public static void Run(string empID, string username)
        {
            bool loggedIn = true;
            while (loggedIn)
            {
                ConsoleUI.Header("Employee Dashboard (" + username + ")");
                Console.WriteLine("1. View my profile");
                Console.WriteLine("2. View my salary slips");
                Console.WriteLine("3. View my schedule");
                Console.WriteLine("4. Submit a leave request");
                Console.WriteLine("5. View my leave requests");
                Console.WriteLine("6. Change my password");
                Console.WriteLine("7. Logout");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": ViewProfile(empID); break;
                    case "2": ViewSalarySlips(empID); break;
                    case "3": ViewSchedule(empID); break;
                    case "4": SubmitLeave(empID); break;
                    case "5": ViewMyLeaves(empID); break;
                    case "6": ChangePassword(username); break;
                    case "7": loggedIn = false; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        private static void ViewProfile(string empID)
        {
            ConsoleUI.Header("My Profile");
            EmployeeDL dl = new EmployeeDL();
            ConsoleUI.PrintTable(dl.GetByID(empID));
            ConsoleUI.Pause();
        }

        private static void ViewSalarySlips(string empID)
        {
            ConsoleUI.Header("My Salary Slips");
            ConsoleUI.PrintTable(SalaryDL.GetSlipsByEmpID(empID));
            ConsoleUI.Pause();
        }

        private static void ViewSchedule(string empID)
        {
            ConsoleUI.Header("My Schedule");
            ConsoleUI.PrintTable(ScheduleDL.GetScheduleByEmpID(empID));
            ConsoleUI.Pause();
        }

        private static void SubmitLeave(string empID)
        {
            ConsoleUI.Header("Submit Leave Request");
            string reason = ConsoleUI.Prompt("Reason");
            string fromDate = ConsoleUI.Prompt("From date (e.g. 2026-09-15)");
            string toDate = ConsoleUI.Prompt("To date (e.g. 2026-09-17)");

            LeaveBL leave = new LeaveBL(empID, reason, fromDate, toDate);
            string result = LeaveDL.Save(leave);

            if (result == "True")
                ConsoleUI.Success("Leave request submitted (status: Pending).");
            else
                ConsoleUI.Error(result);
            ConsoleUI.Pause();
        }

        private static void ViewMyLeaves(string empID)
        {
            ConsoleUI.Header("My Leave Requests");
            LeaveDL dl = new LeaveDL();
            ConsoleUI.PrintTable(dl.GetByID(empID));
            ConsoleUI.Pause();
        }

        private static void ChangePassword(string username)
        {
            ConsoleUI.Header("Change Password");
            string oldPass = ConsoleUI.ReadPassword("Current password");
            string newPass = ConsoleUI.ReadPassword("New password");
            string confirm = ConsoleUI.ReadPassword("Confirm new password");

            if (newPass != confirm)
            {
                ConsoleUI.Error("New passwords do not match.");
                ConsoleUI.Pause();
                return;
            }

            string result = UserDL.UpdatePassword(username, oldPass, newPass);
            if (result == "True")
                ConsoleUI.Success("Password updated.");
            else
                ConsoleUI.Error(result);
            ConsoleUI.Pause();
        }
    }
}
