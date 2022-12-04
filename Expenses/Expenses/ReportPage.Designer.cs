namespace Expenses
{
    partial class ReportPage
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
            this.cmbReportName = new System.Windows.Forms.ComboBox();
            this.btnRefleshCb = new System.Windows.Forms.Button();
            this.dgvFiltreExpenses = new System.Windows.Forms.DataGridView();
            this.btnRefleshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltreExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportName
            // 
            this.cmbReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReportName.FormattingEnabled = true;
            this.cmbReportName.Location = new System.Drawing.Point(341, 15);
            this.cmbReportName.Name = "cmbReportName";
            this.cmbReportName.Size = new System.Drawing.Size(706, 23);
            this.cmbReportName.TabIndex = 0;
            this.cmbReportName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRefleshCb
            // 
            this.btnRefleshCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefleshCb.BackgroundImage = global::Expenses.Properties.Resources.restart_24;
            this.btnRefleshCb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefleshCb.Location = new System.Drawing.Point(1053, 13);
            this.btnRefleshCb.Name = "btnRefleshCb";
            this.btnRefleshCb.Size = new System.Drawing.Size(49, 24);
            this.btnRefleshCb.TabIndex = 1;
            this.btnRefleshCb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefleshCb.UseVisualStyleBackColor = true;
            this.btnRefleshCb.Click += new System.EventHandler(this.btnRefleshCb_Click);
            // 
            // dgvFiltreExpenses
            // 
            this.dgvFiltreExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiltreExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiltreExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltreExpenses.Location = new System.Drawing.Point(12, 44);
            this.dgvFiltreExpenses.Name = "dgvFiltreExpenses";
            this.dgvFiltreExpenses.ReadOnly = true;
            this.dgvFiltreExpenses.RowTemplate.Height = 25;
            this.dgvFiltreExpenses.Size = new System.Drawing.Size(1090, 615);
            this.dgvFiltreExpenses.TabIndex = 2;
            this.dgvFiltreExpenses.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvFiltreExpenses_RowPostPaint);
            // 
            // btnRefleshTable
            // 
            this.btnRefleshTable.Location = new System.Drawing.Point(12, 15);
            this.btnRefleshTable.Name = "btnRefleshTable";
            this.btnRefleshTable.Size = new System.Drawing.Size(136, 23);
            this.btnRefleshTable.TabIndex = 3;
            this.btnRefleshTable.Text = "Reflesh Table";
            this.btnRefleshTable.UseVisualStyleBackColor = true;
            this.btnRefleshTable.Click += new System.EventHandler(this.btnRefleshTable_Click);
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 671);
            this.Controls.Add(this.btnRefleshTable);
            this.Controls.Add(this.dgvFiltreExpenses);
            this.Controls.Add(this.btnRefleshCb);
            this.Controls.Add(this.cmbReportName);
            this.MinimumSize = new System.Drawing.Size(1130, 710);
            this.Name = "ReportPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltreExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbReportName;
        private Button btnRefleshCb;
        private DataGridView dgvFiltreExpenses;
        private Button btnRefleshTable;
    }
}