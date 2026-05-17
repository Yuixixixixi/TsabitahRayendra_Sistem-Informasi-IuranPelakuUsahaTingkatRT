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

        private void utama_Load(object sender, EventArgs e)
        {
            if (cbStatus.Items.Count == 0) { cbStatus.Items.Add("Lunas"); cbStatus.Items.Add("Belum Lunas"); }
            cbStatus.SelectedIndex = 0;

            numBulan.Minimum = 1;
            numBulan.Maximum = 12;

            // Load tarif default dari database berdasarkan tahun aktif awal
            nominalIuran = AmbilTarifDariDB(tahunBerjalan);
            if (numIuranLaporan != null) numIuranLaporan.Value = nominalIuran;

            LoadLaporan();
        }

        private decimal AmbilTarifDariDB(int tahun)
        {
            decimal tarif = 30000; // Default cadangan jika data kosong
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string query = "SELECT tarif FROM tarif_iuran WHERE tahun = @Tahun";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tahun", tahun);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        tarif = Convert.ToDecimal(result);
                    }
                }
            }
            catch { }
            finally { conn.Close(); }
            return tarif;
        }

        private void NumTahunLaporan_ValueChanged(object sender, EventArgs e)
        {
            tahunBerjalan = (int)numTahunLaporan.Value;

            // Ambil data tarif yang terkunci di database per tahun
            nominalIuran = AmbilTarifDariDB(tahunBerjalan);
            numIuranLaporan.Value = nominalIuran;

            LoadLaporan();
        }

        private void NumIuranLaporan_ValueChanged(object sender, EventArgs e)
        {
            nominalIuran = numIuranLaporan.Value;
        }

        private void btnUpdateTarif_Click(object sender, EventArgs e)
        {
            nominalIuran = numIuranLaporan.Value;
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string query = @"
                    IF EXISTS (SELECT 1 FROM tarif_iuran WHERE tahun = @Tahun)
                        UPDATE tarif_iuran SET tarif = @Tarif WHERE tahun = @Tahun;
                    ELSE
                        INSERT INTO tarif_iuran (tahun, tarif) VALUES (@Tahun, @Tarif);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tahun", tahunBerjalan);
                    cmd.Parameters.AddWithValue("@Tarif", nominalIuran);
                    cmd.ExecuteNonQuery();
                }

                HitungTotalan();
                MessageBox.Show("Tarif iuran tahun " + tahunBerjalan + " berhasil dikunci ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Gagal mengunci tarif: " + ex.Message); }
            finally { conn.Close(); }
        }

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

    }
}