using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Home : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public List<Todo> todos = new List<Todo>();
        public Todo todo = new Todo();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadToDosData();
        }

        private void LoadToDosData()
        {
            todos.Clear();
            lstTodos.Items.Clear();
            connection.ConnectionString = "Server=.\\SABAHMS;Database=ToDoApp;Trusted_Connection=True;";
            command.Connection = connection;
            command.CommandText = "SELECT [Id] ,[ToDoTitle] ,[ToDoDetail] ,[ToDoDueDate] ,[Status] FROM [dbo].[ToDos] ";

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //SELECT [id] ,[UserName] ,[Password] FROM [dbo].[Users]    
            while (reader.Read())
            {
                todo = new Todo
                {
                    ToDoId = (int)reader["Id"],
                    ToDoTitle = reader["ToDoTitle"].ToString(),
                    ToDoDetail = reader["ToDoDetail"].ToString(),
                    ToDoDueDate = (DateTime)reader["ToDoDueDate"],
                    Status = (bool)reader["Status"],
                };
                lstTodos.Items.Add(todo);
                todos.Add(todo);
            }
            connection.Close();
            reader.DisposeAsync();
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Title cannot be left blank.");
                return;
            }
            Todo todo = new Todo();
            //todo.ToDoId = todos.Count + 1;
            todo.ToDoTitle = txtToDoTitle.Text;
            todo.ToDoDetail = txtDescription.Text;
            todo.ToDoDueDate = dtpDueDate.Value;
            todo.Status = false;


            string query = $"INSERT INTO [dbo].[ToDos] ([ToDoTitle] ,[ToDoDetail] ,[ToDoDueDate] ,[Status]) VALUES ('{todo.ToDoTitle}' ,'{todo.ToDoDetail}' ,'{todo.ToDoDueDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}' ,'{todo.Status}')";
            command.CommandText = query;



            connection.Open();
            int effectedRowsCount = command.ExecuteNonQuery();
            connection.Close();
            if (effectedRowsCount > 0)
            {
                LoadToDosData();
                MessageBox.Show("New ToDo added to list");
            }
            else
                MessageBox.Show("New ToDo didn't add to list");
            lstTodos.SelectedIndex = -1;


        }

        private void lstTodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTodos.SelectedIndex > -1)
            {
                todo = (Todo)lstTodos.SelectedItem;
                //MessageBox.Show($"{todo.ToDoId}");
                txtUpdateTitle.Text = todo.ToDoTitle;
                txtUpdatDesc.Text = todo.ToDoDetail;
                dtpUpdate.Value = todo.ToDoDueDate;
                cbStatus.Checked = todo.Status;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATE [dbo].[Users] SET [Id] = <Id, int,> ,[UserName] = <UserName, varchar(50),> ,[Password] = <Password, varchar(50),> WHERE <Search Conditions,,>
            string query = $"UPDATE [dbo].[ToDos] SET [ToDoTitle] = '{txtUpdateTitle.Text}',[ToDoDetail] = '{txtUpdatDesc.Text}',[Status] ='{cbStatus.Checked}' WHERE [Id]={todo.ToDoId}";
            command.CommandText = query;

            connection.Open();
            int effectedRowsCount = command.ExecuteNonQuery();
            connection.Close();
            if (effectedRowsCount > 0)
            {
                MessageBox.Show("Update is successful");
                LoadToDosData();
            }
            else
            {
                MessageBox.Show("Update is Unsuccessful");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DELETE FROM [dbo].[ToDos] WHERE < Search Conditions,,>
            if (lstTodos.SelectedIndex > -1)
            {
                todo = (Todo)lstTodos.SelectedItem;
                string query = $"DELETE FROM [dbo].[ToDos] WHERE [Id]={todo.ToDoId}";
                command.CommandText = query;

                connection.Open();
                int effectedRowsCount = command.ExecuteNonQuery();
                connection.Close();
                if (effectedRowsCount > 0)
                {
                    MessageBox.Show("Delet is successful");
                    LoadToDosData();
                }
                else
                {
                    MessageBox.Show("Delete is Unsuccessful");
                }
            }

        }
    }
}
