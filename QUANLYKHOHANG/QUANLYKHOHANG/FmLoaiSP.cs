using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHOHANG
{
    public partial class FmLoaiSP : Form
    {
        SQL dt = new SQL();
        public FmLoaiSP()
        {
            InitializeComponent();
        }

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            btnXoaLSP.Enabled = true;
            btnSuaLSP.Enabled = true;
            errorProvider1.SetError(txtMaLoai, "Bạn Chưa Nhập Mã Loại Sản Phẩm");
            errorProvider1.SetError(txtTenLoai, "Bạn Chưa Nhập Tên Loại Sản Phẩm");
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.ThemLSP(txtMaLoai.Text, txtTenLoai.Text))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
            }
        }
        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.XoaLSP(txtMaLoai.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
            }
        }

        private void btnSuaLSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.SuaLSP(txtMaLoai.Text, txtTenLoai.Text))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
            }
        }

        private void FmLoaiSP_Load(object sender, EventArgs e)
        {
            DataLSP.DataSource = dt.LoadLSP();
        }

        private void DataLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoai.Text = DataLSP.SelectedRows[0].Cells[0].Value.ToString();
            txtTenLoai.Text = DataLSP.SelectedRows[0].Cells[1].Value.ToString();
        }

      
    }
}
