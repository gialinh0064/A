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
    public partial class Thông_tin_Hóa_đơn : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable dt;
        public Thông_tin_Hóa_đơn()
        {
            InitializeComponent();
        }

        private void Thông_tin_Hóa_đơn_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM HoaDon";
            dt = GetCTHDDataset(sql).Tables[0];

            //Binding du lieu cho ComboBox
            cbMaHD.DataSource = dt;
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.ValueMember = "MaHD";

            //Binding du lieu cho cac TextBox
            txtMaNV.DataBindings.Add("Text", dt, "MaNV");
            dtpNgayLapHD.DataBindings.Add("Text", dt, "NgayLapHD");

        }

        public DataSet GetCTHDDataset(string sql)
        {
            try
            {
                //sql = "SELECT * FROM CTHD";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                /*DataSet*/
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


        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * From CTHD WHERE MaHD = '" + cbMaHD.Text + "'";
            dgvHoaDon.DataSource = GetCTHDDataset(sql).Tables[0];
        }



        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                string sql = @"delete from CTHD where MaHD = '" + cbMaHD.Text + "'";//Lỗi

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = CommandType.Text;
                    int count = cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa thành công. ");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }

            }
        }
       

        

       
    }
}
