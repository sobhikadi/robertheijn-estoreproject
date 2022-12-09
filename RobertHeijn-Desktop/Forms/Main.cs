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
        private string role;
        private LogIn login;

        public Main(LogIn login, string role)
        {
            InitializeComponent();
            this.role = role;
            this.login = login;
        }
    }
}
