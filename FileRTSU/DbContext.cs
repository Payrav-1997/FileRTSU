using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRTSU
{
    class DbContext
    {
        public string ConnectionString = @"Data Source=YULDASHEVPAYRAV\SQLEXPRESS;Initial Catalog=FileDB;Integrated Security=True";
        public SqlConnection Connection { get; set; } 
        
        public DbContext()
        {
            Connection = new SqlConnection(ConnectionString);
        }
        
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
        }
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }
        public SqlConnection GetSqlConnection()
        {
            return Connection;
        }
    }
}
