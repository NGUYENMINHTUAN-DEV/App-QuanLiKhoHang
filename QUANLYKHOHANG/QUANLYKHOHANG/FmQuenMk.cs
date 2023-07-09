using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QUANLYKHOHANG
{
    public partial class FmQuenMk : Form
    {
        public FmQuenMk()
        {
            InitializeComponent();
            lbKq.Text = "";
        }
        Modify modify = new Modify();
        //public bool CheckEmail(string em)
        //{
        //    return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        //}
        private void btnLayLaiMk_Click(object sender, EventArgs e)
        {
           
            string Email = txtEmail.Text;
            
            if (Email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đăng kí:");
            }
            //if (!CheckEmail(Email))
            //{
            //    MessageBox.Show("Vui Lòng nhập Đúng định dạng Email ");
            //}
            else
            {
                string query = "select * from TAI_KHOAN where EMAIL = '" + Email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    lbKq.ForeColor = Color.Blue;
                    lbKq.Text = "Mật Khẩu: " + modify.TaiKhoans(query)[0].Matkhau;
                }
                else
                {
                    lbKq.ForeColor = Color.Red;
                    lbKq.Text = "Email này chưa được đăng kí!! ";
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!(new Regex(@"^[\w\.]+@([\w]+\.)+[\w]{2,4}$").IsMatch(txtEmail.Text)))
            {
                errorProvider1.SetError(txtEmail, "Định dạng email sai!");
                return;
            }
            this.errorProvider1.Clear();
        }
    }
}
