using DataAccessLibrary.Products;
using DesktopApplication.Forms.Products;
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

namespace DesktopApplication.Forms.Advertisement
{
    public partial class Advertisements : Form
    {
        private ProductHandler productHandler;
        private SuffixesHandler suffixesHandler;
        private Product? selectedProduct;

        public bool putAdvertisementOpen = false;

        public Advertisements()
        {
            InitializeComponent();
        }

        private void Advertisements_Load(object sender, EventArgs e)
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

        private void btnPutAdvertisement_Click(object sender, EventArgs e)
        {
            if(selectedProduct == null)
                {
                MessageBox.Show("Please select a product from the list first");
                return;
            }
            if (putAdvertisementOpen != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
           
            AddAdvertisement addAdvertisementForm = new AddAdvertisement(productHandler, selectedProduct);
            addAdvertisementForm.FormClosed += AddAdvertisementForm_FormClosed;
            putAdvertisementOpen = true;
            addAdvertisementForm.Show();
            
        }

        private void AddAdvertisementForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            putAdvertisementOpen = false;
        }
    }
}
