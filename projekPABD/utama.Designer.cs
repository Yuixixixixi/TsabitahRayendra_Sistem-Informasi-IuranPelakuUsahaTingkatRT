namespace projekPABD
{
    partial class utama
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDataUsaha = new System.Windows.Forms.TabPage();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.btnSimpan1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.numBulan = new System.Windows.Forms.NumericUpDown();
            this.txtNamaPemilik = new System.Windows.Forms.TextBox();
            this.txtPelakuUsaha = new System.Windows.Forms.TextBox();
            this.txtNoWA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLaporan = new System.Windows.Forms.TabPage();
            this.dgvLaporanFull = new System.Windows.Forms.DataGridView();
            this.lblTotalan = new System.Windows.Forms.Label();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDataUsaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulan)).BeginInit();
            this.tabLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporanFull)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDataUsaha);
            this.tabControl1.Controls.Add(this.tabLaporan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDataUsaha
            // 
            this.tabDataUsaha.BackColor = System.Drawing.Color.GhostWhite;
            this.tabDataUsaha.Controls.Add(this.dgvLaporan);
            this.tabDataUsaha.Controls.Add(this.btnSimpan1);
            this.tabDataUsaha.Controls.Add(this.btnUpdate);
            this.tabDataUsaha.Controls.Add(this.btnDelete);
            this.tabDataUsaha.Controls.Add(this.btnBayar);
            this.tabDataUsaha.Controls.Add(this.cbStatus);
            this.tabDataUsaha.Controls.Add(this.numBulan);
            this.tabDataUsaha.Controls.Add(this.txtNamaPemilik);
            this.tabDataUsaha.Controls.Add(this.txtPelakuUsaha);
            this.tabDataUsaha.Controls.Add(this.txtNoWA);
            this.tabDataUsaha.Controls.Add(this.label1);
            this.tabDataUsaha.Controls.Add(this.label3);
            this.tabDataUsaha.Controls.Add(this.label4);
            this.tabDataUsaha.Location = new System.Drawing.Point(4, 25);
            this.tabDataUsaha.Name = "tabDataUsaha";
            this.tabDataUsaha.Size = new System.Drawing.Size(988, 496);
            this.tabDataUsaha.TabIndex = 0;
            this.tabDataUsaha.Text = "Input Data & Iuran";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaporan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLaporan.ColumnHeadersHeight = 29;
            this.dgvLaporan.EnableHeadersVisualStyles = false;
            this.dgvLaporan.Location = new System.Drawing.Point(20, 200);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.Size = new System.Drawing.Size(940, 280);
            this.dgvLaporan.TabIndex = 0;
            this.dgvLaporan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaporan_CellClick);
            // 
            // btnSimpan1
            // 
            this.btnSimpan1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSimpan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan1.ForeColor = System.Drawing.Color.White;
            this.btnSimpan1.Location = new System.Drawing.Point(100, 150);
            this.btnSimpan1.Name = "btnSimpan1";
            this.btnSimpan1.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan1.TabIndex = 1;
            this.btnSimpan1.Text = "Simpan";
            this.btnSimpan1.UseVisualStyleBackColor = false;
            this.btnSimpan1.Click += new System.EventHandler(this.btnSimpan1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(190, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(280, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBayar.Location = new System.Drawing.Point(700, 110);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(150, 35);
            this.btnBayar.TabIndex = 4;
            this.btnBayar.Text = "Update Status Iuran";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(700, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 24);
            this.cbStatus.TabIndex = 5;
            // 
            // numBulan
            // 
            this.numBulan.Location = new System.Drawing.Point(700, 70);
            this.numBulan.Name = "numBulan";
            this.numBulan.Size = new System.Drawing.Size(150, 22);
            this.numBulan.TabIndex = 6;
            // 
            // txtNamaPemilik
            // 
            this.txtNamaPemilik.Location = new System.Drawing.Point(180, 30);
            this.txtNamaPemilik.Name = "txtNamaPemilik";
            this.txtNamaPemilik.Size = new System.Drawing.Size(200, 22);
            this.txtNamaPemilik.TabIndex = 7;
            // 
            // txtPelakuUsaha
            // 
            this.txtPelakuUsaha.Location = new System.Drawing.Point(180, 70);
            this.txtPelakuUsaha.Name = "txtPelakuUsaha";
            this.txtPelakuUsaha.Size = new System.Drawing.Size(200, 22);
            this.txtPelakuUsaha.TabIndex = 8;
            // 
            // txtNoWA
            // 
            this.txtNoWA.Location = new System.Drawing.Point(180, 110);
            this.txtNoWA.Name = "txtNoWA";
            this.txtNoWA.Size = new System.Drawing.Size(200, 22);
            this.txtNoWA.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Pemilik";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Usaha";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "No WhatsApp";
            // 
            // tabLaporan
            // 
            this.tabLaporan.Controls.Add(this.dgvLaporanFull);
            this.tabLaporan.Controls.Add(this.lblTotalan);
            this.tabLaporan.Controls.Add(this.lblInfoDetail);
            this.tabLaporan.Location = new System.Drawing.Point(4, 25);
            this.tabLaporan.Name = "tabLaporan";
            this.tabLaporan.Size = new System.Drawing.Size(988, 496);
            this.tabLaporan.TabIndex = 1;
            this.tabLaporan.Text = "Laporan Pendapatan";
            // 
            // dgvLaporanFull
            // 
            this.dgvLaporanFull.ColumnHeadersHeight = 29;
            this.dgvLaporanFull.Location = new System.Drawing.Point(20, 20);
            this.dgvLaporanFull.Name = "dgvLaporanFull";
            this.dgvLaporanFull.RowHeadersWidth = 51;
            this.dgvLaporanFull.Size = new System.Drawing.Size(940, 350);
            this.dgvLaporanFull.TabIndex = 0;
            // 
            // lblTotalan
            // 
            this.lblTotalan.AutoSize = true;
            this.lblTotalan.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalan.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalan.Location = new System.Drawing.Point(20, 390);
            this.lblTotalan.Name = "lblTotalan";
            this.lblTotalan.Size = new System.Drawing.Size(0, 32);
            this.lblTotalan.TabIndex = 1;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.Location = new System.Drawing.Point(22, 430);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(0, 16);
            this.lblInfoDetail.TabIndex = 2;
            // 
            // utama
            // 
            this.ClientSize = new System.Drawing.Size(996, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "utama";
            this.Text = "Sistem Iuran Pelaku Usaha";
            this.Load += new System.EventHandler(this.utama_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDataUsaha.ResumeLayout(false);
            this.tabDataUsaha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulan)).EndInit();
            this.tabLaporan.ResumeLayout(false);
            this.tabLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporanFull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDataUsaha;
        private System.Windows.Forms.TabPage tabLaporan;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.DataGridView dgvLaporanFull;
        private System.Windows.Forms.Button btnSimpan1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown numBulan;
        private System.Windows.Forms.TextBox txtNamaPemilik;
        private System.Windows.Forms.TextBox txtPelakuUsaha;
        private System.Windows.Forms.TextBox txtNoWA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalan;
        private System.Windows.Forms.Label lblInfoDetail;
    }
}