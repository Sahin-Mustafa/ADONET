using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses
{
    public class SQLHelper
    {
        private string _ConnectionString;
        public SqlConnection Connection { get; private set; }
        public SqlCommand Command { get; set; }
        public SQLHelper(string connectionString)
        {
            _ConnectionString = connectionString;

            Connection = new SqlConnection(connectionString);
            Command = Connection.CreateCommand();
        }
        public void SetCommand(string query, List<SqlParameter> parameters)
        {
            SetCommand(query, parameters.ToArray());
        }
        public void SetCommand(string query, params SqlParameter[] parameters)
        {
            Command.CommandText = query;
            Command.Parameters.Clear();

            foreach (SqlParameter param in parameters)
            {
                Command.Parameters.AddWithValue(param.Name, param.Value);
            }
        }
        public int RunQuery() 
        {
            int result = 0;

            try
            {
                Connection.Open();
                result = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed &&
                    Connection.State != System.Data.ConnectionState.Broken)
                {
                    Connection.Close();
                }
            }
            return result;
        }
        public object RunQueryScalar()
        {
            object result = null;
            try
            {
                Connection.Open();
                result = Command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed &&
                    Connection.State != System.Data.ConnectionState.Broken)
                {
                    Connection.Close();
                }
            }
            return result;
        }
        public T RunQueryScalar<T>()
        {
            T result;
            try
            {
                Connection.Open();
                result = (T)Command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed &&
                    Connection.State != System.Data.ConnectionState.Broken)
                {
                    Connection.Close();
                }
            }

            return result;
        }
        public DataTable RunQueryForRead()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public bool ConnecionTest()
        {
            bool result = false;
            try
            {
                Connection.Open();
                Connection.Close();

                result = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Connection.State != System.Data.ConnectionState.Closed &&
                    Connection.State != System.Data.ConnectionState.Broken)
                {
                    Connection.Close();
                }
            }
            return result;
        }
    }
}
