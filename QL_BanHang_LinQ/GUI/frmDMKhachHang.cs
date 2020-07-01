using QL_BanHang_LinQ.BS_Layer;
using QL_BanHang_LinQ.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang_LinQ.GUI
{
    public partial class frmDMKhachHang : Form
    {
        public frmDMKhachHang()
        {
            InitializeComponent();
        }
        List<KhachHang> dsKH = new List<KhachHang>();
        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            txtMaKhachHang.Enabled = false;
            HienThiDanhSachKhachHang();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[4].HeaderText = "Giới tính";
            dgvKhachHang.Columns[5].HeaderText = "Ngày sinh";
            dgvKhachHang.Columns[6].HeaderText = "Tổng chi tiêu";
            dgvKhachHang.Columns[7].HeaderText = "Email";
        }
        private void HienThiDanhSachKhachHang()
        {           
            dsKH = BLL_KhachHang.LayToanBoKhachHang();
            dgvKhachHang.DataSource = dsKH;
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
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKhachHang.Enabled = false;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            mtbDienThoai.Text = "";
            txtTongChiTieu.Text = "";
            txtEmail.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count < 1)
                return;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return;
            }
            if (dgvKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Hiển thị thông tin lên bảng thông tin chi tiết
            int indexRow = dgvKhachHang.SelectedRows[0].Index;
            txtMaKhachHang.Text = dgvKhachHang[0, indexRow].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang[1, indexRow].Value.ToString();  
            txtDiaChi.Text = dgvKhachHang[2, indexRow].Value.ToString();
            mtbDienThoai.Text = dgvKhachHang[3, indexRow].Value.ToString();
            txtTongChiTieu.Text = dgvKhachHang[6, indexRow].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dgvKhachHang[5, indexRow].Value;
            txtEmail.Text = dgvKhachHang[7, indexRow].Value.ToString();
            chkNam.Checked = false;
            chkNu.Checked = false;
            if (dgvKhachHang[4, indexRow].Value.ToString() == "Nam")
            {
                chkNam.Checked = true;
            }
            else chkNu.Checked = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaKhachHang.Enabled = true;
            txtMaKhachHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Số điện thoại nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (txtTongChiTieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lương nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongChiTieu.Focus();
                return;
            }
            if (chkNam.Checked && chkNu.Checked)
            {
                MessageBox.Show("Giới tính không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkNam.Focus();
                return;
            }
            string gt = "";
            if (chkNam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            
            KhachHang KH = new KhachHang();
            KH.MaKhachHang = txtMaKhachHang.Text.Trim();
            KH.TenKhachHang = txtTenKhachHang.Text.Trim();
            KH.DiaChi = txtDiaChi.Text.Trim();
            KH.DienThoai = mtbDienThoai.Text.Trim();
            KH.GioiTinh = gt.Trim();
            KH.Email = txtEmail.Text.Trim();
            KH.NgaySinh = dtpNgaySinh.Value;
            KH.TongChiTieu = int.Parse(txtTongChiTieu.Text.Trim());

            int res = BLL_KhachHang.InsertKhachHang(KH) ;
            if (res > 0)
            {
                HienThiDanhSachKhachHang();
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else if (res == 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                txtMaKhachHang.Focus();
            }
            else MessageBox.Show("Thêm khách hàng thất bại");
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = txtMaKhachHang.Text;
            kh.TenKhachHang = txtTenKhachHang.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.TongChiTieu = int.Parse(txtTongChiTieu.Text);
            kh.NgaySinh = (DateTime)dtpNgaySinh.Value;
            kh.DienThoai = mtbDienThoai.Text;
            kh.Email = txtEmail.Text;
            if (chkNam.Checked == true)
            {
                kh.GioiTinh = "Nam";
            }
            else
                kh.GioiTinh = "Nữ";
            int res = BLL_KhachHang.UpdateKhachHang(kh);
            if (res > 0)
            {
                HienThiDanhSachKhachHang();
                MessageBox.Show("Sửa đổi thành công");
            }
            else
            {
                MessageBox.Show("Sửa đổi thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            int res=BLL_KhachHang.DeleteKhachHang(txtMaKhachHang.Text.Trim());
            if (res > 0)
            {
                HienThiDanhSachKhachHang();
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
            ResetValues();
        }

        private void txtTongChiTieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
