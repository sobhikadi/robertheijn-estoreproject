using LogicLayerEntitiesLibrary.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms
{
    public partial class Main : Form
    {
        private User currentUser;
        private LogIn login;
        private Button currentButton;
        private Form activeForm;

        public Main(LogIn login, User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.login = login;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            activeForm = dashboard;
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(dashboard);
            this.panelContainer.Tag = dashboard;
            dashboard.BringToFront();
            dashboard.Show();

            currentButton = btnDashboard;
            currentButton.BackColor = ColorTranslator.FromHtml("#FFB26B");
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Text = $"Robert Heijn - {currentButton.Text}";
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml("#FFB26B");
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 14F);
                    this.Text = $"Robert Heijn - {currentButton.Text}";

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in flpanelContainerSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Black;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Products.Products(), sender);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Employees.Employees(), sender);
        }

        private void brnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Orders.Orders(), sender);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Statistics.Statistics(), sender);
        }

        private void btnAdvertisement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Advertisement.Advertisements(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("All the open windowswill be closed and unsaved data will be lost! Do you still want to procceed ?", "LogOut?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    if (f.Name != "LogIn")
                    {
                        f.Close();
                    }
                }
                login.Show();
            }
            else return;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
