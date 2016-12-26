namespace BaiNhom
{
    partial class Form1
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
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.cbmatkhau = new System.Windows.Forms.CheckBox();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtendangnhap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(172, 157);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(191, 20);
            this.txtmatkhau.TabIndex = 6;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(172, 121);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(191, 20);
            this.txttendangnhap.TabIndex = 5;
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.ForeColor = System.Drawing.Color.Red;
            this.lbThongbao.Location = new System.Drawing.Point(146, 253);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(0, 13);
            this.lbThongbao.TabIndex = 12;
            // 
            // btDangnhap
            // 
            this.btDangnhap.Location = new System.Drawing.Point(133, 241);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(107, 36);
            this.btDangnhap.TabIndex = 11;
            this.btDangnhap.Text = "Đăng Nhập";
            this.btDangnhap.UseVisualStyleBackColor = true;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // cbmatkhau
            // 
            this.cbmatkhau.AutoSize = true;
            this.cbmatkhau.Location = new System.Drawing.Point(80, 207);
            this.cbmatkhau.Name = "cbmatkhau";
            this.cbmatkhau.Size = new System.Drawing.Size(109, 17);
            this.cbmatkhau.TabIndex = 10;
            this.cbmatkhau.Text = "Hiển thị mật khẩu";
            this.cbmatkhau.UseVisualStyleBackColor = true;
            this.cbmatkhau.CheckedChanged += new System.EventHandler(this.cbmatkhau_CheckedChanged);
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmatkhau.Location = new System.Drawing.Point(36, 152);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(100, 27);
            this.lbmatkhau.TabIndex = 7;
            this.lbmatkhau.Text = "Mật Khẩu :";
            this.lbmatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(96, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = " Đăng Nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtendangnhap
            // 
            this.lbtendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtendangnhap.Location = new System.Drawing.Point(36, 116);
            this.lbtendangnhap.Name = "lbtendangnhap";
            this.lbtendangnhap.Size = new System.Drawing.Size(118, 36);
            this.lbtendangnhap.TabIndex = 9;
            this.lbtendangnhap.Text = "Tên Đăng Nhập:";
            this.lbtendangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiNhom.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.lbThongbao);
            this.Controls.Add(this.btDangnhap);
            this.Controls.Add(this.cbmatkhau);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbtendangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label lbThongbao;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.CheckBox cbmatkhau;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtendangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

