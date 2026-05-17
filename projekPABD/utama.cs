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

        private void LoadLaporan()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetLaporanBulanan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tahun", tahunBerjalan);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        dtLaporan = new DataTable();
                        da.Fill(dtLaporan);

                        bindingSource.DataSource = dtLaporan;
                        dgvLaporan.DataSource = bindingSource;
                        dgvLaporanFull.DataSource = bindingSource;

                        if (bindingNavigator1 != null) bindingNavigator1.BindingSource = bindingSource;

                        dgvLaporan.ReadOnly = true;
                        dgvLaporanFull.ReadOnly = true;

                        dgvLaporan.AllowUserToAddRows = false;
                        dgvLaporanFull.AllowUserToAddRows = false;

                        if (dgvLaporan.Columns.Contains("id_usaha")) dgvLaporan.Columns["id_usaha"].Visible = false;
                        if (dgvLaporanFull.Columns.Contains("id_usaha")) dgvLaporanFull.Columns["id_usaha"].Visible = false;

                        dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvLaporanFull.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        BindControls();
                        HitungTotalan();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Gagal Load Data: " + ex.Message); }
        }

        private void BindControls()
        {
            txtNamaPemilik.DataBindings.Clear();
            txtPelakuUsaha.DataBindings.Clear();
            txtNoWA.DataBindings.Clear();

            txtNamaPemilik.DataBindings.Add("Text", bindingSource, "nama_pemilik", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPelakuUsaha.DataBindings.Add("Text", bindingSource, "nama_usaha", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoWA.DataBindings.Add("Text", bindingSource, "no_wa", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void HitungTotalan()
        {
            long totalUang = 0;
            int lunasCount = 0;
            foreach (DataRow row in dtLaporan.Rows)
            {
                for (int i = 4; i <= 15; i++)
                {
                    if (row[i] != DBNull.Value && row[i].ToString() == "Lunas")
                        lunasCount++;
                }
            }
            totalUang = lunasCount * (long)nominalIuran;

            if (lblTotalan != null) lblTotalan.Text = "Total Dana Terkumpul: Rp " + totalUang.ToString("N0");
            if (lblInfoDetail != null) lblInfoDetail.Text = "Detail: " + lunasCount + " Transaksi Lunas (@Rp " + nominalIuran.ToString("N0") + ")";
        }

        private bool ValidasiNomorWA(string nomor)
        {
            if (!nomor.StartsWith("08")) return false;
            return long.TryParse(nomor, out _);
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.CurrentRow == null) return;
            string currentID = dgvLaporan.CurrentRow.Cells["id_usaha"].Value.ToString();

            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                int targetBulan = (int)numBulan.Value;
                string statusValue = cbStatus.Text;

                int startBulan = (statusValue == "Lunas") ? 1 : targetBulan;

                for (int i = startBulan; i <= targetBulan; i++)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SavePembayaran", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsaha", currentID);
                        cmd.Parameters.AddWithValue("@Bulan", i);
                        cmd.Parameters.AddWithValue("@Tahun", tahunBerjalan);
                        cmd.Parameters.AddWithValue("@JumlahBayar", nominalIuran);
                        cmd.Parameters.AddWithValue("@StatusBayar", statusValue);

                        cmd.ExecuteNonQuery();
                    }
                }
                LoadLaporan();
                MessageBox.Show("Status Pelunasan Iuran Berhasil Diperbarui!");
            }
            catch (Exception ex) { MessageBox.Show("Transaksi Gagal: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btnSimpan1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaPemilik.Text) || string.IsNullOrWhiteSpace(txtPelakuUsaha.Text))
            {
                MessageBox.Show("Nama Pemilik & Nama Usaha wajib diisi!");
                return;
            }
            if (!ValidasiNomorWA(txtNoWA.Text))
            {
                MessageBox.Show("Nomor WhatsApp harus diawali dengan '08' dan berisi angka saja.");
                return;
            }

            SqlConnection conn = konn.GetConn();
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertPelakuUsaha", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NamaPemilik", txtNamaPemilik.Text);
                    cmd.Parameters.AddWithValue("@NamaUsaha", txtPelakuUsaha.Text);
                    cmd.Parameters.AddWithValue("@NoWa", txtNoWA.Text);
                    cmd.Parameters.AddWithValue("@Tahun", tahunBerjalan);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                bindingSource.CancelEdit();
                ClearInput();
                LoadLaporan();
                if (bindingSource.CurrencyManager != null)
                {
                    bindingSource.CurrencyManager.Refresh();
                }

                MessageBox.Show("Pelaku Usaha Berhasil Ditambahkan!");
            }
            catch (Exception ex) { MessageBox.Show("Gagal Tambah Data: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.CurrentRow == null) return;
            string currentID = dgvLaporan.CurrentRow.Cells["id_usaha"].Value.ToString();

            if (!ValidasiNomorWA(txtNoWA.Text))
            {
                MessageBox.Show("Nomor WhatsApp harus diawali dengan '08' dan berupa angka.");
                return;
            }

            SqlConnection conn = konn.GetConn();
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePelakuUsaha", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsaha", currentID);
                    cmd.Parameters.AddWithValue("@NamaPemilik", txtNamaPemilik.Text);
                    cmd.Parameters.AddWithValue("@NamaUsaha", txtPelakuUsaha.Text);
                    cmd.Parameters.AddWithValue("@NoWa", txtNoWA.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadLaporan();
                MessageBox.Show("Data Berhasil Diubah!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}