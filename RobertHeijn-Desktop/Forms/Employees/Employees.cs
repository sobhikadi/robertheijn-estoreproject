using DataAccessLibrary.Employees;
using DataAccessLibrary.Products;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms.Employees
{
    public partial class Employees : Form
    {
        private UserHandler userHandler;
        private User? selectedEmployee;
        private bool addEmployeeFormOpen = false;
        private bool updateEmployeeformOpen = false;

        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            try
            {
                userHandler = new UserHandler(new DBUser());
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            cboxSearchCriteria.DataSource = null;
            cboxSearchCriteria.DataSource = Enum.GetValues(typeof(EmployeeSearchType));
            cboxSearchTerm.DataSource = null;
            cboxSearchTerm.DataSource = Enum.GetValues(typeof(EmployeeRole));
        }

        private void cboxSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSearchCriteria.SelectedIndex == (int)EmployeeSearchType.role)
            {
                tbSearchTerm.Visible = false;
                cboxSearchTerm.Visible = true;
            }
            else
            {
                tbSearchTerm.Visible = true;
                cboxSearchTerm.Visible = false;
            }

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            listViewEmployees.Items.Clear();
            string serchTerm = null;
            try
            {
                if (tbSearchTerm.Visible == true)
                {
                    if (string.IsNullOrEmpty(tbSearchTerm.Text)) throw new NullValueException("Please enter a search term");
                    serchTerm = tbSearchTerm.Text;
                }
                else if (cboxSearchTerm.Visible == true) { serchTerm = cboxSearchTerm.Text; }

                List<User> employees = new List<User>();
                employees.AddRange(userHandler.SearchEmployee(serchTerm, (EmployeeSearchType)cboxSearchCriteria.SelectedValue));

                foreach (Employee emp in employees) { AddUserToListView(emp); }
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            try
            {
                listViewEmployees.Items.Clear();
                foreach (Employee employee in userHandler.Users) { AddUserToListView(employee); }
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (addEmployeeFormOpen != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                AddEmployee AddEmployeeForm = new AddEmployee(userHandler);
                AddEmployeeForm.FormClosed += AddEmployeeForm_FormClosed;
                addEmployeeFormOpen = true;
                AddEmployeeForm.Show();
            }
        }

        private void AddEmployeeForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            btnShowAllUsers.PerformClick();
            addEmployeeFormOpen = false;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee first");
                return;
            }
            if (updateEmployeeformOpen != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                UpdateEmployee updateEmployeeForm = new UpdateEmployee(userHandler, selectedEmployee);
                updateEmployeeForm.FormClosed += UpdateEmployeeForm_FormClosed;
                updateEmployeeformOpen = true;
                updateEmployeeForm.Show();
            }
        }

        private void UpdateEmployeeForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            btnShowAllUsers.PerformClick();
            updateEmployeeformOpen = false;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //    if (selectedEmployeeFromList == null)
            //    {
            //        MessageBox.Show("Please select an Employee first");
            //        return;
            //    }
            //    DialogResult dr = MessageBox.Show($"Are You sure you want to Delete this Employee ({selectedEmployeeFromList.FirstName} {selectedEmployeeFromList.LastName}) ?", "Delete Employee?", MessageBoxButtons.OKCancel);
            //    if (dr == DialogResult.OK)
            //    {
            //        try
            //        {
            //            userHandler.DeleteEmployee(selectedEmployeeFromList);
            //            MessageBox.Show("Employee has successfully been deleted");
            //            btnShowAllUsers.PerformClick();
            //        }
            //        catch (SqlException) { MessageBox.Show("Something went wrong with database connection"); }
            //        catch (Exception ex) { MessageBox.Show(ex.Message); }

            //    }
            //    else return;
        }

        private void listViewUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedEmployee = (Employee)e.Item.Tag;
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 0)  selectedEmployee = null;
        }

        private void AddUserToListView(Employee employee)
        {
            ListViewItem item = new ListViewItem(employee.Id.ToString());
            item.Tag = employee;
            item.SubItems.Add(employee.FirstName);
            item.SubItems.Add(employee.LastName);
            item.SubItems.Add(employee.EmployeeRole.ToString());
            item.SubItems.Add(employee.Email);

            listViewEmployees.Items.Add(item);
        }

    }
}
