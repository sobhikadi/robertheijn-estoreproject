using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Users
{
    public class Employee : User
    {
        private EmployeeRole employeeRole;
        private DateTime? lastModified;

        public EmployeeRole EmployeeRole { get { return employeeRole; } private set { employeeRole = value; } }
        public DateTime? LastModified { get { return lastModified; } private set { lastModified = value; } }

        public Employee(string fName, string lName, string email, string password, DateTime? lastModified, EmployeeRole employeeRole) : base(fName, lName, email, password)
        {
            EmployeeRole = employeeRole;
        }
        public Employee(int id, string fName, string lName, string email, string password, DateTime? lastModified, EmployeeRole employeeRole) : base(id, fName, lName, email, password)
        {
            EmployeeRole = employeeRole;
        }
    }
}
