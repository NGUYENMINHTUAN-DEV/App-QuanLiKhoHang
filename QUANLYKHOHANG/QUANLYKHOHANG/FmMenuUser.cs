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
    public partial class FmMenuUser : Form
    {
        public FmMenuUser()
        {
            InitializeComponent();
        }
        public FmMenuUser(string quyen)
        {
            InitializeComponent();
            lbQuyen.Text = quyen;
        }
       
        private void FmMenuUser_Load(object sender, EventArgs e)
        {

        }

        private void picKH_Click(object sender, EventArgs e)
        {
            FmKhachHang fmKhachHang = new FmKhachHang();
            fmKhachHang.Show();
        }

        private void picNCC_Click(object sender, EventArgs e)
        {
            FmNCC fmNCC = new FmNCC();
            fmNCC.Show();
        }

        private void pciSanPham_Click(object sender, EventArgs e)
        {
            FmSanPham fmSanPham = new FmSanPham();
            fmSanPham.Show();
        }

        private void picLSP_Click(object sender, EventArgs e)
        {
            FmLoaiSP fmLoaiSP = new FmLoaiSP();
            fmLoaiSP.Show();
        }

        private void picPhieu_Click(object sender, EventArgs e)
        {
            FmPhieu fmPhieu = new FmPhieu();
            fmPhieu.Show();
        }

        private void picKho_Click(object sender, EventArgs e)
        {
            FmKhoHang fmKhoHang = new FmKhoHang();
            fmKhoHang.Show();
        }

        private void picChiTietN_Click(object sender, EventArgs e)
        {
            FmChiTietPhieuNhap fmChiTietPhieuNhap = new FmChiTietPhieuNhap();
            fmChiTietPhieuNhap.Show();
        }

        private void picChiTietX_Click(object sender, EventArgs e)
        {
            FmChiTietPhieuXuat fmChiTietPhieuXuat = new FmChiTietPhieuXuat();
            fmChiTietPhieuXuat.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmKhachHang fmKhachHang = new FmKhachHang();
            fmKhachHang.Show();
        }

        private void nhàCungCapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmNCC fmNCC = new FmNCC();
            fmNCC.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmSanPham fmSanPham = new FmSanPham();
            fmSanPham.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmKhoHang fmKhoHang = new FmKhoHang();
            fmKhoHang.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmPhieu fmPhieu = new FmPhieu();
            fmPhieu.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmLoaiSP fmLoaiSP = new FmLoaiSP();
            fmLoaiSP.Show();
        }

        private void phiếunhapToolMenuitem_Click(object sender, EventArgs e)
        {
            FmChiTietNH fmChiTietNH = new FmChiTietNH();
            fmChiTietNH.Show();
        }

        private void phiếuxuatToolMenuitem_Click(object sender, EventArgs e)
        {
            FmChiTietXH fmChiTietXH = new FmChiTietXH();
            fmChiTietXH.Show();
        }
    }
}
