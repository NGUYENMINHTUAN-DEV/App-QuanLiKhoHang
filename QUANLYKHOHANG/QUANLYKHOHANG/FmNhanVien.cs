using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYKHOHANG
{
    public partial class FmNhanVien : Form
    {
       
        SQL dt = new SQL();
        public FmNhanVien()
        {
            InitializeComponent();
        }

        


        private void FmNhanVien_Load(object sender, EventArgs e)
        {
            //string stringconn = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
            //SqlConnection sqlconn = new SqlConnection(stringconn);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "danhsachnhanvien";
            //cmd.Connection = sqlconn;
            //sda.SelectCommand = cmd;
            //DataTable da = new DataTable();
            //sda.Fill(da);
            //DataNhanVien.DataSource = da;
            DataNhanVien.DataSource = dt.LoadNV();
        }

        private void DataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNv.Text = DataNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNv.Text = DataNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txtMailNv.Text = DataNhanVien.SelectedRows[0].Cells[2].Value.ToString();
            dateNv.Text = DataNhanVien.SelectedRows[0].Cells[3].Value.ToString();
           cmGtNv.SelectedItem = DataNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            txtDtNv.Text = DataNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            txtCvNv.Text = DataNhanVien.SelectedRows[0].Cells[6].Value.ToString();
            txtDiaChiNv.Text = DataNhanVien.SelectedRows[0].Cells[7].Value.ToString();
            txtLuongNv.Text = DataNhanVien.SelectedRows[0].Cells[8].Value.ToString();
            cmBp.SelectedItem = DataNhanVien.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void txtMaNv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            this.errorProvider1.Clear();
        }

        private void txtMailNv_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[\w\.]+@([\w]+\.)+[\w]{2,4}$").IsMatch(txtMailNv.Text)))
            {
                errorProvider1.SetError(txtMailNv, "Định dạng email sai!");
                return;
            }
            this.errorProvider1.Clear();
        }

        private void txtDtNv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MANV", "*" + txtTimKiem.Text + "*");
            (DataNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dt.XoaNV(txtMaNv.Text))
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
            }
        }

        

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoaNV.Enabled = true;
            btnTimKiem.Enabled = true;
            //errorProvider1.SetError(txtMaNv, "Bạn Chưa Nhập Mã Nhân Viên");
            //errorProvider1.SetError(txtTenNv, "Bạn Chưa Nhập Tên Nhân Viên");
            //errorProvider1.SetError(txtMailNv, "Bạn Chưa Nhập Email ");
            //errorProvider1.SetError(cmGtNv, "Bạn Chưa Chọn Giới Tính Nhân Viên");
            //errorProvider1.SetError(txtDtNv, "Bạn Chưa Nhập Số Điện Thoại");
            //errorProvider1.SetError(txtCvNv, "Bạn Chưa Nhập Chức Vụ");
            //errorProvider1.SetError(txtDiaChiNv, "Bạn Chưa Nhập Địa Chỉ");
            //errorProvider1.SetError(txtLuongNv, "Bạn Chưa Nhập Lương");
            //errorProvider1.SetError(cmBp, "Bạn Chưa Chọn Bộ Phận");
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.ThemNV(txtMaNv.Text, txtTenNv.Text, txtMailNv.Text, dateNv.Value, cmGtNv.Text, txtDtNv.Text, txtCvNv.Text, txtDiaChiNv.Text, txtLuongNv.Text, cmBp.Text))
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.XoaNV(txtMaNv.Text))
                {
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.SuaNV(txtMaNv.Text, txtTenNv.Text, txtMailNv.Text, dateNv.Value, cmGtNv.Text, txtDtNv.Text, txtCvNv.Text, txtDiaChiNv.Text, txtLuongNv.Text, cmBp.Text))
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                }
            }
        }
    }
}

      

