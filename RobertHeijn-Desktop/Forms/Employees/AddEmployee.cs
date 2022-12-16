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
    public partial class AddEmployee : Form
    {
        private UserHandler userHandler;
        public AddEmployee(UserHandler userHandler)
        {
            InitializeComponent();
            this.userHandler = userHandler;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            cboxRoles.DataSource = null;
            cboxRoles.DataSource = Enum.GetValues(typeof(EmployeeRole));
            cboxRoles.SelectedIndex = -1;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName, lastName, email, password, confirmPaswd;
            EmployeeRole role;

            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            email = tbEmail.Text;
            password = tbPassword.Text;
            confirmPaswd = tbRepeatPassword.Text;
            

            DialogResult dr = MessageBox.Show($"Are You sure you want to add this mployee ({firstName})?", "Add Employee?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    if (string.IsNullOrEmpty(password)) throw new NullValueException("The field password cannot be empty");
                    if (string.IsNullOrEmpty(confirmPaswd)) { throw new NullValueException("password confirmation field is empty"); }
                    if (password != confirmPaswd) throw new ArgumentException("Password and confirmation does not match");
                    if (cboxRoles.SelectedIndex < 0) throw new NullValueException("Please select a role");
                    role = (EmployeeRole)cboxRoles.SelectedItem;
                    User employee = new Employee(firstName, lastName, email, password, null, role);

                    userHandler.AddUser(employee);

                    MessageBox.Show("Employee added successfully!");

                    foreach (Control co in this.Controls)
                    {
                        if (co is TextBox || co is ComboBox) { co.ResetText(); }
                    }
                    cboxRoles.SelectedIndex = -1;
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }
    }
}
