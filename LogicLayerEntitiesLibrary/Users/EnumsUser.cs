using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Users
{
    public enum EmployeeRole
    {
        HREmployee,
        InventoryEmployee,
        SalesEmployee
    }

    public enum EmployeeSearchType
    {
        first_name,
        last_name,
        role,
        email
    }
}
