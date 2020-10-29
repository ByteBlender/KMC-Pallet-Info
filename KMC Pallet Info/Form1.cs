using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMC_Pallet_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= Data.GetPalletInfo(new List<string>() {"54525","54520" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPalletID.Text))
            {
                listBox1.Items.Add(txtPalletID.Text);
                txtPalletID.ResetText();
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
