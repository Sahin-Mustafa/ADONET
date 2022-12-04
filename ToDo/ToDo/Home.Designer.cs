namespace ToDo
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
            this.lstTodos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtToDoTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpUpdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUpdatDesc = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTodos
            // 
            this.lstTodos.FormattingEnabled = true;
            this.lstTodos.ItemHeight = 15;
            this.lstTodos.Location = new System.Drawing.Point(15, 26);
            this.lstTodos.Name = "lstTodos";
            this.lstTodos.Size = new System.Drawing.Size(384, 424);
            this.lstTodos.TabIndex = 0;
            this.lstTodos.SelectedIndexChanged += new System.EventHandler(this.lstTodos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtToDoTitle);
            this.groupBox1.Location = new System.Drawing.Point(408, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add ToDo";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(140, 177);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(96, 23);
            this.txtAdd.TabIndex = 5;
            this.txtAdd.Text = "Add";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpDueDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 41);
            this.panel3.TabIndex = 4;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(73, 6);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(157, 23);
            this.dtpDueDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Due Date  :";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 12);
            this.panel2.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescription.Location = new System.Drawing.Point(3, 54);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.Size = new System.Drawing.Size(238, 64);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 12);
            this.panel1.TabIndex = 1;
            // 
            // txtToDoTitle
            // 
            this.txtToDoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtToDoTitle.Location = new System.Drawing.Point(3, 19);
            this.txtToDoTitle.Name = "txtToDoTitle";
            this.txtToDoTitle.PlaceholderText = "Title";
            this.txtToDoTitle.Size = new System.Drawing.Size(238, 23);
            this.txtToDoTitle.TabIndex = 0;
            this.txtToDoTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.txtUpdatDesc);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.txtUpdateTitle);
            this.groupBox2.Location = new System.Drawing.Point(405, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 245);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update ToDo";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbStatus.Location = new System.Drawing.Point(3, 183);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(241, 19);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Text = "Done";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 171);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 12);
            this.panel7.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(143, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpUpdate);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 41);
            this.panel4.TabIndex = 4;
            // 
            // dtpUpdate
            // 
            this.dtpUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdate.Location = new System.Drawing.Point(73, 6);
            this.dtpUpdate.Name = "dtpUpdate";
            this.dtpUpdate.Size = new System.Drawing.Size(168, 23);
            this.dtpUpdate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Due Date  :";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 12);
            this.panel5.TabIndex = 3;
            // 
            // txtUpdatDesc
            // 
            this.txtUpdatDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUpdatDesc.Location = new System.Drawing.Point(3, 54);
            this.txtUpdatDesc.Multiline = true;
            this.txtUpdatDesc.Name = "txtUpdatDesc";
            this.txtUpdatDesc.PlaceholderText = "Description";
            this.txtUpdatDesc.Size = new System.Drawing.Size(241, 64);
            this.txtUpdatDesc.TabIndex = 2;
            this.txtUpdatDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 12);
            this.panel6.TabIndex = 1;
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUpdateTitle.Location = new System.Drawing.Point(3, 19);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.PlaceholderText = "Title";
            this.txtUpdateTitle.Size = new System.Drawing.Size(241, 23);
            this.txtUpdateTitle.TabIndex = 0;
            this.txtUpdateTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 491);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstTodos);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstTodos;
        private GroupBox groupBox1;
        private Panel panel2;
        private TextBox txtDescription;
        private Panel panel1;
        private TextBox txtToDoTitle;
        private Button txtAdd;
        private Panel panel3;
        private DateTimePicker dtpDueDate;
        private Label label2;
        private GroupBox groupBox2;
        private CheckBox cbStatus;
        private Panel panel7;
        private Button btnUpdate;
        private Panel panel4;
        private DateTimePicker dtpUpdate;
        private Label label3;
        private Panel panel5;
        private TextBox txtUpdatDesc;
        private Panel panel6;
        private TextBox txtUpdateTitle;
        private Button btnDelete;
    }
}