using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    public class UserBL : PersonBL
    {
        protected string username;
        protected string password;
        protected string role;

        // ---( Default Constructor )---
        public UserBL() : base()
        {
            username = "";
            password = "";
            role = "Employee";
        }

        // ---( Parameterized Constructor )---
        public UserBL(string username, string password) : base()
        {
            this.username = username;
            this.password = password;
        }

        // ---( Copy Constructor )---
        public UserBL(UserBL other) : base()
        {
            name = other.name;
            email = other.email;
            phone = other.phone;
            address = other.address;
            username = other.username;
            password = other.password;
            role = other.role;
        }

        // ---( Getters )---
        public string GetUsername() { return username; }
        public string GetPassword() { return password; }
        public string GetRole() { return role; }

        // ---( Setter )---
        public void SetUsername(string value) { username = value; }
        public void SetPassword(string value) { password = value; }
        public void SetRole(string value) { role = value; }

        // ---( IValidatable )---
        public override bool Validate()
        {
            return name != "" && username != "" && password != "";
        }

        public override string GetValidationError()
        {
            if (name == "") return "Name is required.";
            if (username == "") return "Username is required.";
            if (password == "") return "Password is required.";
            return "";
        }
    }
}
