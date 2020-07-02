using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang_LinQ.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QL_BanHang_LinQ.DB_Layer;

namespace QL_BanHang_LinQ.BS_Layer
{
    public class BLL_HangHoa
    {
        public static List<HangHoa> LayToanBoHangHoa()
        {
            return Query_DAL.LayToanBoHangHoa();
        }
        public static DataTable FindHangHoa(HangHoa HH)
        {
            string sql = "SELECT * from dbo.HangHoa WHERE 1=1";
            if (HH.MaHang != "")
                sql += " AND MaHang LIKE '%" + HH.MaHang.Trim() + "%'";
            if (HH.TenHang != "")
                sql += " AND TenHang LIKE N'%" + HH.TenHang.Trim() + "%'";
            if (HH.LoaiHang != "")
                sql += " AND LoaiHang LIKE '%" + HH.LoaiHang.Trim() + "%'";
            return Query_DAL.GetDataToTable(sql);
        }
        public static int InsertHangHoa(HangHoa HH)
        {
            if (CheckKeyHH(HH.MaHang.Trim()))
                return 0;
            return Query_DAL.InsertHangHoa(HH);
        }
        private static bool CheckKeyHH(string MaHangHoa)
        {
            List<HangHoa> dsHH = LayToanBoHangHoa();
            foreach (HangHoa hh in dsHH)
            {
                if (hh.MaHang == MaHangHoa)
                    return true;
            }
            return false;
        }
        /*
  MaHang, TenHang, SoLuong,  DonGiaNhap, DonGiaBan,  Anh , 
  GhiChu ,ThoiGianBaoHanh, XuatXu , LoaiHang 
         */
        public static int UpdateHangHoa(HangHoa HH)
        {           
            return Query_DAL.UpdateHangHoa(HH);
        }
        public static int DeleteHangHoa(string MaHH)
        {
            return Query_DAL.DeleteHangHoa(MaHH);
        }
    }
}

