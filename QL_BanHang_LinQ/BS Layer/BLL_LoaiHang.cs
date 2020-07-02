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
    public class BLL_LoaiHang
    {
        public static List<LoaiHang> LayToanBoLoaiHang()
        {
            return Query_DAL.LayToanBoLoaiHang();
        }
        private static bool checkKey(LoaiHang LH)
        {
            List<LoaiHang> dsLH= Query_DAL.LayToanBoLoaiHang();
            foreach(LoaiHang item in dsLH)
            {
                if (item.MaLoaiHang.Trim() == LH.MaLoaiHang.Trim())
                    return true;
            }
            return false;
        }
        public static int InsertLoaiHang(LoaiHang LH)
        {
            if (checkKey(LH) == true)
                return 0;
            string sql = "Insert into dbo.LoaiHang(MaLoaiHang,TenLoaiHang)"
                + "Values"
                + $"('{LH.MaLoaiHang}',N'{LH.TenLoaiHang}')";
            return Query_DAL.InsertData(sql);
        }
        public static int DeleteLoaiHang(string MaLoaiHang)
        {
            return Query_DAL.DeleteLoaiHang(MaLoaiHang);
        }
        
        public static int UpdateLoaiHang(LoaiHang LH)
        {
            return Query_DAL.UpdateLoaiHang(LH);
        }
        
    }
}
