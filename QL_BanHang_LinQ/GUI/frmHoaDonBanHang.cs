using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComExcel = Microsoft.Office.Interop.Excel;
using QL_BanHang_LinQ.DTO;
using QL_BanHang_LinQ.BS_Layer;

namespace QL_BanHang_LinQ.GUI
{
    
    public partial class frmHoaDonBanHang : Form
    {
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }
        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaHDBan.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenKhachHang.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mtbDienThoai.ReadOnly = true;
            txtTenhang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtGiamgia.Text = "0";
            txtTongtien.Text = "0";
            txtSoluong.Text = "0";

            // Lấy dữ liệu đưa vào List
            ResetData();
            HienThiLenCombobox();
            HienThiChiTietHoaDonBan(txtMaHDBan.Text);
            dgvHDBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng hoá";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá";
            dgvHDBanHang.Columns[5].HeaderText = "Thành Tiền";
        }

        #region List Object
        List<NhanVien> dsNV = new List<NhanVien>();
        List<HangHoa> dsHH = new List<HangHoa>();
        List<KhachHang> dsKH = new List<KhachHang>();
        List<HoaDon> dsHD = new List<HoaDon>();
        List<LoaiHang> dsLH = new List<LoaiHang>();
        List<ChiTietHD> dsCTHD = new List<ChiTietHD>();
        #endregion
        
        #region Method Display
        // Chi tiết sản phẩm của hoá đơn theo mã hoá đơn
        private void HienThiChiTietHoaDonBan(string MaHD)
        {
            List<GetDataToTableResult> dtlCTHD;
            dtlCTHD = BLL_HoaDonBanHang.LayDuLieuLenBang(MaHD);

            dgvHDBanHang.DataSource = dtlCTHD;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;           
            int Price = 0;
            foreach(GetDataToTableResult item in dtlCTHD)
            {
           
                Price += int.Parse(item.ThanhTien);
            }    
            BLL_HoaDonBanHang.UpdataHoaDonBanHang(txtMaHDBan.Text.Trim(), Price);
            txtTongtien.Text = Price.ToString();
        
        }
        private void HienThiLenCombobox()
        {
            ResetData();
            cmbMahoadon.Items.Clear();
            cmbMaNhanVien.Items.Clear();
            cmbMaKhach.Items.Clear();
            cmbMaHang.Items.Clear();
            foreach (NhanVien nv in dsNV)
            {
                cmbMaNhanVien.Items.Add(nv.MaNhanVien);              
            }
            foreach (KhachHang kh in dsKH)
            {
                cmbMaKhach.Items.Add(kh.MaKhachHang);
            }
            foreach (HangHoa nv in dsHH)
            {
                cmbMaHang.Items.Add(nv.MaHang);
            }
            foreach (HoaDon hd in dsHD)
            {
                cmbMahoadon.Items.Add(hd.MaHoaDon.Trim());
            }
        }

        #endregion

        #region ValuesChanged
        private void cmbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NhanVien nv in dsNV)
            {
                if (nv.MaNhanVien.Trim() == cmbMaNhanVien.SelectedItem.ToString().Trim())
                {
                    txtTennhanvien.Text = nv.TenNhanVien;
                }
            }
        }

        private void cmbMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KhachHang kh in dsKH)
            {
                if (kh.MaKhachHang.Trim() == cmbMaKhach.SelectedItem.ToString().Trim())
                {
                    txtTenKhachHang.Text = kh.TenKhachHang;
                    txtDiachi.Text = kh.DiaChi;
                    mtbDienThoai.Text = kh.DienThoai;
                }
            }
        }
        private void cmbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (HangHoa hh in dsHH)
            {
                if (hh.MaHang.Trim() == cmbMaHang.SelectedItem.ToString().Trim())
                {
                    txtTenhang.Text = hh.TenHang;
                    txtDonGiaBan.Text = hh.DonGiaBan;
                }
            }
            txtSoluong.Text = "1";
            txtGiamgia.Text = "0";
            //Hiển thị giá tiền
            int SL = int.Parse(txtSoluong.Text);
            float DG = float.Parse(txtDonGiaBan.Text);
            int GG = int.Parse(txtGiamgia.Text);
            float ThanhTien;
            ThanhTien = (DG * SL) - (DG * SL) * (float)GG / 100;
            txtThanhtien.Text = ThanhTien.ToString();
        }


        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaBan.Text != ""&&txtSoluong.Text!="")
            {
                int SL = int.Parse(txtSoluong.Text);
                float DG = float.Parse(txtDonGiaBan.Text);
                int GG = int.Parse(txtGiamgia.Text);
                float ThanhTien;
                ThanhTien = (DG * SL) - (DG * SL) * (float)GG / 100;
                txtThanhtien.Text = ThanhTien.ToString();
            }
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text != "")
            {
                int SL = int.Parse(txtSoluong.Text);
                float DG = float.Parse(txtDonGiaBan.Text);
                int GG = int.Parse(txtGiamgia.Text);
                float ThanhTien;
                ThanhTien = (DG * SL) - (DG * SL) * (float)GG / 100;
                txtThanhtien.Text = ThanhTien.ToString();
            }

        }


        private void cmbMahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInHoaDon.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            txtMaHDBan.Text = cmbMahoadon.Text;
            //Reset thông tin mặt hàng
            ResetHang();
            foreach (HoaDon hd in dsHD)
            {
                if (hd.MaHoaDon.Trim() == txtMaHDBan.Text.Trim())
                {
                    cmbMaNhanVien.Text = hd.MaNhanVien;
                    cmbMaKhach.Text = hd.MaKhachHang;
                    dtpNgayban.Value = (DateTime)hd.NgayBan;
                    txtTongtien.Text = hd.TongTien.ToString();
                }
            }
            HienThiChiTietHoaDonBan(cmbMahoadon.Text.Trim());
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            lblBangchu.Text = "Bằng Chữ: " + BLL_HoaDonBanHang.So_chu(double.Parse(txtTongtien.Text));
        }

        #endregion

        #region MethodReset
        private void ResetValues()
        {
            txtMaHDBan.Text = "";
            dtpNgayban.Text = DateTime.Now.ToShortDateString();
            cmbMaNhanVien.Text = "";
            txtTennhanvien.Text = "";
            cmbMaKhach.Text = "";
            txtTenKhachHang.Text = "";
            txtDiachi.Text = "";
            mtbDienThoai.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cmbMaHang.Text = "";
            txtSoluong.Text = "0";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            txtDonGiaBan.Text = "0";
            txtTenKhachHang.Text = "";
        }
        private void ResetHang()
        {
            cmbMaHang.Text = "";
            txtTenhang.Text = "";
            txtDonGiaBan.Text = "0";
            txtGiamgia.Text = "0";
            txtSoluong.Text = "0";
            txtThanhtien.Text = "";
        }
        private void ResetData()
        {
            dsNV = BLL_NhanVien.LayToanBoNhanVien();
            dsHH = BLL_HangHoa.LayToanBoHangHoa();
            dsKH = BLL_KhachHang.LayToanBoKhachHang();
            dsLH = BLL_LoaiHang.LayToanBoLoaiHang();
            dsCTHD = BLL_HoaDonBanHang.LayToanBoDanhSachChiTietHD();
            dsHD = BLL_HoaDonBanHang.LayToanBoDanhSachHoaDon();
        }
        #endregion

        #region EvenClick
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            dgvHDBanHang.DataSource = null;
            ResetValues();
            txtMaHDBan.Text = BLL_HoaDonBanHang.CreateKey("HDB");
            cmbMahoadon.Text = txtMaHDBan.Text;
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (cmbMaNhanVien.Text=="")
            {
                MessageBox.Show("Vui lòng chọn nhân viên bán hàng");
                cmbMaNhanVien.Focus();
                return;
            }
            if (cmbMaKhach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng mua");
                cmbMaKhach.Focus();
                return;
            }
            if (cmbMaHang.Text=="")
            {
                MessageBox.Show("Vui lòng chọn mã hàng");
                cmbMaHang.Focus();
                return;
            }    
            //Tạo 1 hoá đơn
            HoaDon hd = new HoaDon();
            hd.MaHoaDon = txtMaHDBan.Text;
            hd.MaKhachHang = cmbMaKhach.Text;
            hd.MaNhanVien = cmbMaNhanVien.Text;
            hd.NgayBan = dtpNgayban.Value;
            hd.TongTien = int.Parse(txtTongtien.Text);
            //
            //Tạo 1 chi tiết hoá đơn
            ChiTietHD CTHD = new ChiTietHD();
            CTHD.MaHoaDon = txtMaHDBan.Text;
            CTHD.MaHang = cmbMaHang.Text;
            CTHD.SoLuong = int.Parse(txtSoluong.Text);
            CTHD.GiamGia = int.Parse(txtGiamgia.Text);
            CTHD.DonGia = txtDonGiaBan.Text;
            CTHD.ThanhTien = txtThanhtien.Text;

            // Trừ số lượng Hàng Hoá
            foreach (HangHoa hh in dsHH)
            {
                if (hh.MaHang == CTHD.MaHang)
                {
                    if (hh.SoLuong >= CTHD.SoLuong)
                    {
                        hh.SoLuong = hh.SoLuong - CTHD.SoLuong;
                        BLL_HangHoa.UpdateHangHoa(hh);
                    }
                    else
                    {
                        MessageBox.Show($"Số lượng trong kho chỉ còn {hh.SoLuong} sản phẩm");
                        return;
                    }                                       
                }
            }
            //
            int res = BLL_HoaDonBanHang.InsertHoaDonBanHang(hd,CTHD);
            if (res >0)
            {
                foreach(KhachHang kh in dsKH)
                {
                    if (kh.MaKhachHang==hd.MaKhachHang)
                    {
                        kh.TongChiTieu += int.Parse(CTHD.ThanhTien);
                        BLL_KhachHang.UpdateKhachHang(kh);
                    }    
                }    
                MessageBox.Show("Insert Thành Công");
                
            }
            else
            {
                MessageBox.Show("Insert thất bại");
            }
            //
            btnInHoaDon.Enabled = true;
            HienThiChiTietHoaDonBan(cmbMahoadon.Text.Trim());
            HienThiLenCombobox();
            ResetHang();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            this.Close();
        }

      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            int  res =BLL_HoaDonBanHang.DeleteHoaDon(cmbMahoadon.Text.Trim());
            if (res > 0)
            {
                MessageBox.Show("Huỷ hoá đơn thành công");
            }    
            else
            {
                MessageBox.Show("Huỷ hoá đơn thất bại");
            }                
            HienThiLenCombobox();
            cmbMahoadon.SelectedIndex = -1;
            HienThiChiTietHoaDonBan("");
            ResetValues();
        }


        private void dgvHDBanHang_Click(object sender, EventArgs e)
        {
            if (dgvHDBanHang.Rows.Count < 1)
                return;
            int indexRow = dgvHDBanHang.SelectedRows[0].Index;
            cmbMaHang.Text = dgvHDBanHang[0, indexRow].Value.ToString();
            txtTenhang.Text = dgvHDBanHang[1, indexRow].Value.ToString();
            txtSoluong.Text= dgvHDBanHang[2, indexRow].Value.ToString();
            txtDonGiaBan.Text = dgvHDBanHang[3, indexRow].Value.ToString();
            txtGiamgia.Text = dgvHDBanHang[4, indexRow].Value.ToString();
            txtThanhtien.Text = dgvHDBanHang[5, indexRow].Value.ToString();
            

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            button5.Enabled = true;
            cmbMahoadon.Text = "";
            txtTenKhachHang.Text = "";
            txtTennhanvien.Text = "";
            txtDiachi.Text = "";
            mtbDienThoai.Text = "";
            HienThiChiTietHoaDonBan(cmbMahoadon.Text);
            ResetValues();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
           
            
            frmReport frm = new frmReport();
            frm.Tag = cmbMahoadon.Text;
            frm.Show();
        }
        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHDBanHang.Rows.Count < 1)
                return;
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            int indexRow = dgvHDBanHang.SelectedRows[0].Index;
            string MaHang = dgvHDBanHang[0, indexRow].Value.ToString();
            string MaHD = cmbMahoadon.Text;
            int ThanhTien = int.Parse(dgvHDBanHang[5, indexRow].Value.ToString().Trim());
            int SoLuong = int.Parse(dgvHDBanHang["SoLuong", indexRow].Value.ToString());
            int res =BLL_HoaDonBanHang.DeleteChiTietHD(MaHD, MaHang);
            if (res > 0)
            {
                HienThiChiTietHoaDonBan(MaHD);
                // Trừ số lượng Hàng Hoá
                foreach (HangHoa hh in dsHH)
                {
                    if (hh.MaHang == MaHang)
                    {
                        hh.SoLuong = hh.SoLuong + SoLuong;
                        BLL_HangHoa.UpdateHangHoa(hh);
                    }
                }
                // Trừ tổng chi tiêu
                foreach (KhachHang kh in dsKH)
                {
                    if (kh.MaKhachHang == cmbMaKhach.Text)
                    {
                        kh.TongChiTieu = kh.TongChiTieu-ThanhTien;
                        BLL_KhachHang.UpdateKhachHang(kh);
                    }
                }
                MessageBox.Show("Xoá thành công");
            }    
            else
            {
                MessageBox.Show("Xoá thất bại");
            }                
         
        }


        #endregion

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            
         
        }

        private void cmbMaKhach_MouseClick(object sender, MouseEventArgs e)
        {
            dsKH = BLL_KhachHang.LayToanBoKhachHang();
            HienThiLenCombobox();
        }
    }
}
