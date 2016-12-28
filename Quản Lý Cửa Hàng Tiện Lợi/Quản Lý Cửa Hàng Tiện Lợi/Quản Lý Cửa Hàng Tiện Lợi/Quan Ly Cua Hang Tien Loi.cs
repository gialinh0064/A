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
    public partial class Quan_Ly_Cua_Hang_Tien_Loi : Form
    {
        public Quan_Ly_Cua_Hang_Tien_Loi()
        {
            InitializeComponent();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            Thông_tin_nhân_viên f = new Thông_tin_nhân_viên();
            f.ShowDialog();//khi chạy ct ban bảng thông tin nhân viên thì bảng quản lý nhân viên sẽ không sử dụng dc
        }

        private void btNhapXuatHang_Click(object sender, EventArgs e)
        {
            Nhập_Xuất_Kiểm_Kê f = new Nhập_Xuất_Kiểm_Kê();
            f.ShowDialog();
        }

        private void Quan_Ly_Cua_Hang_Tien_Loi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình Quản lý cửa hàng?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       

    }
}
