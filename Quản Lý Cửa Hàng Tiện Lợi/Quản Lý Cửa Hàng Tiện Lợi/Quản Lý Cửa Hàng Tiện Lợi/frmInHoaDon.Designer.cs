namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    partial class frmInHoaDon
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
            this.rvHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvHoaDon
            // 
            this.rvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rvHoaDon.Name = "rvHoaDon";
            this.rvHoaDon.Size = new System.Drawing.Size(739, 358);
            this.rvHoaDon.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 358);
            this.Controls.Add(this.rvHoaDon);
            this.Name = "frmInHoaDon";
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvHoaDon;

    }
}