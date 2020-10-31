using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBUtils;

namespace KMC_Pallet_Info
{
    public partial class Form1 : Form
    {
        List<Pallet> pallets = new List<Pallet>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            List<string> palletIDs = new List<string>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!string.IsNullOrWhiteSpace(row.Cells[0].Value?.ToString()) && row.Cells[0].Value.ToString() != "0")
                {
                    palletIDs.Add(row.Cells[0].Value.ToString());
                }
            }

           dataGridView1.DataSource = pallets = Data.GetPalletInfo(palletIDs);
        }




        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string cellVaue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!int.TryParse(cellVaue, out int x))
                {
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|.xlsx";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != null)
            {
                DataTable table = TextFileRW.CreateTableFromObject(pallets);
                ExcelRW.WriteExcelFile(saveFileDialog.FileName, table);
            }

          
            
        }
    }
    }

