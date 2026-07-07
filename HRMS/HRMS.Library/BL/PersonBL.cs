using HRMS.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.BL
{
    public abstract class PersonBL : IValidatable
    {
        // private fields
        protected string name;
        protected string email;
        protected string phone;
        protected string address;

        // ---( Default Constructor )---
        public PersonBL()
        {
            name = "";
            email = "";
            phone = "";
            address = "";
        }

        // ---( Getters )--- ]
        public string GetName() { return name; }
        public string GetEmail() { return email; }
        public string GetPhone() { return phone; }
        public string GetAddress() { return address; }

        // ---( Setters )---
        public void SetName(string value) { name = value; }
        public void SetEmail(string value) { email = value; }
        public void SetPhone(string value) { phone = value; }
        public void SetAddress(string value) { address = value; }

        // ---( IValidatable, each subclass writes their own )---
        public abstract bool Validate();
        public abstract string GetValidationError();
    }
}
