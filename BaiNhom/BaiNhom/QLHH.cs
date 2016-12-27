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
    public partial class QLHH : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        public QLHH()
        {
            InitializeComponent();
        }

        private void QLHH_Load(object sender, EventArgs e)
        {

            cnStr = "Data Source=PHUONG;Initial Catalog=A;Integrated Security=True";
            //cnStr = @"Data Source=DESKTOP-PC9C563\SERVER1;Initial Catalog=A;Integrated Security=True";
            cn = new SqlConnection(cnStr);

            dgvHangHoa.DataSource = GetProductDatabase().Tables[0];
        }

        private void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        public DataSet GetProductDatabase()
        {
            //cn.Open();
            try
            {
                string sql = "SELECT * FROM HangHoa";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //DataSet
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }

            finally
            {
                cn.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Connect();
            string ins = "INSERT INTO HangHoa(MaHH, TenHH, Donvitinh, Dongia,MaLoaiHH) VALUES ('" + txtMaHH.Text + "','" + txtTenHH.Text + "','" + txtDonvitinh.Text + "','" + txtDongia.Text + "','" + txtMaLoaiHH.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm Thanh Cong");
            cn.Close();
            dgvHangHoa.DataSource = GetProductDatabase().Tables[0];
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Connect();
            string update = "update HangHoa set TenHH= @TenHH,Donvitinh=@Donvitinh,Dongia=@Dongia,MaLoaiHH=@MaLoaiHH where MaHH=@MaHH";
            SqlDataAdapter da = new SqlDataAdapter(); //=>Update
            SqlCommand cmd = new SqlCommand(update, cn);
            cmd.Parameters.Add("@MaHH", SqlDbType.NVarChar, 10, "MaHH");
            cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar, 50, "TenHH");
            cmd.Parameters.Add("@Donvitinh", SqlDbType.NVarChar, 8, "Donvitinh");
            cmd.Parameters.Add("@Dongia", SqlDbType.Int, 0, "Dongia");
            cmd.Parameters.Add("@MaLoaiHH", SqlDbType.Int, 0, "MaLoaiHH");
            da.UpdateCommand = cmd;
            da.Update(ds);

            MessageBox.Show("Sửa Thanh Cong");
            cn.Close();

        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            Connect();
            string Delete = "delete from HangHoa where MaHH='" + txtMaHH + "'";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(Delete, cn);
            cmd.CommandType = CommandType.Text;


            cmd.ExecuteNonQuery();
            da.Update(ds);


            GetProductDatabase();
            MessageBox.Show("Xóa Thanh Cong");
            cn.Close();
            //dgvHangHoa.DataSource = GetProductDatabase().Tables[0];
        }

        

        private void QL_Hàng_Hóa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban có muốn thoát chương trình?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btTim_Click_1(object sender, EventArgs e)
        {

            cn.Open();
            string find = "SELECT * FROM HangHoa WHERE ";
            if (rdMaHH.Checked == true)
            {

                find += "MaHH  LIKE '%"  + txtSearch.Text+"%'";
            }
            else
                if (rdTênHH.Checked == true)
            {
                find += "TenHH LIKE '%" + txtSearch.Text + "%'";
            }
            else if (rdMaLoaiHH.Checked == true)
            {
                find += "MaLoaiHH =" + txtSearch.Text;
            }



            //hien thi data tim kiem
            SqlDataAdapter da = new SqlDataAdapter(find, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvHangHoa.DataSource = ds.Tables[0];



            //dgvHangHoa.DataSource = GetProductDatabase();
            cn.Close();
        }
    }
}
