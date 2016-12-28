namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    partial class Thông_tin_hàng_hóa
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
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTim = new System.Windows.Forms.Button();
            this.rdMaLoaiHH = new System.Windows.Forms.RadioButton();
            this.rdTênHH = new System.Windows.Forms.RadioButton();
            this.rdMaHH = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiHH = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(15, 472);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(598, 233);
            this.dgvHangHoa.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.rdMaLoaiHH);
            this.groupBox2.Controls.Add(this.rdTênHH);
            this.groupBox2.Controls.Add(this.rdMaHH);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm";
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.Location = new System.Drawing.Point(234, 104);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(122, 44);
            this.btTim.TabIndex = 3;
            this.btTim.Text = "Tìm Kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // rdMaLoaiHH
            // 
            this.rdMaLoaiHH.AutoSize = true;
            this.rdMaLoaiHH.Location = new System.Drawing.Point(419, 81);
            this.rdMaLoaiHH.Name = "rdMaLoaiHH";
            this.rdMaLoaiHH.Size = new System.Drawing.Size(115, 17);
            this.rdMaLoaiHH.TabIndex = 2;
            this.rdMaLoaiHH.TabStop = true;
            this.rdMaLoaiHH.Text = "Mã Loại Hàng Hóa";
            this.rdMaLoaiHH.UseVisualStyleBackColor = true;
            // 
            // rdTênHH
            // 
            this.rdTênHH.AutoSize = true;
            this.rdTênHH.Location = new System.Drawing.Point(234, 81);
            this.rdTênHH.Name = "rdTênHH";
            this.rdTênHH.Size = new System.Drawing.Size(94, 17);
            this.rdTênHH.TabIndex = 2;
            this.rdTênHH.TabStop = true;
            this.rdTênHH.Text = "Tên Hàng hóa";
            this.rdTênHH.UseVisualStyleBackColor = true;
            // 
            // rdMaHH
            // 
            this.rdMaHH.AutoSize = true;
            this.rdMaHH.Location = new System.Drawing.Point(86, 81);
            this.rdMaHH.Name = "rdMaHH";
            this.rdMaHH.Size = new System.Drawing.Size(92, 17);
            this.rdMaHH.TabIndex = 2;
            this.rdMaHH.TabStop = true;
            this.rdMaHH.Text = "Mã Hàng Hóa";
            this.rdMaHH.UseVisualStyleBackColor = true;
            this.rdMaHH.CheckedChanged += new System.EventHandler(this.rdMaPN_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRemove);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 67);
            this.panel1.TabIndex = 6;
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(435, 15);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(129, 36);
            this.btRemove.TabIndex = 0;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(215, 15);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(129, 36);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(27, 15);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(129, 36);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLoaiHH);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.txtTenHH);
            this.groupBox1.Controls.Add(this.txtDonvitinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaHH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtMaLoaiHH
            // 
            this.txtMaLoaiHH.Location = new System.Drawing.Point(186, 190);
            this.txtMaLoaiHH.Name = "txtMaLoaiHH";
            this.txtMaLoaiHH.Size = new System.Drawing.Size(351, 20);
            this.txtMaLoaiHH.TabIndex = 1;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(186, 149);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(351, 20);
            this.txtDongia.TabIndex = 1;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(186, 78);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(351, 20);
            this.txtTenHH.TabIndex = 1;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Location = new System.Drawing.Point(186, 112);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(351, 20);
            this.txtDonvitinh.TabIndex = 1;
            this.txtDonvitinh.TextChanged += new System.EventHandler(this.txtMaNcc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Loại Hàng Hóa:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(186, 33);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(351, 20);
            this.txtMaHH.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Hàng Hóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Hoá:";
            // 
            // Thông_tin_hàng_hóa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 652);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thông_tin_hàng_hóa";
            this.Text = "Thông_tin_hàng_hóa";
            this.Load += new System.EventHandler(this.Thông_tin_hàng_hóa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdMaLoaiHH;
        private System.Windows.Forms.RadioButton rdTênHH;
        private System.Windows.Forms.RadioButton rdMaHH;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiHH;
        private System.Windows.Forms.Label label6;
    }
}