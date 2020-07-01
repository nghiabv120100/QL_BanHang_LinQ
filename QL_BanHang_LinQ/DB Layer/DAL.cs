using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_BanHang_LinQ.DB_Layer
{
    public class DAL
    {
        public static string strConn = "Server =DESKTOP-QUOAKL7;Database=QL_BanHang;User Id=sa;pwd=123456";
        public static SqlConnection conn = null;
        public static void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public static void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
