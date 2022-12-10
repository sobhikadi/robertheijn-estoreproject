namespace DesktopApplication.Forms.Products
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.lblStock = new System.Windows.Forms.Label();
            this.cboxStock = new System.Windows.Forms.ComboBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbsubCaregory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tbProductUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStock.Location = new System.Drawing.Point(17, 238);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 20);
            this.lblStock.TabIndex = 80;
            this.lblStock.Text = "Stock";
            // 
            // cboxStock
            // 
            this.cboxStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStock.FormattingEnabled = true;
            this.cboxStock.Items.AddRange(new object[] {
            "In Stock",
            "Out Of Stock"});
            this.cboxStock.Location = new System.Drawing.Point(171, 235);
            this.cboxStock.MaximumSize = new System.Drawing.Size(731, 0);
            this.cboxStock.Name = "cboxStock";
            this.cboxStock.Size = new System.Drawing.Size(587, 28);
            this.cboxStock.TabIndex = 5;
            // 
            // tbCategory
            // 
            this.tbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategory.Location = new System.Drawing.Point(171, 67);
            this.tbCategory.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(587, 27);
            this.tbCategory.TabIndex = 1;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteImage.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteImage.FlatAppearance.BorderSize = 0;
            this.btnDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.Location = new System.Drawing.Point(578, 324);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(180, 34);
            this.btnDeleteImage.TabIndex = 7;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImage.Location = new System.Drawing.Point(18, 284);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(51, 20);
            this.lblImage.TabIndex = 76;
            this.lblImage.Text = "Image";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(578, 284);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(180, 34);
            this.btnSelectImage.TabIndex = 6;
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
            this.pboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pboxImage.Location = new System.Drawing.Point(171, 284);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(335, 227);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImage.TabIndex = 74;
            this.pboxImage.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(573, 477);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(185, 34);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbsubCaregory
            // 
            this.tbsubCaregory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsubCaregory.Location = new System.Drawing.Point(171, 108);
            this.tbsubCaregory.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbsubCaregory.Name = "tbsubCaregory";
            this.tbsubCaregory.Size = new System.Drawing.Size(587, 27);
            this.tbsubCaregory.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Sub category";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductCategory.Location = new System.Drawing.Point(17, 70);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(69, 20);
            this.lblProductCategory.TabIndex = 72;
            this.lblProductCategory.Text = "Category";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductPrice.Location = new System.Drawing.Point(171, 193);
            this.tbProductPrice.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(587, 27);
            this.tbProductPrice.TabIndex = 4;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductPrice.Location = new System.Drawing.Point(17, 196);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(41, 20);
            this.lblProductPrice.TabIndex = 71;
            this.lblProductPrice.Text = "Price";
            // 
            // tbProductUnit
            // 
            this.tbProductUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductUnit.Location = new System.Drawing.Point(171, 151);
            this.tbProductUnit.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductUnit.Name = "tbProductUnit";
            this.tbProductUnit.Size = new System.Drawing.Size(587, 27);
            this.tbProductUnit.TabIndex = 3;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnit.Location = new System.Drawing.Point(18, 154);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(36, 20);
            this.lblUnit.TabIndex = 70;
            this.lblUnit.Text = "Unit";
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductName.Location = new System.Drawing.Point(171, 24);
            this.tbProductName.MaximumSize = new System.Drawing.Size(731, 32);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(587, 27);
            this.tbProductName.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductName.Location = new System.Drawing.Point(18, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(49, 20);
            this.lblProductName.TabIndex = 69;
            this.lblProductName.Text = "Name";
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 523);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cboxStock);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbsubCaregory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.tbProductUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lblProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStock;
        private ComboBox cboxStock;
        private TextBox tbCategory;
        private Button btnDeleteImage;
        private Label lblImage;
        private Button btnSelectImage;
        private PictureBox pboxImage;
        private Button btnAddProduct;
        private TextBox tbsubCaregory;
        private Label label4;
        private Label lblProductCategory;
        private TextBox tbProductPrice;
        private Label lblProductPrice;
        private TextBox tbProductUnit;
        private Label lblUnit;
        private TextBox tbProductName;
        private Label lblProductName;
        private OpenFileDialog ofdImage;
    }
}