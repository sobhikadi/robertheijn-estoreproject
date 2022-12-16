using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            LastModified = lastModified;
            EmployeeRole = employeeRole;
        }
        public Employee(int id, string fName, string lName, string email, DateTime? lastModified, EmployeeRole employeeRole, byte[] salt, byte[] password) : base(id, fName, lName, email, salt, password)
        {
            LastModified = lastModified;
            EmployeeRole = employeeRole;
        }

        public override bool ChangeInformation(User newEmployee, User currentEmployee)
        {
            bool updated = false;
            Employee updatedEmployee = (Employee)newEmployee;

            currentEmployee.ChangeParentInformation(newEmployee, currentEmployee);
            
            EmployeeRole = updatedEmployee.EmployeeRole;
            LastModified = updatedEmployee.LastModified;

            return updated;
        }
    }
}
