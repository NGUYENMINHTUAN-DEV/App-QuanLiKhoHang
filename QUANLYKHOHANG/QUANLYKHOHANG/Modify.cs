using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace QUANLYKHOHANG
{
    class Modify
    {
        public Modify()
        {

        }
        SqlDataAdapter data;
        SqlCommand cmd;
        SqlDataReader dataReader;
        public DataTable DataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = SQL.GetSqlConnection())
            {
                sqlConnection.Open();
                data = new SqlDataAdapter(query, sqlConnection);
                data.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        [Obsolete]
        public void Command(SANPHAM sanpham, string query)
           {
            using (SqlConnection sqlConnection = SQL.GetSqlConnection())
            {
                
                sqlConnection.Open();
               cmd= new SqlCommand(query,sqlConnection);
                cmd.Parameters.Add("@MA_SP", sanpham.Masp);
                cmd.Parameters.Add("@MA_NCC", sanpham.Mancc);
                cmd.Parameters.Add("@TEN_SP", sanpham.TenSp1);
                cmd.Parameters.Add("@NGAYSX", sanpham.NgaySX1);
                cmd.Parameters.Add("@HSD", sanpham.HSD1);
                cmd.Parameters.Add("@SOLUONG_SP", sanpham.SoLuong1);
                cmd.Parameters.Add("@MALOAI", sanpham.MaLSp1);
                cmd.Parameters.Add("@GIA", sanpham.Gia);
                cmd.Parameters.Add("@GHICHU_SP", sanpham.Ghichu);
                cmd.Parameters.Add("@MAKHO", sanpham.Makho);
                cmd.Parameters.Add("@ANH", sanpham.Anh);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
           }
        
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = SQL.GetSqlConnection())
            {
               sqlConnection.Open();
                cmd=new SqlCommand(query, sqlConnection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read()) 
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Commnand(string query) 
        {
            using (SqlConnection sqlConnection = SQL.GetSqlConnection())
            {
                sqlConnection.Open();
                cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();//thực thi
                sqlConnection.Close();
            }
        }
    }
}
