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

            string sql = "Insert into dbo.KhachHang(MaKhachHang,TenKhachHang, DiaChi,"
                + "DienThoai,GioiTinh,Email,NgaySinh,TongChiTieu)"
                + "Values"
                + $"('{KH.MaKhachHang}',N'{KH.TenKhachHang}',N'{KH.DiaChi}',"
                + $"'{KH.DienThoai}',N'{KH.GioiTinh}',N'{KH.Email}','{KH.NgaySinh}',{KH.TongChiTieu})";
            return Query_DAL.InsertData(sql);
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
            //string sql = $"Update dbo.KhachHang " +
            //    $"Set TenKhachHang=N'{kh.TenKhachHang}',DiaChi=N'{kh.DiaChi}'," +
            //    $"TongChiTieu={kh.TongChiTieu},DienThoai='{kh.DienThoai}',Email=N'{kh.Email}',NgaySinh='{kh.NgaySinh}'," +
            //    $"GioiTinh=N'{kh.GioiTinh}' " +
            //    $"Where MaKhachHang='{kh.MaKhachHang}'";
            return Query_DAL.UpdateKhachHang(kh);
        }
        public static int DeleteKhachHang(string MaKH)
        {
            string sql = "Delete from dbo.KhachHang " +
                $"Where MaKhachHang='{MaKH}'";
            return Query_DAL.DeleteData(sql);
        }
    }
}
