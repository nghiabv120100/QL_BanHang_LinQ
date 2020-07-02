using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang_LinQ.DB_Layer;
using QL_BanHang_LinQ.DTO;


namespace QL_BanHang_LinQ.BS_Layer
{
    public class BLL_KhachHang
    {
        public static List<KhachHang> LayToanBoKhachHang()
        {
            return Query_DAL.LayToanBoKhachHang();
        }
        public static int InsertKhachHang(KhachHang KH)
        {
            if (CheckKeyKH(KH.MaKhachHang.Trim()))
                return 0;
            return Query_DAL.InsertKhachHang(KH);
        }
        private static bool CheckKeyKH(string MaKhachHang)
        {
            List<KhachHang> dsKH = LayToanBoKhachHang();
            foreach (KhachHang kh in dsKH)
            {
                if (kh.MaKhachHang == MaKhachHang)
                    return true;
            }
            return false;
        }
        public static int UpdateKhachHang(KhachHang kh)
        {
            return Query_DAL.UpdateKhachHang(kh);
        }
        public static int DeleteKhachHang(string MaKH)
        {
            return Query_DAL.DeleteKhachHang(MaKH);
        }
    }
}
