using LogicLayerEntitiesLibrary.Exceptions;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerEntitiesLibrary.Products.DiscountS;
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
    public partial class AddAdvertisement : Form
    {
        private ProductHandler productHandler;
        private Product product;
        public AddAdvertisement(ProductHandler productHandler, Product product)
        {
            InitializeComponent();
            this.productHandler = productHandler;
            this.product = product;
        }

        private void AddAdvertisement_Load(object sender, EventArgs e)
        {
            cboxRules.DataSource = null;
            cboxRules.DataSource = Enum.GetValues(typeof(DiscountRules));
            cboxRules.SelectedIndex = -1;

        }

        private void cboxRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((DiscountRules)cboxRules.SelectedIndex == DiscountRules.PerUnits) 
            {
                tbFlatDiscount.Enabled = true;
            }
            else tbFlatDiscount.Enabled = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to add this advertisement?", "Add advertisement?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string name;
                DateTime sDate, eDate;
                int nrProducts;
                DiscountRules discountRule;
                double flatDiscount = 0; ;

                try
                {
                    
                    name = tbAdSlogan.Text;
                    sDate = dtpSDate.Value.Date;
                    eDate = dtpEDate.Value.Date;
                    nrProducts = (int)nudAmountProducts.Value;
                    discountRule = (DiscountRules)cboxRules.SelectedItem;


                    if ((DiscountRules)cboxRules.SelectedItem == DiscountRules.PerUnits) 
                    {
                        if (!double.TryParse(tbFlatDiscount.Text, out flatDiscount)) { throw new ArgumentException("The price field cannot include letters"); }
                    }

                    double calculatedDiscount = (double)product.CalculateDiscount(discountRule, nrProducts, product.Price, flatDiscount);

                    if (calculatedDiscount == null) throw new NullValueException("Calculation did not succeed");
                    
                    Discount discount = new Discount(name, sDate, eDate, nrProducts, calculatedDiscount);
                    

                    productHandler.AddAdvertisement(product, discount);

                    MessageBox.Show("Product added successfully!");
                    foreach (Control co in this.Controls)
                    {
                        if (co is TextBox || co is ComboBox || co is DateTimePicker) { co.ResetText(); }
                    }
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }
    }
}
