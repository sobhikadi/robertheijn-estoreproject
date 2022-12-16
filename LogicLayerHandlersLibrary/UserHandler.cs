using DataAccessLibrary.Employees;
using DataAccessLibrary.Products;
using Konscious.Security.Cryptography;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerEntitiesLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerHandlersLibrary
{
    public class UserHandler
    {
        private IDBMediatorUsers dbHandlerUsers;
        private List<User> users;

        public UserHandler(IDBMediatorUsers dbHandlerUsers) 
        {
            this.dbHandlerUsers = dbHandlerUsers;
            this.users = new List<User>();
            UpdateListOfUsers();
        }

        public IList<User> Users { get { return users.AsReadOnly(); } }

        public void AddUser(User user)
        {
            int id = dbHandlerUsers.InsertUser(user);
            if (id == 0) throw new ArgumentException("User has not been added successfully");
            user.Id = id;
            users.Add(user);
        }

        public void UpdateUser(User newUser, User currentUser)
        {
            bool updated = dbHandlerUsers.UpdateUser(newUser, currentUser);
            if (!updated) throw new ArgumentException("Employee has not been updated successfully");

            foreach (User user in users) 
            {
                if(user.Id == currentUser.Id) user.ChangeInformation(newUser, currentUser);
            }
        }

        public void DeleteUser(User user)
        {
            bool deleted = dbHandlerUsers.DeleteUser(user);
            if (!deleted) throw new ArgumentException("Employee has not been deleted successfully");
            users.Remove(user);
        }

        public IList<User> SearchEmployee(string term, EmployeeSearchType type)
        {
            return dbHandlerUsers.SearchEmployee(term, type);
        }

        private void UpdateListOfUsers()
        {
            users.Clear();
            users = dbHandlerUsers.GetAllUsers();
        }






        //public string ValidateUser(string email, string enteredPassword)
        //{
        //    string role = "";
        //    byte[] salt = dbHandlerUsers.GetSalt(email);
        //    if (salt == null) return role;
        //    byte[] enteredPasswordHashed = HashPassword(enteredPassword, salt);
        //    role = dbHandlerUsers.ComaparePassword(email, enteredPasswordHashed);
        //    return role;
        //}

        private byte[] HashPassword(string password, byte[] salt)
        {
            Argon2id argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 3;
            argon2.Iterations = 2;
            argon2.MemorySize = 512 * 512;

            return argon2.GetBytes(16);
        }

    }
}
