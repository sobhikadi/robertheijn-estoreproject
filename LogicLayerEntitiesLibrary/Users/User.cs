using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Konscious.Security.Cryptography;

namespace LogicLayerEntitiesLibrary.Users
{
    public abstract class User
    {
        private string firstName, lastName, email;
        private byte[] salt, password;
        

        public int Id { get; set; }
        public string FirstName { get { return firstName; } private set { firstName = value; } }
        public string LastName { get { return lastName; } private set { lastName = value; } }
        public string Email { get { return email; } private set { email = value; } }
        public byte[] Salt { get { return salt; } private set { salt = value; } }
        public byte[] Password { get { return password; } private set { password = value; } }
        

        public User(string fName, string lName, string email, string password) 
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
            Salt = CreateSalt();
            Password = HashPassword(password, Salt);
        }

        public User(int id, string fName, string lName, string email, string password)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Salt = CreateSalt();
            Password = HashPassword(password, Salt);
        }


        public byte[] CreateSalt()
        {
            byte[] salt = new byte[16];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(salt);
            return salt;
        }

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
