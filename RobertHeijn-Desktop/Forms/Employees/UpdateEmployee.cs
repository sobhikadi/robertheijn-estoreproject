using LogicLayerEntitiesLibrary.Users;
using LogicLayerHandlersLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms.Employees
{
    public partial class UpdateEmployee : Form
    {
        private UserHandler userHandler;
        private User currentEmployee;

        public UpdateEmployee(UserHandler userHandler, User currentEmployee)
        {
            InitializeComponent();
            this.userHandler = userHandler;
            this.currentEmployee = currentEmployee;
        }
    }
}
