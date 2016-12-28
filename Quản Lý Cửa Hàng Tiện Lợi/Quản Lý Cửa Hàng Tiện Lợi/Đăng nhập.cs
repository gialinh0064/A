using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    public partial class Đăng_nhập : Form
    {
        public Đăng_nhập()
        {
            InitializeComponent();
        }
        ///////////////////////////Phuong làm/////////////////////////////
        //thong bao khi thoat bat chot
        private void Đăng_nhập_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;    
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //nut hien thị mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmatkhau.Checked)
            {
                tbmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                tbmatkhau.UseSystemPasswordChar = true;
            }


           
        }

        
    }
}
