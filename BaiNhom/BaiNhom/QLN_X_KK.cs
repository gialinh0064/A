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
    public partial class QLN_X_KK : Form
    {
        public QLN_X_KK()
        {
            InitializeComponent();
        }

        private void QLN_X_KK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btPN_Click(object sender, EventArgs e)
        {
            QLNH f = new QLNH();
            f.ShowDialog();
        }
    }
}
