namespace Expenses
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.lbEmployeeInfo = new System.Windows.Forms.Label();
            this.contextMenuManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvExpenseList = new System.Windows.Forms.DataGridView();
            this.contextMenuAccountant = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlExpenseInfo = new System.Windows.Forms.Panel();
            this.pnlAccountant = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExpenseDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.contextMenuManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseList)).BeginInit();
            this.contextMenuAccountant.SuspendLayout();
            this.pnlExpenseInfo.SuspendLayout();
            this.pnlAccountant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmployeeInfo
            // 
            this.lbEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeeInfo.AutoSize = true;
            this.lbEmployeeInfo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeInfo.Location = new System.Drawing.Point(871, 16);
            this.lbEmployeeInfo.Name = "lbEmployeeInfo";
            this.lbEmployeeInfo.Size = new System.Drawing.Size(163, 23);
            this.lbEmployeeInfo.TabIndex = 0;
            this.lbEmployeeInfo.Text = "Employee Name";
            // 
            // contextMenuManager
            // 
            this.contextMenuManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveToolStripMenuItem,
            this.rejectToolStripMenuItem});
            this.contextMenuManager.Name = "contextMenuManger";
            this.contextMenuManager.Size = new System.Drawing.Size(120, 48);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
            // 
            // dgvExpenseList
            // 
            this.dgvExpenseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpenseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseList.Location = new System.Drawing.Point(290, 42);
            this.dgvExpenseList.Name = "dgvExpenseList";
            this.dgvExpenseList.ReadOnly = true;
            this.dgvExpenseList.RowTemplate.Height = 25;
            this.dgvExpenseList.Size = new System.Drawing.Size(843, 603);
            this.dgvExpenseList.TabIndex = 0;
            this.dgvExpenseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseList_CellClick);
            this.dgvExpenseList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseList_CellMouseEnter);
            // 
            // contextMenuAccountant
            // 
            this.contextMenuAccountant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payToolStripMenuItem});
            this.contextMenuAccountant.Name = "contextMenuAccountant";
            this.contextMenuAccountant.Size = new System.Drawing.Size(94, 26);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.payToolStripMenuItem.Text = "Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // pnlExpenseInfo
            // 
            this.pnlExpenseInfo.Controls.Add(this.pnlAccountant);
            this.pnlExpenseInfo.Controls.Add(this.label4);
            this.pnlExpenseInfo.Controls.Add(this.label3);
            this.pnlExpenseInfo.Controls.Add(this.label2);
            this.pnlExpenseInfo.Controls.Add(this.nudAmount);
            this.pnlExpenseInfo.Controls.Add(this.btnDelete);
            this.pnlExpenseInfo.Controls.Add(this.btnUpdate);
            this.pnlExpenseInfo.Controls.Add(this.btnAdd);
            this.pnlExpenseInfo.Controls.Add(this.txtExpenseDetail);
            this.pnlExpenseInfo.Controls.Add(this.label1);
            this.pnlExpenseInfo.Controls.Add(this.dtpExpenseDate);
            this.pnlExpenseInfo.Controls.Add(this.txtExpenseTitle);
            this.pnlExpenseInfo.Location = new System.Drawing.Point(14, 35);
            this.pnlExpenseInfo.Name = "pnlExpenseInfo";
            this.pnlExpenseInfo.Size = new System.Drawing.Size(270, 688);
            this.pnlExpenseInfo.TabIndex = 13;
            // 
            // pnlAccountant
            // 
            this.pnlAccountant.Controls.Add(this.label6);
            this.pnlAccountant.Controls.Add(this.label5);
            this.pnlAccountant.Location = new System.Drawing.Point(16, 385);
            this.pnlAccountant.Name = "pnlAccountant";
            this.pnlAccountant.Size = new System.Drawing.Size(241, 218);
            this.pnlAccountant.TabIndex = 23;
            this.pnlAccountant.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(14, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = " Cannot enter expenses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(38, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Accounting staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Amount";
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudAmount.Location = new System.Drawing.Point(87, 124);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(183, 29);
            this.nudAmount.TabIndex = 19;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(151, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 31);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(0, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 33);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(154, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 33);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExpenseDetail
            // 
            this.txtExpenseDetail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpenseDetail.Location = new System.Drawing.Point(0, 173);
            this.txtExpenseDetail.Multiline = true;
            this.txtExpenseDetail.Name = "txtExpenseDetail";
            this.txtExpenseDetail.PlaceholderText = "Expense Detail";
            this.txtExpenseDetail.Size = new System.Drawing.Size(270, 150);
            this.txtExpenseDetail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date";
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpenseDate.Location = new System.Drawing.Point(87, 59);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(183, 29);
            this.dtpExpenseDate.TabIndex = 13;
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpenseTitle.Location = new System.Drawing.Point(0, 6);
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.PlaceholderText = "Expense Title";
            this.txtExpenseTitle.Size = new System.Drawing.Size(270, 29);
            this.txtExpenseTitle.TabIndex = 12;
            this.txtExpenseTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReport.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReport.Location = new System.Drawing.Point(1017, 652);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(116, 33);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Report Page";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 691);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pnlExpenseInfo);
            this.Controls.Add(this.dgvExpenseList);
            this.Controls.Add(this.lbEmployeeInfo);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.contextMenuManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseList)).EndInit();
            this.contextMenuAccountant.ResumeLayout(false);
            this.pnlExpenseInfo.ResumeLayout(false);
            this.pnlExpenseInfo.PerformLayout();
            this.pnlAccountant.ResumeLayout(false);
            this.pnlAccountant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbEmployeeInfo;
        private ContextMenuStrip contextMenuManager;
        private ToolStripMenuItem approveToolStripMenuItem;
        private ToolStripMenuItem rejectToolStripMenuItem;
        private DataGridView dgvExpenseList;
        private ContextMenuStrip contextMenuAccountant;
        private ToolStripMenuItem payToolStripMenuItem;
        private Panel pnlExpenseInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown nudAmount;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtExpenseDetail;
        private Label label1;
        private DateTimePicker dtpExpenseDate;
        private TextBox txtExpenseTitle;
        private Panel pnlAccountant;
        private Label label6;
        private Label label5;
        private Button btnReport;
    }
}