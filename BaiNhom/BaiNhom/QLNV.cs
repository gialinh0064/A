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
    public partial class QLNV : Form
    {
        string cnStr;
        SqlConnection cn;
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            cnStr = "Data Source=PHUONG;Initial Catalog=A;Integrated Security=True";
            cn = new SqlConnection(cnStr);
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
        private void DisConnect()
        {
            cn.Close();
        }
        //nút thêm nv mới
        private void btIns_NV_Click_1(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_THEM_NV", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@manv", txtma_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@ho", txtho_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txtten_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@qquan", txtdc_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txtsdt_nv.Text));

                cmd.ExecuteNonQuery();
                dgv_Nhanvien.DataSource = GetEmployee("SELECT* FROM Nhanvien");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
            finally
            {
                DisConnect();
            }
        }
        //xóa nhân viên cũ
        private void btDel_NV_Click_1(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_XOA_NV", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@manv", txtma_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@ho", txtho_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txtten_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@qquan", txtdc_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txtsdt_nv.Text));

                cmd.ExecuteNonQuery();
                dgv_Nhanvien.DataSource = GetEmployee("SELECT* FROM Nhanvien");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
            finally
            {
                DisConnect();
            }
        }
        //hiển thị danh sach nhan vien
        public List<Employees> GetEmployee(string sql)
        {
            Connect();
            List<Employees> list = new List<Employees>();
            try
            {
                //string sql = "SELECT * FROM Nhanvien";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                string ma, ho, ten, qq, sdt;
                //dr chi doc tung dong
                while (dr.Read())
                {
                    ma = dr.GetString(0);
                    ho = dr.GetString(1);
                    ten = dr.GetString(2);
                    qq = dr.GetString(3);
                    sdt = dr.GetString(4);
                    Employees nv = new Employees(ma, ho, ten, qq, sdt);
                    list.Add(nv);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return list;
        }
        //nút tìm kiếm
        private void btTraTim_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Nhanvien WHERE ";
            if (rdma.Checked == true)
            {
                sql += "MaNV LIKE '%" + txtnv.Text + "%'";
            }
            else if (rdHo.Checked == true)
            {
                sql += "HoNV LIKE '%" + txtnv.Text + "%'";
            }
            else
            {
                sql += "Ten LIKE '%" + txtnv.Text + "%'";
            }
            dgv_Nhanvien.DataSource = GetEmployee(sql);
        }

        private void btUpd_NV_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_UPD_NV", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@manv", txtma_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@ho", txtho_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@ten", txtten_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@qquan", txtdc_nv.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txtsdt_nv.Text));


                cmd.ExecuteNonQuery();
                dgv_Nhanvien.DataSource = GetEmployee("SELECT* FROM Nhanvien");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                DisConnect();
            }
        }     
    }
}
