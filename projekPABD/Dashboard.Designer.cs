namespace projekPABD
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUsaha = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKelola = new System.Windows.Forms.Button();
            this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numTahun = new System.Windows.Forms.NumericUpDown();
            this.lblTotalUsaha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTahun)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUsaha
            // 
            chartArea7.Name = "ChartArea1";
            this.chartUsaha.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartUsaha.Legends.Add(legend7);
            this.chartUsaha.Location = new System.Drawing.Point(82, 102);
            this.chartUsaha.Name = "chartUsaha";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartUsaha.Series.Add(series7);
            this.chartUsaha.Size = new System.Drawing.Size(588, 406);
            this.chartUsaha.TabIndex = 0;
            this.chartUsaha.Text = "chart1";
            this.chartUsaha.Click += new System.EventHandler(this.chartUsaha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "PENDATAAN IURAN RT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKelola
            // 
            this.btnKelola.Location = new System.Drawing.Point(1337, 526);
            this.btnKelola.Name = "btnKelola";
            this.btnKelola.Size = new System.Drawing.Size(94, 32);
            this.btnKelola.TabIndex = 2;
            this.btnKelola.Text = "Kelola Data";
            this.btnKelola.UseVisualStyleBackColor = true;
            this.btnKelola.Click += new System.EventHandler(this.btnKelola_Click_1);
            // 
            // chartStatus
            // 
            chartArea8.Name = "ChartArea1";
            this.chartStatus.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartStatus.Legends.Add(legend8);
            this.chartStatus.Location = new System.Drawing.Point(676, 102);
            this.chartStatus.Name = "chartStatus";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartStatus.Series.Add(series8);
            this.chartStatus.Size = new System.Drawing.Size(755, 406);
            this.chartStatus.TabIndex = 4;
            this.chartStatus.Text = "chart1";
            this.chartStatus.Click += new System.EventHandler(this.chart1_Click);
            // 
            // numTahun
            // 
            this.numTahun.Location = new System.Drawing.Point(1268, 74);
            this.numTahun.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numTahun.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numTahun.Name = "numTahun";
            this.numTahun.ReadOnly = true;
            this.numTahun.Size = new System.Drawing.Size(163, 22);
            this.numTahun.TabIndex = 5;
            this.numTahun.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numTahun.ValueChanged += new System.EventHandler(this.numTahun_ValueChanged);
            // 
            // lblTotalUsaha
            // 
            this.lblTotalUsaha.AutoSize = true;
            this.lblTotalUsaha.Location = new System.Drawing.Point(89, 473);
            this.lblTotalUsaha.Name = "lblTotalUsaha";
            this.lblTotalUsaha.Size = new System.Drawing.Size(44, 16);
            this.lblTotalUsaha.TabIndex = 3;
            this.lblTotalUsaha.Text = "label2";
            this.lblTotalUsaha.Click += new System.EventHandler(this.lblTotalUsaha_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 645);
            this.Controls.Add(this.numTahun);
            this.Controls.Add(this.chartStatus);
            this.Controls.Add(this.btnKelola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartUsaha);
            this.Controls.Add(this.lblTotalUsaha);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTahun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsaha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKelola;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private System.Windows.Forms.NumericUpDown numTahun;
        private System.Windows.Forms.Label lblTotalUsaha;
    }
}