using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // WAJIB ADA UNTUK SQL SERVER

namespace projekPABD
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            // Sesuaikan Data Source dengan nama Server SQL kamu
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_IuranRT;Integrated Security=True";
            return conn;
        }
    }
}