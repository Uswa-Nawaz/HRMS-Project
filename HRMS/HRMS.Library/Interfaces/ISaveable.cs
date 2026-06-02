using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.Interfaces
{
    public interface ISaveable
    {
        // Saves a new record to the database
        // Returns true if it worked, false if it failed
        bool Save();

        // Deletes a record from the database by its ID
        bool Delete(string id);
    }
}
