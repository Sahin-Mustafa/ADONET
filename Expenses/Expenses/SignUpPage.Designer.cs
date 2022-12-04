namespace Expenses
{
    partial class formSignUpPage
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
            this.btnSave = new System.Windows.Forms.Button();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.cmbEmployeType = new System.Windows.Forms.ComboBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.PanelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(96, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PanelBase
            // 
            this.PanelBase.Controls.Add(this.cmbEmployeType);
            this.PanelBase.Controls.Add(this.txtRePassword);
            this.PanelBase.Controls.Add(this.pictureBox1);
            this.PanelBase.Controls.Add(this.btnSave);
            this.PanelBase.Controls.Add(this.txtPassword);
            this.PanelBase.Controls.Add(this.txtUserName);
            this.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBase.Location = new System.Drawing.Point(0, 0);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(293, 369);
            this.PanelBase.TabIndex = 1;
            // 
            // cmbEmployeType
            // 
            this.cmbEmployeType.FormattingEnabled = true;
            this.cmbEmployeType.Items.AddRange(new object[] {
            "Worker",
            "Manager",
            "Accountant"});
            this.cmbEmployeType.Location = new System.Drawing.Point(46, 297);
            this.cmbEmployeType.Name = "cmbEmployeType";
            this.cmbEmployeType.Size = new System.Drawing.Size(197, 23);
            this.cmbEmployeType.TabIndex = 7;
            this.cmbEmployeType.Text = "Employee Position";
            this.cmbEmployeType.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeType_SelectedIndexChanged);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(46, 259);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.PlaceholderText = "Again Password";
            this.txtRePassword.Size = new System.Drawing.Size(197, 23);
            this.txtRePassword.TabIndex = 6;
            this.txtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expenses.Properties.Resources.user_128px;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(48, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(197, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(48, 180);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.Size = new System.Drawing.Size(197, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formSignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 369);
            this.Controls.Add(this.PanelBase);
            this.MaximizeBox = false;
            this.Name = "formSignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Employee Information";
            this.PanelBase.ResumeLayout(false);
            this.PanelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private Panel PanelBase;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private ComboBox cmbEmployeType;
        private TextBox txtRePassword;
    }
}