using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    public class LeaveBL
    {
        private int leaveID;
        private string empID;
        private string reason;
        private string status;   // Pending, Approved, Rejected
        private string fromDate;
        private string toDate;

        public LeaveBL()
        {
            leaveID = 0;
            empID = "";
            reason = "";
            status = "Pending";
            fromDate = "";
            toDate = "";
        }

        public LeaveBL(string empID, string reason, string fromDate, string toDate)
        {
            SetEmpID(empID);
            SetReason(reason);
            SetFromDate(fromDate);
            SetToDate(toDate);
            status = "Pending";
        }

        // ---( Getters )---
        public int GetLeaveID() { return leaveID; }
        public string GetEmpID() { return empID; }
        public string GetReason() { return reason; }
        public string GetStatus() { return status; }
        public string GetFromDate() { return fromDate; }
        public string GetToDate() { return toDate; }

        // ---( Setters )---
        public void SetEmpID(string value) { empID = value; }
        public void SetReason(string value) { reason = value; }
        public void SetStatus(string value) { status = value; }
        public void SetFromDate(string value) { fromDate = value; }
        public void SetToDate(string value) { toDate = value; }
    }
}
