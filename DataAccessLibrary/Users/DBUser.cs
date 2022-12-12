using LogicLayerEntitiesLibrary.Exceptions;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerEntitiesLibrary.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Employees
{
    public class DBUser : IDBMediatorUsers
    {
        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372_robertheij;" + "user id=dbi376372_robertheij;" + "password=robertheijn;" + "connect timeout=30;";

        public int InsertUser(User user)
        {
            if (CheckIfUserExist(user.Email)) throw new ArgumentException("User with the entered email already exists in the database");
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (user is Employee)
                {
                    Employee employee = (Employee)user;

                    string sql = "insert into [User] (first_name, last_name, email, salt, password) values (@firstName, @lastName, @email, @salt, @password); select SCOPE_IDENTITY(); insert into Employee (id, role, last_modified) values (SCOPE_IDENTITY(), @role, @last_modified)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@salt", employee.Salt);
                    cmd.Parameters.AddWithValue("@password", employee.Password);
                    cmd.Parameters.AddWithValue("@role", employee.EmployeeRole.ToString());
                    cmd.Parameters.AddWithValue("@last_modified", DBNull.Value);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) id = Convert.ToInt32(dr[0]);
                }
                else if (user is Customer) 
                {
                    Customer customer = (Customer)user;

                    string sql = "insert into User (first_name, last_name, email, salt, password) values (@firstName, @lastName, @email, @salt, @password); select SCOPE_IDENTITY(); insert into Customer (id) values (SCOPE_IDENTITY())";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@email", customer.Email);
                    cmd.Parameters.AddWithValue("@salt", customer.Salt);
                    cmd.Parameters.AddWithValue("@password", customer.Password);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) id = Convert.ToInt32(dr[0]);
                }
            }
            return id;
        }

        public List<User> SearchEmployee(string term, EmployeeSearchType type)
        {
            List<User> employees = new List<User>();
            string query = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (type == EmployeeSearchType.role)
                {
                    query = "select * from ViewEmployeeInformation WHERE role = @role ORDER BY id;";

                }
                else
                {
                    query = $"select * from ViewEmployeeInformation WHERE {type} LIKE '%{term}%' ORDER BY id;";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (type == EmployeeSearchType.role) cmd.Parameters.AddWithValue("@role", term);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows) throw new NoResultException("No results found");

                while (dr.Read())
                {
                    DateTime? lastModified;

                    if (dr["last_modified"] != DBNull.Value) lastModified = (DateTime)dr["last_modified"];
                    else lastModified = null;

                    employees.Add(new Employee(Convert.ToInt32(dr["id"]), (string)dr["first_name"], (string)dr["last_name"], (string)dr["email"], lastModified, (EmployeeRole)Enum.Parse(typeof(EmployeeRole), (string)dr["role"])));
                }
            }
            return employees;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //string sqlCus =
                //    " select users.id, firstName, lastName, email, salt, Password, phoneNumber, Address, postalCode, LastModified, BillingAddress, billingPostalCode from users inner join Customer on users.Id = Customer.Id order by users.id;";

                //SqlCommand cmdCus = new SqlCommand(sqlCus, conn);

                //SqlDataReader drCus = cmdCus.ExecuteReader();

                //while (drCus.Read())
                //{
                //    string? phoneNumber, address, postalCode, billingAddress, billingPostalCode;
                //    DateTime? lastModified;
                //    if (drCus["phoneNumber"] != DBNull.Value) phoneNumber = (string)drCus["phoneNumber"];
                //    else phoneNumber = null;
                //    if (drCus["address"] != DBNull.Value) address = (string)drCus["address"];
                //    else address = null;
                //    if (drCus["postalCode"] != DBNull.Value) postalCode = (string)drCus["postalCode"];
                //    else postalCode = null;
                //    if (drCus["billingAddress"] != DBNull.Value) billingAddress = (string)drCus["billingAddress"];
                //    else billingAddress = null;
                //    if (drCus["billingPostalCode"] != DBNull.Value) billingPostalCode = (string)drCus["billingPostalCode"];
                //    else billingPostalCode = null;
                //    if (drCus["LastModified"] != DBNull.Value) lastModified = (DateTime)drCus["LastModified"];
                //    else lastModified = null;

                //    users.Add(new Customer(Convert.ToInt32(drCus["id"]), (string)drCus["firstName"], (string)drCus["lastname"], (string)drCus["email"], (byte[])drCus["salt"], (byte[])drCus["password"], phoneNumber, address, postalCode, billingAddress, billingPostalCode, lastModified));
                //}

                string sqlEmp = " select * from ViewEmployeeInformation;";

                SqlCommand cmdEmp = new SqlCommand(sqlEmp, conn);
                SqlDataReader drEmp = cmdEmp.ExecuteReader();

                while (drEmp.Read())
                {
                    DateTime? lastModified;

                    if (drEmp["last_modified"] != DBNull.Value) lastModified = (DateTime)drEmp["last_modified"];
                    else lastModified = null;

                    users.Add(new Employee(Convert.ToInt32(drEmp["id"]), (string)drEmp["first_name"], (string)drEmp["last_name"], (string)drEmp["email"], lastModified, (EmployeeRole)Enum.Parse(typeof(EmployeeRole), (string)drEmp["role"])));
                }
            }
            return users;
        }

        private bool CheckIfUserExist(string email)
        {
            bool exist = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id from [User] where email = @email";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@email", email);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) exist = true;
            }
            return exist;
        }
    }
}
