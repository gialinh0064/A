namespace BaiNhom
{
    partial class QLN_X_KK
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
            this.btPN = new System.Windows.Forms.Button();
            this.btPX = new System.Windows.Forms.Button();
            this.btPKK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPN
            // 
            this.btPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPN.Location = new System.Drawing.Point(35, 113);
            this.btPN.Name = "btPN";
            this.btPN.Size = new System.Drawing.Size(192, 72);
            this.btPN.TabIndex = 0;
            this.btPN.Text = "Quản lý Phiếu Nhập Hàng";
            this.btPN.UseVisualStyleBackColor = true;
            this.btPN.Click += new System.EventHandler(this.btPN_Click);
            // 
            // btPX
            // 
            this.btPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPX.Location = new System.Drawing.Point(247, 113);
            this.btPX.Name = "btPX";
            this.btPX.Size = new System.Drawing.Size(192, 72);
            this.btPX.TabIndex = 0;
            this.btPX.Text = "Quản lý Phiếu Xuất Hàng";
            this.btPX.UseVisualStyleBackColor = true;
            this.btPX.Click += new System.EventHandler(this.btPX_Click);
            // 
            // btPKK
            // 
            this.btPKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPKK.Location = new System.Drawing.Point(445, 113);
            this.btPKK.Name = "btPKK";
            this.btPKK.Size = new System.Drawing.Size(192, 72);
            this.btPKK.TabIndex = 0;
            this.btPKK.Text = "Quản lý Phiếu Kiểm Kê";
            this.btPKK.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiNhom.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // QLN_X_KK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(697, 204);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btPKK);
            this.Controls.Add(this.btPX);
            this.Controls.Add(this.btPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QLN_X_KK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLN_X_KK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLN_X_KK_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPN;
        private System.Windows.Forms.Button btPX;
        private System.Windows.Forms.Button btPKK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}