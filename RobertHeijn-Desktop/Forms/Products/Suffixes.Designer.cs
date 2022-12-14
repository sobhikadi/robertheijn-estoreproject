namespace DesktopApplication.Forms.Products
{
    partial class Suffixes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suffixes));
            this.gboxAddSuffix = new System.Windows.Forms.GroupBox();
            this.btnAddSuffix = new System.Windows.Forms.Button();
            this.cboxSuffixType = new System.Windows.Forms.ComboBox();
            this.lblSuffixType = new System.Windows.Forms.Label();
            this.tbSuffixText = new System.Windows.Forms.TextBox();
            this.lblSuffixText = new System.Windows.Forms.Label();
            this.lboxSuffixes = new System.Windows.Forms.ListBox();
            this.lblSuffixes = new System.Windows.Forms.Label();
            this.gboxUpdateSuffix = new System.Windows.Forms.GroupBox();
            this.btnUpdateSuffix = new System.Windows.Forms.Button();
            this.cboxUpdateSuffixType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpdateSuffixType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxAddSuffix.SuspendLayout();
            this.gboxUpdateSuffix.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxAddSuffix
            // 
            this.gboxAddSuffix.Controls.Add(this.btnAddSuffix);
            this.gboxAddSuffix.Controls.Add(this.cboxSuffixType);
            this.gboxAddSuffix.Controls.Add(this.lblSuffixType);
            this.gboxAddSuffix.Controls.Add(this.tbSuffixText);
            this.gboxAddSuffix.Controls.Add(this.lblSuffixText);
            this.gboxAddSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.gboxAddSuffix.Location = new System.Drawing.Point(12, 12);
            this.gboxAddSuffix.Name = "gboxAddSuffix";
            this.gboxAddSuffix.Size = new System.Drawing.Size(447, 216);
            this.gboxAddSuffix.TabIndex = 0;
            this.gboxAddSuffix.TabStop = false;
            this.gboxAddSuffix.Text = "AddSuffix";
            // 
            // btnAddSuffix
            // 
            this.btnAddSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnAddSuffix.FlatAppearance.BorderSize = 0;
            this.btnAddSuffix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSuffix.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSuffix.ForeColor = System.Drawing.Color.White;
            this.btnAddSuffix.Location = new System.Drawing.Point(264, 154);
            this.btnAddSuffix.Name = "btnAddSuffix";
            this.btnAddSuffix.Size = new System.Drawing.Size(160, 36);
            this.btnAddSuffix.TabIndex = 48;
            this.btnAddSuffix.Text = "Add";
            this.btnAddSuffix.UseVisualStyleBackColor = false;
            this.btnAddSuffix.Click += new System.EventHandler(this.btnAddSuffix_Click);
            // 
            // cboxSuffixType
            // 
            this.cboxSuffixType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSuffixType.FormattingEnabled = true;
            this.cboxSuffixType.Location = new System.Drawing.Point(155, 96);
            this.cboxSuffixType.Name = "cboxSuffixType";
            this.cboxSuffixType.Size = new System.Drawing.Size(269, 31);
            this.cboxSuffixType.TabIndex = 3;
            // 
            // lblSuffixType
            // 
            this.lblSuffixType.AutoSize = true;
            this.lblSuffixType.ForeColor = System.Drawing.Color.Black;
            this.lblSuffixType.Location = new System.Drawing.Point(15, 99);
            this.lblSuffixType.Name = "lblSuffixType";
            this.lblSuffixType.Size = new System.Drawing.Size(89, 23);
            this.lblSuffixType.TabIndex = 2;
            this.lblSuffixType.Text = "Suffix type";
            // 
            // tbSuffixText
            // 
            this.tbSuffixText.Location = new System.Drawing.Point(155, 39);
            this.tbSuffixText.Name = "tbSuffixText";
            this.tbSuffixText.Size = new System.Drawing.Size(269, 30);
            this.tbSuffixText.TabIndex = 1;
            // 
            // lblSuffixText
            // 
            this.lblSuffixText.AutoSize = true;
            this.lblSuffixText.ForeColor = System.Drawing.Color.Black;
            this.lblSuffixText.Location = new System.Drawing.Point(15, 42);
            this.lblSuffixText.Name = "lblSuffixText";
            this.lblSuffixText.Size = new System.Drawing.Size(85, 23);
            this.lblSuffixText.TabIndex = 0;
            this.lblSuffixText.Text = "Suffix text";
            // 
            // lboxSuffixes
            // 
            this.lboxSuffixes.FormattingEnabled = true;
            this.lboxSuffixes.ItemHeight = 23;
            this.lboxSuffixes.Location = new System.Drawing.Point(465, 42);
            this.lboxSuffixes.Name = "lboxSuffixes";
            this.lboxSuffixes.Size = new System.Drawing.Size(474, 418);
            this.lboxSuffixes.TabIndex = 1;
            // 
            // lblSuffixes
            // 
            this.lblSuffixes.AutoSize = true;
            this.lblSuffixes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.lblSuffixes.Location = new System.Drawing.Point(465, 16);
            this.lblSuffixes.Name = "lblSuffixes";
            this.lblSuffixes.Size = new System.Drawing.Size(67, 23);
            this.lblSuffixes.TabIndex = 2;
            this.lblSuffixes.Text = "Suffixes";
            // 
            // gboxUpdateSuffix
            // 
            this.gboxUpdateSuffix.Controls.Add(this.btnUpdateSuffix);
            this.gboxUpdateSuffix.Controls.Add(this.cboxUpdateSuffixType);
            this.gboxUpdateSuffix.Controls.Add(this.label1);
            this.gboxUpdateSuffix.Controls.Add(this.tbUpdateSuffixType);
            this.gboxUpdateSuffix.Controls.Add(this.label2);
            this.gboxUpdateSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.gboxUpdateSuffix.Location = new System.Drawing.Point(12, 244);
            this.gboxUpdateSuffix.Name = "gboxUpdateSuffix";
            this.gboxUpdateSuffix.Size = new System.Drawing.Size(447, 216);
            this.gboxUpdateSuffix.TabIndex = 49;
            this.gboxUpdateSuffix.TabStop = false;
            this.gboxUpdateSuffix.Text = "UpdateSuffix";
            // 
            // btnUpdateSuffix
            // 
            this.btnUpdateSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(246)))));
            this.btnUpdateSuffix.FlatAppearance.BorderSize = 0;
            this.btnUpdateSuffix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSuffix.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSuffix.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSuffix.Location = new System.Drawing.Point(264, 154);
            this.btnUpdateSuffix.Name = "btnUpdateSuffix";
            this.btnUpdateSuffix.Size = new System.Drawing.Size(160, 36);
            this.btnUpdateSuffix.TabIndex = 48;
            this.btnUpdateSuffix.Text = "Update";
            this.btnUpdateSuffix.UseVisualStyleBackColor = false;
            // 
            // cboxUpdateSuffixType
            // 
            this.cboxUpdateSuffixType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUpdateSuffixType.FormattingEnabled = true;
            this.cboxUpdateSuffixType.Location = new System.Drawing.Point(155, 96);
            this.cboxUpdateSuffixType.Name = "cboxUpdateSuffixType";
            this.cboxUpdateSuffixType.Size = new System.Drawing.Size(269, 31);
            this.cboxUpdateSuffixType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suffix type";
            // 
            // tbUpdateSuffixType
            // 
            this.tbUpdateSuffixType.Location = new System.Drawing.Point(155, 39);
            this.tbUpdateSuffixType.Name = "tbUpdateSuffixType";
            this.tbUpdateSuffixType.Size = new System.Drawing.Size(269, 30);
            this.tbUpdateSuffixType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suffix text";
            // 
            // Suffixes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 474);
            this.Controls.Add(this.gboxUpdateSuffix);
            this.Controls.Add(this.lblSuffixes);
            this.Controls.Add(this.lboxSuffixes);
            this.Controls.Add(this.gboxAddSuffix);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suffixes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suffixes";
            this.Load += new System.EventHandler(this.Suffixes_Load);
            this.gboxAddSuffix.ResumeLayout(false);
            this.gboxAddSuffix.PerformLayout();
            this.gboxUpdateSuffix.ResumeLayout(false);
            this.gboxUpdateSuffix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboxAddSuffix;
        private ComboBox cboxSuffixType;
        private Label lblSuffixType;
        private TextBox tbSuffixText;
        private Label lblSuffixText;
        private Button btnAddSuffix;
        private ListBox lboxSuffixes;
        private Label lblSuffixes;
        private GroupBox gboxUpdateSuffix;
        private Button btnUpdateSuffix;
        private ComboBox cboxUpdateSuffixType;
        private Label label1;
        private TextBox tbUpdateSuffixType;
        private Label label2;
    }
}