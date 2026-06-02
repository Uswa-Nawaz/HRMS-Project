using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    public class AdminBL : UserBL
    {
        private string adminID;

        // ---( Default Constructor )---
        public AdminBL() : base()
        {
            adminID = "";
            role = "Admin";
        }

        // ---( Parameterized Constructor )---
        public AdminBL(string adminID, string name) : base()
        {
            this.adminID = adminID;
            this.name = name;
            role = "Admin";
        }

        // ---( Getter )---
        public string GetAdminID() { return adminID; }

        // ---( Setter — just assign )---
        public void SetAdminID(string value) { adminID = value; }

        // ---( IValidatable override )---
        public override bool Validate()
        {
            return base.Validate() && adminID != "";
        }

        public override string GetValidationError()
        {
            string baseError = base.GetValidationError();
            if (baseError != "") return baseError;
            if (adminID == "") return "Admin ID not assigned.";
            return "";
        }
    }
}
