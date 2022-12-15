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
    public partial class Suffixes : Form
    {
        private SuffixesHandler suffixesHandler;
        private Suffix selectedSuffix;
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

            cboxSuffixType.SelectedIndex = -1;
            cboxUpdateSuffixType.SelectedIndex = -1;

            LoadSuffixes();
        }

        

        private void btnAddSuffix_Click(object sender, EventArgs e)
        {
            try 
            {
                if (cboxSuffixType.SelectedIndex < 0) throw new ArgumentException("Please select a type first");

                Suffix suffix = new Suffix(tbSuffixText.Text, (SuffixType)cboxSuffixType.SelectedItem);
                suffixesHandler.AddSuffix(suffix);

                MessageBox.Show("Suffix added successfully");

                tbSuffixText.Clear();
                cboxSuffixType.SelectedIndex = -1;

                LoadSuffixes();

            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void listViewSuffixes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedSuffix = (Suffix)e.Item.Tag;

            tbUpdateSuffixType.Text = selectedSuffix.Name;
            cboxUpdateSuffixType.SelectedIndex = (int)selectedSuffix.SuffixType;

        }

        private void listViewSuffixes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewSuffixes.SelectedItems.Count == 0)
            {
                selectedSuffix = null;
                tbUpdateSuffixType.Clear();
                cboxUpdateSuffixType.SelectedIndex = -1;
            }

        }

        private void AddProductToListView(Suffix suffix)
        {
            ListViewItem item = new ListViewItem(suffix.Name);
            item.Tag = suffix;
            item.SubItems.Add(suffix.SuffixType.ToString());

            listViewSuffixes.Items.Add(item);
        }

        private void btnUpdateSuffix_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxSuffixType.SelectedIndex < 0) throw new ArgumentException("Please select a type first");

                Suffix newSuffix = new Suffix(tbSuffixText.Text, (SuffixType)cboxSuffixType.SelectedItem);
                suffixesHandler.UpdateSuffix(selectedSuffix, newSuffix);

                MessageBox.Show("Suffix Updated successfully");

                selectedSuffix = null;
                tbSuffixText.Clear();
                cboxSuffixType.SelectedIndex = -1;

                LoadSuffixes();

            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with the database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadSuffixes() 
        {
            listViewSuffixes.Items.Clear();
            foreach (Suffix suff in suffixesHandler.Suffixes)
            {
                AddProductToListView(suff);
            }
        }
    }
}
