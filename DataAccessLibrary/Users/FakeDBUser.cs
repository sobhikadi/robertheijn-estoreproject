using LogicLayerEntitiesLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Employees
{
    public class FakeDBUser : IDBMediatorUsers
    {
        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public int InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchEmployee(string term, EmployeeSearchType type)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User newUser, User currentUser)
        {
            throw new NotImplementedException();
        }
    }
}
