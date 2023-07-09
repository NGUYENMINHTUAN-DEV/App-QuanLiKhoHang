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
    public partial class FmChiTietNH : Form
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        SQL dt = new SQL();
        SqlCommand cm = new SqlCommand();
        public FmChiTietNH()
        {
            InitializeComponent();
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            
            btnSuaPhieu.Enabled = true;
            btnXoaPhieu.Enabled = true;
            btnInPN.Enabled = true;
            errorProvider1.SetError(cmMaPN, "Bạn Chưa Chọn Mã Nhà Phiếu Nhập");
            errorProvider1.SetError(cmMaSp, "Bạn Chưa Chọn Mã Sản Phẩm");
            errorProvider1.SetError(txtSoLuong, "Bạn Chưa Nhập Số Lượng");
            //if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //{
            //    if (dt.ThemCTPN(cmMaPN.Text, cmMaSp.Text, txtSoLuong.Text))
            //    {
            //        MessageBox.Show("Thêm Thành Công");
            //    }
            //}
           
            string sql = "insert into CHITIET_NH values(@MAPHIEU_NH,@MA_SP,@SOLUONG)";
            SqlCommand cm = new SqlCommand(sql,_cnn);
            cm.Parameters.AddWithValue("@MAPHIEU_NH", cmMaPN.Text);
            cm.Parameters.AddWithValue("@MA_SP", cmMaSp.Text);
            cm.Parameters.AddWithValue("@SOLUONG", txtSoLuong.Text);
            cm.ExecuteNonQuery();
            LoadDulieu();


        }
        void LoadComBoxSPN()
        {
            var cmd = new SqlCommand("select MA_SP from SAN_PHAM", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaSp.DisplayMember = "MA_SP";
            cmMaSp.DataSource = dt;
        }
        void LoadComBoxPN()
        {
            var cmd = new SqlCommand("select MAPHIEU_NH from PHIEU_NHAP_HANG", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaPN.DisplayMember = "MAPHIEU_NH";
            cmMaPN.DataSource = dt;
        }
        void LoadDulieu()
        {
            string sql = "select * from CHITIET_NH";
            SqlCommand cm = new SqlCommand(sql, _cnn);

            SqlDataReader da = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(da);
            DataCTPN.DataSource = dt;
        }
        private void FmChiTietNH_Load(object sender, EventArgs e)
        {
            _cnn.Open();
            LoadComBoxPN();
            LoadComBoxSPN();
            LoadDulieu();
            //DataCTPN.DataSource = dt.LoadLCHITIETNH();
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.XoaCTPN(cmMaPN.Text))
                {
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                }
            }
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.SuaCTPN(cmMaPN.Text, cmMaSp.Text, txtSoLuong.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
            }
        }

        private void DataCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmMaPN.Text = DataCTPN.SelectedRows[0].Cells[0].Value.ToString();
            cmMaSp.Text = DataCTPN.SelectedRows[0].Cells[1].Value.ToString();
            txtSoLuong.Text = DataCTPN.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnInPN_Click(object sender, EventArgs e)
        {
            FmChiTietPhieuNhap fmChiTietPhieuNhap = new FmChiTietPhieuNhap();
            fmChiTietPhieuNhap.Show();
        }
    }
}
