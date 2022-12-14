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
    public partial class UpdateProduct : Form
    {
        private ProductHandlers productHandler;
        private SuffixesHandler suffixesHandler;
        Product currentProduct;

        public UpdateProduct(ProductHandlers productHandler, Product currentProduct, SuffixesHandler suffixesHandler)
        {
            InitializeComponent();
            this.productHandler = productHandler;
            this.currentProduct = currentProduct;
            this.suffixesHandler = suffixesHandler;
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            cboxCategories.Items.Clear();
            cboxSubCategories.Items.Clear();
            cboxUnits.Items.Clear();

            foreach (Suffix suffix in suffixesHandler.Suffixes)
            {
                if (suffix.SuffixType is SuffixType.category) cboxCategories.Items.Add(suffix.Name);
                else if (suffix.SuffixType is SuffixType.sub_category) cboxSubCategories.Items.Add(suffix.Name);
                else cboxUnits.Items.Add(suffix.Name);

            }

            tbProductName.Text = currentProduct.Name;
            cboxCategories.SelectedItem = currentProduct.Category;
            cboxSubCategories.SelectedItem = currentProduct.SubCategory;
            cboxUnits.SelectedItem = currentProduct.Unit;
            tbProductPrice.Text = currentProduct.Price.ToString();
            if(currentProduct.InStock) cboxStock.SelectedIndex = 0;
            else cboxStock.SelectedIndex = 1;
            if (currentProduct.Image != null) pboxImage.Image = ConvertByteArrayToImage(currentProduct.Image);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control co in this.Controls)
            {
                if (co is Label == false)
                {
                    if (co.Enabled == false)
                    {
                        co.Enabled = true;
                    }
                }
            }
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

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data))
            using (Image image = Image.FromStream(ms, false, true))
            {
                return new Bitmap(image);
            }

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to Update this Product?", "Update Product?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string name;
                bool stock;
                double price;
                byte[]? image;


                try
                {

                    if (string.IsNullOrEmpty(tbProductPrice.Text)) { throw new NullValueException("Please enter a price"); }

                    name = tbProductName.Text;
                    Suffix category = (Suffix)cboxCategories.SelectedItem;
                    Suffix subCategory = (Suffix)cboxSubCategories.SelectedItem;
                    Suffix unit = (Suffix)cboxUnits.SelectedItem;
                    if (!double.TryParse(tbProductPrice.Text, out price)) { throw new ArgumentException("The price field cannot include letters"); }
                    if (pboxImage.Image != null) image = AddProduct.ConvertImageToByteArray(pboxImage.Image);
                    else image = null;
                    if (string.IsNullOrEmpty(cboxStock.Text)) { throw new NullValueException("Please select product stock status"); }
                    if (cboxStock.SelectedIndex == 0) stock = true;
                    else stock = false;



                    Product newProduct = new Product(name, category, subCategory, unit, price, image, stock, DateTime.Now);

                    productHandler.UpdateProduct(newProduct, currentProduct);


                    MessageBox.Show("Product Updated successfully!");
                    this.Close();
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }
    }
}
