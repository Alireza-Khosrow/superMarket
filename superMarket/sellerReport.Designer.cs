namespace superMarket
{
    partial class sellerReport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DGVseller = new Guna.UI2.WinForms.Guna2DataGridView();
            TId = new DataGridViewTextBoxColumn();
            BillId = new DataGridViewTextBoxColumn();
            NameP = new DataGridViewTextBoxColumn();
            QtyP = new DataGridViewTextBoxColumn();
            CostP = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGVseller).BeginInit();
            SuspendLayout();
            // 
            // DGVseller
            // 
            DGVseller.AllowUserToAddRows = false;
            DGVseller.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 49, 69);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 49, 69);
            DGVseller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVseller.BackgroundColor = Color.FromArgb(50, 49, 69);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(36, 232, 166);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(36, 232, 166);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVseller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVseller.ColumnHeadersHeight = 30;
            DGVseller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DGVseller.Columns.AddRange(new DataGridViewColumn[] { TId, BillId, NameP, QtyP, CostP });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 49, 69);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(83, 81, 115);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVseller.DefaultCellStyle = dataGridViewCellStyle3;
            DGVseller.GridColor = Color.FromArgb(50, 49, 69);
            DGVseller.Location = new Point(12, 17);
            DGVseller.Name = "DGVseller";
            DGVseller.ReadOnly = true;
            DGVseller.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(50, 49, 69);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 49, 69);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVseller.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVseller.RowHeadersVisible = false;
            DGVseller.RowHeadersWidth = 51;
            DGVseller.Size = new Size(1126, 617);
            DGVseller.TabIndex = 74;
            DGVseller.ThemeStyle.AlternatingRowsStyle.BackColor = Color.Transparent;
            DGVseller.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DGVseller.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGVseller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGVseller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGVseller.ThemeStyle.BackColor = Color.FromArgb(50, 49, 69);
            DGVseller.ThemeStyle.GridColor = Color.FromArgb(50, 49, 69);
            DGVseller.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DGVseller.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVseller.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGVseller.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGVseller.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DGVseller.ThemeStyle.HeaderStyle.Height = 30;
            DGVseller.ThemeStyle.ReadOnly = true;
            DGVseller.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(50, 49, 69);
            DGVseller.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVseller.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGVseller.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGVseller.ThemeStyle.RowsStyle.Height = 29;
            DGVseller.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(50, 49, 69);
            DGVseller.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // TId
            // 
            TId.DataPropertyName = "TId";
            TId.HeaderText = "تراکنش";
            TId.MinimumWidth = 6;
            TId.Name = "TId";
            TId.ReadOnly = true;
            // 
            // BillId
            // 
            BillId.DataPropertyName = "BillId";
            BillId.HeaderText = "فاکتور";
            BillId.MinimumWidth = 6;
            BillId.Name = "BillId";
            BillId.ReadOnly = true;
            // 
            // NameP
            // 
            NameP.DataPropertyName = "NameP";
            NameP.HeaderText = "نام";
            NameP.MinimumWidth = 6;
            NameP.Name = "NameP";
            NameP.ReadOnly = true;
            // 
            // QtyP
            // 
            QtyP.DataPropertyName = "QtyP";
            QtyP.HeaderText = "تعداد";
            QtyP.MinimumWidth = 6;
            QtyP.Name = "QtyP";
            QtyP.ReadOnly = true;
            // 
            // CostP
            // 
            CostP.DataPropertyName = "CostP";
            CostP.HeaderText = "قیمت";
            CostP.MinimumWidth = 6;
            CostP.Name = "CostP";
            CostP.ReadOnly = true;
            // 
            // sellerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 49, 69);
            ClientSize = new Size(1150, 650);
            Controls.Add(DGVseller);
            Name = "sellerReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sellerReport";
            Load += sellerReport_Load;
            ((System.ComponentModel.ISupportInitialize)DGVseller).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVseller;
        private DataGridViewTextBoxColumn TId;
        private DataGridViewTextBoxColumn BillId;
        private DataGridViewTextBoxColumn NameP;
        private DataGridViewTextBoxColumn QtyP;
        private DataGridViewTextBoxColumn CostP;
    }
}