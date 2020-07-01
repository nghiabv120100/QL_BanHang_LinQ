using QL_BanHang_LinQ.DB_Layer;
using QL_BanHang_LinQ.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang_LinQ.BS_Layer
{
    public static class BLL_TaiKhoan
    {
        public static bool CheckTaiKhoan(TaiKhoan tk)
        {
            
            return Query_DAL.KiemTraTaiKhoan(tk);
        }
    }
}
