using projekPABD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekPABD
{
    public partial class Form1 : Form
    {

        Koneksi koneksi = new Koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Siapkan koneksi
            SqlConnection conn = koneksi.GetConn();

            try
            {
                conn.Open();

                // 2. Query untuk cek username dan passwordAdmin
                string query = "SELECT COUNT(*) FROM admin WHERE username=@user AND passwordAdmin=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);

                // 3. Ambil input dari TextBox (pastikan name-nya sudah txtUsername & txtPassword)
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Jika berhasil, pindah ke form utama
                    MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    utama formUtama = new utama(); // Nama sesuai file 'utama.cs' kamu
                    formUtama.Show();
                    this.Hide(); // Sembunyikan form login
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If designer wires btnLogin, reuse the same logic
            button1_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
