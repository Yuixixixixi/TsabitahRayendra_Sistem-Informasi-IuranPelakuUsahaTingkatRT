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

        public DataTable GetChartByTahun()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConn())
            {
                string query = "SELECT tahun, COUNT(id_usaha) as JumlahUsaha FROM dbo.pelaku_usaha GROUP BY tahun";
                using (SqlCommand cmd = new SqlCommand(query, conn))
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
                        MessageBox.Show("Gagal load data chart: " + ex.Message);
                    }
                }
            }
            return dt;
        }
        public DataTable GetStatusIuranPie(int tahun)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConn())
            {
                string query = "SELECT status_bayar, COUNT(*) as Total FROM dbo.pembayaran WHERE tahun = @Tahun GROUP BY status_bayar";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tahun", tahun);
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd)) { da.Fill(dt); }
                    }
                    catch { }
                }
            }
            return dt;
        }

       
    }
}