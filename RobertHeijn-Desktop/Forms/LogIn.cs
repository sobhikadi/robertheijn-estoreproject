using DataAccessLibrary.Employees;
using DesktopApplication.Forms;
using LogicLayerEntitiesLibrary.Users;
using LogicLayerHandlersLibrary;
using System.Data.SqlClient;

namespace DesktopApplication;

public partial class LogIn : Form
{
    public LogIn()
    {
        InitializeComponent();
    }

    private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            btnLogIn.PerformClick();
        }
    }

    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            btnLogIn.PerformClick();
        }
    }

    private void btnLogIn_Click(object sender, EventArgs e)
    {
       
        Main main;
        string email, password;

        try
        {
            UserHandler userHandler = new UserHandler(new DBUser());
            if (string.IsNullOrEmpty(tbEmail.Text)) throw new Exception("Please enter an email.");
            if (string.IsNullOrEmpty(tbPassword.Text)) throw new Exception("Please enter a password.");

            email = tbEmail.Text;
            password = tbPassword.Text;

            User? user = userHandler.ValidateUser(email, password);
            if (user == null) throw new Exception("Email or passowrd is incorrect");
            if (!user.GetType().IsAssignableTo(typeof(Employee))) throw new Exception("Email or passowrd is incorrect");
            main = new Main(this, user);
            main.Show();
            this.Hide();
        }
        catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
        
    }
}