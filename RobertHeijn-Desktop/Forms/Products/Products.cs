using DataAccessLibrary.Products;
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
    public partial class Products : Form
    {
        private ProductHandler productHandler;
        private Product? selectedProduct;

        public static bool ADD_PRODUCT_FORM_OPEN = false;
        public static bool UPDATE_PRODUCT_FORM_OPEN = false;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            try
            {
                productHandler = new ProductHandler();
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
            cboxSearchCriteria.DataSource = null;
            cboxSearchCriteria.DataSource = Enum.GetValues(typeof(ProductSearchType));


            //List<string> catgeories = new List<string>();
            //List<string> subCatgeories = new List<string>();

            //foreach (Product product in productHandler.Products)
            //{
            //    catgeories.Clear();
            //    subCatgeories.Clear();

            //    catgeories.Add(product.Category);
            //    subCatgeories.Add(product.SubCategory);

            //}
            //cboxSearchTermCat.DataSource = null;
            //cboxSearchTermCat.DataSource = catgeories.Distinct();
            //cboxSearchTermSub.DataSource = null;
            //cboxSearchTermSub.DataSource = subCatgeories.Distinct();
        }

        private void cboxSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSearchCriteria.Text == "category")
            {
                cboxSearchTermCat.Visible = true;
                tbSearchTerm.Visible = false;
                cboxSearchTermSub.Visible = false;
            }
            else if (cboxSearchCriteria.Text == "sub_category") 
            {
                cboxSearchTermCat.Visible = false;
                tbSearchTerm.Visible = false;
                cboxSearchTermSub.Visible = true;
            }
            else
            {
                cboxSearchTermCat.Visible = false;
                tbSearchTerm.Visible = true;
                cboxSearchTermSub.Visible = false;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //listViewProducts.Items.Clear();
            //string serchTerm = null;
            //try
            //{
            //    if (tbSearchTerm.Visible == true)
            //    {
            //        if (string.IsNullOrEmpty(tbSearchTerm.Text)) throw new Exception("Please enter a search term");
            //        serchTerm = tbSearchTerm.Text;
            //    }
            //    if (cboxSearchTermCat.Visible == true)
            //    {
            //        serchTerm = cboxSearchTermCat.Text;
            //    }
            //    if (cboxSearchTermSub.Visible == true)
            //    {
            //        serchTerm = cboxSearchTermSub.Text;
            //    }

            //    List<Product> products = new List<Product>();
            //    products.AddRange(productHandler.SearchProduct(serchTerm, (ProductSearchType)cboxSearchCriteria.SelectedValue));

            //    foreach (Product product in products)
            //    {
            //        AddProductToListView(product);
            //    }
            //}
            //catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    listViewProducts.Items.Clear();

            //    foreach (Product product in productHandler.Products)
            //    {
            //        AddProductToListView(product);
            //    }
            //    selectedProduct = null;

            //}
            //catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listViewProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedProduct = (Product)e.Item.Tag;

        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewProducts.SelectedItems.Count == 0)
            {
                selectedProduct = null;
            }

        }

        private void AddProductToListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.Id.ToString());
            item.Tag = product;
            item.SubItems.Add(product.Name);
            item.SubItems.Add(product.Unit);
            item.SubItems.Add(product.Category);
            item.SubItems.Add(product.SubCategory);
            item.SubItems.Add(product.Price.ToString());
            item.SubItems.Add(product.InStock.ToString());

            listViewProducts.Items.Add(item);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //if (ADD_PRODUCT_FORM_OPEN != false)
            //{
            //    MessageBox.Show("There is already a window open");
            //    return;
            //}
            //else
            //{
            //    AddProduct addProductForm = new AddProduct(productHandler);
            //    addProductForm.FormClosed += AddProductForm_FormClosed; 
            //    ADD_PRODUCT_FORM_OPEN = true;
            //    addProductForm.Show();
            //}
        }

        

        private void btnOpenUpdateProduct_Click(object sender, EventArgs e)
        {
            //if (selectedProduct == null)
            //{
            //    MessageBox.Show("Please select a product from the list first");
            //    return;
            //}
            //if (UPDATE_PRODUCT_FORM_OPEN != false)
            //{
            //    MessageBox.Show("There is already a window open");
            //    return;
            //}
            //else
            //{
            //    UpdateProduct updateProductForm = new UpdateProduct(productHandler, selectedProduct);
            //    UPDATE_PRODUCT_FORM_OPEN = true;
            //    updateProductForm.FormClosed += AddProductForm_FormClosed;
            //    updateProductForm.Show();
            //}
        }

        private void AddProductForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            btnShowAllProducts.PerformClick();
        }
    }
}
