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
        public static List<BieuDo> LaySoLieuBieuDo(DateTime dateStart, DateTime dateEnd)
        {
            return Query_DAL.LaySoLieuBieuDo(dateStart,dateEnd);
        }
    }
}
