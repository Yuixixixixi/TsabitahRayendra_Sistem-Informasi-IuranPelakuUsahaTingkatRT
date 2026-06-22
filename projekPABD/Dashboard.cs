using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace projekPABD
{
    public partial class Dashboard : Form
    {
        DataAccessLogic dbLogic = new DataAccessLogic();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            numTahun.Value = DateTime.Now.Year;
            LoadDataChart();
        }

        public void numTahun_ValueChanged(object sender, EventArgs e)
        {
            LoadDataChart(); // Memicu grafik buat refresh setiap tahunnya diganti
        }

        public void LoadDataChart()
        {
            try
            {
                int tahunAktif = Convert.ToInt32(numTahun.Value);

                // --- 1. MEMUAT GRAFIK BATANG (Jumlah Usaha global) ---
                DataTable dtBar = dbLogic.GetChartByTahun();
                chartUsaha.Series.Clear();
                chartUsaha.ChartAreas.Clear();
                chartUsaha.Titles.Clear();

                ChartArea caBar = new ChartArea("MainArea");
                chartUsaha.ChartAreas.Add(caBar);
                Series sBar = new Series("Pelaku Usaha") { ChartType = SeriesChartType.Column };

                foreach (DataRow row in dtBar.Rows)
                {
                    sBar.Points.AddXY(row["tahun"].ToString(), Convert.ToInt32(row["JumlahUsaha"]));
                }
                chartUsaha.Series.Add(sBar);
                chartUsaha.Titles.Add("Grafik Pertumbuhan Pelaku Usaha RT");


                // --- 2. MEMUAT GRAFIK LINGKARAN / PIE CHART (Dinamis per Tahun) ---
                DataTable dtPie = dbLogic.GetStatusIuranPie(tahunAktif);
                chartStatus.Series.Clear();
                chartStatus.ChartAreas.Clear();
                chartStatus.Titles.Clear();

                ChartArea caPie = new ChartArea("PieArea");
                chartStatus.ChartAreas.Add(caPie);
                Series sPie = new Series("StatusIuran") { ChartType = SeriesChartType.Pie };

                foreach (DataRow row in dtPie.Rows)
                {
                    sPie.Points.AddXY(row["status_bayar"].ToString(), Convert.ToInt32(row["Total"]));
                }

                sPie["PieLabelStyle"] = "Outside";
                chartStatus.Series.Add(sPie);
                chartStatus.Titles.Add("Persentase Pelunasan Iuran Tahun " + tahunAktif);

                // Update Label ringkasan warga di bagian bawah
                if (lblTotalUsaha != null)
                {
                    int totalWarga = dbLogic.GetTotalPelakuUsaha();
                    lblTotalUsaha.Text = "Total Pelaku Usaha Terdaftar: " + totalWarga + " Warga";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat grafik: " + ex.Message, "Error Chart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKelola_Click(object sender, EventArgs e)
        {
            utama frmUtama = new utama();
            frmUtama.Show();
            this.Hide();
        }

        private void btnKelola_Click_1(object sender, EventArgs e)
        {
            utama frmUtama = new utama();
            frmUtama.Show();
            this.Hide();
        }

        
    }
}