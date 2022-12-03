using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Users
{
    public class Employee : User
    {
        private EnumsUser.EmployeeRole employeeRole;
        private DateTime? lastModified;

        public EnumsUser.EmployeeRole EmployeeRole { get { return employeeRole; } private set { employeeRole = value; } }
        public DateTime? LastModified { get { return lastModified; } private set { lastModified = value; } }

        public Employee(string fName, string lName, string email, string password, DateTime? lastModified, EnumsUser.EmployeeRole employeeRole) : base(fName, lName, email, password)
        {
            EmployeeRole = employeeRole;
        }
        public Employee(int id, string fName, string lName, string email, string password, DateTime? lastModified, EnumsUser.EmployeeRole employeeRole) : base(id, fName, lName, email, password)
        {
            EmployeeRole = employeeRole;
        }
    }
}
