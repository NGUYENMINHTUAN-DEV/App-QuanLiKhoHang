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
    public partial class FmChiTietPhieuXuat : Form
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        SQL dt = new SQL();
        public FmChiTietPhieuXuat()
        {
            InitializeComponent();
        }

        private void FmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            _cnn.Open();
            cmMaPX.DataSource = dt.LoadMAPHIEUX();
            cmMaPX.DisplayMember = "MAPH_XH";
            cmMaPX.ValueMember = "MAPH_XH";
        }

        private void cmMaPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapx = cmMaPX.SelectedValue.ToString();
            DataTable dtPX = dt.LoadChiTietPhieuXuat(mapx);
            CrystalReportPX Xuat = new CrystalReportPX();
            Xuat.SetDataSource(dtPX);
            crystalReportPhieuXuat.ReportSource = Xuat;
        }
    }
}
