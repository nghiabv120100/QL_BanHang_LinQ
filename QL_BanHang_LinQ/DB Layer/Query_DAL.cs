using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang_LinQ.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.AccessControl;

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
        #region Lấy Dữ Liệu
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
            OpenConnection();
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
        #endregion
        #region Update
        public static int UpdateHangHoa(HangHoa hh)
        {
            try
            {
                QL_BanHangDataContext context = new QL_BanHangDataContext();
                HangHoa hanghoa = context.HangHoas.FirstOrDefault(x => x.MaHang.Trim() == hh.MaHang.Trim());
                hanghoa.TenHang = hh.TenHang;
                hanghoa.SoLuong = hh.SoLuong;
                hanghoa.DonGiaNhap = hh.DonGiaNhap;
                hanghoa.DonGiaBan = hh.DonGiaBan;
                hanghoa.Anh = hh.Anh;
                hanghoa.GhiChu = hh.GhiChu;
                hanghoa.ThoiGianBaoHanh = hh.ThoiGianBaoHanh;
                hanghoa.XuatXu = hh.XuatXu;
                hanghoa.LoaiHang = hh.LoaiHang;
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public static int UpdateHoaDonBanHang(HoaDon hd)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            HoaDon hoadon = context.HoaDons.FirstOrDefault
                (x => x.MaHoaDon.Trim() == hd.MaHoaDon.Trim());
            if (hoadon != null)
            {
                try
                {
                    hoadon.TongTien = hd.TongTien;
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int UpdateKhachHang(KhachHang kh)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            KhachHang khachhang = context.KhachHangs.FirstOrDefault(x => x.MaKhachHang.Trim() == kh.MaKhachHang.Trim());
            if (khachhang != null)
            {
                try
                {
                    khachhang.TenKhachHang = kh.TenKhachHang;
                    khachhang.TongChiTieu = kh.TongChiTieu;
                    khachhang.GioiTinh = kh.GioiTinh;
                    khachhang.DiaChi = kh.DiaChi;
                    khachhang.DienThoai = kh.DienThoai;
                    khachhang.Email = kh.Email;
                    khachhang.NgaySinh = kh.NgaySinh;
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;

        }
        public static int UpdateLoaiHang(LoaiHang lh)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            LoaiHang loaihang = context.LoaiHangs.FirstOrDefault(x => x.MaLoaiHang.Trim() == lh.MaLoaiHang.Trim());
            if (loaihang != null)
            {
                try
                {
                    loaihang.TenLoaiHang = lh.TenLoaiHang;
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int UpdateNhanVien(NhanVien nv)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            NhanVien nhanvien = context.NhanViens.FirstOrDefault
                (x => x.MaNhanVien.Trim() == nv.MaNhanVien.Trim());
            if (nhanvien != null)
            {
                try
                {
                    nhanvien.TenNhanVien = nv.TenNhanVien;
                    nhanvien.DiaChi = nv.DiaChi;
                    nhanvien.NgaySinh = nv.NgaySinh;
                    nhanvien.Luong = nv.Luong;
                    nhanvien.DienThoai = nv.DienThoai;
                    nhanvien.ChucVu = nv.ChucVu;
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        //public static int UpdateData(string sql)
        //{
        //    try
        //    {
        //        OpenConnection();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = sql;
        //        cmd.Connection = conn;
        //        int res = cmd.ExecuteNonQuery();
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return -1;
        //    }
        //}
        #endregion
        #region Delete
        public static int DeleteHangHoa(string Ma)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            HangHoa deleteHangHoa = context.HangHoas.
                FirstOrDefault(x => x.MaHang.Trim() == Ma.Trim());
            if (deleteHangHoa != null)
            {
                try
                {
                    context.HangHoas.DeleteOnSubmit(deleteHangHoa);
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int DeleteChiTietHD(string MaHD,string MaHH)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            ChiTietHD deleteChiTietHD = context.ChiTietHDs.
                FirstOrDefault(x => x.MaHoaDon.Trim() == MaHD.Trim() && x.MaHang.Trim()==MaHH.Trim());
            if (deleteChiTietHD != null)
            {
                try
                {
                    context.ChiTietHDs.DeleteOnSubmit(deleteChiTietHD);
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int DeleteHoaDon(string MaHD)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            List<ChiTietHD> dsCTHD = context.ChiTietHDs.Where(x => x.MaHoaDon.Trim() == MaHD.Trim()).ToList();
            if (dsCTHD != null)
            {
                try
                {
                    context.ChiTietHDs.DeleteAllOnSubmit(dsCTHD);
                    context.SubmitChanges();
                    HoaDon hoadon = context.HoaDons.FirstOrDefault(x => x.MaHoaDon.Trim() == MaHD.Trim());
                    context.HoaDons.DeleteOnSubmit(hoadon);
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int DeleteKhachHang(string MaKH)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            KhachHang deleteKhachHang = context.KhachHangs.
                FirstOrDefault(x => x.MaKhachHang.Trim() == MaKH.Trim());
              
            if (deleteKhachHang != null)
            {
                try
                {
                    context.KhachHangs.DeleteOnSubmit(deleteKhachHang);
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int DeleteLoaiHang(string MaLH)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            LoaiHang deleteLoaiHang = context.LoaiHangs.
                FirstOrDefault(x => x.MaLoaiHang.Trim() == MaLH.Trim());

            if (deleteLoaiHang != null)
            {
                try
                {
                    context.LoaiHangs.DeleteOnSubmit(deleteLoaiHang);
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public static int DeleteNhanVien(string MaNV)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            NhanVien deleteNhanVien = context.NhanViens.
                FirstOrDefault(x => x.MaNhanVien.Trim() == MaNV.Trim());

            if (deleteNhanVien != null)
            {
                try
                {
                    context.NhanViens.DeleteOnSubmit(deleteNhanVien);
                    context.SubmitChanges();
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        #endregion
        #region Insert
        public static int InsertHangHoa(HangHoa hh)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            try
            {
                context.HangHoas.InsertOnSubmit(hh);
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        public static int InsertHoaDon(HoaDon hd)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            try
            {
                context.HoaDons.InsertOnSubmit(hd);
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        public static int InsertChiTietHD(ChiTietHD cthd)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            try
            {
                context.ChiTietHDs.InsertOnSubmit(cthd);
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        public static int InsertKhachHang(KhachHang kh)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            try
            {
                context.KhachHangs.InsertOnSubmit(kh);
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        public static int InsertLoaiHang(LoaiHang lh)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            try
            {
                context.LoaiHangs.InsertOnSubmit(lh);
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        public static int InsertNhanVien(NhanVien nv)
        {
            QL_BanHangDataContext context = new QL_BanHangDataContext();
            try
            {
                context.NhanViens.InsertOnSubmit(nv);
                context.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }

        }
        #endregion

    }
}
