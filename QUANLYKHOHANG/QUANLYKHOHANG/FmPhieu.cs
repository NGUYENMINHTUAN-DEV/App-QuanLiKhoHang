using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLYKHOHANG
{
    public partial class FmPhieu : Form
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        SQL dt = new SQL();
        SqlCommand cmd;
        Modify modify = new Modify();
        string sql;
        SqlConnection ketnoi;
        string chuoiketnoi = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        public FmPhieu()
        {
            _cnn.Open();
            InitializeComponent();
            
        }

        private void FmPhieu_Load(object sender, EventArgs e)
        {
          //  sql = @"select TONGTIEN_XH=Sum(GIA* SOLUONG_XH)
//from  SAN_PHAM,PHIEU_XUAT_HANG
//where SAN_PHAM.MA_SP=PHIEU_XUAT_HANG.MA_SP";
//            thuchien = new SqlCommand(sql, _cnn);
//            docdulieu = thuchien.ExecuteReader();
//            while (docdulieu.Read())
//            {
//                txtTTX.Text = docdulieu[0].ToString();
//                i++;
//            }
            dataPN.DataSource = dt.LoadPhieu();
            dataPX.DataSource = dt.LoadPhieuX();
            LoadComBoxNV();
            LoadComBoxKHX();
            LoadComBoxNVX();
        }

        void LoadComBoxNV()
        {

            var cmd = new SqlCommand("select MANV from NHAN_VIEN", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaNvN.DisplayMember = "MANV";
            cmMaNvN.DataSource = dt;
        }
        void LoadComBoxNVX()
        {

            var cmd = new SqlCommand("select MANV from NHAN_VIEN", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaNVX.DisplayMember = "MANV";
            cmMaNVX.DataSource = dt;
        }
        void LoadComBoxKHX()
        {

            var cmd = new SqlCommand("select MAKH from KHACH_HANG", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaKh.DisplayMember = "MAKH";
            cmMaKh.DataSource = dt;
        }
        private void btnThemN_Click(object sender, EventArgs e)
        {
            btnSuaN.Enabled = true;
           btnChiTietPN.Enabled = true;
            btnTKn.Enabled = true;
            btnXoaN.Enabled = true;
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.ThemPhieu(txtMaPnN.Text, dateNN.Value, txtTongTienN.Text, cmMaNvN.Text))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                }
            }
        }

        private void btnTKn_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MAPHIEU_NH", "*" + txtTimKiemN.Text + "*");
            (dataPN.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnSuaN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.SuaPhieuN(txtMaPnN.Text, dateNN.Value, txtTongTienN.Text, cmMaNvN.Text))
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                }
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.XoaPhieuN(txtMaPnN.Text))
                {
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                }
            }

        }

        private void dataPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPnN.Text = dataPN.SelectedRows[0].Cells[0].Value.ToString();
            dateNN.Text = dataPN.SelectedRows[0].Cells[1].Value.ToString();
            txtTongTienN.Text = dataPN.SelectedRows[0].Cells[2].Value.ToString();
            cmMaNvN.Text = dataPN.SelectedRows[0].Cells[3].Value.ToString();
        }

       
      

        private void dataPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaPX.Text = dataPX.SelectedRows[0].Cells[0].Value.ToString();
            dataNgayX.Text = dataPX.SelectedRows[0].Cells[1].Value.ToString();
            txtTongTienX.Text = dataPX.SelectedRows[0].Cells[2].Value.ToString();
            cmMaKh.SelectedItem = dataPX.SelectedRows[0].Cells[3].Value.ToString();
            cmMaNVX.SelectedItem = dataPX.SelectedRows[0].Cells[4].Value.ToString();
        
            
           
        }

        private void btnTimKiemX_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MAPH_XH", "*" + txtTKX.Text + "*");
            (dataPX.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        
       
        private void txtTTX_TextChanged(object sender, EventArgs e)
        {
            string query = "Select sum(SOLUONG_XH*GIA) from SAN_PHAM,PHIEU_XUAT_HANG where SAN_PHAM.MA_SP =PHIEU_XUAT_HANG.MA_SP";
        }

        private void btnInPN_Click(object sender, EventArgs e)
        {
            FmChiTietPhieuNhap fmChiTietPhieuNhap = new FmChiTietPhieuNhap();
            fmChiTietPhieuNhap.Show();
        }

        private void btnINp_Click(object sender, EventArgs e)
        {
            FmChiTietPhieuXuat fmChiTietPhieuXuat = new FmChiTietPhieuXuat();
            fmChiTietPhieuXuat.Show();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoaX_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có chắc chắn Xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
              if (dt.XoaPhieuX(txtMaPX.Text))
               {
                  MessageBox.Show("Xóa Thành Công", "Thông Báo");

                }
            }  
        }

        private void btnSuaX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
               
                if (dt.SuaPhieuX(txtMaPX.Text, dateNN.Value, txtTongTienX.Text, cmMaKh.Text, cmMaNVX.Text))
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                }
            }
        }

        private void btnThemX_Click(object sender, EventArgs e)
        {
            btnXoaX.Enabled = true;
            btnSuaX.Enabled = true;
            btnTkX.Enabled = true;
            btnChiTietPhieuX.Enabled = true;
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.ThemPhieuX(txtMaPX.Text, dateNN.Value, txtTongTienX.Text, cmMaKh.Text, cmMaNVX.Text))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                }
            }
        }

        private void cmMaKh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTkX_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MAPH_XH", "*" + txtTKX.Text + "*");
            (dataPX.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnChiTietPN_Click(object sender, EventArgs e)
        {
            FmChiTietNH fmChiTietNH = new FmChiTietNH();
            fmChiTietNH.Show();
        }

        private void btnChiTietPhieuX_Click(object sender, EventArgs e)
        {
            FmChiTietXH fmChiTietXH = new FmChiTietXH();
            fmChiTietXH.Show();
        }
    }
}
