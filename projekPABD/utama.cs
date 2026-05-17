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
        private BindingSource bindingSource = new BindingSource();
        private DataTable dtLaporan = new DataTable();

        private int tahunBerjalan = 2026;
        private decimal nominalIuran = 30000;

        private NumericUpDown numTahunLaporan;
        private NumericUpDown numIuranLaporan;
        private Button btnUpdateTarif;

        public utama()
        {
            InitializeComponent();
            dgvLaporan.CellFormatting += dgv_CellFormatting;
            dgvLaporanFull.CellFormatting += dgv_CellFormatting;
            BuatKomponenLaporanDinamis();
        }


    }
}