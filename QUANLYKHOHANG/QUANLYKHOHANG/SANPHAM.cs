using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHOHANG
{
     class SANPHAM
    {
        private string masp;
        private string mancc;
        private string TenSp;
        private DateTime NgaySX;
        private DateTime HSD;
        private string SoLuong;
        private string MaLSp;
        private string gia;
        private string ghichu;
        private string makho;
        private byte[] anh;

        public SANPHAM(string masp, string mancc, string tenSp, DateTime ngaySX, DateTime hSD, string soLuong, string maLSp, string gia, string ghichu, string makho, byte[] anh)
        {
            this.masp = masp;
            this.mancc = mancc;
            TenSp = tenSp;
            NgaySX = ngaySX;
            HSD = hSD;
            SoLuong = soLuong;
            MaLSp = maLSp;
            this.gia = gia;
            this.ghichu = ghichu;
            this.makho = makho;
            this.anh = anh;
        }

        public string Masp { get => masp; set => masp = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string TenSp1 { get => TenSp; set => TenSp = value; }
        public DateTime NgaySX1 { get => NgaySX; set => NgaySX = value; }
        public DateTime HSD1 { get => HSD; set => HSD = value; }
        public string SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string MaLSp1 { get => MaLSp; set => MaLSp = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Makho { get => makho; set => makho = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
