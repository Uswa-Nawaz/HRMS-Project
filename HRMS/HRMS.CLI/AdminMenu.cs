using System;
using HRMS.Library.BL;
using HRMS.Library.DL;

namespace HRMS.CLI
{
    // Everything an Admin could do across AdminDashboard + its SubForms
    // (AddEmployeeForm, UpdateEmployeeForm, PromoteDemoteForm,
    // SalarySlipForm), reachable from one numbered menu instead of
    // separate windows.
    internal static class AdminMenu
    {
        public static void Run(string username)
        {
            bool loggedIn = true;
            while (loggedIn)
            {
                ConsoleUI.Header("Admin Dashboard (" + username + ")");
                Console.WriteLine("1. Employees");
                Console.WriteLine("2. Departments");
                Console.WriteLine("3. Payroll / Salary Slips");
                Console.WriteLine("4. Leave Requests");
                Console.WriteLine("5. Work Schedules");
                Console.WriteLine("6. Change My Password");
                Console.WriteLine("7. Logout");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": EmployeesMenu(); break;
                    case "2": DepartmentsMenu(); break;
                    case "3": PayrollMenu(); break;
                    case "4": LeaveMenu(); break;
                    case "5": ScheduleMenu(); break;
                    case "6": ChangePassword(username); break;
                    case "7": loggedIn = false; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        // ---------------------------------------------------------------
        // Employees
        // ---------------------------------------------------------------
        private static void EmployeesMenu()
        {
            bool back = false;
            while (!back)
            {
                ConsoleUI.Header("Employees");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. List all employees");
                Console.WriteLine("3. Search employees");
                Console.WriteLine("4. View employee by ID");
                Console.WriteLine("5. Update employee");
                Console.WriteLine("6. Promote / Demote (change designation)");
                Console.WriteLine("7. Delete employee");
                Console.WriteLine("8. Back");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": AddEmployee(); break;
                    case "2": ListAllEmployees(); break;
                    case "3": SearchEmployees(); break;
                    case "4": ViewEmployeeByID(); break;
                    case "5": UpdateEmployee(); break;
                    case "6": PromoteDemote(); break;
                    case "7": DeleteEmployee(); break;
                    case "8": back = true; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        private static void AddEmployee()
        {
            ConsoleUI.Header("Add Employee");

            ListAllDepartments(); // so the admin can see valid DeptIDs first

            EmployeeBL emp = new EmployeeBL();
            emp.SetName(ConsoleUI.Prompt("Full name (starts with a capital letter)"));
            emp.SetEmail(ConsoleUI.Prompt("Email"));
            emp.SetPhone(ConsoleUI.Prompt("Phone (11 digits)"));
            emp.SetAddress(ConsoleUI.Prompt("Address"));
            emp.SetUsername(ConsoleUI.Prompt("Username (4-20 chars, letters/digits/_)"));
            emp.SetPassword(ConsoleUI.ReadPassword("Password (8-15 chars, needs upper/digit/symbol)"));
            emp.SetSalary(ConsoleUI.PromptDouble("Salary (>= 40,000)"));
            emp.SetDesignation(ConsoleUI.Prompt("Designation"));
            emp.SetDeptID(ConsoleUI.PromptInt("Department ID"));

            // Same as AddEmployeeForm: EmpID is generated, never typed in.
            emp.SetEmpID(EmployeeDL.GenerateEmpID());

            string result = EmployeeDL.Save(emp);
            if (result == "True")
                ConsoleUI.Success("Employee added with ID " + emp.GetEmpID() + ".");
            else
                ConsoleUI.Error(result);

            ConsoleUI.Pause();
        }

        private static void ListAllEmployees()
        {
            ConsoleUI.Header("All Employees");
            EmployeeDL dl = new EmployeeDL();
            ConsoleUI.PrintTable(dl.GetAll());
            ConsoleUI.Pause();
        }

        private static void SearchEmployees()
        {
            ConsoleUI.Header("Search Employees");
            string keyword = ConsoleUI.Prompt("Search by name, department, or EmpID");
            ConsoleUI.PrintTable(EmployeeDL.Search(keyword));
            ConsoleUI.Pause();
        }

        private static void ViewEmployeeByID()
        {
            ConsoleUI.Header("View Employee");
            string empID = ConsoleUI.Prompt("Employee ID (e.g. EMP-1001)");
            EmployeeDL dl = new EmployeeDL();
            ConsoleUI.PrintTable(dl.GetByID(empID));
            ConsoleUI.Pause();
        }

        private static void UpdateEmployee()
        {
            ConsoleUI.Header("Update Employee");
            string empID = ConsoleUI.Prompt("Employee ID to update");

            EmployeeDL dl = new EmployeeDL();
            var existing = dl.GetByID(empID);
            if (existing.Rows.Count == 0)
            {
                ConsoleUI.Error("No employee found with that ID.");
                ConsoleUI.Pause();
                return;
            }
            ConsoleUI.PrintTable(existing);

            Console.WriteLine("Enter the new values (required fields, like UpdateEmployeeForm):");
            EmployeeBL emp = new EmployeeBL();
            emp.SetEmpID(empID);
            emp.SetName(ConsoleUI.Prompt("Name"));
            emp.SetEmail(ConsoleUI.Prompt("Email"));
            emp.SetPhone(ConsoleUI.Prompt("Phone (11 digits)"));
            emp.SetAddress(ConsoleUI.Prompt("Address"));
            emp.SetSalary(ConsoleUI.PromptDouble("Salary"));
            emp.SetDesignation(ConsoleUI.Prompt("Designation"));
            emp.SetDeptID(ConsoleUI.PromptInt("Department ID"));

            string result = EmployeeDL.Update(emp);
            if (result == "True")
                ConsoleUI.Success("Employee updated.");
            else
                ConsoleUI.Error(result);

            ConsoleUI.Pause();
        }

        private static void PromoteDemote()
        {
            ConsoleUI.Header("Promote / Demote");
            string empID = ConsoleUI.Prompt("Employee ID");
            string newDesignation = ConsoleUI.Prompt("New designation");

            string result = EmployeeDL.UpdateDesignation(empID, newDesignation);
            if (result == "True")
                ConsoleUI.Success("Designation updated.");
            else
                ConsoleUI.Error(result);

            ConsoleUI.Pause();
        }

        private static void DeleteEmployee()
        {
            ConsoleUI.Header("Delete Employee");
            string empID = ConsoleUI.Prompt("Employee ID to delete");

            if (!ConsoleUI.Confirm("This also removes their login account. Delete " + empID + "?"))
            {
                Console.WriteLine("Cancelled.");
                ConsoleUI.Pause();
                return;
            }

            EmployeeDL dl = new EmployeeDL();
            bool ok = dl.Delete(empID);
            if (ok)
                ConsoleUI.Success("Employee deleted.");
            else
                ConsoleUI.Error("Employee not found or could not be deleted.");

            ConsoleUI.Pause();
        }

        // ---------------------------------------------------------------
        // Departments
        // ---------------------------------------------------------------
        private static void DepartmentsMenu()
        {
            bool back = false;
            while (!back)
            {
                ConsoleUI.Header("Departments");
                Console.WriteLine("1. Add department");
                Console.WriteLine("2. List all departments");
                Console.WriteLine("3. Delete department");
                Console.WriteLine("4. Back");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": AddDepartment(); break;
                    case "2": ListAllDepartments(); break;
                    case "3": DeleteDepartment(); break;
                    case "4": back = true; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        private static void AddDepartment()
        {
            ConsoleUI.Header("Add Department");
            string name = ConsoleUI.Prompt("Department name");
            string result = DepartmentDL.Save(name);
            if (result == "True")
                ConsoleUI.Success("Department added.");
            else
                ConsoleUI.Error(result);
            ConsoleUI.Pause();
        }

        private static void ListAllDepartments()
        {
            Console.WriteLine();
            Console.WriteLine("-- Departments --");
            DepartmentDL dl = new DepartmentDL();
            ConsoleUI.PrintTable(dl.GetAll());
        }

        private static void DeleteDepartment()
        {
            ConsoleUI.Header("Delete Department");
            ListAllDepartments();
            string deptID = ConsoleUI.Prompt("Department ID to delete");

            DepartmentDL dl = new DepartmentDL();
            bool ok = dl.Delete(deptID);
            if (ok)
                ConsoleUI.Success("Department deleted.");
            else
                ConsoleUI.Error("Could not delete — it either doesn't exist or still has employees assigned.");
            ConsoleUI.Pause();
        }

        // ---------------------------------------------------------------
        // Payroll
        // ---------------------------------------------------------------
        private static void PayrollMenu()
        {
            bool back = false;
            while (!back)
            {
                ConsoleUI.Header("Payroll / Salary Slips");
                Console.WriteLine("1. Generate salary slip for an employee");
                Console.WriteLine("2. View salary slips for an employee");
                Console.WriteLine("3. Back");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": GenerateSalarySlip(); break;
                    case "2": ViewSalarySlips(); break;
                    case "3": back = true; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        private static void GenerateSalarySlip()
        {
            ConsoleUI.Header("Generate Salary Slip");
            string empID = ConsoleUI.Prompt("Employee ID");
            double gross = ConsoleUI.PromptDouble("Gross salary");
            string month = ConsoleUI.Prompt("Month (e.g. 2026-09)");

            // Same 7% default tax rate as EmployeeBL.CalculateTax() / SalarySlipBL.
            SalarySlipBL slip = new SalarySlipBL(empID, gross, month);
            string result = SalaryDL.GenerateSlip(slip);

            if (result == "True")
            {
                ConsoleUI.Success("Slip generated. Tax: " + slip.GetTaxAmount().ToString("F2") +
                                   "  Net: " + slip.GetNetSalary().ToString("F2"));
            }
            else
            {
                ConsoleUI.Error(result);
            }
            ConsoleUI.Pause();
        }

        private static void ViewSalarySlips()
        {
            ConsoleUI.Header("Salary Slips");
            string empID = ConsoleUI.Prompt("Employee ID");
            ConsoleUI.PrintTable(SalaryDL.GetSlipsByEmpID(empID));
            ConsoleUI.Pause();
        }

        // ---------------------------------------------------------------
        // Leave Requests
        // ---------------------------------------------------------------
        private static void LeaveMenu()
        {
            bool back = false;
            while (!back)
            {
                ConsoleUI.Header("Leave Requests");
                Console.WriteLine("1. View all leave requests");
                Console.WriteLine("2. Approve / Reject a leave request");
                Console.WriteLine("3. Delete a leave request");
                Console.WriteLine("4. Back");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": ViewAllLeaves(); break;
                    case "2": DecideLeave(); break;
                    case "3": DeleteLeave(); break;
                    case "4": back = true; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        private static void ViewAllLeaves()
        {
            ConsoleUI.Header("All Leave Requests");
            LeaveDL dl = new LeaveDL();
            ConsoleUI.PrintTable(dl.GetAll());
            ConsoleUI.Pause();
        }

        private static void DecideLeave()
        {
            ConsoleUI.Header("Approve / Reject Leave");
            ViewAllLeaves();

            int leaveID = ConsoleUI.PromptInt("Leave ID");
            string status = ConsoleUI.Prompt("New status (Approved/Rejected)");

            string result = LeaveDL.UpdateStatus(leaveID, status);
            if (result == "True")
                ConsoleUI.Success("Leave request updated.");
            else
                ConsoleUI.Error(result);
            ConsoleUI.Pause();
        }

        private static void DeleteLeave()
        {
            ConsoleUI.Header("Delete Leave Request");
            string leaveID = ConsoleUI.Prompt("Leave ID to delete");

            LeaveDL dl = new LeaveDL();
            bool ok = dl.Delete(leaveID);
            if (ok)
                ConsoleUI.Success("Leave request deleted.");
            else
                ConsoleUI.Error("Leave request not found.");
            ConsoleUI.Pause();
        }

        // ---------------------------------------------------------------
        // Work Schedules
        // ---------------------------------------------------------------
        private static void ScheduleMenu()
        {
            bool back = false;
            while (!back)
            {
                ConsoleUI.Header("Work Schedules");
                Console.WriteLine("1. Assign shift to an employee");
                Console.WriteLine("2. View all schedules");
                Console.WriteLine("3. View schedule for an employee");
                Console.WriteLine("4. Back");

                string choice = ConsoleUI.Prompt("Choose an option");
                switch (choice)
                {
                    case "1": AssignSchedule(); break;
                    case "2": ViewAllSchedules(); break;
                    case "3": ViewEmployeeSchedule(); break;
                    case "4": back = true; break;
                    default: ConsoleUI.Error("Invalid option."); break;
                }
            }
        }

        private static void AssignSchedule()
        {
            ConsoleUI.Header("Assign Shift");
            string empID = ConsoleUI.Prompt("Employee ID");
            string shift = ConsoleUI.Prompt("Shift (Morning/Evening/Night)");
            string start = ConsoleUI.Prompt("Start time (e.g. 09:00)");
            string end = ConsoleUI.Prompt("End time (e.g. 17:00)");

            string result = ScheduleDL.AssignSchedule(empID, shift, start, end);
            if (result == "True")
                ConsoleUI.Success("Shift assigned.");
            else
                ConsoleUI.Error(result);
            ConsoleUI.Pause();
        }

        private static void ViewAllSchedules()
        {
            ConsoleUI.Header("All Schedules");
            ConsoleUI.PrintTable(ScheduleDL.GetAll());
            ConsoleUI.Pause();
        }

        private static void ViewEmployeeSchedule()
        {
            ConsoleUI.Header("Employee Schedule");
            string empID = ConsoleUI.Prompt("Employee ID");
            ConsoleUI.PrintTable(ScheduleDL.GetScheduleByEmpID(empID));
            ConsoleUI.Pause();
        }

        // ---------------------------------------------------------------
        // Account
        // ---------------------------------------------------------------
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
