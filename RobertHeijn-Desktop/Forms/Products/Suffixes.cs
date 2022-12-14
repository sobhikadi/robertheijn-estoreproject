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
            cboxUpdateSuffixType.DataSource = null;
            cboxSuffixType.DataSource = Enum.GetValues(typeof(SuffixType));
            cboxUpdateSuffixType.DataSource = Enum.GetValues(typeof(SuffixType));

            LoadDataToListBoxes();
        }

        private void LoadDataToListBoxes() 
        {
            lboxSuffixes.DataSource = null;
            lboxSuffixes.DataSource = suffixesHandler.Suffixes;
        }

        private void btnAddSuffix_Click(object sender, EventArgs e)
        {
            Suffix suffix = new Suffix(tbSuffixText.Text, (SuffixType)cboxSuffixType.SelectedItem);
            suffixesHandler.AddSuffix(suffix);
        }
    }
}
