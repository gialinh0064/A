namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    partial class Quan_Ly_Cua_Hang_Tien_Loi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btHangHoa = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btNhapXuatHang = new System.Windows.Forms.Button();
            this.btDoanhThu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(196, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG TIỆN LỢI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNhanVien
            // 
            this.btNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhanVien.ForeColor = System.Drawing.Color.Purple;
            this.btNhanVien.Location = new System.Drawing.Point(41, 96);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(303, 48);
            this.btNhanVien.TabIndex = 1;
            this.btNhanVien.Text = "Thông tin Nhân Viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btHangHoa
            // 
            this.btHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHangHoa.ForeColor = System.Drawing.Color.Purple;
            this.btHangHoa.Location = new System.Drawing.Point(372, 164);
            this.btHangHoa.Name = "btHangHoa";
            this.btHangHoa.Size = new System.Drawing.Size(303, 48);
            this.btHangHoa.TabIndex = 1;
            this.btHangHoa.Text = "Thông tin Hàng Hóa";
            this.btHangHoa.UseVisualStyleBackColor = true;
            // 
            // btHoaDon
            // 
            this.btHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoaDon.ForeColor = System.Drawing.Color.Purple;
            this.btHoaDon.Location = new System.Drawing.Point(41, 164);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(303, 48);
            this.btHoaDon.TabIndex = 1;
            this.btHoaDon.Text = "Thông tin Hóa Đơn";
            this.btHoaDon.UseVisualStyleBackColor = true;
            // 
            // btNhapXuatHang
            // 
            this.btNhapXuatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhapXuatHang.ForeColor = System.Drawing.Color.Purple;
            this.btNhapXuatHang.Location = new System.Drawing.Point(372, 96);
            this.btNhapXuatHang.Name = "btNhapXuatHang";
            this.btNhapXuatHang.Size = new System.Drawing.Size(303, 48);
            this.btNhapXuatHang.TabIndex = 1;
            this.btNhapXuatHang.Text = "Nhập Xuất Kiểm Kê Hàng";
            this.btNhapXuatHang.UseVisualStyleBackColor = true;
            this.btNhapXuatHang.Click += new System.EventHandler(this.btNhapXuatHang_Click);
            // 
            // btDoanhThu
            // 
            this.btDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDoanhThu.ForeColor = System.Drawing.Color.Purple;
            this.btDoanhThu.Location = new System.Drawing.Point(372, 235);
            this.btDoanhThu.Name = "btDoanhThu";
            this.btDoanhThu.Size = new System.Drawing.Size(303, 48);
            this.btDoanhThu.TabIndex = 1;
            this.btDoanhThu.Text = "Thông tin Doanh Thu";
            this.btDoanhThu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btNhapXuatHang);
            this.groupBox1.Controls.Add(this.btHangHoa);
            this.groupBox1.Controls.Add(this.btNhanVien);
            this.groupBox1.Controls.Add(this.btDoanhThu);
            this.groupBox1.Controls.Add(this.btHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Quan_Ly_Cua_Hang_Tien_Loi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 447);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Quan_Ly_Cua_Hang_Tien_Loi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Tiện Lợi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quan_Ly_Cua_Hang_Tien_Loi_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btHangHoa;
        private System.Windows.Forms.Button btHoaDon;
        private System.Windows.Forms.Button btNhapXuatHang;
        private System.Windows.Forms.Button btDoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}