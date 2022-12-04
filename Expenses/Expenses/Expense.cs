using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses
{
    public class Expense
    {
        public Guid ExpenseId { get; set; }
        public Guid Spender_Id { get; set; }
        public string Spender_Name { get; set; }
        public DateTime Expense_Date { get; set; }
        public string Expense_Title { get; set; }
        public string Expense_Detail { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    }
}
