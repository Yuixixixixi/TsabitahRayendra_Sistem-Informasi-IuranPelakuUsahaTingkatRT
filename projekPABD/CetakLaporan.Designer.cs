namespace projekPABD
{
    partial class CetakLaporan
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
            this.CetakLaporanLoad = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportIuranRT1 = new projekPABD.ReportIuranRT();
            this.SuspendLayout();
            // 
            // CetakLaporanLoad
            // 
            this.CetakLaporanLoad.ActiveViewIndex = -1;
            this.CetakLaporanLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CetakLaporanLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this.CetakLaporanLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CetakLaporanLoad.Location = new System.Drawing.Point(0, 0);
            this.CetakLaporanLoad.Name = "CetakLaporanLoad";
            this.CetakLaporanLoad.Size = new System.Drawing.Size(800, 450);
            this.CetakLaporanLoad.TabIndex = 0;
            this.CetakLaporanLoad.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // CetakLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CetakLaporanLoad);
            this.Name = "CetakLaporan";
            this.Text = "CetakLaporan";
            this.Load += new System.EventHandler(this.CetakLaporan_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CetakLaporanLoad;
        private ReportIuranRT ReportIuranRT1;
    }
}