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

        private void BuatKomponenLaporanDinamis()
        {
            Label lblTahun = new Label { Text = "Tahun Laporan :", Location = new Point(520, 395), Size = new Size(110, 23), Font = new Font("Arial", 9, FontStyle.Bold) };
            tabLaporan.Controls.Add(lblTahun);

            numTahunLaporan = new NumericUpDown { Location = new Point(635, 393), Size = new Size(70, 22), Minimum = 2020, Maximum = 2099, Value = tahunBerjalan };
            numTahunLaporan.ValueChanged += NumTahunLaporan_ValueChanged;
            tabLaporan.Controls.Add(numTahunLaporan);

            Label lblTarif = new Label { Text = "Tarif Per@ (Rp) :", Location = new Point(520, 430), Size = new Size(110, 23), Font = new Font("Arial", 9, FontStyle.Bold) };
            tabLaporan.Controls.Add(lblTarif);

            numIuranLaporan = new NumericUpDown { Location = new Point(635, 428), Size = new Size(100, 22), Minimum = 0, Maximum = 1000000, Value = nominalIuran, Increment = 5000 };
            numIuranLaporan.ValueChanged += NumIuranLaporan_ValueChanged;
            tabLaporan.Controls.Add(numIuranLaporan);

            btnUpdateTarif = new Button { Text = "Simpan Tarif Tahun Ini", Location = new Point(750, 390), Size = new Size(160, 60), BackColor = Color.LightSkyBlue, FlatStyle = FlatStyle.Flat, Font = new Font("Arial", 9, FontStyle.Bold) };
            btnUpdateTarif.Click += btnUpdateTarif_Click;
            tabLaporan.Controls.Add(btnUpdateTarif);
        }


    }
}