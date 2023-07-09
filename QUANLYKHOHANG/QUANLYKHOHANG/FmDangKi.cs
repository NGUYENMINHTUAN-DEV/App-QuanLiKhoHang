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
using System.Net.Mail;
using System.Net;

namespace QUANLYKHOHANG
{
    public partial class FmDangKi : Form
    {
        Random random = new Random();
        int otp;
        public FmDangKi()
        {
            InitializeComponent();
        }
        public bool CheckAcount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string tentk = txtTk.Text;
            string matkhau = txtMk.Text;
            string xacnhanmk = txtXnMk.Text;
            string Email = txtEmail.Text;
            string Quyen = cmQuyen.Text;
            if (otp.ToString().Equals(txtMaOTP.Text))
            {
                MessageBox.Show("Xác minh mã thành công");
            }
            else
                MessageBox.Show("Xác minh mã không thành công");
            if (!CheckAcount(tentk))
            {
                MessageBox.Show("Vui Lòng nhập tên tài khoản dài 6-24 ký tự ");
            }
            if (!CheckAcount(matkhau))
            {
                MessageBox.Show("Vui Lòng nhập tên mật khẩu dài 6-24 ký tự ");
            }
            if (xacnhanmk != matkhau)
            {
                MessageBox.Show("Vui Lòng nhập mật khẩu chính xác ");
                return;
            }
            if (!CheckEmail(Email))
            {
                MessageBox.Show("Vui Lòng nhập Đúng định dạng Email ");
                return;
            }
            if (modify.TaiKhoans("select * from TAI_KHOAN where EMAIL = '" + Email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký vui lòng đăng kí Email khác");
                return;
            }
            try
            {
                string query = "Insert into TAI_KHOAN values ('" + tentk + "','" + matkhau + "','" + Email + "','" + Quyen+ "')";
                   modify.Commnand(query);
                }
            catch
            {
                MessageBox.Show("Tên Tài Khoản này đã được đăng ký, vui lòng đăng ký tài khoản khác");
            }
        }

        private void btnMaOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);
                var fromAddress = new MailAddress("khohangquanli@gmail.com");//gmail gửi mã otp
                var toAddress = new MailAddress(txtEmail.ToString());//mail nhận mã otp
                const string frompass = "hiexrlydznvqqkui";
                const string subject = "OTP code";
                string body = otp.ToString();
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 20000

                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("OTP đã được gửi qua mail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
