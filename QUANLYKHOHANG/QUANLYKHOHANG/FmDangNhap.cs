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
    public partial class FmDangNhap : Form
    {
        public FmDangNhap()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
       
        private void btnQuenMk_Click(object sender, EventArgs e)
        {
            FmQuenMk fmQuenMk = new FmQuenMk();
            fmQuenMk.Show();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            FmDangKi fmDangKi = new FmDangKi();
            fmDangKi.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            if (txtTk.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (txtMk.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu!");
            }
            else
            {
                SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
                SqlDataAdapter sql = new SqlDataAdapter("select * from TAI_KHOAN where TK = '" + txtTk.Text + "' and MK = '" + txtMk.Text + "'", _cnn);
               
                    DataTable dt = new DataTable();
                sql.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][3].ToString() == "Admin     ")
                    {
                        FmMenuAdmin fmAdmin = new FmMenuAdmin(dt.Rows[0][3].ToString());
                        fmAdmin.Show();
                    }
                    else if (dt.Rows[0][3].ToString() == "User      ")
                    {
                        FmMenuUser fmUser = new FmMenuUser(dt.Rows[0][3].ToString());
                        fmUser.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên Tài khoản hoặc mật khẩu không chính xác hoặc phải nhập đầy đủ", "Thông Báo");
                }
            }
        }

        private void chHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(chHienthi.Checked)
            {
                txtMk.UseSystemPasswordChar = false;
            }
            if (!chHienthi.Checked)
            {
                txtMk.UseSystemPasswordChar = true;
            }
        }
    }
}
