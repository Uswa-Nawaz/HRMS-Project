using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.Interfaces
{
    public interface IValidatable
    {
        // Returns true if all fields are valid, false if anything is wrong
        bool Validate();
        // Returns a human-readable error message explaining what's wrong
        string GetValidationError();
    }
}
