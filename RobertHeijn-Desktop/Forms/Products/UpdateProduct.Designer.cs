namespace DesktopApplication.Forms.Products
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.lblStock = new System.Windows.Forms.Label();
            this.cboxStock = new System.Windows.Forms.ComboBox();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.cboxUnits = new System.Windows.Forms.ComboBox();
            this.cboxSubCategories = new System.Windows.Forms.ComboBox();
            this.cboxCategories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStock.Location = new System.Drawing.Point(17, 232);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 20);
            this.lblStock.TabIndex = 97;
            this.lblStock.Text = "Stock";
            // 
            // cboxStock
            // 
            this.cboxStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStock.Enabled = false;
            this.cboxStock.FormattingEnabled = true;
            this.cboxStock.Items.AddRange(new object[] {
            "In Stock",
            "Out Of Stock"});
            this.cboxStock.Location = new System.Drawing.Point(171, 229);
            this.cboxStock.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxStock.Name = "cboxStock";
            this.cboxStock.Size = new System.Drawing.Size(587, 28);
            this.cboxStock.TabIndex = 86;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteImage.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteImage.Enabled = false;
            this.btnDeleteImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.Location = new System.Drawing.Point(578, 318);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(180, 34);
            this.btnDeleteImage.TabIndex = 88;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImage.Location = new System.Drawing.Point(18, 278);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(51, 20);
            this.lblImage.TabIndex = 96;
            this.lblImage.Text = "Image";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnSelectImage.Enabled = false;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(578, 278);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(180, 34);
            this.btnSelectImage.TabIndex = 87;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pboxImage
            // 
            this.pboxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxImage.BackgroundImage")));
            this.pboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxImage.Location = new System.Drawing.Point(171, 278);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(298, 178);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImage.TabIndex = 95;
            this.pboxImage.TabStop = false;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(573, 471);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(185, 34);
            this.btnUpdateProduct.TabIndex = 89;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Sub category";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductCategory.Location = new System.Drawing.Point(17, 64);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(69, 20);
            this.lblProductCategory.TabIndex = 93;
            this.lblProductCategory.Text = "Category";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Location = new System.Drawing.Point(171, 187);
            this.tbProductPrice.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(587, 27);
            this.tbProductPrice.TabIndex = 85;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductPrice.Location = new System.Drawing.Point(17, 190);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(41, 20);
            this.lblProductPrice.TabIndex = 92;
            this.lblProductPrice.Text = "Price";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnit.Location = new System.Drawing.Point(18, 148);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(36, 20);
            this.lblUnit.TabIndex = 91;
            this.lblUnit.Text = "Unit";
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(171, 18);
            this.tbProductName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(587, 27);
            this.tbProductName.TabIndex = 81;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductName.Location = new System.Drawing.Point(18, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(49, 20);
            this.lblProductName.TabIndex = 90;
            this.lblProductName.Text = "Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(373, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(194, 34);
            this.btnEdit.TabIndex = 98;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // cboxUnits
            // 
            this.cboxUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnits.Enabled = false;
            this.cboxUnits.FormattingEnabled = true;
            this.cboxUnits.Location = new System.Drawing.Point(171, 145);
            this.cboxUnits.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxUnits.Name = "cboxUnits";
            this.cboxUnits.Size = new System.Drawing.Size(587, 28);
            this.cboxUnits.TabIndex = 101;
            // 
            // cboxSubCategories
            // 
            this.cboxSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSubCategories.Enabled = false;
            this.cboxSubCategories.FormattingEnabled = true;
            this.cboxSubCategories.Location = new System.Drawing.Point(171, 102);
            this.cboxSubCategories.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxSubCategories.Name = "cboxSubCategories";
            this.cboxSubCategories.Size = new System.Drawing.Size(587, 28);
            this.cboxSubCategories.TabIndex = 100;
            // 
            // cboxCategories
            // 
            this.cboxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategories.Enabled = false;
            this.cboxCategories.FormattingEnabled = true;
            this.cboxCategories.Location = new System.Drawing.Point(171, 61);
            this.cboxCategories.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxCategories.Name = "cboxCategories";
            this.cboxCategories.Size = new System.Drawing.Size(587, 28);
            this.cboxCategories.TabIndex = 99;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 523);
            this.Controls.Add(this.cboxUnits);
            this.Controls.Add(this.cboxSubCategories);
            this.Controls.Add(this.cboxCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cboxStock);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lblProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStock;
        private ComboBox cboxStock;
        private Button btnDeleteImage;
        private Label lblImage;
        private Button btnSelectImage;
        private PictureBox pboxImage;
        private Button btnUpdateProduct;
        private Label label4;
        private Label lblProductCategory;
        private TextBox tbProductPrice;
        private Label lblProductPrice;
        private Label lblUnit;
        private TextBox tbProductName;
        private Label lblProductName;
        private Button btnEdit;
        private OpenFileDialog ofdImage;
        private ComboBox cboxUnits;
        private ComboBox cboxSubCategories;
        private ComboBox cboxCategories;
    }
}