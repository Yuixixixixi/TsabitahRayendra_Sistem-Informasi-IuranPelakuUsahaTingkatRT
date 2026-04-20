using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace projekPABD
{
    public partial class utama : Form
    {
        Koneksi konn = new Koneksi();
        string selectedID = "";

        public utama()
        {
            InitializeComponent();
            // Menambahkan event untuk mewarnai cell Lunas/Belum Lunas
            dgvLaporan.CellFormatting += dgv_CellFormatting;
            dgvLaporanFull.CellFormatting += dgv_CellFormatting;
        }
        // Fungsi mewarnai tabel
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Value.ToString() == "Lunas")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (e.Value.ToString() == "Belum Lunas")
                {
                    e.CellStyle.BackColor = Color.MistyRose;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void LoadLaporan()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string sql = @"SELECT id_usaha, nama_pemilik, nama_usaha, no_wa,
                               ISNULL([1], 'Belum Lunas') AS Jan, ISNULL([2], 'Belum Lunas') AS Feb,
                               ISNULL([3], 'Belum Lunas') AS Mar, ISNULL([4], 'Belum Lunas') AS Apr,
                               ISNULL([5], 'Belum Lunas') AS Mei, ISNULL([6], 'Belum Lunas') AS Jun,
                               ISNULL([7], 'Belum Lunas') AS Jul, ISNULL([8], 'Belum Lunas') AS Ags,
                               ISNULL([9], 'Belum Lunas') AS Sep, ISNULL([10], 'Belum Lunas') AS Okt,
                               ISNULL([11], 'Belum Lunas') AS Nov, ISNULL([12], 'Belum Lunas') AS Des
                               FROM (
                                   SELECT p.id_usaha, p.nama_pemilik, p.nama_usaha, p.no_wa, b.bulan, b.status_bayar
                                   FROM pelaku_usaha p
                                   LEFT JOIN pembayaran b ON p.id_usaha = b.id_usaha AND b.tahun = 2026
                               ) AS SourceTable
                               PIVOT (
                                   MAX(status_bayar)
                                   FOR bulan IN ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
                               ) AS PivotTable";

