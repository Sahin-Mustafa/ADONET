using System.Data.SqlClient;


namespace Expenses
{
    public partial class formSignUpPage : Form
    {

        private SqlConnection conn = new SqlConnection("Server=DESKTOP-TGAGQ1J\\SQLEXPRESS;Database=Expenses;Trusted_Connection=True;");
        private SqlCommand cmd = new SqlCommand();
        private Employee employee;

        public formSignUpPage()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Isim Kısmı bos birakilamz.");
                return;
            }
            if (txtPassword.Text.Contains(" ") || txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Sifre bosluk kullanılamaz ve EN AZ 8 karakterli olmalı");
                return;
            }
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Sifreler aynı olmalı");
                return;
            }
            if (cmbEmployeType.SelectedIndex == -1)
            {
                MessageBox.Show("Calisanin pozisyonunu seciniz");
                return;
            }

            cmd.Connection= conn;
            string query = "INSERT INTO [dbo].[Employees] ([EmployeeFullName] ,[EmployeePassword] ,[EmployeeType] ,[EnterExpence] ,[Approves] ,[CanPay]) VALUES (@name ,@pass ,@type ,@enterExpence ,@approves ,@canPay)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("name", txtUserName.Text);
            cmd.Parameters.AddWithValue("pass", txtPassword.Text);
            cmd.Parameters.AddWithValue("type", cmbEmployeType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("enterExpence", employee.EnterExpence);
            cmd.Parameters.AddWithValue("approves", employee.Approves);
            cmd.Parameters.AddWithValue("canPay", employee.CanPay);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            cmd.Parameters.Clear();

            MessageBox.Show("Calisan Eklendi.");
            this.Close();        

        }
        private void cmbEmployeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeType = cmbEmployeType.SelectedItem.ToString().ToLower();
            
            switch (employeeType)
            {
                case ("worker"):
                    employee = new Worker();
                    break;
                case ("manager"):
                    employee = new Manager();
                    break;
                case ("accountant"):
                    employee = new Accountant();
                    break;
                default:
                    break;
            }
        }
    }
}
