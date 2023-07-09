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
    public partial class FmNCC : Form
    {
        SQL dt = new SQL();
        public FmNCC()
        {
            InitializeComponent();
        }

      
        private void FmNCC_Load(object sender, EventArgs e)
        {
            //string stringconn = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
            //SqlConnection sqlconn = new SqlConnection(stringconn);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "danhsachnhacungcap";
            //cmd.Connection = sqlconn;
            //sda.SelectCommand = cmd;
            //DataTable da = new DataTable();
            //////sda.Fill(da);
            //DataNCC.DataSource = da;
            DataNCC.DataSource = dt.LoadNCC();
        }

        private void DataNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = DataNCC.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNCC.Text = DataNCC.SelectedRows[0].Cells[1].Value.ToString();
            txtDcNCC.Text = DataNCC.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            btnSuaNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
            errorProvider1.SetError(txtMaNCC, "Bạn Chưa Nhập Mã Nhà Cung Cấp");
            errorProvider1.SetError(txtTenNCC, "Bạn Chưa Nhập Tên Nhà Cung Cấp");
            errorProvider1.SetError(txtDcNCC, "Bạn Chưa Nhập Địa Chỉ Nhà Cung Cấp");
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.ThemNCC(txtMaNCC.Text, txtTenNCC.Text, txtDcNCC.Text))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.XoaNCC(txtMaNCC.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (dt.SuaNCC(txtMaNCC.Text, txtTenNCC.Text, txtDcNCC.Text))
                {
                    MessageBox.Show("Sửa Thành Công");
                }
            }
        }
    }
}
