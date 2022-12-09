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
       
        Main fMain;
        string email, password;
        User user = null;

        try
        {
            //UserHandler userHandler = new UserHandler();
            //if (string.IsNullOrEmpty(tbEmail.Text)) throw new Exception("Please enter an email.");
            //if (string.IsNullOrEmpty(tbPassword.Text)) throw new Exception("Please enter a password.");

            //email = tbEmail.Text;
            //password = tbPassword.Text;

            //user = userHandler.ValidateUser(email, password);
            //if (user == null) throw new Exception("Email or passowrd is incorrect");
            //if (user.role == "Customer") throw new Exception("Email or passowrd is incorrect");
            fMain = new Main(this, user);
            fMain.Show();
            this.Hide();
        }
        catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }
}