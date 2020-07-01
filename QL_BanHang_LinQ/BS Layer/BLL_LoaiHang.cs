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
            string sql = $"Delete from dbo.LoaiHang " +
                $"Where MaLoaiHang='{MaLoaiHang}'";
            return Query_DAL.DeleteData(sql);
        }
        
        public static int UpdateLoaiHang(LoaiHang LH)
        {
            string sql = $"Update dbo.LoaiHang " +
                $"set TenLoaiHang=N'{LH.TenLoaiHang}'" +               
                $"Where MaLoaiHang='{LH.MaLoaiHang}'";
            return Query_DAL.UpdateData(sql);
        }
        
    }
}
