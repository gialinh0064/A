using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    public partial class frmInHoaDon : Form
    {
        const string cnStr = " ";
        SqlConnection cn;
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            HienThiReport();
            //this.reportViewer1.RefreshReport();
        }

        private void HienThiReport()
        {
            string sql = "SELECT * FROM CTHD";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            ReportDataSource rds = new ReportDataSource("dsCTHD", ds.Tables[0]);
            rvHoaDon.LocalReport.DataSources.Clear();
            rvHoaDon.LocalReport.DataSources.Add(rds);
            rvHoaDon.LocalReport.ReportPath = @"..\...\rptHoaDon.rdlc";
            this.rvHoaDon.RefreshReport();
        }
    }
}
