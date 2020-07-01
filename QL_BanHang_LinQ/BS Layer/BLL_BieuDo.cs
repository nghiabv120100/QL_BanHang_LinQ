using QL_BanHang_LinQ.DB_Layer;
using QL_BanHang_LinQ.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang_LinQ.BS_Layer
{
    public class BLL_BieuDo
    {
        public static List<BieuDo> LaySoLieuBieuDo(DateTime dateStart,DateTime dateEnd )
        {

            string sql = "select LoaiHang.MaLoaiHang,LoaiHang.TenLoaiHang,sum(ChiTietHD.SoLuong) as SL," +
                         "Sum(Cast(ThanhTien as int)) as TT ," +
                         $"sum(Cast(ChiTietHD.SoLuong as float))/(select sum(SoLuong) from dbo.ChiTietHD,HoaDon where HoaDon.NgayBan <= '{dateEnd.ToString()}' and HoaDon.NgayBan >= '{dateStart.ToString()}' and ChiTietHD.MaHoaDon=HoaDon.MaHoaDon) as T, " +
                         $"sum(Cast(ChiTietHD.ThanhTien as float))/(select sum(Cast(ChiTietHD.ThanhTien as float)) from dbo.ChiTietHD ,HoaDon where HoaDon.NgayBan <= '{dateEnd.ToString()}' and HoaDon.NgayBan >= '{dateStart.ToString()}' and ChiTietHD.MaHoaDon=HoaDon.MaHoaDon) as PTTongTien  " +
                         "from dbo.HangHoa,dbo.LoaiHang,ChiTietHD,dbo.HoaDon " +
                         "where HangHoa.LoaiHang = LoaiHang.MaLoaiHang and ChiTietHD.MaHang = HangHoa.MaHang and HoaDon.MaHoaDon=ChiTietHD.MaHoaDon and " +
                         $"HoaDon.NgayBan <= '{dateEnd.ToString()}' and HoaDon.NgayBan >= '{dateStart.ToString()}'"+
                         "group by HangHoa.LoaiHang,LoaiHang.MaLoaiHang,LoaiHang.TenLoaiHang";
            return Query_DAL.LaySoLieuBieuDo(sql);
        }

    }
}
