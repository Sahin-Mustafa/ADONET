using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses
{
    public class SqlParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public SqlParameter(string name, object value)
        {
            // Null ise hata fırlat hata da parametrenin adını yaz.
            Name = name ?? throw new ArgumentNullException(nameof(name));
            //Value = value ?? throw new ArgumentNullException(nameof(value));

            if (string.IsNullOrEmpty(name)) // ""  boş string ise.
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(name)) // " "  boşluk karakteri string ise.
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (value == null)
            {
                Value = DBNull.Value;
            }
            else
            {
                Value = value;
            }
        }
    }
}
