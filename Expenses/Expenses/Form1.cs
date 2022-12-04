
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Expenses
{
	public partial class formLoginPage : Form
	{
        private SqlConnection conn = new SqlConnection("Server=DESKTOP-TGAGQ1J\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        private SqlCommand cmd = new SqlCommand();
        Employee employee;
        public formLoginPage()
		{
			InitializeComponent();

            cmd.Connection = conn;
            string masterDboPath = Application.StartupPath + "master.txt";
            string expensesDboPath = Application.StartupPath + "expenseDbo.txt";
            string queryMaster = File.ReadAllText(masterDboPath);
            string queryExpense = File.ReadAllText(expensesDboPath);

            //MessageBox.Show(queryString);
            cmd.CommandText = queryMaster;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.ConnectionString = "Server=DESKTOP-TGAGQ1J\\SQLEXPRESS;Database=Expenses;Trusted_Connection=True;";
            cmd.CommandText = queryExpense;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
		private void btnSignUp_Click(object sender, EventArgs e)
		{
			formSignUpPage signUpPage= new formSignUpPage();

			signUpPage.ShowDialog();

		}
		private void btnLogin_Click(object sender, EventArgs e)
		{

            bool isRegistered = false;

            //[GuideEmployeeId] ,[EmployeeFullName] ,[EmployeePassword] ,[EmployeeType] ,[EnterExpence] ,[Approves] ,[CanPay]
            string select = "SELECT [GuideEmployeeId] ,[EmployeeFullName] ,[EmployeePassword] ,[EmployeeType] ,[EnterExpence] ,[Approves] ,[CanPay] FROM [dbo].[Employees] WHERE EmployeeFullName=@name AND [EmployeePassword]=@pass";
            cmd.CommandText = select;
            cmd.Parameters.AddWithValue("name", txtName.Text);
            cmd.Parameters.AddWithValue("pass", txtPassword.Text);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                employee = new Employee
                {
                    EmployeeId = reader.GetGuid("GuideEmployeeId"),
                    EmployeeFullName = reader.GetString("EmployeeFullName"),
                    EmployeePassword= reader.GetString("EmployeePassword"),
                    EmployeeType=reader.GetString("EmployeeType"),
                    EnterExpence =reader.GetBoolean("EnterExpence"),
                    Approves = reader.GetBoolean("Approves"),
                    CanPay = reader.GetBoolean("CanPay"),
                };
                isRegistered = true;
            }
            conn.Close();

            if (isRegistered)
            {
                Home home = new Home(employee);
                home.Show();
                this.Hide();
            }
            else
                MessageBox.Show("User not found or Wrong Password");
            cmd.Parameters.Clear();
        }
	}
}