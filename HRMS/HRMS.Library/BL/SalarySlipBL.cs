using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    // Composition, a SalarySlip belongs to an Employee
    // If the Employee is deleted, their salary slips go too
    public class SalarySlipBL
    {
        private int slipID;
        private string empID;
        private double grossSalary;
        private double taxAmount;
        private double netSalary;
        private string month;

        public SalarySlipBL()
        {
            slipID = 0;
            empID = "";
            grossSalary = 0;
            taxAmount = 0;
            netSalary = 0;
            month = "";
        }

        public SalarySlipBL(string empID, double grossSalary, string month)
        {
            SetEmpID(empID);
            SetGrossSalary(grossSalary);
            SetMonth(month);
        }

        // ---( Getters )---
        public int GetSlipID() { return slipID; }
        public string GetEmpID() { return empID; }
        public double GetGrossSalary() { return grossSalary; }
        public double GetTaxAmount() { return taxAmount; }
        public double GetNetSalary() { return netSalary; }
        public string GetMonth() { return month; }

        // ---( Setters )---
        public void SetEmpID(string value) { empID = value; }
        public void SetMonth(string value) { month = value; }
        public void SetGrossSalary(double value)
        {
            grossSalary = value;
            taxAmount = grossSalary * 0.07;
            netSalary = grossSalary - taxAmount;
        }
    }
}
