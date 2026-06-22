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

        public DataTable GetAllPelakuUsaha()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConn())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.pelaku_usaha", conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal mengambil data: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        
    }
}