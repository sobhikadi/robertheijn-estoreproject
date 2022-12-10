namespace DesktopApplication.Forms.Products
{
    partial class Products
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
            this.gboxSearchProduct = new System.Windows.Forms.GroupBox();
            this.cboxSearchTermCat = new System.Windows.Forms.ComboBox();
            this.cboxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.btnShowAllProducts = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnOpenUpdateProduct = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.productUnit = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.subCategory = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cboxSearchTermSub = new System.Windows.Forms.ComboBox();
            this.gboxSearchProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSearchProduct
            // 
            this.gboxSearchProduct.Controls.Add(this.cboxSearchTermSub);
            this.gboxSearchProduct.Controls.Add(this.cboxSearchTermCat);
            this.gboxSearchProduct.Controls.Add(this.cboxSearchCriteria);
            this.gboxSearchProduct.Controls.Add(this.lblSearchCriteria);
            this.gboxSearchProduct.Controls.Add(this.btnShowAllProducts);
            this.gboxSearchProduct.Controls.Add(this.btnSearchProduct);
            this.gboxSearchProduct.Controls.Add(this.tbSearchTerm);
            this.gboxSearchProduct.Controls.Add(this.lblSearchTerm);
            this.gboxSearchProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.gboxSearchProduct.Location = new System.Drawing.Point(0, 0);
            this.gboxSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gboxSearchProduct.Name = "gboxSearchProduct";
            this.gboxSearchProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gboxSearchProduct.Size = new System.Drawing.Size(1238, 105);
            this.gboxSearchProduct.TabIndex = 1;
            this.gboxSearchProduct.TabStop = false;
            this.gboxSearchProduct.Text = "Search Product Or Show All Products";
            // 
            // cboxSearchTermCat
            // 
            this.cboxSearchTermCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSearchTermCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSearchTermCat.FormattingEnabled = true;
            this.cboxSearchTermCat.Location = new System.Drawing.Point(163, 25);
            this.cboxSearchTermCat.Name = "cboxSearchTermCat";
            this.cboxSearchTermCat.Size = new System.Drawing.Size(783, 31);
            this.cboxSearchTermCat.TabIndex = 14;
            // 
            // cboxSearchCriteria
            // 
            this.cboxSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSearchCriteria.FormattingEnabled = true;
            this.cboxSearchCriteria.Location = new System.Drawing.Point(163, 63);
            this.cboxSearchCriteria.Name = "cboxSearchCriteria";
            this.cboxSearchCriteria.Size = new System.Drawing.Size(783, 31);
            this.cboxSearchCriteria.TabIndex = 13;
            this.cboxSearchCriteria.SelectedIndexChanged += new System.EventHandler(this.cboxSearchCriteria_SelectedIndexChanged);
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchCriteria.Location = new System.Drawing.Point(14, 66);
            this.lblSearchCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(130, 23);
            this.lblSearchCriteria.TabIndex = 9;
            this.lblSearchCriteria.Text = "Search Criteria: ";
            // 
            // btnShowAllProducts
            // 
            this.btnShowAllProducts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnShowAllProducts.FlatAppearance.BorderSize = 0;
            this.btnShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllProducts.ForeColor = System.Drawing.Color.White;
            this.btnShowAllProducts.Location = new System.Drawing.Point(970, 62);
            this.btnShowAllProducts.Name = "btnShowAllProducts";
            this.btnShowAllProducts.Size = new System.Drawing.Size(256, 30);
            this.btnShowAllProducts.TabIndex = 8;
            this.btnShowAllProducts.Text = "Show All Products";
            this.btnShowAllProducts.UseVisualStyleBackColor = false;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(970, 24);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(256, 30);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchTerm.Location = new System.Drawing.Point(163, 25);
            this.tbSearchTerm.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(783, 30);
            this.tbSearchTerm.TabIndex = 1;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchTerm.Location = new System.Drawing.Point(14, 28);
            this.lblSearchTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(111, 23);
            this.lblSearchTerm.TabIndex = 0;
            this.lblSearchTerm.Text = "Search term: ";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(1036, 886);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(195, 42);
            this.btnDeleteProduct.TabIndex = 46;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(10, 886);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(160, 42);
            this.btnAddProduct.TabIndex = 44;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnOpenUpdateProduct
            // 
            this.btnOpenUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnOpenUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnOpenUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnOpenUpdateProduct.Location = new System.Drawing.Point(176, 886);
            this.btnOpenUpdateProduct.Name = "btnOpenUpdateProduct";
            this.btnOpenUpdateProduct.Size = new System.Drawing.Size(160, 42);
            this.btnOpenUpdateProduct.TabIndex = 45;
            this.btnOpenUpdateProduct.Text = "Update Product";
            this.btnOpenUpdateProduct.UseVisualStyleBackColor = false;
            this.btnOpenUpdateProduct.Click += new System.EventHandler(this.btnOpenUpdateProduct_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.lblProducts.Location = new System.Drawing.Point(10, 107);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(77, 23);
            this.lblProducts.TabIndex = 43;
            this.lblProducts.Text = "Products";
            // 
            // listViewProducts
            // 
            this.listViewProducts.AllowColumnReorder = true;
            this.listViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.productUnit,
            this.Category,
            this.subCategory,
            this.Price,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(10, 137);
            this.listViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(1221, 742);
            this.listViewProducts.TabIndex = 42;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProducts_ItemSelectionChanged);
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Product
            // 
            this.Product.Text = "Name";
            this.Product.Width = 200;
            // 
            // productUnit
            // 
            this.productUnit.Text = "Unit";
            this.productUnit.Width = 80;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 150;
            // 
            // subCategory
            // 
            this.subCategory.Text = "Sub Category";
            this.subCategory.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "In Stock";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bonus";
            this.columnHeader2.Width = 300;
            // 
            // cboxSearchTermSub
            // 
            this.cboxSearchTermSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSearchTermSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSearchTermSub.FormattingEnabled = true;
            this.cboxSearchTermSub.Location = new System.Drawing.Point(163, 25);
            this.cboxSearchTermSub.Name = "cboxSearchTermSub";
            this.cboxSearchTermSub.Size = new System.Drawing.Size(783, 31);
            this.cboxSearchTermSub.TabIndex = 15;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 935);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnOpenUpdateProduct);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.gboxSearchProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.gboxSearchProduct.ResumeLayout(false);
            this.gboxSearchProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboxSearchProduct;
        private ComboBox cboxSearchTermCat;
        private ComboBox cboxSearchCriteria;
        private Label lblSearchCriteria;
        private Button btnShowAllProducts;
        private Button btnSearchProduct;
        private TextBox tbSearchTerm;
        private Label lblSearchTerm;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private Button btnOpenUpdateProduct;
        private Label lblProducts;
        private ListView listViewProducts;
        private ColumnHeader ID;
        private ColumnHeader Product;
        private ColumnHeader productUnit;
        private ColumnHeader Category;
        private ColumnHeader subCategory;
        private ColumnHeader Price;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox cboxSearchTermSub;
    }
}