using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    public class EmployeeBL : UserBL
    {
        private string empID;
        private double salary;
        private string designation;
        private int deptID;

        // ---( Default Constructor )---
        public EmployeeBL() : base()
        {
            empID = "";
            salary = 40000;
            designation = "Associate";
            deptID = 0;
        }

        // ---( Parameterized Constructor )---
        public EmployeeBL(string empID, string name, double salary,
                          string designation, int deptID) : base()
        {
            this.empID = empID;
            this.name = name;
            this.salary = salary;
            this.designation = designation;
            this.deptID = deptID;
        }

        // ---( Copy Constructor )---
        public EmployeeBL(EmployeeBL other) : base(other)
        {
            empID = other.empID;
            salary = other.salary;
            designation = other.designation;
            deptID = other.deptID;
        }

        // ---( Getters )---
        public string GetEmpID() { return empID; }
        public double GetSalary() { return salary; }
        public string GetDesignation() { return designation; }
        public int GetDeptID() { return deptID; }

        // ---( Setters)---
        public void SetEmpID(string value) { empID = value; }
        public void SetSalary(double value) { salary = value; }
        public void SetDesignation(string value) { designation = value; }
        public void SetDeptID(int value) { deptID = value; }

        // ---( Static Polymorphism )---
        // ---( overloaded methods, same name different parameters )---
        public double CalculateTax()
        {
            return salary * 0.07;
        }
        public double CalculateTax(double customRate)
        {
            return salary * customRate;
        }

        // ---( IValidatable override )---
        public override bool Validate()
        {
            return base.Validate()
                && empID != ""
                && salary >= 40000
                && deptID > 0;
        }

        public override string GetValidationError()
        {
            string baseError = base.GetValidationError();
            if (baseError != "") return baseError;
            if (empID == "") return "Employee ID not assigned.";
            if (salary < 40000) return "Salary must be at least 40,000.";
            if (deptID <= 0) return "Department must be selected.";
            return "";
        }
    }
}
