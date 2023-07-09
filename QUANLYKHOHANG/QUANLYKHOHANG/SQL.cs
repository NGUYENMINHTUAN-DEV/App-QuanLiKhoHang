using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using DataTable = System.Data.DataTable;

namespace QUANLYKHOHANG
{
    public class SQL
    {
        private static string _cnn = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
     
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_cnn);
        }
        DataSet ds_QLKHOHANG = new DataSet();
        SqlDataAdapter da_KH;
        SqlDataAdapter da_NV;
        SqlCommand cmd;
        SqlDataAdapter da_KHO;
        SqlDataAdapter da_NCC;
        SqlDataAdapter da_SP;
        SqlDataAdapter da_PN;
        SqlDataAdapter da_PX;
        SqlDataAdapter da_LSP;
        SqlDataAdapter da_CTPX;
        SqlDataAdapter da_CTPN;
        public SQL()
        {

        }
        
        public DataTable LoadKH()
        {
            string CauLenh = "select * from KHACH_HANG";
            da_NV = new SqlDataAdapter(CauLenh, _cnn);
            da_NV.Fill(ds_QLKHOHANG, "KHACH_HANG");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["KHACH_HANG"].Columns[0];
            ds_QLKHOHANG.Tables["KHACH_HANG"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["KHACH_HANG"];
        }
        public bool ThemKH(string makh, string tenkh, string diachikh, string gt,string sdt, string email, string fax)
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["KHACH_HANG"].NewRow();
                them[0] = makh;
                them[1] = tenkh;
                them[2] = diachikh;
                them[3] = gt;
                them[4] = sdt;
                them[5] = email;
                them[6] = fax;
               
                ds_QLKHOHANG.Tables["KHACH_HANG"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_NV);

                da_NV.Update(ds_QLKHOHANG,"KHACH_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaKH(string makh)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["KHACH_HANG"].Rows.Find(makh);
                if(xoa !=null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder (da_NV);
                da_NV.Update(ds_QLKHOHANG, "KHACH_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaKH(string makh, string tenkh, string diachikh, string gt, string sdt, string email, string fax)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["KHACH_HANG"].Rows.Find(makh);
                if (Sua != null)
                {
                    Sua[0] = makh;
                    Sua[1] = tenkh;
                    Sua[2] = diachikh;
                    Sua[3] = gt;
                    Sua[4] = sdt;
                    Sua[5] = email;
                    Sua[6] = fax;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_NV);
                da_NV.Update(ds_QLKHOHANG, "KHACH_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }


       /// <summary>
       /// Load Nhân Viên
       /// </summary>
       /// <returns></returns>
        public DataTable LoadNV()
        {
            string CauLenh = "select * from NHAN_VIEN";
            da_NV = new SqlDataAdapter(CauLenh, _cnn);
            da_NV.Fill(ds_QLKHOHANG, "NHAN_VIEN");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["NHAN_VIEN"].Columns[0];
            ds_QLKHOHANG.Tables["NHAN_VIEN"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["NHAN_VIEN"];
        }
        public bool ThemNV(string manv, string tennv, string email,DateTime ngaysinh, string gt, string sdt, string chucvu,string diachi,string luong,string bophan)
        {
            
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["NHAN_VIEN"].NewRow();
                them[0] = manv;
                them[1] = tennv;
                them[2] = email;
                them[3] = ngaysinh;
                them[4] = gt;
                them[5] = sdt;
                them[6] = chucvu;
                them[7] = diachi;
                them[8] = luong;
                them[9] = bophan;
                ds_QLKHOHANG.Tables["NHAN_VIEN"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_NV);

                da_NV.Update(ds_QLKHOHANG, "NHAN_VIEN");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaNV(string manv)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["NHAN_VIEN"].Rows.Find(manv);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_NV);
                da_NV.Update(ds_QLKHOHANG, "NHAN_VIEN");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaNV(string manv, string tennv, string email, DateTime ngaysinh, string gt, string sdt, string chucvu, string diachi, string luong, string bophan)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["NHAN_VIEN"].Rows.Find(manv);
                if (Sua != null)
                {
                    Sua[0] = manv;
                    Sua[1] = tennv;
                    Sua[2] = email;
                    Sua[3] = ngaysinh;
                    Sua[4] = gt;
                    Sua[5] = sdt;
                    Sua[6] = chucvu;
                    Sua[7] = diachi;
                    Sua[8] = luong;
                    Sua[9] = bophan;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_NV);
                da_NV.Update(ds_QLKHOHANG, "NHAN_VIEN");
                return true;
            }
            catch
            {
                return false;
            }
        }

       

        /// <summary>
        /// From KHO HÀNG
        /// </summary>
        /// <returns></returns>
        public DataTable LoadKHO()
        {
            string CauLenh = "select * from KHO_HANG";
            da_KHO = new SqlDataAdapter(CauLenh, _cnn);
            da_KHO.Fill(ds_QLKHOHANG, "KHO_HANG");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["KHO_HANG"].Columns[0];
            ds_QLKHOHANG.Tables["KHO_HANG"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["KHO_HANG"];
        }
        public bool ThemKHO(string makho,string tenkho,string diachi,string ghichu )
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["KHO_HANG"].NewRow();
                them[0] = makho;
                them[1] = tenkho;
                them[2] = diachi;
                them[3] = ghichu;
                ds_QLKHOHANG.Tables["KHO_HANG"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_KHO);

                da_KHO.Update(ds_QLKHOHANG, "KHO_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaKHO(string makho)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["KHO_HANG"].Rows.Find(makho);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_KHO);
                da_KHO.Update(ds_QLKHOHANG, "KHO_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaKHO(string makho, string tenkho, string diachi, string ghichu)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["KHO_HANG"].Rows.Find(makho);
                if (Sua != null)
                {
                    Sua[0] = makho;
                    Sua[1] = tenkho;
                    Sua[2] = diachi;
                    Sua[3] = ghichu;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_KHO);
                da_KHO.Update(ds_QLKHOHANG, "KHO_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// From Nhà Cung Cấp
        /// </summary>
        /// <returns></returns>
        public DataTable LoadNCC()
        {
            string CauLenh = "select * from NHA_CUNG_CAP";
            da_NCC = new SqlDataAdapter(CauLenh, _cnn);
            da_NCC.Fill(ds_QLKHOHANG, "NHA_CUNG_CAP");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["NHA_CUNG_CAP"].Columns[0];
            ds_QLKHOHANG.Tables["NHA_CUNG_CAP"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["NHA_CUNG_CAP"];
        }
        public bool ThemNCC(string mancc, string tenncc, string diachi)
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["NHA_CUNG_CAP"].NewRow();
                them[0] = mancc;
                them[1] = tenncc;
                them[2] = diachi;
               
                ds_QLKHOHANG.Tables["NHA_CUNG_CAP"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_NCC);

                da_NCC.Update(ds_QLKHOHANG, "NHA_CUNG_CAP");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaNCC(string makho)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["NHA_CUNG_CAP"].Rows.Find(makho);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_NCC);
                da_NCC.Update(ds_QLKHOHANG, "NHA_CUNG_CAP");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaNCC(string mancc, string tenncc, string diachi)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["NHA_CUNG_CAP"].Rows.Find(mancc);
                if (Sua != null)
                {
                    Sua[0] = mancc;
                    Sua[1] = tenncc;
                    Sua[2] = diachi;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_NCC);
                da_NCC.Update(ds_QLKHOHANG, "NHA_CUNG_CAP");
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// From Sản Phẩm
        /// </summary>
        /// <returns></returns>
        public DataTable LoadSP()
        {
            string CauLenh = "select * from SAN_PHAM";
            da_SP = new SqlDataAdapter(CauLenh, _cnn);
            da_SP.Fill(ds_QLKHOHANG, "SAN_PHAM");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["SAN_PHAM"].Columns[0];
            ds_QLKHOHANG.Tables["SAN_PHAM"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["SAN_PHAM"];
        }
       
       
      
        public bool SuaSP(string manSP, string mancc, string tensp, string danhmuc, DateTime ngaysinh, DateTime hsd, string sl, string pl, string gia, string ghichu,Image anh)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["SAN_PHAM"].Rows.Find(manSP);
                if (Sua != null)
                {
                    Sua[0] = manSP;
                    Sua[1] = mancc;
                    Sua[2] = tensp;
                    Sua[3] = danhmuc;
                    Sua[4] = ngaysinh;
                    Sua[5] = hsd;
                    Sua[6] = sl;
                    Sua[7] = pl;
                    Sua[8] = gia;
                    Sua[9] = ghichu;
                    Sua[10]= anh;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_SP);
                da_SP.Update(ds_QLKHOHANG, "SAN_PHAM");
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Form Phiếu
        /// </summary>
        /// <returns></returns>
        public DataTable LoadPhieu()
        {

            string CauLenh = "select * from PHIEU_NHAP_HANG";
            da_PN = new SqlDataAdapter(CauLenh, _cnn);
            da_PN.Fill(ds_QLKHOHANG, "PHIEU_NHAP_HANG");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"].Columns[0];
            ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"];
        }
        public DataTable LoadPhieuX()
        {
            string CauLenh = "select * from PHIEU_XUAT_HANG";
            da_PX = new SqlDataAdapter(CauLenh, _cnn);
            da_PX.Fill(ds_QLKHOHANG, "PHIEU_XUAT_HANG");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"].Columns[0];
            ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"];
        }
        public bool ThemPhieu(string mapn,DateTime ngaynh,string tongtien,string manv)
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"].NewRow();
                them[0] = mapn;
                them[1] = ngaynh;
                them[2] = tongtien;
                them[3] = manv;

                ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_PN);

                da_PN.Update(ds_QLKHOHANG, "PHIEU_NHAP_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemPhieuX(string mapx,DateTime ngayxh,string tongtien,string makh,string manv)
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"].NewRow();
                them[0] = mapx;
                them[1] = ngayxh;
                them[2] = tongtien;
                them[3] = makh;
                them[4] = manv;
                ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_PX);

                da_PX.Update(ds_QLKHOHANG, "PHIEU_XUAT_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaPhieuN(string mapn, DateTime ngaynh, string tongtien, string manv)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"].Rows.Find(mapn);
                if (Sua != null)
                {
                    Sua[0] = mapn;
                    Sua[1] = ngaynh;
                    Sua[2] = tongtien;
                    Sua[3] = manv;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_PN);
                da_PN.Update(ds_QLKHOHANG, "PHIEU_NHAP_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhieuN(string mapn)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["PHIEU_NHAP_HANG"].Rows.Find(mapn);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_PN);
                da_PN.Update(ds_QLKHOHANG, "PHIEU_NHAP_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool SuaPhieuX(string mapx, DateTime ngayxh,string tongtien, string makh, string manv)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"].Rows.Find(mapx);
                if (Sua != null)
                {
                    Sua[0] = mapx;
                    Sua[1] = ngayxh;
                    Sua[2] = tongtien;
                    Sua[3] = makh;
                    Sua[4] = manv;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_PX);
                da_PX.Update(ds_QLKHOHANG, "PHIEU_XUAT_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhieuX(string mapx)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["PHIEU_XUAT_HANG"].Rows.Find(mapx);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_PX);
                da_PX.Update(ds_QLKHOHANG, "PHIEU_XUAT_HANG");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadMAPHIEUN()
        {
            SqlDataAdapter da_MAPHIEUN = new SqlDataAdapter("select * from CHITIET_NH ", _cnn);
            DataTable dt_MAPHIEUN = new DataTable();
            da_MAPHIEUN.Fill(dt_MAPHIEUN);
            return dt_MAPHIEUN;
        }
        public DataTable LoadMAPHIEUX()
        {
            SqlDataAdapter da_MAPHIEUX = new SqlDataAdapter("select * from CHITIET_XH ", _cnn);
            DataTable dt_MAPHIEUX = new DataTable();
            da_MAPHIEUX.Fill(dt_MAPHIEUX);
            return dt_MAPHIEUX;
        }
        public DataTable LoadChiTietPhieuNhap(string Pmapn)
        {
            //string stringconn = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
            //SqlConnection sqlconn = new SqlConnection(stringconn);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "TIENPN";
            //cmd.Connection = sqlconn;
            //sda.SelectCommand = cmd;
            //DataTable da = new DataTable();
            //sda.Fill(da);
            //return da;
            SqlDataAdapter da_CTPN = new SqlDataAdapter("select * from CHITIET_NH where MAPHIEU_NH= '" + Pmapn + "'", _cnn);
            DataTable dt_CTPN = new DataTable();
            da_CTPN.Fill(dt_CTPN);
            return dt_CTPN;
        }
        public DataTable LoadChiTietPhieuXuat(string Pmapx)
        {
            //string stringconn = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
            //SqlConnection sqlconn = new SqlConnection(stringconn);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "TIENPX";
            //cmd.Connection = sqlconn;
            //sda.SelectCommand = cmd;
            //DataTable da = new DataTable();
            //sda.Fill(da);
            //return da;
            SqlDataAdapter da_CTPX = new SqlDataAdapter("select * from CHITIET_XH where MAPH_XH= '" + Pmapx + "'", _cnn);
            DataTable dt_CTPX = new DataTable();
            da_CTPX.Fill(dt_CTPX);
            return dt_CTPX;
        }
        public DataTable LoadLSP()
        {
            string CauLenh = "select * from LOAISP";
            da_LSP = new SqlDataAdapter(CauLenh, _cnn);
            da_LSP.Fill(ds_QLKHOHANG, "LOAISP");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLKHOHANG.Tables["LOAISP"].Columns[0];
            ds_QLKHOHANG.Tables["LOAISP"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["LOAISP"];
        }
        public bool ThemLSP(string malsp, string tennlsp)
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["LOAISP"].NewRow();
                them[0] = malsp;
                them[1] = tennlsp;
                ds_QLKHOHANG.Tables["LOAISP"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_LSP);

                da_LSP.Update(ds_QLKHOHANG, "LOAISP");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaLSP(string makho)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["LOAISP"].Rows.Find(makho);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_LSP);
                da_LSP.Update(ds_QLKHOHANG, "LOAISP");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaLSP(string malsp, string tennlsp)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["LOAISP"].Rows.Find(malsp);
                if (Sua != null)
                {
                    Sua[0] = malsp;
                    Sua[1] = tennlsp;
               
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_LSP);
                da_LSP.Update(ds_QLKHOHANG, "LOAISP");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadLCHITIETNH()
        {
            string CauLenh = "select * from CHITIET_NH";
            da_CTPN = new SqlDataAdapter(CauLenh, _cnn);
            da_CTPN.Fill(ds_QLKHOHANG, "CHITIET_NH");
            DataColumn[] keys = new DataColumn[1];
            //keys[0] = ds_QLKHOHANG.Tables["CHITIET_NH"].Columns[0];
            //ds_QLKHOHANG.Tables["CHITIET_NH"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["CHITIET_NH"];
        }
        public bool ThemCTPN(string pn, string tmasp,string soluong)
        {
            try
            {
                DataRow them = ds_QLKHOHANG.Tables["CHITIET_NH"].NewRow();
                them[0] = pn;
                them[1] = tmasp;
                them[2] = soluong;
                ds_QLKHOHANG.Tables["CHITIET_NH"].Rows.Add(them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_CTPN);

                da_CTPN.Update(ds_QLKHOHANG, "CHITIET_NH");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaCTPN(string pn)
        {
            try
            {
                DataRow xoa = ds_QLKHOHANG.Tables["CHITIET_NH"].Rows.Find(pn);
                if (xoa != null)
                {
                    xoa.Delete();
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_CTPN);
                da_CTPN.Update(ds_QLKHOHANG, "CHITIET_NH");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaCTPN(string pn, string tmasp, string soluong)
        {
            try
            {
                DataRow Sua = ds_QLKHOHANG.Tables["CHITIET_NH"].Rows.Find(pn);
                if (Sua != null)
                {
                    Sua[0] = pn;
                    Sua[1] = tmasp;
                    Sua[2] = soluong;
                }
                SqlCommandBuilder build = new SqlCommandBuilder(da_CTPN);
                da_CTPN.Update(ds_QLKHOHANG, "CHITIET_NH");
                return true;
            }
            catch
            {
                return false;
            }
        }
        ///chi tiết phiếu xuất hàng
        ///
             public DataTable LoadLCHITIETXH()
        {
            string CauLenh = "select * from CHITIET_XH";
        da_CTPX = new SqlDataAdapter(CauLenh, _cnn);
            da_CTPX.Fill(ds_QLKHOHANG, "CHITIET_XH");
            DataColumn[] keys = new DataColumn[1];
        keys[0] = ds_QLKHOHANG.Tables["CHITIET_XH"].Columns[0];
            ds_QLKHOHANG.Tables["CHITIET_XH"].PrimaryKey = keys;
            return ds_QLKHOHANG.Tables["CHITIET_XH"];
        }
    public bool ThemCTPX(string pn, string tmasp, string soluong)
    {
        try
        {
            DataRow them = ds_QLKHOHANG.Tables["CHITIET_XH"].NewRow();
            them[0] = pn;
            them[1] = tmasp;
            them[2] = soluong;
            ds_QLKHOHANG.Tables["CHITIET_XH"].Rows.Add(them);

            SqlCommandBuilder build = new SqlCommandBuilder(da_CTPX);

                da_CTPX.Update(ds_QLKHOHANG, "CHITIET_XH");
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool XoaCTPX(string pn)
    {
        try
        {
            DataRow xoa = ds_QLKHOHANG.Tables["CHITIET_XH"].Rows.Find(pn);
            if (xoa != null)
            {
                xoa.Delete();
            }
            SqlCommandBuilder build = new SqlCommandBuilder(da_CTPX);
                da_CTPX.Update(ds_QLKHOHANG, "CHITIET_XH");
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool SuaCTPX(string pn, string tmasp, string soluong)
    {
        try
        {
            DataRow Sua = ds_QLKHOHANG.Tables["CHITIET_XH"].Rows.Find(pn);
            if (Sua != null)
            {
                Sua[0] = pn;
                Sua[1] = tmasp;
                Sua[2] = soluong;
            }
            SqlCommandBuilder build = new SqlCommandBuilder(da_CTPX);
                da_CTPX.Update(ds_QLKHOHANG, "CHITIET_XH");
            return true;
        }
        catch
        {
            return false;
        }
    }
}
}
