
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ToDo
{
    public partial class formLogin : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public List<User> users = new List<User>();
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = "Server=.\\SABAHMS;Database=ToDoApp;Trusted_Connection=True;";
            command.Connection = connection;
            LoadCategories();

        }
        private void LoadCategories()
        {
            command.CommandText = "SELECT [Id] ,[UserName] ,[Password] FROM [dbo].[Users]";

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //SELECT [id] ,[UserName] ,[Password] FROM [dbo].[Users]    
            while (reader.Read())
            {
                User user = new User();

                user.Id = (int)reader["Id"];
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                users.Add(user);

            }
            connection.Close();
            reader.DisposeAsync();
            //command.DisposeAsync();
            //connection.DisposeAsync();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            command.CommandText = "SELECT * FROM [dbo].[Users] WHERE [UserName]=@uname AND [Password]= @pass ";
            command.Parameters.AddWithValue("uname", username);
            command.Parameters.AddWithValue("pass", password);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
                MessageBox.Show("Hatalý giris yaptýnýz");

            connection.Close();

        }
    }
}