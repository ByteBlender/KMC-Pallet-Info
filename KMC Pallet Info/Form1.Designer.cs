namespace KMC_Pallet_Info
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PalletID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblWeightVal = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(4, 114);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(199, 42);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "Generate Report";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 768);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblWeightVal);
            this.splitContainer2.Panel2.Controls.Add(this.lblWeight);
            this.splitContainer2.Panel2.Controls.Add(this.lblVal3);
            this.splitContainer2.Panel2.Controls.Add(this.lblVal2);
            this.splitContainer2.Panel2.Controls.Add(this.lblVal1);
            this.splitContainer2.Panel2.Controls.Add(this.lblCount3);
            this.splitContainer2.Panel2.Controls.Add(this.lblCount2);
            this.splitContainer2.Panel2.Controls.Add(this.lblCount1);
            this.splitContainer2.Panel2.Controls.Add(this.btnViewDetails);
            this.splitContainer2.Panel2.Controls.Add(this.btnClear);
            this.splitContainer2.Panel2.Controls.Add(this.btnExport);
            this.splitContainer2.Size = new System.Drawing.Size(205, 768);
            this.splitContainer2.SplitterDistance = 557;
            this.splitContainer2.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PalletID});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(205, 557);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // PalletID
            // 
            this.PalletID.HeaderText = "Pallet ID";
            this.PalletID.Name = "PalletID";
            this.PalletID.Width = 200;
            // 
            // lblVal3
            // 
            this.lblVal3.AutoSize = true;
            this.lblVal3.Location = new System.Drawing.Point(94, 71);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(0, 13);
            this.lblVal3.TabIndex = 8;
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(94, 51);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(0, 13);
            this.lblVal2.TabIndex = 7;
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(94, 32);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(0, 13);
            this.lblVal1.TabIndex = 6;
            // 
            // lblCount3
            // 
            this.lblCount3.AutoSize = true;
            this.lblCount3.Location = new System.Drawing.Point(12, 71);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(0, 13);
            this.lblCount3.TabIndex = 5;
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Location = new System.Drawing.Point(12, 51);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(0, 13);
            this.lblCount2.TabIndex = 4;
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Location = new System.Drawing.Point(12, 32);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(0, 13);
            this.lblCount1.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(3, 162);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(199, 42);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1015, 768);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblWeightVal
            // 
            this.lblWeightVal.AutoSize = true;
            this.lblWeightVal.Location = new System.Drawing.Point(94, 91);
            this.lblWeightVal.Name = "lblWeightVal";
            this.lblWeightVal.Size = new System.Drawing.Size(0, 13);
            this.lblWeightVal.TabIndex = 10;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 91);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 13);
            this.lblWeight.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 768);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Pallet Information";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalletID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount3;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblVal3;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblWeightVal;
        private System.Windows.Forms.Label lblWeight;
    }
}

