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
    public partial class QLXH : Form
    {
        string cnStr;
        SqlConnection cn;
        DataSet ds;
        public QLXH()
        {
            InitializeComponent();
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

        public DataSet GetPhieuXuatDatabase()
        {
            //cn.Open();
            try
            {
                string sql = "SELECT * FROM PhieuXuat";
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
            string ins = "INSERT INTO PhieuXuat(MaPX, NgayXuat,  MaNV) VALUES ('" + txtMaPX.Text + "','" + txtNX.Text + "','" + txtMaNV.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm Thanh Cong");
            cn.Close();
            dgvPhieuXuat.DataSource = GetPhieuXuatDatabase().Tables[0];
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Connect();
            string update = "update PhieuXuat set NgayXuat= @NgayXuat,MaNV=@MaNV where MaPX=@MaPX";
            SqlDataAdapter da = new SqlDataAdapter(); //=>Update
            SqlCommand cmd = new SqlCommand(update, cn);
            cmd.Parameters.Add("@MaPX", SqlDbType.NVarChar, 10, "MaPX");
            cmd.Parameters.Add("@NgayXuat", SqlDbType.DateTime, 0, "NgayXuat");
            cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10, "MaNV");
            da.UpdateCommand = cmd;
            da.Update(ds);

            MessageBox.Show("Sửa Thanh Cong");
            cn.Close();

        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            Connect();
            string Delete = "delete from PhieuXuat where MaPX='" + txtMaPX + "'";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(Delete, cn);
            cmd.CommandType = CommandType.Text;


            cmd.ExecuteNonQuery();
            da.Update(ds);


            GetPhieuXuatDatabase();
            MessageBox.Show("Xóa Thanh Cong");
            cn.Close();
            //dgvHangHoa.DataSource = GetProductDatabase().Tables[0];
        }

      
        private void btTim_Click_1(object sender, EventArgs e)
        {

            cn.Open();
            string find = "SELECT * FROM PhieuXuat WHERE ";
            if (rdMaPX.Checked == true)
            {

                find += "MaPX  LIKE '%" + txtSearch.Text + "%'";
            }
            else
                if (rdMaNV.Checked == true)
            {
                find += "MaNV LIKE '%" + txtSearch.Text + "%'";
            }




            //hien thi data tim kiem
            SqlDataAdapter da = new SqlDataAdapter(find, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvPhieuXuat.DataSource = ds.Tables[0];



            //dgvHangHoa.DataSource = GetProductDatabase();
            cn.Close();
        }

        private void QLNX_Load(object sender, EventArgs e)
        {
            //cnStr = "Data Source=PHUONG;Initial Catalog=A;Integrated Security=True";
            cnStr = @"Data Source=DESKTOP-PC9C563\SERVER1;Initial Catalog=A;Integrated Security=True";
            cn = new SqlConnection(cnStr);

            dgvPhieuXuat.DataSource = GetPhieuXuatDatabase().Tables[0];

        }
    }
}
