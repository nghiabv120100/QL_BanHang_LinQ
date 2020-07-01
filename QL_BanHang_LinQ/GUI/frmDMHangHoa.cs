using QL_BanHang_LinQ.BS_Layer;
using QL_BanHang_LinQ.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang_LinQ.GUI
{
    public partial class frmDMHangHoa : Form
    {
        public frmDMHangHoa()
        {
            InitializeComponent();
        }
        List<HangHoa> dsHH = new List<HangHoa>();
        List<LoaiHang> dsLH = new List<LoaiHang>();
        private void frmDMHangHoa_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            txtMaHang.Enabled = false;
            HienThiDanhSachHangHoa();
            HienThiDanhSachLoaiHang();
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHangHoa.Columns[0].HeaderText = "Mã hàng";
            dgvHangHoa.Columns[1].HeaderText = "Tên hàng hoá";
            dgvHangHoa.Columns[2].HeaderText = "Số lượng";
            dgvHangHoa.Columns[3].HeaderText = "Đơn giá nhập";
            dgvHangHoa.Columns[4].HeaderText = "Đơn giá bán";
            dgvHangHoa.Columns[5].HeaderText = "Ảnh";
            dgvHangHoa.Columns[6].HeaderText = "Ghi chú";
            dgvHangHoa.Columns[7].HeaderText = "Bảo hành";
            dgvHangHoa.Columns[8].HeaderText = "Xuất xứ";
            dgvHangHoa.Columns[9].HeaderText = "Loại hàng";
            dgvHangHoa.Columns[5].Visible = false;
        }
        private void HienThiDanhSachHangHoa()
        {
            dsHH = BLL_HangHoa.LayToanBoHangHoa();
            dgvHangHoa.DataSource = dsHH;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void HienThiDanhSachLoaiHang()
        {
            dsLH = BLL_LoaiHang.LayToanBoLoaiHang();
            cmbMaLoaiHang.DataSource = dsLH;
            cmbMaLoaiHang.DisplayMember = "MaLoaiHang";
            cmbMaLoaiHang.ValueMember = "MaLoaiHang";
            cmbMaLoaiHang.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
            btnHienThiDS.Enabled = false;
            btnBoQua.Enabled = true;
            ResetValues();
            txtMaHang.Enabled = true;
            cmbMaLoaiHang.SelectedIndex = -1;
            picAnh.Image = null;
            txtPath.Text = "";
            txtMaHang.Focus();
        }
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cmbMaLoaiHang.SelectedIndex = -1;
            txtSoluong.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtXuatXu.Text = "";
            txtPath.Text = "";
            txtGhichu.Text = "";
            txtThoiGianBaoHanh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoa HH = new HangHoa();
            HH.MaHang = txtMaHang.Text;
            HH.TenHang = txtTenHang.Text;
            HH.SoLuong = int.Parse(txtSoluong.Text);
            HH.DonGiaNhap = txtDongianhap.Text;
            HH.DonGiaBan = txtDongiaban.Text;
            HH.Anh = txtPath.Text;
            HH.GhiChu = txtGhichu.Text;
            HH.ThoiGianBaoHanh = int.Parse(txtThoiGianBaoHanh.Text);
            HH.XuatXu = txtXuatXu.Text;
            HH.LoaiHang = cmbMaLoaiHang.SelectedValue.ToString();

            int res = BLL_HangHoa.InsertHangHoa(HH);
            if (res > 0)
            {
                MessageBox.Show("Thêm hàng hoá thành công");
            }    
            else if (res==0)
            {
                MessageBox.Show("Mã hàng hoá đã tồn tại");
            }    
            else
            {
                MessageBox.Show("Thêm hàng hoá thất bại");
            }
            HienThiDanhSachHangHoa();
            ResetValues();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaHang.Enabled = false;
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HangHoa HH = new HangHoa();
            HH.MaHang = txtMaHang.Text;
            HH.TenHang = txtTenHang.Text;
            HH.SoLuong = int.Parse(txtSoluong.Text);
            HH.DonGiaNhap = txtDongianhap.Text;
            HH.DonGiaBan = txtDongiaban.Text;
            HH.Anh = txtPath.Text;
            HH.GhiChu = txtGhichu.Text;
            HH.ThoiGianBaoHanh = int.Parse(txtThoiGianBaoHanh.Text);
            HH.XuatXu = txtXuatXu.Text;
            HH.LoaiHang = cmbMaLoaiHang.Text;
            int res = BLL_HangHoa.UpdateHangHoa(HH);
            if (res >0)
            {
                MessageBox.Show("Cập nhật hàng hoá thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật hàng hoá thất bại");
            }
            HienThiDanhSachHangHoa();  
        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.Rows.Count < 1)
                return;

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (dgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = false;
            // Hiển thị thông tin lên bảng thông tin chi tiết
            int indexRow = dgvHangHoa.SelectedRows[0].Index;
            txtMaHang.Text=dgvHangHoa[0,indexRow].Value.ToString();
            txtTenHang.Text=dgvHangHoa[1,indexRow].Value.ToString();
            txtSoluong.Text=dgvHangHoa[2,indexRow].Value.ToString();
            txtDongianhap.Text=dgvHangHoa[3,indexRow].Value.ToString();
            txtDongiaban.Text=dgvHangHoa[4,indexRow].Value.ToString();
            txtPath.Text=dgvHangHoa[5,indexRow].Value.ToString();
            txtGhichu.Text=dgvHangHoa[6,indexRow].Value.ToString();
            txtThoiGianBaoHanh.Text=dgvHangHoa[7,indexRow].Value.ToString();
            txtXuatXu.Text=dgvHangHoa[8,indexRow].Value.ToString();
            cmbMaLoaiHang.Text= dgvHangHoa[9, indexRow].Value.ToString();
            try
            {
                picAnh.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + txtPath.Text);
            }
            catch
            {

            }
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            int res = BLL_HangHoa.DeleteHangHoa(txtMaHang.Text.Trim());
            if (res > 0)
            {
                HienThiDanhSachHangHoa();
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
            ResetValues();
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHangHoa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHang.Text == "") && (txtTenHang.Text == "") && (cmbMaLoaiHang.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HangHoa HH = new HangHoa();
            HH.MaHang = txtMaHang.Text;
            HH.TenHang = txtTenHang.Text;           
            
            HH.LoaiHang = cmbMaLoaiHang.Text;

            DataTable tblH = BLL_HangHoa.FindHangHoa(HH);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHangHoa.DataSource = tblH;
            ResetValues();
        }

        private void cboMaLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //return;
            try
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|GIF(*.gif)|*.gif|All files(*.*)|*.*";
                dlgOpen.FilterIndex = 1;
                dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = Image.FromFile(dlgOpen.FileName);
                    txtPath.Text = Path.GetFileName(dlgOpen.FileName);
                }
            }
            catch
            {

            }
            
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtThoiGianBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
