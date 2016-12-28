using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    public partial class Thông_tin_nhân_viên : Form
    {
        string cnstr;
        SqlConnection cn;
        public Thông_tin_nhân_viên()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thông_tin_nhân_viên_Load(object sender, EventArgs e)
        {
            
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnstr);

            dvgNhanvien1.DataSource = GetEmployee("Select * From Nhanvien");
        }

        private void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                    MessageBox.Show("Ket noi duoc");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void Disconnect()
        {
            if (cn != null && cn.State == ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        public List<NhanVien> GetEmployee(string sql)
        {
            Connect();
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                //string sql = "SELECT * FROM Nhanvien";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                String id;
                string lastName, firstName, phone, home;
                while (dr.Read())
                {
                    id = dr.GetString(0);
                    lastName = dr.GetString(1);
                    firstName = dr.GetString(2);
                    phone = dr.GetString(3);
                    home = dr.GetString(4);
                    NhanVien nv = new NhanVien(id, lastName, firstName, phone, home);
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
                Disconnect();
            }
            return list;
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("uspInsertEmployee", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MaNV", txtMaNV.Text));
                cmd.Parameters.Add(new SqlParameter("@HoNV", txtHoNV.Text));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTenNV.Text));
                cmd.Parameters.Add(new SqlParameter("@QueQuan", txtDiaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtDT.Text));


                int numofRows = cmd.ExecuteNonQuery();
                MessageBox.Show("So Nhan Vien Da Them:" + numofRows);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnect();
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("uspXoaEmployee", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HoNV", txtHoNV.Text));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTenNV.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtDT.Text));
                cmd.Parameters.Add(new SqlParameter("@QueQuan", txtDiaChi.Text));


                int numofRows = cmd.ExecuteNonQuery();
                MessageBox.Show("So Nhan Vien Da Xoa:" + numofRows);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnect();
            }
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand("uspUpdateEmployee", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", txtMaNV.Text));
                cmd.Parameters.Add(new SqlParameter("@HoNV", txtHoNV.Text));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTenNV.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtDT.Text));
                cmd.Parameters.Add(new SqlParameter("@QueQuan", txtDiaChi.Text));


                int numofRows = cmd.ExecuteNonQuery();
                MessageBox.Show("So Nhan Vien Da Them:" + numofRows);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnect();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Nhanvien WHERE ";
            if (rdma.Checked == true)
            {

                sql += "MaNV LIKE '%" + txtNhap.Text + "%'";
            }
            else if (rdho.Checked == true)
            {
                sql += "HoNV LIKE '%" + txtNhap.Text + "%'";
            }

            else if (rdten.Checked == true)
            {
                sql += "Ten LIKE '%" + txtNhap.Text + "%'";
            }

            dvgNhanvien1.DataSource = GetEmployee(sql);


        }
    }
}
