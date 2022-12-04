using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Expenses
{

    public static class FileOperations
    {
        public static List<Employee> GetEmloyees()
        {

            //string filePath = Application.StartupPath + "employees.json";
           // string filePath = Application.StartupPath + "expenses.txt";

            string filePath = Application.StartupPath + "employees.json";

            var file = new List<Employee>();
            //if (!File.Exists(filePath))
            //{
            //    File.Create(filePath).Close();
            //    return file;
            //}
            //else
            //{

            //    string sql = File.ReadAllText(filePath);
            //    if (string.Empty != sql)
            //    {
            //        file = JsonSerializer.Deserialize<List<Employee>>(sql);

            //    string json = File.ReadAllText(filePath);
            //    if (string.Empty != json)
            //    {
            //        file = JsonSerializer.Deserialize<List<Employee>>(json);

            //    }
            //}
            return file;
        }
        public static void SaveEmployeeFile(List<Employee> file)
        {
            string filePath = Application.StartupPath + "employees.json";
            string json = JsonSerializer.Serialize(file);
            File.WriteAllText(filePath, json);
        }
        public static List<Expense> GetExpenses()
        {
            string filePath = Application.StartupPath + "expenses.json";
            var file = new List<Expense>();
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                return file;
            }
            else
            {
                string json = File.ReadAllText(filePath);
                if (string.Empty != json)
                {
                    return JsonSerializer.Deserialize<List<Expense>>(json);                   
                }
            }
            return file;
        }
        public static void SaveExpensesFile(List<Expense> file)
        {
            string filePath = Application.StartupPath + "expenses.json";
            string json = JsonSerializer.Serialize(file);
            File.WriteAllText(filePath, json);
        }
    }
}
