namespace DesktopApplication.Forms.Advertisement
{
    partial class AddAdvertisement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdvertisement));
            this.tbAdSlogan = new System.Windows.Forms.TextBox();
            this.lblAdSlogan = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.cboxRules = new System.Windows.Forms.ComboBox();
            this.lblRule = new System.Windows.Forms.Label();
            this.nudAmountProducts = new System.Windows.Forms.NumericUpDown();
            this.tbFlatDiscount = new System.Windows.Forms.TextBox();
            this.lblFlatDiscount = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblAmountRequired = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdSlogan
            // 
            this.tbAdSlogan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdSlogan.Location = new System.Drawing.Point(207, 12);
            this.tbAdSlogan.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbAdSlogan.Name = "tbAdSlogan";
            this.tbAdSlogan.Size = new System.Drawing.Size(556, 30);
            this.tbAdSlogan.TabIndex = 70;
            // 
            // lblAdSlogan
            // 
            this.lblAdSlogan.AutoSize = true;
            this.lblAdSlogan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdSlogan.Location = new System.Drawing.Point(23, 15);
            this.lblAdSlogan.Name = "lblAdSlogan";
            this.lblAdSlogan.Size = new System.Drawing.Size(62, 23);
            this.lblAdSlogan.TabIndex = 71;
            this.lblAdSlogan.Text = "Slogan";
            // 
            // dtpSDate
            // 
            this.dtpSDate.Location = new System.Drawing.Point(207, 58);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(556, 30);
            this.dtpSDate.TabIndex = 72;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Location = new System.Drawing.Point(207, 104);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(556, 30);
            this.dtpEDate.TabIndex = 73;
            // 
            // cboxRules
            // 
            this.cboxRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxRules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRules.FormattingEnabled = true;
            this.cboxRules.Location = new System.Drawing.Point(207, 200);
            this.cboxRules.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxRules.Name = "cboxRules";
            this.cboxRules.Size = new System.Drawing.Size(556, 31);
            this.cboxRules.TabIndex = 85;
            this.cboxRules.SelectedIndexChanged += new System.EventHandler(this.cboxRules_SelectedIndexChanged);
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRule.Location = new System.Drawing.Point(23, 203);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(115, 23);
            this.lblRule.TabIndex = 84;
            this.lblRule.Text = "Discount type";
            // 
            // nudAmountProducts
            // 
            this.nudAmountProducts.Location = new System.Drawing.Point(207, 152);
            this.nudAmountProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountProducts.Name = "nudAmountProducts";
            this.nudAmountProducts.Size = new System.Drawing.Size(120, 30);
            this.nudAmountProducts.TabIndex = 86;
            this.nudAmountProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbFlatDiscount
            // 
            this.tbFlatDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFlatDiscount.Enabled = false;
            this.tbFlatDiscount.Location = new System.Drawing.Point(207, 250);
            this.tbFlatDiscount.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbFlatDiscount.Name = "tbFlatDiscount";
            this.tbFlatDiscount.Size = new System.Drawing.Size(556, 30);
            this.tbFlatDiscount.TabIndex = 87;
            // 
            // lblFlatDiscount
            // 
            this.lblFlatDiscount.AutoSize = true;
            this.lblFlatDiscount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFlatDiscount.Location = new System.Drawing.Point(23, 253);
            this.lblFlatDiscount.Name = "lblFlatDiscount";
            this.lblFlatDiscount.Size = new System.Drawing.Size(142, 23);
            this.lblFlatDiscount.TabIndex = 88;
            this.lblFlatDiscount.Text = "Discount amount";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndDate.Location = new System.Drawing.Point(23, 110);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(78, 23);
            this.lblEndDate.TabIndex = 89;
            this.lblEndDate.Text = "End date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(23, 64);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 23);
            this.lblStartDate.TabIndex = 90;
            this.lblStartDate.Text = "Start date";
            // 
            // lblAmountRequired
            // 
            this.lblAmountRequired.AutoSize = true;
            this.lblAmountRequired.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmountRequired.Location = new System.Drawing.Point(23, 154);
            this.lblAmountRequired.Name = "lblAmountRequired";
            this.lblAmountRequired.Size = new System.Drawing.Size(169, 23);
            this.lblAmountRequired.TabIndex = 91;
            this.lblAmountRequired.Text = "Nr.Products required";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(578, 302);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(185, 34);
            this.btnAddProduct.TabIndex = 92;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // AddAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 348);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblAmountRequired);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.tbFlatDiscount);
            this.Controls.Add(this.lblFlatDiscount);
            this.Controls.Add(this.nudAmountProducts);
            this.Controls.Add(this.cboxRules);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.tbAdSlogan);
            this.Controls.Add(this.lblAdSlogan);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAdvertisement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Advertisement";
            this.Load += new System.EventHandler(this.AddAdvertisement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAdSlogan;
        private Label lblAdSlogan;
        private DateTimePicker dtpSDate;
        private DateTimePicker dtpEDate;
        private ComboBox cboxRules;
        private Label lblRule;
        private NumericUpDown nudAmountProducts;
        private TextBox tbFlatDiscount;
        private Label lblFlatDiscount;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblAmountRequired;
        private Button btnAddProduct;
    }
}