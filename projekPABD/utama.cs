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