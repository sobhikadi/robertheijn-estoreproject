using LogicLayerEntitiesLibrary.Exceptions;
using LogicLayerEntitiesLibrary.Users;
using LogicLayerHandlersLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms.Employees
{
    public partial class UpdateEmployee : Form
    {
        private UserHandler userHandler;
        private Employee currentEmployee;

        public UpdateEmployee(UserHandler userHandler, User currentEmployee)
        {
            InitializeComponent();
            this.userHandler = userHandler;
            this.currentEmployee = (Employee)currentEmployee;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            cboxRoles.DataSource = null;
            cboxRoles.DataSource = Enum.GetValues(typeof(EmployeeRole));

            tbFirstName.Text = currentEmployee.FirstName;
            tbLastName.Text = currentEmployee.LastName;
            tbEmail.Text = currentEmployee.Email;
            cboxRoles.SelectedItem = currentEmployee.EmployeeRole;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            foreach (Control co in this.Controls)
            {
                if (co is not Label)
                {
                    if (co.Name != "tbPassword" && co.Name != "tbRepeatPassword") co.Enabled = true;
                    else co.Enabled = false;
                }

            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string firstName, lastName, email, password, confirmPaswd;
            EmployeeRole role;

            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            email = tbEmail.Text;
            password = tbPassword.Text;
            confirmPaswd = tbRepeatPassword.Text;
            role = (EmployeeRole)cboxRoles.SelectedItem;

            DialogResult dr = MessageBox.Show("Are You sure you want to Update this Employee?", "Update Employee?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    if (tbPassword.Enabled == true && tbRepeatPassword.Enabled == true)
                    {
                        password = tbPassword.Text;
                        confirmPaswd = tbRepeatPassword.Text;
                        if (string.IsNullOrEmpty(password)) throw new NullValueException("The field password cannot be empty");
                        if (string.IsNullOrEmpty(confirmPaswd)) { throw new NullValueException("password confirmation field is empty"); }
                        if (password != confirmPaswd) throw new ArgumentException("Password and confirmation does not match");

                        User newEmployee = new Employee(firstName, lastName, email, password, DateTime.Now, role);

                        userHandler.UpdateUser(newEmployee, currentEmployee);
                    }
                    else
                    {
                        password = "DoNoTUPdaTePassWord!@#HHGTR";
                        User newEmployee = new Employee(firstName, lastName, email, password, DateTime.Now, role);

                        userHandler.UpdateUser(newEmployee, currentEmployee);
                    }

                    MessageBox.Show("Employee Updated successfully!");
                    
                    this.Close();
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }

        private void btnChangePassowrd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to change the password?", "Change password?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tbPassword.Enabled = true;
                tbRepeatPassword.Enabled = true;
            }
            else return;
        }
    }
}
