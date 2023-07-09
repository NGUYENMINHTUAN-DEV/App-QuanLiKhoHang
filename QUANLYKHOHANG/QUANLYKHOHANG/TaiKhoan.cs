using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHOHANG
{
    class TaiKhoan
    {
        private string tentaikhoan;
        private string matkhau;
        public TaiKhoan()
            {

            }
        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }

}
