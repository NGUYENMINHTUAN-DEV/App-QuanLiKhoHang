using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QUANLYKHOHANG
{
    public class KetNoi
    {
        public static SqlConnection con;
        public bool KTraKetNoi(string pTenMay, string pTenCSDL, string pUser, string pPass)
        {
            try
            {
                con = new SqlConnection("Data Source=" + pTenMay + ";Initial Catalog=" + pTenCSDL + "; User ID =" + pUser + ";Password=" + pPass + "");
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
