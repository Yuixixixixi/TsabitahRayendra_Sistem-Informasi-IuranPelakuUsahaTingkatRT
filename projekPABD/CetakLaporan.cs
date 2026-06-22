using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace projekPABD
{
    public partial class CetakLaporan : Form
    {
        private int _tahun;

        public CetakLaporan(int tahun)
        {
            InitializeComponent();
            _tahun = tahun;
        }

        // Ini fungsi lama yang sudah tidak terikat ke form, dikosongkan saja tidak apa-apa
        private void CetakLaporan_Load(object sender, EventArgs e)
        {
        }

        // KUNCI PERBAIKAN: Seluruh kode pelacak dan cetak dimasukkan ke fungsi AKTIF ini
        private void CetakLaporan_Load_1(object sender, EventArgs e)
        {
            try
            {
                DataAccessLogic db = new DataAccessLogic();
                DataTable dt = new DataTable();

                using (SqlConnection conn = db.GetConn())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetLaporanBulanan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Tahun", _tahun);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }

                // Munculkan kotak pesan untuk melacak jumlah data dari database
                MessageBox.Show("Sistem mendeteksi ada " + dt.Rows.Count + " baris data untuk tahun " + _tahun,
                                "Log Debug Laporan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sinkronisasi nama datatable dengan Crystal Reports
                dt.TableName = "sp_GetLaporanBulanan";

                ReportIuranRT cryRpt = new ReportIuranRT();
                cryRpt.SetDataSource(dt);

                // Mengisi komponen viewer bawaan form kamu
                CetakLaporanLoad.ReportSource = cryRpt;
                CetakLaporanLoad.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat cetakan laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}