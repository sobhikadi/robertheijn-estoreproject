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
    }
}
