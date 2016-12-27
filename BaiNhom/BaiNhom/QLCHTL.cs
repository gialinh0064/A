using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiNhom
{
    public partial class QLCHTL : Form
    {
        public QLCHTL()
        {
            InitializeComponent();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            QLNCC f = new QLNCC();
            f.ShowDialog();
        }

        private void QLCHTL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btQL_NV_Click(object sender, EventArgs e)
        {
            QLNV f1 = new QLNV();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLHH f2 = new QLHH();
            f2.ShowDialog();
        }

        private void btNXKK_Click(object sender, EventArgs e)
        {
            QLN_X_KK f3 = new QLN_X_KK();
            f3.ShowDialog();
        }
    }
}
