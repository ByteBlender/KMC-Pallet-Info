﻿using System;
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
            dataGridView1.DataSource = null;
            btnExport.Enabled = false;

            List<string> palletIDs = new List<string>();

            try
            {

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(row.Cells[0].Value?.ToString()) && row.Cells[0].Value.ToString() != "0")
                    {
                        palletIDs.Add(row.Cells[0].Value.ToString());
                    }
                }

                pallets = Data.GetPalletInfo(palletIDs);


                double totalWeight = 0;


                foreach (Pallet pallet in pallets)
                {
                    pallet.GTIN = Pallet.GenerateGTIN(pallet.EAN, pallet.Weight, pallet.Date, pallet.SerialNo);

                    totalWeight += pallet.Weight;
                }


                lblCount1.Text = $"Entered Pallet IDs";
                lblCount2.Text = $"Valid Pallet IDs";
                lblCount3.Text = $"Total Cartons";
                lblWeight.Text = $"Total Weight";

                lblVal1.Text = $": {palletIDs.Count.ToString()}";
                lblVal2.Text = $": { pallets.Select(x => x.PalletID).Distinct().ToList().Count.ToString()}";
                lblVal3.Text = $": { pallets.Count.ToString()}";
                lblWeightVal.Text = $": {totalWeight}";


                dataGridView1.DataSource = pallets;
                dataGridView1.Columns[7].Width = 350;

                if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                {
                    btnExport.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
            lblCount1.ResetText();
            lblCount2.ResetText();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel|*.xlsx";
            saveFileDialog.ShowDialog();

            try
            {
                if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {

                    List<string> palledIds = pallets.Select(x => x.PalletID.ToString()).ToList().Distinct().ToList();
                    DataTable table = TextFileRW.CreateTableFromObject(pallets);
                    Excel1.WriteExcelFile($"{saveFileDialog.FileName}", table);

                    for (int i = 0; i < palledIds.Count; i++)
                    {
                        List<Pallet> p = pallets.Where(x => x.PalletID == int.Parse(palledIds[i].ToString())).ToList();

                        DataTable t = TextFileRW.CreateTableFromObject(p);


                        Excel1.WriteExcelFile($"{saveFileDialog.FileName.Replace(".xlsx","")}_{palledIds[i]}.xlsx", t);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
    }
    }

