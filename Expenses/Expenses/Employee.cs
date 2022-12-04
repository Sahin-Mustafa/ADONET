using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeType { get; set; }
        public virtual bool EnterExpence { get; set; } = true;
        public virtual bool Approves { get; set; } = false;
        public virtual bool CanPay { get; set; } = false;
    }
    public class Worker : Employee
    {
    }
    public class Manager : Employee
    {
        public override bool Approves { get; set; } = true;
    }
    public class Accountant : Employee
    {
        public override bool EnterExpence { get; set; } = false;
        public override bool CanPay { get; set; } = true;

    }
}

