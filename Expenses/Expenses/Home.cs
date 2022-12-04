using System;
using System.Data;
using System.Data.SqlClient;


namespace Expenses
{
    public partial class Home : Form
    {
        SQLHelper sqlHelper = new SQLHelper("Server=DESKTOP-TGAGQ1J\\SQLEXPRESS;Database=Expenses;Trusted_Connection=True;");

        private List<Expense> expensesList = new List<Expense>();
        private List<Expense> employeeExpenses=new List<Expense>();
        private Employee employee;
        private Expense expense;
        private DataGridViewCellEventArgs mouseLocation; //mouse position when right click is done

        public Home(Employee employe)
        {
            InitializeComponent();
            this.employee = employe;
        }
        //Events of page
        private void Home_Load(object sender, EventArgs e)
        {
            //expensesList = FileOperations.GetExpenses();
            lbEmployeeInfo.Text = $"{employee.EmployeeFullName}-{employee.EmployeeType}";

            if (employee.EmployeeType.ToLower() == "manager")
            {
                dgvExpenseList.ContextMenuStrip = contextMenuManager;
                btnReport.Visible = true;
            }

            else if (employee.EmployeeType.ToLower() == "accountant")
            {
                pnlExpenseInfo.Enabled = false;
                pnlAccountant.Visible = true;
                dgvExpenseList.ContextMenuStrip = contextMenuAccountant;
            }

            LoadSqlData();

            //SetDataView(employeeExpenses);
        }

        private void LoadSqlData()
        {
            dgvExpenseList.DataSource = null;
            if (employee.EmployeeType.ToLower() == "worker")
            {
                string query = "SELECT [ExpenseId],[Spender_Id],[Spender_Name],[Expense_Date],[Expense_Title],[Expense_Detail],[Amount] ,[Status] FROM [dbo].[Expenses] WHERE Spender_Id=@spender ";
                sqlHelper.SetCommand(query, new SqlParameter("@spender", employee.EmployeeId));

                DataTable dt = sqlHelper.RunQueryForRead();
                dgvExpenseList.DataSource = dt;


            }
            else if (employee.EmployeeType.ToLower() == "manager")
            {
                string query = "SELECT [ExpenseId],[Spender_Id],[Spender_Name],[Expense_Date],[Expense_Title],[Expense_Detail],[Amount] ,[Status] FROM [dbo].[Expenses] WHERE Status != @status ";
                sqlHelper.SetCommand(query, new SqlParameter("@status", "Paid"));

                DataTable dt = sqlHelper.RunQueryForRead();
                dgvExpenseList.DataSource = dt;
            }
            else
            {
                string query = "SELECT [ExpenseId],[Spender_Id],[Spender_Name],[Expense_Date],[Expense_Title],[Expense_Detail],[Amount] ,[Status] FROM [dbo].[Expenses] ";
                sqlHelper.SetCommand(query);

                DataTable dt = sqlHelper.RunQueryForRead();
                dgvExpenseList.DataSource = dt;
            }
            ClearHomePage();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtExpenseTitle.Text.Trim().Length == 0 || txtExpenseDetail.Text.Trim().Length == 0)
            {
                MessageBox.Show($"Harcama adi ve aciklamasi bos birakilamaz {nudAmount.Value}");
                return;
            }
            if (nudAmount.Value == 0)
            {
                DialogResult result = MessageBox.Show("Tutar kısmını girmediniz.\nHarcamayı kayıt etmek istiyor msusunuz?", "Tutar Boş", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    AddExpense();
                }
                ClearHomePage();
                return;
            }

            AddExpense();
        }

        private void ClearHomePage()
        {
            txtExpenseTitle.Clear();
            txtExpenseDetail.Clear();
            nudAmount.Value = 0;
            dtpExpenseDate.Value = DateTime.Now;
        }

        private void AddExpense()
        {
            string query = $"INSERT INTO [dbo].[Expenses]([Spender_Id],[Spender_Name],[Expense_Date],[Expense_Title],[Expense_Detail],[Amount],[Status])VALUES (@Spender_Id,@Spender_Name,@Expense_Date,@Expense_Title,@Expense_Detail,@Amount,@Status)";
            sqlHelper.SetCommand(query,
                                    new SqlParameter("@Spender_Id", employee.EmployeeId),
                                    new SqlParameter("@Spender_Name", $"{employee.EmployeeFullName}-{employee.EmployeeType}"),
                                    new SqlParameter("@Expense_Date", dtpExpenseDate.Value),
                                    new SqlParameter("@Expense_Title", txtExpenseTitle.Text),
                                    new SqlParameter("@Expense_Detail", txtExpenseDetail.Text),
                                    new SqlParameter("@Amount", nudAmount.Value),
                                    new SqlParameter("@Status", employee.EmployeeType.ToLower() == "manager" ? "Approved" : "Waiting"));

            sqlHelper.RunQuery();
            LoadSqlData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employee.EmployeeType.ToLower() == "worker" && (expense.Status.ToLower() == "rejected" || expense.Status.ToLower() == "waiting"))
            {
                UpdateExpense("Waiting");
            }
            else if (employee.EmployeeType.ToLower() == "worker" && expense.Status.ToLower() == "approved")
            {
                MessageBox.Show("Onaylanan harcamalarda degisiklk yapılamaz");
                btnDelete.Visible = false;
            }
            else if (employee.EmployeeType.ToLower() == "manager" && employee.EmployeeId == expense.Spender_Id)
            {
                UpdateExpense("Approved");
            }
            else if (employee.EmployeeType.ToLower() == "manager" && employee.EmployeeId != expense.Spender_Id)
            {
                MessageBox.Show("Sadece Kendi harcamalarınızı güncelleyebilirsiniz.");
                btnDelete.Visible = false;
            }
        }
        private void UpdateExpense(string newStatus)
        {
            string query = "UPDATE [dbo].[Expenses] SET [Expense_Date] = @Expense_Date, [Expense_Title] = @Expense_Title, [Expense_Detail] =@Expense_Detail, [Amount] = @Amount, [Status] = @Status WHERE ExpenseId = @ExpenseId";
            sqlHelper.SetCommand(query,
                                    new SqlParameter("@Expense_Date", dtpExpenseDate.Value),
                                    new SqlParameter("@Expense_Title", txtExpenseTitle.Text),
                                    new SqlParameter("@Expense_Detail", txtExpenseDetail.Text),
                                    new SqlParameter("@Amount", nudAmount.Value),
                                    new SqlParameter("@Status", newStatus),
                                    new SqlParameter("@ExpenseId", expense.ExpenseId));
            sqlHelper.RunQuery();
            LoadSqlData();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [dbo].[Expenses] WHERE ExpenseId = @expeseId";


            if (employee.EmployeeType.ToLower() == "worker" && expense.Status.ToLower() == "waiting")
            {
                RemoveExpense();
            }
            else if (employee.EmployeeType.ToLower() == "worker" && (expense.Status.ToLower() == "rejected" || expense.Status.ToLower() == "approved"))
            {
                MessageBox.Show("Onaylanan veya Reddedilen harcamalarda degisiklk yapılamaz");
                btnDelete.Visible = false;
            }
            else if (employee.EmployeeType.ToLower() == "manager" && employee.EmployeeId == expense.Spender_Id)
            {
                RemoveExpense();
            }
            else if (employee.EmployeeType.ToLower() == "manager" && employee.EmployeeId != expense.Spender_Id)
            {
                MessageBox.Show("Sadece Kendi harcamalarınızı Silebilirsiniz.");
                btnDelete.Visible = false;
            }
        }
        private void RemoveExpense()
        {
            string query = "DELETE FROM [dbo].[Expenses] WHERE ExpenseId = @ExpenseId";
            sqlHelper.SetCommand(query,new SqlParameter("@ExpenseId", expense.ExpenseId));
            sqlHelper.RunQuery();
            LoadSqlData();   
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense currentExpense = SelectExpense();
            ChangeExpenseStatus(currentExpense,"waiting","Approved");
        }
        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense currentExpense = SelectExpense();
            ChangeExpenseStatus(currentExpense, "waiting", "Rejected");
        }
        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense currentExpense = SelectExpense();
            ChangeExpenseStatus(currentExpense, "approved", "Paid");
        }
        /// <summary>
        /// mouse position when right click is done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="location"></param>
        private void dgvExpenseList_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
        }
        /// <summary>
        /// Returns the selected spend on the 'DataGridView' right clicking.
        /// </summary>
        /// <returns></returns>
        private Expense SelectExpense()
        {
            int rowIndex = dgvExpenseList.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].RowIndex;
            dgvExpenseList.CurrentCell.Selected = true;
            Expense currentExpense = new Expense
            {
                ExpenseId = (Guid)dgvExpenseList.Rows[rowIndex].Cells["ExpenseId"].Value,
                Status = dgvExpenseList.Rows[rowIndex].Cells["Status"].Value.ToString()
            };
            return currentExpense;
        }
        
        /// <summary>
        /// Changing the expenditure by pressing the right button.
        /// </summary>
        /// <param name="currentExpense"></param>
        /// <param name="process"></param>
        /// <param name="result"></param>
        private void ChangeExpenseStatus(Expense currentExpense, string process, string result)
        {
            if (currentExpense.Status.ToLower() == process.ToLower())
            {
                string query = "UPDATE [dbo].[Expenses] SET [Status] = @Status WHERE ExpenseId = @ExpenseId";
                sqlHelper.SetCommand(query,new SqlParameter("@Status", result),
                                        new SqlParameter("@ExpenseId", currentExpense.ExpenseId));
                sqlHelper.RunQuery();
                LoadSqlData();
            }
            else
            {
                string message = process == "approved" ? "onaylı" : "bekleyen";
                MessageBox.Show($"Sadece {message} harcamalar işlem yapılabilir");
            }

        }

        /// <summary>
        /// Retrieving data from datagridview with double click and displaying it to 'textboxes'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExpenseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;
            //dgvExpenseList.CurrentCell = dgvExpenseList.Rows[index].Cells[0];
            dgvExpenseList.CurrentCell.Selected = true;
            Expense currentExpense = new Expense
            {
                ExpenseId =(Guid)dgvExpenseList.Rows[e.RowIndex].Cells["ExpenseId"].Value,
                Status = dgvExpenseList.Rows[e.RowIndex].Cells["Status"].Value.ToString()
            };
            expense = currentExpense;

            txtExpenseTitle.Text = dgvExpenseList.Rows[e.RowIndex].Cells["Expense_Title"].Value.ToString();
            dtpExpenseDate.Value = (DateTime) dgvExpenseList.Rows[e.RowIndex].Cells["Expense_Date"].Value;
            nudAmount.Value = (decimal) dgvExpenseList.Rows[e.RowIndex].Cells["Amount"].Value;
            txtExpenseDetail.Text = dgvExpenseList.Rows[e.RowIndex].Cells["Expense_Detail"].Value.ToString();

            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }
        
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            ReportPage reportPage = new ReportPage();
            reportPage.ShowDialog();
        }
    }
}
