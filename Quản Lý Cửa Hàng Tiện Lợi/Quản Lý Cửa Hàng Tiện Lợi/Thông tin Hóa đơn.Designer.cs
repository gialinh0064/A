namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    partial class Thông_tin_Hóa_đơn
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdNgayLapHD = new System.Windows.Forms.RadioButton();
            this.rdMaNV = new System.Windows.Forms.RadioButton();
            this.rdMaHD = new System.Windows.Forms.RadioButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(209, 80);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(290, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập Hóa đơn:";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(565, 12);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(96, 38);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Location = new System.Drawing.Point(565, 62);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(96, 38);
            this.btIn.TabIndex = 2;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(565, 120);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 38);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdNgayLapHD);
            this.groupBox1.Controls.Add(this.rdMaNV);
            this.groupBox1.Controls.Add(this.rdMaHD);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdNgayLapHD
            // 
            this.rdNgayLapHD.AutoSize = true;
            this.rdNgayLapHD.Location = new System.Drawing.Point(417, 109);
            this.rdNgayLapHD.Name = "rdNgayLapHD";
            this.rdNgayLapHD.Size = new System.Drawing.Size(204, 28);
            this.rdNgayLapHD.TabIndex = 2;
            this.rdNgayLapHD.TabStop = true;
            this.rdNgayLapHD.Text = "Ngày Lập Hóa Đơn";
            this.rdNgayLapHD.UseVisualStyleBackColor = true;
            // 
            // rdMaNV
            // 
            this.rdMaNV.AutoSize = true;
            this.rdMaNV.Location = new System.Drawing.Point(238, 109);
            this.rdMaNV.Name = "rdMaNV";
            this.rdMaNV.Size = new System.Drawing.Size(161, 28);
            this.rdMaNV.TabIndex = 2;
            this.rdMaNV.TabStop = true;
            this.rdMaNV.Text = "Mã Nhân Viên";
            this.rdMaNV.UseVisualStyleBackColor = true;
            // 
            // rdMaHD
            // 
            this.rdMaHD.AutoSize = true;
            this.rdMaHD.Location = new System.Drawing.Point(40, 109);
            this.rdMaHD.Name = "rdMaHD";
            this.rdMaHD.Size = new System.Drawing.Size(144, 28);
            this.rdMaHD.TabIndex = 2;
            this.rdMaHD.TabStop = true;
            this.rdMaHD.Text = "Mã Hóa Đơn";
            this.rdMaHD.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(146, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(395, 29);
            this.txtTim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập:";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 335);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(670, 225);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Location = new System.Drawing.Point(210, 120);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(289, 20);
            this.dtpNgayLapHD.TabIndex = 5;
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(209, 23);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(290, 21);
            this.cbMaHD.TabIndex = 6;
            // 
            // Thông_tin_Hóa_đơn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 572);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.dtpNgayLapHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Thông_tin_Hóa_đơn";
            this.Text = "Thông_tin_Hóa_đơn";
            this.Load += new System.EventHandler(this.Thông_tin_Hóa_đơn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdNgayLapHD;
        private System.Windows.Forms.RadioButton rdMaNV;
        private System.Windows.Forms.RadioButton rdMaHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.ComboBox cbMaHD;
    }
}