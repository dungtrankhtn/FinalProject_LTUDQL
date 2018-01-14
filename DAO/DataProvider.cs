using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        static string connectString = "Data Source=QUOCDUNG;Initial Catalog=LibraryManagement;Integrated Security=True";
        static SqlConnection connection = null;

        public static void OpenConnection()
        {
            if(connection == null)
            {
                connection = new SqlConnection(connectString);
            }
            if(connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public static void ExecNonQuery(string sql)
        {
            // Mo ket noi
            OpenConnection();

            // Thuc thi truy van
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();

            // Dong ket noi
            CloseConnection();
        }

        public static DbAck ExecNonQuery(string sql, Dictionary<string, object> dic)
        {
            try
            {
                // Mo ket noi
                OpenConnection();

                // Thuc thi truy van
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;

                foreach (string key in dic.Keys)
                {
                    command.Parameters.AddWithValue(key, dic[key]);
                }
                command.ExecuteNonQuery();


                // Dong ket noi
                CloseConnection();

                return DbAck.Ok;
            }
            catch { }

            return DbAck.Unknown;
        }
        public static DataTable ExecQuery(string sql)
        {
            DataTable result = new DataTable();
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectString);
            adapter.Fill(result);

            return result;
        }


        // Get DATA 
        // Hàm này dùng để get data dưới db lên rồi trả về 1 bảng(bảng này t viết bằng proc cho dễ dùng)
        public static DataTable GetData(string proc)
        {
            try
            {
                OpenConnection();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(proc, connectString);
                adapter.Fill(data);
                CloseConnection();
                return data;
            }
            catch (SqlException)
            {
                CloseConnection();
                return null;
            }
        }

        // Login
        public static string Login(string function)
        {
            // Vẫn chưa làm
            try
            {
                OpenConnection();
                string result = "";
                return result;
            }
            catch (SqlException)
            {
                CloseConnection();
                return null;
            }
        }
    }
}
