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
    public partial class QLNH : Form
    {

        string cnStr;
        SqlConnection cn;
        DataSet ds;

        public QLNH()
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

    public DataSet GetPhieuNhapDatabase()
    {
        //cn.Open();
        try
        {
            string sql = "SELECT * FROM PhieuNhap";
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
        string ins = "INSERT INTO PhieuNhap(MaPN, NgayNhap, MaNCC, MaNV) VALUES ('" + txtMaPN.Text + "','" + txtNN.Text + "','" + txtMaNCC.Text + "','" + txtMaNV.Text + "')";
        SqlCommand cmd = new SqlCommand(ins, cn);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Thêm Thanh Cong");
        cn.Close();
        dgvPhieuNhap.DataSource = GetPhieuNhapDatabase().Tables[0];
    }

    private void btSua_Click(object sender, EventArgs e)
    {
        Connect();
        string update = "update PhieuNhap set NgayNhap= @NgayNhap,MaNCC=@MaNCC,MaNV=@MaNV where MaPN=@MaPN";
        SqlDataAdapter da = new SqlDataAdapter(); //=>Update
        SqlCommand cmd = new SqlCommand(update, cn);
        cmd.Parameters.Add("@MaPN", SqlDbType.NVarChar, 10, "MaPN");
        cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime,0, "NgayNhap");
        cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar, 10, "MaNCC");
        cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10, "MaNV");
        da.UpdateCommand = cmd;
        da.Update(ds);

        MessageBox.Show("Sửa Thanh Cong");
        cn.Close();

    }

    private void btRemove_Click(object sender, EventArgs e)
    {
        Connect();
        string Delete = "delete from PhieuNhap where MaPN='" + txtMaPN + "'";
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand(Delete, cn);
        cmd.CommandType = CommandType.Text;


        cmd.ExecuteNonQuery();
        da.Update(ds);


        GetPhieuNhapDatabase();
        MessageBox.Show("Xóa Thanh Cong");
        cn.Close();
        //dgvHangHoa.DataSource = GetProductDatabase().Tables[0];
    }

        private void QLNH_Load(object sender, EventArgs e)
        {
            //cnStr = "Data Source=PHUONG;Initial Catalog=A;Integrated Security=True";
            cnStr = @"Data Source=DESKTOP-PC9C563\SERVER1;Initial Catalog=A;Integrated Security=True";
            cn = new SqlConnection(cnStr);

            dgvPhieuNhap.DataSource = GetPhieuNhapDatabase().Tables[0];
        
    }
        private void btTim_Click_1(object sender, EventArgs e)
        {

            cn.Open();
            string find = "SELECT * FROM PhieuNhap WHERE ";
            if (rdMaPN.Checked == true)
            {

                find += "MaPN  LIKE '%" + txtSearch.Text + "%'";
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
            dgvPhieuNhap.DataSource = ds.Tables[0];



            //dgvHangHoa.DataSource = GetProductDatabase();
            cn.Close();
        }
    }
}
