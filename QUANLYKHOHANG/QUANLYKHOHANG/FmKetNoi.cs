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
    public partial class FmKetNoi : Form
    {
        public FmKetNoi()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btn_ketnoi_Click(object sender, EventArgs e)
        {

            if (txt_tenmay.Text == string.Empty || txt_tencsdl.Text == string.Empty || txt_user.Text == string.Empty || txt_pass.Text == string.Empty)
            {
                MessageBox.Show("Mời nhập thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            if (kn.KTraKetNoi(txt_tenmay.Text, txt_tencsdl.Text, txt_user.Text, txt_pass.Text))
            {
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK);
                FmDangNhap fm = new FmDangNhap();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ketnoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ketnoi.PerformClick();
        }

        private void FmKetNoi_Load(object sender, EventArgs e)
        {

        }

        private void FmKetNoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
