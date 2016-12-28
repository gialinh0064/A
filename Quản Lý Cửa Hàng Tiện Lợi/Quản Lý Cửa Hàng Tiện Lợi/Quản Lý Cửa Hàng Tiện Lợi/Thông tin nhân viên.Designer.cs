namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    partial class Thông_tin_nhân_viên
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btTim = new System.Windows.Forms.Button();
            this.rdho = new System.Windows.Forms.RadioButton();
            this.rdten = new System.Windows.Forms.RadioButton();
            this.rdma = new System.Windows.Forms.RadioButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dvgNhanvien1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btUpd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btIns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNhanvien1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dvgNhanvien1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtDT);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtHoNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 432);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btTim);
            this.panel3.Controls.Add(this.rdho);
            this.panel3.Controls.Add(this.rdten);
            this.panel3.Controls.Add(this.rdma);
            this.panel3.Controls.Add(this.txtNhap);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(5, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 169);
            this.panel3.TabIndex = 6;
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTim.Location = new System.Drawing.Point(176, 113);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(185, 39);
            this.btTim.TabIndex = 9;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // rdho
            // 
            this.rdho.AutoSize = true;
            this.rdho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdho.Location = new System.Drawing.Point(222, 74);
            this.rdho.Name = "rdho";
            this.rdho.Size = new System.Drawing.Size(112, 35);
            this.rdho.TabIndex = 6;
            this.rdho.TabStop = true;
            this.rdho.Text = "Họ NV";
            this.rdho.UseVisualStyleBackColor = true;
            // 
            // rdten
            // 
            this.rdten.AutoSize = true;
            this.rdten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdten.Location = new System.Drawing.Point(424, 74);
            this.rdten.Name = "rdten";
            this.rdten.Size = new System.Drawing.Size(124, 35);
            this.rdten.TabIndex = 7;
            this.rdten.TabStop = true;
            this.rdten.Text = "Tên NV";
            this.rdten.UseVisualStyleBackColor = true;
            // 
            // rdma
            // 
            this.rdma.AutoSize = true;
            this.rdma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdma.Location = new System.Drawing.Point(9, 74);
            this.rdma.Name = "rdma";
            this.rdma.Size = new System.Drawing.Size(114, 35);
            this.rdma.TabIndex = 8;
            this.rdma.TabStop = true;
            this.rdma.Text = "Mã NV";
            this.rdma.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhap.Location = new System.Drawing.Point(126, 9);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(449, 47);
            this.txtNhap.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nhập  :";
            // 
            // dvgNhanvien1
            // 
            this.dvgNhanvien1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgNhanvien1.Location = new System.Drawing.Point(3, 319);
            this.dvgNhanvien1.Name = "dvgNhanvien1";
            this.dvgNhanvien1.Size = new System.Drawing.Size(810, 180);
            this.dvgNhanvien1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btUpd);
            this.panel2.Controls.Add(this.btDel);
            this.panel2.Controls.Add(this.btIns);
            this.panel2.Location = new System.Drawing.Point(661, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 188);
            this.panel2.TabIndex = 5;
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(16, 131);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(121, 40);
            this.btUpd.TabIndex = 4;
            this.btUpd.Text = "Sửa";
            this.btUpd.UseVisualStyleBackColor = true;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(16, 75);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(121, 40);
            this.btDel.TabIndex = 4;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // btIns
            // 
            this.btIns.Location = new System.Drawing.Point(16, 20);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(121, 40);
            this.btIns.TabIndex = 4;
            this.btIns.Text = "Thêm";
            this.btIns.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(449, 40);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(169, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(116, 86);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(244, 20);
            this.txtDT.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(116, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(250, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 58);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "SDT:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ NV:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê Quán:";
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(116, 35);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(243, 20);
            this.txtHoNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(387, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên :";
            // 
            // Thông_tin_nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 464);
            this.Controls.Add(this.panel1);
            this.Name = "Thông_tin_nhân_viên";
            this.Text = "Thông_tin_nhân_viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thông_tin_nhân_viên_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNhanvien1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdho;
        private System.Windows.Forms.RadioButton rdten;
        private System.Windows.Forms.RadioButton rdma;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dvgNhanvien1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btIns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.Label label3;
    }
}