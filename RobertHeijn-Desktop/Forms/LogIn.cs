using DesktopApplication.Forms;
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
       
        Main fMain;
        string email, password, role;

        try
        {
            //UserHandler userHandler = new UserHandler();
            //if (string.IsNullOrEmpty(tbEmail.Text)) throw new Exception("Please enter an email.");
            //if (string.IsNullOrEmpty(tbPassword.Text)) throw new Exception("Please enter a password.");

            //email = tbEmail.Text;
            //password = tbPassword.Text;

            //role = userHandler.ValidateUser(email, password);
            //if (string.IsNullOrEmpty(role)) throw new Exception("Email or passowrd is incorrect");
            //if (role != "Employee" && role != "Admin") throw new Exception("Email or passowrd is incorrect");
            fMain = new Main(this, "");
            fMain.Show();
            this.Hide();
        }
        catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }
}