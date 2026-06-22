using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projekPABD
{
    public class DataAccessLogic
    {
        private static string connectionString = @"Server=DESKTOP-031PEAQ\SQLEXPRESS;Database=DB_iuranRT;Trusted_Connection=True;";

        public SqlConnection GetConn()
        {
            return new SqlConnection(connectionString);
        }

       
    }
}