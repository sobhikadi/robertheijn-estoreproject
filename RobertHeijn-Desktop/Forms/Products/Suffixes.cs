using LogicLayerEntitiesLibrary.Products;
using LogicLayerHandlersLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Forms.Products
{
    public partial class Suffixes : Form
    {
        private SuffixesHandler suffixesHandler;
        public Suffixes(SuffixesHandler suffixesHandler)
        {
            this.suffixesHandler = suffixesHandler;
            InitializeComponent();
        }

        private void Suffixes_Load(object sender, EventArgs e)
        {
            cboxSuffixType.DataSource = null;
            cboxSuffixType.DataSource = Enum.GetValues(typeof(ProductSuffix));

            LoadDataToListBoxes();
        }

        private void LoadDataToListBoxes() 
        {
            lboxCategories.Items.Clear();
            lboxSubCategories.Items.Clear();
            lboxUnits.Items.Clear();

            foreach (Suffix suff in suffixesHandler.Suffixes) 
            {
                if (suff is Category) lboxCategories.Items.Add(suff);
                else if (suff is SubCategory) lboxSubCategories.Items.Add(suff);
                else lboxUnits.Items.Add(suff);
            }
        }

        private void btnAddSuffix_Click(object sender, EventArgs e)
        {
            Suffix suffix = new Category(textBox1.Text);
            suffixesHandler.AddSuffix(suffix, (ProductSuffix)cboxSuffixType.SelectedItem);
        }
    }
}
