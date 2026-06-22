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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utama));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDataUsaha = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnTestInjection = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnSimpanKeDB = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabLogAktivitas = new System.Windows.Forms.TabPage();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDataUsaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulan)).BeginInit();
            this.tabLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporanFull)).BeginInit();
            this.tabLogAktivitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDataUsaha);
            this.tabControl1.Controls.Add(this.tabLaporan);
            this.tabControl1.Controls.Add(this.tabLogAktivitas);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 560);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDataUsaha
            // 
            this.tabDataUsaha.BackColor = System.Drawing.Color.GhostWhite;
            this.tabDataUsaha.Controls.Add(this.btnKembali);
            this.tabDataUsaha.Controls.Add(this.txtSearch);
            this.tabDataUsaha.Controls.Add(this.btnSearch);
            this.tabDataUsaha.Controls.Add(this.btnClear);
            this.tabDataUsaha.Controls.Add(this.btnResetData);
            this.tabDataUsaha.Controls.Add(this.btnTestInjection);
            this.tabDataUsaha.Controls.Add(this.bindingNavigator1);
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
            this.tabDataUsaha.Size = new System.Drawing.Size(1156, 531);
            this.tabDataUsaha.TabIndex = 0;
            this.tabDataUsaha.Text = "Input Data & Iuran";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 199);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(110, 22);
            this.txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(145, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 22);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(361, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 22);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(812, 67);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(73, 106);
            this.btnResetData.TabIndex = 15;
            this.btnResetData.Text = "bekap";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnTestInjection
            // 
            this.btnTestInjection.Location = new System.Drawing.Point(810, 32);
            this.btnTestInjection.Name = "btnTestInjection";
            this.btnTestInjection.Size = new System.Drawing.Size(75, 23);
            this.btnTestInjection.TabIndex = 14;
            this.btnTestInjection.Text = "tes";
            this.btnTestInjection.UseVisualStyleBackColor = true;
            this.btnTestInjection.Click += new System.EventHandler(this.btnTestInjection_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1156, 27);
            this.bindingNavigator1.TabIndex = 13;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            this.dgvLaporan.Location = new System.Drawing.Point(20, 227);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.Size = new System.Drawing.Size(940, 253);
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
            this.btnBayar.Location = new System.Drawing.Point(472, 110);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(150, 35);
            this.btnBayar.TabIndex = 4;
            this.btnBayar.Text = "Update Status Iuran";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Location = new System.Drawing.Point(472, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 24);
            this.cbStatus.TabIndex = 5;
            // 
            // numBulan
            // 
            this.numBulan.Location = new System.Drawing.Point(472, 71);
            this.numBulan.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numBulan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBulan.Name = "numBulan";
            this.numBulan.ReadOnly = true;
            this.numBulan.Size = new System.Drawing.Size(150, 22);
            this.numBulan.TabIndex = 6;
            this.numBulan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tabLaporan.Controls.Add(this.btnCetak);
            this.tabLaporan.Controls.Add(this.btnSimpanKeDB);
            this.tabLaporan.Controls.Add(this.btnImportExcel);
            this.tabLaporan.Controls.Add(this.dgvLaporanFull);
            this.tabLaporan.Controls.Add(this.lblTotalan);
            this.tabLaporan.Controls.Add(this.lblInfoDetail);
            this.tabLaporan.Location = new System.Drawing.Point(4, 25);
            this.tabLaporan.Name = "tabLaporan";
            this.tabLaporan.Size = new System.Drawing.Size(1156, 531);
            this.tabLaporan.TabIndex = 1;
            this.tabLaporan.Text = "Laporan Pendapatan";
            this.tabLaporan.Click += new System.EventHandler(this.tabLaporan_Click);
            // 
            // dgvLaporanFull
            // 
            this.dgvLaporanFull.ColumnHeadersHeight = 29;
            this.dgvLaporanFull.Location = new System.Drawing.Point(20, 20);
            this.dgvLaporanFull.Name = "dgvLaporanFull";
            this.dgvLaporanFull.RowHeadersWidth = 51;
            this.dgvLaporanFull.Size = new System.Drawing.Size(979, 319);
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
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(945, 384);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(118, 28);
            this.btnImportExcel.TabIndex = 3;
            this.btnImportExcel.Text = "Impor Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnSimpanKeDB
            // 
            this.btnSimpanKeDB.Location = new System.Drawing.Point(945, 419);
            this.btnSimpanKeDB.Name = "btnSimpanKeDB";
            this.btnSimpanKeDB.Size = new System.Drawing.Size(118, 27);
            this.btnSimpanKeDB.TabIndex = 4;
            this.btnSimpanKeDB.Text = "Simpan ke DB";
            this.btnSimpanKeDB.UseVisualStyleBackColor = true;
            this.btnSimpanKeDB.Click += new System.EventHandler(this.btnSimpanKeDB_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(20, 151);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(65, 25);
            this.btnKembali.TabIndex = 19;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(949, 456);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(114, 29);
            this.btnCetak.TabIndex = 5;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tabLogAktivitas
            // 
            this.tabLogAktivitas.Controls.Add(this.dgvLog);
            this.tabLogAktivitas.Location = new System.Drawing.Point(4, 25);
            this.tabLogAktivitas.Name = "tabLogAktivitas";
            this.tabLogAktivitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogAktivitas.Size = new System.Drawing.Size(1156, 531);
            this.tabLogAktivitas.TabIndex = 2;
            this.tabLogAktivitas.Text = "Log Aktivitas";
            this.tabLogAktivitas.UseVisualStyleBackColor = true;
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(3, 3);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.RowTemplate.Height = 24;
            this.dgvLog.Size = new System.Drawing.Size(1150, 525);
            this.dgvLog.TabIndex = 0;
            // 
            // utama
            // 
            this.ClientSize = new System.Drawing.Size(1164, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "utama";
            this.Text = "Sistem Iuran Pelaku Usaha";
            this.Load += new System.EventHandler(this.utama_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDataUsaha.ResumeLayout(false);
            this.tabDataUsaha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBulan)).EndInit();
            this.tabLaporan.ResumeLayout(false);
            this.tabLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporanFull)).EndInit();
            this.tabLogAktivitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnTestInjection;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnSimpanKeDB;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.TabPage tabLogAktivitas;
        private System.Windows.Forms.DataGridView dgvLog;
    }
}