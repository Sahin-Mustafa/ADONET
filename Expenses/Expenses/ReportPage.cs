
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

namespace Expenses
{
    public partial class ReportPage : Form
    {
        SQLHelper sqlHelper = new SQLHelper("Server=DESKTOP-TGAGQ1J\\SQLEXPRESS;Database=Expenses;Trusted_Connection=True;");
        DataTable dt =new DataTable();
        public ReportPage()
        {
            InitializeComponent();
            LoadReportNames();
        }

        private void btnRefleshCb_Click(object sender, EventArgs e)
        {
            LoadReportNames();
        }
        private void LoadReportNames()
        {
            string query = "SELECT '[' + name + ']' AS name FROM sys.views ORDER BY name ASC";

            sqlHelper.SetCommand(query);

            DataTable table = sqlHelper.RunQueryForRead();

            cmbReportName.DataSource = null;
            cmbReportName.DataSource = table;
            cmbReportName.DisplayMember = "name";
        }

        private void btnRefleshTable_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            if (cmbReportName.SelectedIndex == -1)
            {
                dgvFiltreExpenses.DataSource = null;
                return;
            }

            string viewName = (cmbReportName.SelectedItem as DataRowView)["name"].ToString();
            if(viewName== "[EXPENDITURE DATA BY EMPLOYEES]")
            {
                string query = $"SELECT Spender_Name,Expense_Date, Expense_Title,Expense_Detail,Amount,Status\r\n  FROM [Expenses].[dbo].[Expenses]  ORDER BY Spender_Name ,Status,Amount";
                sqlHelper.SetCommand(query);
            }
            else if(viewName =="[TOTAL EXPENDITURES OF THE EMPLOYEE BY YEARS]")
            {
                string query = "SELECT YEAR(Expense_Date) AS [Year],Spender_Name AS [Spender Name],sum(Amount) as [Total Expense] FROM [Expenses].[dbo].[Expenses] Where Status = 'Paid' GROUP BY YEAR(Expense_Date),Spender_Name ORDER BY YEAR(Expense_Date) DESC";
                sqlHelper.SetCommand(query);
            }else if(viewName == "[EXPENSES PAID]")
            {
                string query = "SELECT Spender_Name AS [Spender Name],Expense_Title,Amount \r\n  FROM [Expenses].[dbo].[Expenses] Where Status = 'Paid'ORDER BY Spender_Name DESC";
                sqlHelper.SetCommand(query);
            }else if(viewName == "[UNPAID EXPENSES]")
            {
                string query = "SELECT Spender_Name AS [Spender Name],Expense_Title,Amount  \r\n  FROM [Expenses].[dbo].[Expenses] Where Status != 'Paid'ORDER BY Spender_Name DESC";
                sqlHelper.SetCommand(query);
            }
            else
            {
                string query = $"SELECT * FROM {viewName}";
                sqlHelper.SetCommand(query);
            }
           
            dt = sqlHelper.RunQueryForRead();
            
            dgvFiltreExpenses.DataSource = null;
            dgvFiltreExpenses.DataSource = dt;
        }

        private void dgvFiltreExpenses_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnExportExcell_Click(object sender, EventArgs e)
        {
            
            

            //MessageBox.Show("Kaydedildi.");
        }
    }
}
