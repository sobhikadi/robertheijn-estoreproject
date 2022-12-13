using LogicLayerEntitiesLibrary.Exceptions;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerHandlersLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms.Products
{
    public partial class AddProduct : Form
    {
        private ProductHandlers productHandler;

        public AddProduct(ProductHandlers productHandler)
        {
            InitializeComponent();
            this.productHandler = productHandler;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to add this Product?", "Add Product?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string name, category, subCategory, unit;
                bool stock;
                double price;
                byte[]? image;

                try
                {
                    if (string.IsNullOrEmpty(tbProductPrice.Text)) { throw new NullValueException("Please enter a price"); }

                    name = tbProductName.Text;
                    category = tbCategory.Text;
                    subCategory = tbsubCaregory.Text;
                    unit = tbProductUnit.Text;
                    if (!double.TryParse(tbProductPrice.Text, out price)) { throw new ArgumentException("The price field cannot include letters"); }
                    if (pboxImage.Image != null) image = ConvertImageToByteArray(pboxImage.Image);
                    else image = null;
                    if (string.IsNullOrEmpty(cboxStock.Text)) { throw new NullValueException("Please select product stock status"); }
                    if(cboxStock.SelectedIndex == 0) stock = true;
                    else stock = false;

                    Product product = new Product(name, category, subCategory, unit, price, image, stock, null);
                    productHandler.AddProduct(product);

                    MessageBox.Show("Product added successfully!");
                    foreach (Control co in this.Controls) 
                    {
                        if (co is TextBox || co is ComboBox) { co.ResetText(); }
                    }
                    btnDeleteImage.PerformClick();
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdImage.ShowDialog();
            ofdImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            Image? img = null;
            if (dialogResult == DialogResult.OK)
            {
                img = new Bitmap(ofdImage.FileName);
                pboxImage.Image = img.GetThumbnailImage(340, 165, null, new IntPtr());
            }
            else return;
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            pboxImage.Image = null;
        }

        public static byte[] ConvertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
