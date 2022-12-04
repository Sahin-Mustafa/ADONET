using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Todo
    {
        public int ToDoId { get; set; }
        public string ToDoTitle { get; set; }
        public string ToDoDetail { get; set; }
        public DateTime ToDoDueDate { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return $"{this.ToDoTitle}";
        }

    }
}
