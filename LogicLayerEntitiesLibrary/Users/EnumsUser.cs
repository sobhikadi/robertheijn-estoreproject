using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Users
{
    public enum EmployeeRole
    {
        hr_employee,
        inventory_employee,
        sales_employee
    }

    public enum EmployeeSearchType
    {
        id,
        first_name,
        last_name,
        role,
        email
    }
}
