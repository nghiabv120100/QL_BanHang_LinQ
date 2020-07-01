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
        public static bool KiemTraTaiKhoan(string sql)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }    
            else
            {
                reader.Close();
                return false;
            }    
            
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
                List<NhanVien> dsNV = new List<NhanVien>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.NhanVien";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string MaNhanVien = reader.GetString(0);
                    string TenNhanVien = reader.GetString(1);
                    string DiaChi = reader.GetString(2);
                    string DienThoai = reader.GetString(3);
                    string GioiTinh = reader.GetString(4);
                    DateTime NgaySinh = reader.GetDateTime(7);
                    string ChucVu = reader.GetString(5);
                    int Luong = reader.GetInt32(6);

                    NhanVien NV = new NhanVien();
                    NV.MaNhanVien = MaNhanVien;
                    NV.TenNhanVien = TenNhanVien;
                    NV.DiaChi = DiaChi;
                    NV.DienThoai = DienThoai;
                    NV.GioiTinh = GioiTinh;
                    NV.NgaySinh = NgaySinh;
                    NV.ChucVu = ChucVu;
                    NV.Luong = Luong;
                    dsNV.Add(NV);
                }
                reader.Close();
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
                List<KhachHang> dsKH = new List<KhachHang>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.KhachHang";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string MaKhachHang = reader.GetString(0);
                    string TenKhachHang = reader.GetString(1);
                    string DiaChi = reader.GetString(2);
                    string DienThoai = reader.GetString(3);
                    string GioiTinh = reader.GetString(4);
                    string Email = reader.GetString(5);
                    DateTime NgaySinh = reader.GetDateTime(6);
                    int TongChiTieu = reader.GetInt32(7);

                    KhachHang KH = new KhachHang();
                    KH.MaKhachHang = MaKhachHang;
                    KH.TenKhachHang = TenKhachHang;
                    KH.DiaChi = DiaChi;
                    KH.DienThoai = DienThoai;
                    KH.GioiTinh = GioiTinh;
                    KH.Email = Email;
                    KH.NgaySinh = NgaySinh;
                    KH.TongChiTieu = TongChiTieu;
                    dsKH.Add(KH);
                }
                reader.Close();
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
                List<HangHoa> dsHH = new List<HangHoa>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.HangHoa";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string MaHangHoa = reader.GetString(0);
                    string TenHangHoa = reader.GetString(1);
                    int SoLuong = reader.GetInt32(2);
                    string DonGiaNhap = reader.GetString(3);
                    string DonGiaBan = reader.GetString(4);
                    string Anh = reader.GetString(5);
                    string GhiChu = reader.GetString(6);
                    int ThoiGianBaoHanh = reader.GetInt32(7);
                    string XuatXu = reader.GetString(8);
                    string LoaiHang = reader.GetString(9);

                    HangHoa HH = new HangHoa();
                    HH.MaHang = MaHangHoa;
                    HH.TenHang = TenHangHoa;
                    HH.SoLuong = SoLuong;
                    HH.DonGiaNhap = DonGiaNhap;
                    HH.DonGiaBan = DonGiaBan;
                    HH.Anh = Anh;
                    HH.GhiChu = GhiChu;
                    HH.ThoiGianBaoHanh = ThoiGianBaoHanh;
                    HH.XuatXu = XuatXu;
                    HH.LoaiHang = LoaiHang;
                    dsHH.Add(HH);
                }
                reader.Close();
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
                List<LoaiHang> dsLH = new List<LoaiHang>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.LoaiHang";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string MaLoaiHang = reader.GetString(0);
                    string TenLoaiHang = reader.GetString(1);
                    LoaiHang LH = new LoaiHang();
                    LH.MaLoaiHang = MaLoaiHang;
                    LH.TenLoaiHang = TenLoaiHang;
                    dsLH.Add(LH);
                }
                reader.Close();
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
                List<HoaDon> dsHD = new List<HoaDon>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.HoaDon";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string MaHoaDon = reader.GetString(0);
                    string MaNhanVien = reader.GetString(1);
                    string MaKhachHang = reader.GetString(2);
                    DateTime NgayBan = reader.GetDateTime(3);
                    int TongTien = reader.GetInt32(4);
                    HoaDon HD = new HoaDon();
                    HD.MaHoaDon = MaHoaDon;
                    HD.MaNhanVien = MaNhanVien;
                    HD.MaKhachHang = MaKhachHang;
                    HD.NgayBan = NgayBan;
                    HD.TongTien = TongTien;
                    dsHD.Add(HD);
                }
                reader.Close();
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
                List<ChiTietHD> dsCTHD = new List<ChiTietHD>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.ChiTietHD";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string MaHoaDon = reader.GetString(0);
                    string MaHang = reader.GetString(1);
                    int SoLuong = reader.GetInt32(2);
                    string DonGia = reader.GetString(3);
                    int GiamGia = reader.GetInt32(4);
                    string ThanhTien = reader.GetString(5);
                    ChiTietHD CTHD = new ChiTietHD();
                    CTHD.MaHoaDon = MaHoaDon;
                    CTHD.MaHang = MaHang;
                    CTHD.SoLuong = SoLuong;
                    CTHD.DonGia = DonGia;
                    CTHD.GiamGia = GiamGia;
                    CTHD.ThanhTien = ThanhTien;
                    dsCTHD.Add(CTHD);
                }
                reader.Close();
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
