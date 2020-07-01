using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang_LinQ.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_BanHang_LinQ.DB_Layer
{
    public class Query_DAL:DAL
    {
        public static bool KiemTraTaiKhoan(TaiKhoan tk)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            List<TaiKhoan> dsTK = context.TaiKhoans.ToList();
            foreach(TaiKhoan x in dsTK)
            {
                if (x.TenDangNhap == tk.TenDangNhap.Trim() && x.MatKhau == tk.MatKhau.Trim())
                    return true;
            }
            return false;    
            
        }
        public static List<BieuDo> LaySoLieuBieuDo(string sql)
        {
            try
            {
                List<BieuDo> dsSL = new List<BieuDo>();//Danh sách số liệu
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BieuDo bd = new BieuDo();
                    bd.MaLoaiHang = reader.GetString(0);
                    bd.TenLoaiHang = reader.GetString(1);
                    bd.SoLuong = reader.GetInt32(2);
                    bd.TongTien = reader.GetInt32(3);
                    bd.PhanTram = float.Parse(reader.GetDouble(4).ToString());
                    bd.PhanTramTongTien = float.Parse(reader.GetDouble(5).ToString());
                    dsSL.Add(bd);
                }
                reader.Close();
                return dsSL;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public static List<NhanVien> LayToanBoNhanVien()
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();
                List<NhanVien> dsNV = context.NhanViens.ToList();              
                return dsNV;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public static List<KhachHang> LayToanBoKhachHang()
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();

                List<KhachHang> dsKH = context.KhachHangs.ToList();
                return dsKH;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public static List<HangHoa> LayToanBoHangHoa()
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();
                List<HangHoa> dsHH = context.HangHoas.ToList();
                
                return dsHH;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public static List<LoaiHang> LayToanBoLoaiHang()
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();
                List<LoaiHang> dsLH = context.LoaiHangs.ToList();
          
                return dsLH;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public static List<HoaDon> LayToanBoDanhSachHoaDon()
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();
                List<HoaDon> dsHD = context.HoaDons.ToList();
                
                return dsHD;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection =conn; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static List<ChiTietHD> LayToanBoDanhSachChiTietHD()
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();
                List<ChiTietHD> dsCTHD = context.ChiTietHDs.ToList();
             
               return dsCTHD;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public static int UpdateData(string sql)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public static int DeleteData(string sql)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public static int InsertData(string sql)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

    }
}
