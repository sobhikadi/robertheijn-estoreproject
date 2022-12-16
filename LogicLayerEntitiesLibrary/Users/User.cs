using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Konscious.Security.Cryptography;
using LogicLayerEntitiesLibrary.Exceptions;

namespace LogicLayerEntitiesLibrary.Users
{
    public abstract class User
    {
        private string firstName, lastName, email;
        private byte[] salt, password;
        

        public int Id { get; set; }
        public string FirstName { get { return firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field first name cannot be empty");
                if (value.Length < 2 || value.Length > 255) throw new OutOfrangeException("First name must have at least 2 charachters and maximum of 255 charachters");
                firstName = value;
            }
        }
        public string LastName { get { return lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field last name cannot be empty");
                if (value.Length < 2 || value.Length > 255) throw new OutOfrangeException("Last name must have at least 2 charachters and maximum of 255 charachters");
                lastName = value;
            }
        }
        public string Email { get { return email; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field email cannot be empty");
                Regex regex = new Regex(@"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
                if (!regex.IsMatch(value)) throw new ArgumentException("Email has been entered in an incorrect format");
                email = value;
            }
        }
        public byte[] Salt { get { return salt; } private set { salt = value; } }
        public byte[] Password { get { return password; } private set { password = value; } }
        

        public User(string fName, string lName, string email, string password) 
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
            Salt = CreateSalt();
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("The field password cannot be empty");
            else if (password == "DoNoTUPdaTePassWord!@#HHGTR") Password = Encoding.UTF8.GetBytes(password);
            else Password = HashPassword(password, Salt);
            
        }

        public User(int id, string fName, string lName, string email, byte[] salt, byte[] password)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Salt = salt;
            Password = password;
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

        public void ChangeParentInformation(User newUser, User currentUser) 
        {
            FirstName = newUser.FirstName;
            LastName = newUser.LastName;
            Email = newUser.Email;
            if (Encoding.Default.GetString(newUser.Password) == "DoNoTUPdaTePassWord!@#HHGTR")
            {
                Salt = currentUser.Salt;
                Password = currentUser.Password;
            }
            else
            {
                Salt = newUser.Salt;
                Password = newUser.Password;
            }
        }

        public abstract bool ChangeInformation(User newUser, User currentUser);



    }
}
