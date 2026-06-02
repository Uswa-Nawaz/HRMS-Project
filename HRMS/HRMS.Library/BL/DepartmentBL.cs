using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    public class DepartmentBL
    {
        // Standalone class — does not extend PersonBL
        // Departments are not people, so no inheritance here
        private int deptID;
        private string deptName;

        public DepartmentBL()
        {
            deptID = 0;
            deptName = "";
        }

        public DepartmentBL(int deptID, string deptName)
        {
            SetDeptID(deptID);
            SetDeptName(deptName);
        }

        public int GetDeptID() { return deptID; }
        public string GetDeptName() { return deptName; }
        public void SetDeptID(int value) { deptID = value; }
        public void SetDeptName(string value) { deptName = value; }
    }
}
