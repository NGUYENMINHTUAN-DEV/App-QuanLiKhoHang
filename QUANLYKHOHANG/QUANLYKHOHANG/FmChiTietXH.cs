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
    public partial class FmChiTietXH : Form
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        SQL dt = new SQL();
        public FmChiTietXH()
        {
            InitializeComponent();
        }
        void LoadComBoxSPX()
        {
            var cmd = new SqlCommand("select MA_SP from SAN_PHAM", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaSpX.DisplayMember = "MA_SP";
            cmMaSpX.DataSource = dt;
        }
        void LoadComBoxPX()
        {
            var cmd = new SqlCommand("select MAPH_XH from PHIEU_XUAT_HANG", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaPX.DisplayMember = "MAPH_XH";
            cmMaPX.DataSource = dt;
        }
        private void FmChiTietXH_Load(object sender, EventArgs e)
        {
            _cnn.Open();
            LoadComBoxPX();
            LoadComBoxSPX();
            DataCTPX.DataSource = dt.LoadLCHITIETXH();
        }

        private void btnThemPhieuX_Click(object sender, EventArgs e)
        {
            btnSuaPhieuX.Enabled = true;
            btnXoaPhieuX.Enabled = true;
            btnInPX.Enabled = true;
            errorProvider1.SetError(cmMaPX, "Bạn Chưa Chọn Mã Nhà Phiếu Nhập");
            errorProvider1.SetError(cmMaSpX, "Bạn Chưa Chọn Mã Sản Phẩm");
            errorProvider1.SetError(txtSoLuongX, "Bạn Chưa Nhập Số Lượng");
          
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.ThemCTPX(cmMaPX.Text, cmMaSpX.Text, txtSoLuongX.Text))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
            }
        }

        private void btnXoaPhieuX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.XoaCTPX(cmMaPX.Text))
                {
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                }
            }
        }

        private void btnSuaPhieuX_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.SuaCTPX(cmMaPX.Text, cmMaSpX.Text, txtSoLuongX.Text))
                {
                    MessageBox.Show("Sửa Thành Công");
                }
            }
        }

        private void DataCTPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmMaPX.Text = DataCTPX.SelectedRows[0].Cells[0].Value.ToString();
            cmMaSpX.Text = DataCTPX.SelectedRows[0].Cells[1].Value.ToString();
            txtSoLuongX.Text = DataCTPX.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnInPX_Click(object sender, EventArgs e)
        {
            FmChiTietPhieuXuat fmChiTietPhieuXuat = new FmChiTietPhieuXuat();
            fmChiTietPhieuXuat.Show();
        }
    }
}
