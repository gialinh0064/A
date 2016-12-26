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
    public partial class QLNCC : Form
    {
        string cnStr;
        SqlConnection cn;
        public QLNCC()
        {
            InitializeComponent();
        }
        /*========== cung cấp thông tin kết nối============*/
        private void NCC_Load(object sender, EventArgs e)
        {
            cnStr = "Data Source=PHUONG;Initial Catalog=A;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }

        /*======================= Thực hiện kết nối- không kết nối=======================*/
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
                //throw;
            }

        }
        private void DisConnect()
        {
            cn.Close();
        }

        /*=====================Nút Thêm ==========================*/
        private void btThem_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_INS_NCC", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MANCC", txtmancc.Text));
                cmd.Parameters.Add(new SqlParameter("@TEN", txttenncc.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", txtdc.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txtsdtncc.Text));
                cmd.Parameters.Add(new SqlParameter("@fax", txtfax.Text));

                cmd.ExecuteNonQuery();

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
            dgv_NCC.DataSource = GetNHACUNGCAP("SELECT* FROM NCC");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_DEL_NCC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm các tham so vào
                cmd.Parameters.Add(new SqlParameter("@MANCC", txtmancc.Text));
                cmd.Parameters.Add(new SqlParameter("@TEN", txttenncc.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", txtdc.Text));
                cmd.Parameters.Add(new SqlParameter("@sdt", txtsdtncc.Text));
                cmd.Parameters.Add(new SqlParameter("@fax", txtfax.Text));

                cmd.ExecuteNonQuery();

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
            dgv_NCC.DataSource = GetNHACUNGCAP("SELECT* FROM NCC");
        }
        public List<NCC> GetNHACUNGCAP(string sql)
        {
            Connect();
            List<NCC> list = new List<NCC>();
            try
            {
                //string sql = "SELECT * FROM Nhanvien";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                string ma, ten, diachi, sdt, fax;
                while (dr.Read())
                {
                    ma = dr.GetString(0);
                    ten = dr.GetString(1);
                    diachi = dr.GetString(2);
                    sdt = dr.GetString(3);
                    fax = dr.GetString(4);
                    NCC ncc = new NCC(ma, ten, diachi, sdt, fax);
                    list.Add(ncc);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttim_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NCC WHERE ";
            if (rdMa_NCC.Checked == true)
            {
                sql += "MaNCC LIKE '%" + txtTim_NCC.Text + "%'";
            }
            else
            {
                sql += "TenNCC LIKE '%" + txtTim_NCC.Text + "%'";
            }
            dgv_NCC.DataSource = GetNHACUNGCAP(sql);
        }
    }
}
