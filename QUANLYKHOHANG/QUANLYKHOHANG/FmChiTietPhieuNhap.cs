using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QUANLYKHOHANG
{
    public partial class FmChiTietPhieuNhap : Form
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        SQL dt = new SQL();
        public FmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void FmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            _cnn.Open();
            cmMaPN.DataSource = dt.LoadMAPHIEUN();
            cmMaPN.DisplayMember = "MAPHIEU_NH";
            cmMaPN.ValueMember = "MAPHIEU_NH";
        }
        private void cmMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapn = cmMaPN.SelectedValue.ToString();
            DataTable dtPN = dt.LoadChiTietPhieuNhap(mapn);
            CrystalReportPN Nhap = new CrystalReportPN();
            Nhap.SetDataSource(dtPN);
            crystalReportPhieuNhap.ReportSource = Nhap;
        }
    }
}
