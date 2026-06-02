using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Library.Interfaces
{
    public interface ISearchable
    {
        // Gets every record from the table
        DataTable GetAll();

        // Gets one specific record by its ID
        DataTable GetByID(string id);
    }
}
