namespace DesktopApplication.Forms.Employees
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordConfirmation = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cboxRoles = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Location = new System.Drawing.Point(176, 158);
            this.tbRepeatPassword.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(616, 30);
            this.tbRepeatPassword.TabIndex = 68;
            // 
            // tbPasswordConfirmation
            // 
            this.tbPasswordConfirmation.AutoSize = true;
            this.tbPasswordConfirmation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPasswordConfirmation.Location = new System.Drawing.Point(23, 161);
            this.tbPasswordConfirmation.Name = "tbPasswordConfirmation";
            this.tbPasswordConfirmation.Size = new System.Drawing.Size(147, 23);
            this.tbPasswordConfirmation.TabIndex = 76;
            this.tbPasswordConfirmation.Text = "Confirm password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(176, 122);
            this.tbPassword.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(616, 30);
            this.tbPassword.TabIndex = 67;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(23, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 75;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRole.Location = new System.Drawing.Point(24, 200);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 23);
            this.lblRole.TabIndex = 74;
            this.lblRole.Text = "Role";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(149)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(598, 244);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(194, 34);
            this.btnAddEmployee.TabIndex = 73;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cboxRoles
            // 
            this.cboxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRoles.FormattingEnabled = true;
            this.cboxRoles.ItemHeight = 23;
            this.cboxRoles.Location = new System.Drawing.Point(176, 194);
            this.cboxRoles.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxRoles.Name = "cboxRoles";
            this.cboxRoles.Size = new System.Drawing.Size(616, 31);
            this.cboxRoles.TabIndex = 69;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(176, 86);
            this.tbEmail.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Jhon.doe@email.com";
            this.tbEmail.Size = new System.Drawing.Size(616, 30);
            this.tbEmail.TabIndex = 66;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(23, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 72;
            this.lblEmail.Text = "Email";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(176, 50);
            this.tbLastName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "Doe";
            this.tbLastName.Size = new System.Drawing.Size(616, 30);
            this.tbLastName.TabIndex = 65;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastName.Location = new System.Drawing.Point(23, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 23);
            this.lblLastName.TabIndex = 71;
            this.lblLastName.Text = "Last name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(176, 14);
            this.tbFirstName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "Jhon";
            this.tbFirstName.Size = new System.Drawing.Size(616, 30);
            this.tbFirstName.TabIndex = 64;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstName.Location = new System.Drawing.Point(23, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 23);
            this.lblFirstName.TabIndex = 70;
            this.lblFirstName.Text = "First name";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 293);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.tbPasswordConfirmation);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cboxRoles);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbRepeatPassword;
        private Label tbPasswordConfirmation;
        private TextBox tbPassword;
        private Label lblPassword;
        private Label lblRole;
        private Button btnAddEmployee;
        private ComboBox cboxRoles;
        private TextBox tbEmail;
        private Label lblEmail;
        private TextBox tbLastName;
        private Label lblLastName;
        private TextBox tbFirstName;
        private Label lblFirstName;
    }
}