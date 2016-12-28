namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    partial class Đăng_nhập
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
            this.tbtendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmatkhau = new System.Windows.Forms.CheckBox();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbtendangnhap
            // 
            this.tbtendangnhap.Location = new System.Drawing.Point(119, 82);
            this.tbtendangnhap.Name = "tbtendangnhap";
            this.tbtendangnhap.Size = new System.Drawing.Size(214, 20);
            this.tbtendangnhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(130, 117);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(169, 20);
            this.tbmatkhau.TabIndex = 0;
            this.tbmatkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(52, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = " Đăng Nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbmatkhau
            // 
            this.cbmatkhau.AutoSize = true;
            this.cbmatkhau.Location = new System.Drawing.Point(87, 156);
            this.cbmatkhau.Name = "cbmatkhau";
            this.cbmatkhau.Size = new System.Drawing.Size(109, 17);
            this.cbmatkhau.TabIndex = 2;
            this.cbmatkhau.Text = "Hiển thị mật khẩu";
            this.cbmatkhau.UseVisualStyleBackColor = true;
            this.cbmatkhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btDangnhap
            // 
            this.btDangnhap.Location = new System.Drawing.Point(42, 218);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(107, 36);
            this.btDangnhap.TabIndex = 3;
            this.btDangnhap.Text = "Đăng Nhập";
            this.btDangnhap.UseVisualStyleBackColor = true;
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.ForeColor = System.Drawing.Color.Red;
            this.lbThongbao.Location = new System.Drawing.Point(39, 185);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(0, 13);
            this.lbThongbao.TabIndex = 4;
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(177, 218);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(107, 36);
            this.btDong.TabIndex = 3;
            this.btDong.Text = "Canncel";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // Đăng_nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 306);
            this.Controls.Add(this.lbThongbao);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btDangnhap);
            this.Controls.Add(this.cbmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtendangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Đăng_nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Đăng_nhập_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbtendangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbmatkhau;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.Label lbThongbao;
        private System.Windows.Forms.Button btDong;
    }
}