using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiNhom
{
    public partial class Form1 : Form
    {

        //string cnStr = "Data Source=PHUONG;Initial Catalog=Login;Integrated Security=True";
        string cnStr = @"Data Source=DESKTOP-PC9C563\SERVER1;Initial Catalog=Login;Integrated Security=True";
        SqlConnection cn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
        //ket noi  
        private void Connect()
        {
            if (cn != null && cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        //k ket noi
        private void DisConect()
        {
            cn.Close();
        }
       
//nut dang nhap
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                cn = new SqlConnection(cnStr);
                cn.Open();
                //cach1: 
                //string sql = "Select COUNT(*) FROM [Login].[dbo].[Login_DN] WHERE Taikhoan = @TK and Matkhau = @MK";
                //cmd = new SqlCommand(sql, cn);
                //cach2
                cmd = new SqlCommand();
                cmd.CommandText = "USP_DANGNHAP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                //khai bao tham so 
                cmd.Parameters.Add(new SqlParameter("@TK", txttendangnhap.Text));
                cmd.Parameters.Add(new SqlParameter("@MK", txtmatkhau.Text));

                int x = (int)cmd.ExecuteScalar();//doi tuong tra ve 1 so dung cho count
                //dung dang nhap
                if (x == 1)
                {
                    MessageBox.Show("đăng nhập thành công", "Thông báo");
                    QLCHTL frm = new QLCHTL();
                    frm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hay mật khẩu có vấn đề", "Thông báo");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                DisConect();
            }           
        }
 //nut hien thị mật khẩu
        private void cbmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmatkhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
