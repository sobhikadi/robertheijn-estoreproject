using LogicLayerEntitiesLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Employees
{
    public interface IDBMediatorUsers
    {
        public int InsertUser(User user);

        public bool UpdateUser(User newUser, User currentUser);

        public List<User> SearchEmployee(string term, EmployeeSearchType type);

        public List<User> GetAllUsers();

    }
}
