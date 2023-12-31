﻿using DataAccessLibrary.Products;
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
    public partial class Products : Form
    {
        private ProductHandler productHandler;
        private SuffixesHandler suffixesHandler;
        private Product? selectedProduct;

        private bool addproductFormOpen = false;
        public  bool updateProductFormOpen = false;
        public bool suffixesFormOpen = false;


        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            try
            {
                productHandler = new ProductHandler(new DBProduct());
                suffixesHandler = new(new DBProduct());
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
            cboxSearchCriteria.DataSource = null;
            cboxSearchCriteria.DataSource = Enum.GetValues(typeof(ProductSearchType));


            cboxSearchTermCat.Items.Clear();
            cboxSearchTermSub.Items.Clear();

            foreach (Suffix suffix in suffixesHandler.Suffixes)
            {
                if (suffix.SuffixType == SuffixType.category) cboxSearchTermCat.Items.Add(suffix);
                else if (suffix.SuffixType == SuffixType.sub_category) cboxSearchTermSub.Items.Add(suffix);

            }

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
            listViewProducts.Items.Clear();
            string serchTerm = null;
            try
            {
                if (tbSearchTerm.Visible == true)
                {
                    if (string.IsNullOrEmpty(tbSearchTerm.Text)) throw new NullValueException("Please enter a search term");
                    serchTerm = tbSearchTerm.Text;
                }
                if (cboxSearchTermCat.Visible == true)
                {
                    serchTerm = cboxSearchTermCat.SelectedIndex.ToString();
                }
                if (cboxSearchTermSub.Visible == true)
                {
                    serchTerm = cboxSearchTermSub.SelectedIndex.ToString();
                }

                List<Product> products = new List<Product>();
                products.AddRange(productHandler.SearchProduct(serchTerm, (ProductSearchType)cboxSearchCriteria.SelectedValue));

                foreach (Product product in products)
                {
                    AddProductToListView(product);
                }
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                listViewProducts.Items.Clear();
                foreach (Product product in productHandler.Products)
                {
                    AddProductToListView(product);
                }
                selectedProduct = null;
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            item.SubItems.Add(product.Unit.Name);
            item.SubItems.Add(product.Category.Name);
            item.SubItems.Add(product.SubCategory.Name);
            item.SubItems.Add(product.Price.ToString());
            if (product.InStock)
            {
                item.SubItems.Add("In Stock");
                item.SubItems[6].BackColor = Color.Green;
            }
            else
            {
                item.SubItems.Add("Out Of Stock");
                item.SubItems[6].BackColor = Color.Red;
            }

            item.UseItemStyleForSubItems = false;

            listViewProducts.Items.Add(item);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (addproductFormOpen != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                AddProduct addProductForm = new AddProduct(productHandler, suffixesHandler);
                addProductForm.FormClosed += AddProductForm_FormClosed;
                addproductFormOpen = true;
                addProductForm.Show();
            }
        }

        private void AddProductForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            btnShowAllProducts.PerformClick();
            addproductFormOpen = false;
        }

        private void btnOpenUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProduct == null)
                {
                    MessageBox.Show("Please select a product from the list first");
                    return;
                }
                if (updateProductFormOpen != false)
                {
                    MessageBox.Show("There is already a window open");
                    return;
                }
                else
                {
                    UpdateProduct updateProductForm = new UpdateProduct(productHandler, selectedProduct, suffixesHandler);
                    updateProductFormOpen = true;
                    updateProductForm.FormClosed += UpdateProductForm_FormClosed; ;
                    updateProductForm.Show();
                }
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void UpdateProductForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            btnShowAllProducts.PerformClick();
            updateProductFormOpen = false;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product first");
                return;
            }
            DialogResult dr = MessageBox.Show($"Are You sure you want to Delete this Product ({selectedProduct.Name}) ?", "Delete Product?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    productHandler.DeleteProduct(selectedProduct);
                    MessageBox.Show("Product has successfully been deleted");
                    btnShowAllProducts.PerformClick();
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            else return;
        }

        private void btnSuffixes_Click(object sender, EventArgs e)
        {
            if (suffixesFormOpen != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                Suffixes suffixesForm = new Suffixes(suffixesHandler);
                suffixesForm.FormClosed += SuffixesForm_FormClosed;
                suffixesFormOpen = true;
                suffixesForm.Show();
            }
        }

        private void SuffixesForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            suffixesFormOpen = false;
        }

        private void tbSearchTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchProduct.PerformClick();
            }
        }
    }
}
