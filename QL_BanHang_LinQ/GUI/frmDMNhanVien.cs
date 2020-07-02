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
    public partial class frmDMNhanVien : Form
    {
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            txtMaNhanVien.Enabled = false;
            //Cấu hình datagribview
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //end
            HienThiDanhSachNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[4].HeaderText = "Giới tính";
            dgvNhanVien.Columns[5].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[6].HeaderText = "Lương";
            dgvNhanVien.Columns[7].HeaderText = "Ngày sinh";
        }
        private void HienThiDanhSachNhanVien()
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            
            dsNV = BLL_NhanVien.LayToanBoNhanVien();
            dgvNhanVien.DataSource = dsNV;  
        }
        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";
            txtLuong.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            mtbDienThoai.Text = "";
            txtMaNhanVien.Focus(); // Đưa con trỏ tới MaNhanVien
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count < 1)
                return;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Hiển thị thông tin lên bảng thông tin chi tiết
            int indexRow = dgvNhanVien.SelectedRows[0].Index;
            txtMaNhanVien.Text = dgvNhanVien[0, indexRow].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien[1, indexRow].Value.ToString();
            txtChucVu.Text = dgvNhanVien[5, indexRow].Value.ToString();
            txtDiaChi.Text = dgvNhanVien[2, indexRow].Value.ToString();
            mtbDienThoai.Text = dgvNhanVien[3, indexRow].Value.ToString();
            txtLuong.Text = dgvNhanVien[6, indexRow].Value.ToString();
            dtpNgaySinh.Value = (DateTime)dgvNhanVien[7, indexRow].Value;
            chkNam.Checked = false;
            chkNu.Checked = false;
            if (dgvNhanVien[4, indexRow].Value.ToString() == "Nam")
            {
                chkNam.Checked = true;
            }
            else chkNu.Checked = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNhanVien.Enabled = false;
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaNhanVien.Text.Trim().Length==0)
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chức vụ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChucVu.Focus();
                return;
            }
            if(txtDiaChi.Text.Trim().Length==0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }    
            if (mtbDienThoai.Text== "(   )     -")
            {
                MessageBox.Show("Số điện thoại nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (txtLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lương nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }
            if (chkNam.Checked&&chkNu.Checked)
            {
                MessageBox.Show("Giới tính không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkNam.Focus();
                return;
            }
            string gt = "";
            if (chkNam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text.Trim();
            nv.TenNhanVien = txtTenNhanVien.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.DienThoai = mtbDienThoai.Text;
            nv.NgaySinh = dtpNgaySinh.Value.Date;
            nv.ChucVu = txtChucVu.Text;
            nv.Luong = int.Parse(txtLuong.Text.Trim());
            nv.GioiTinh = gt;
            int res = BLL_NhanVien.InsertNhanVien(nv);
            if (res > 0)
            {
                HienThiDanhSachNhanVien();
                MessageBox.Show("Thêm nhân viên thành công");
                
            }
            else if(res==0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                txtMaNhanVien.Focus();
            }    
            else MessageBox.Show("Thêm nhân viên thất bại");

            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text;
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NgaySinh = (DateTime)dtpNgaySinh.Value;
            nv.Luong = int.Parse(txtLuong.Text);
            nv.DienThoai = mtbDienThoai.Text;
            nv.ChucVu = txtChucVu.Text;
            if (chkNam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
                nv.GioiTinh = "Nữ";
            int res =BLL_NhanVien.UpdateNhanVien(nv);
            if (res>0)
            {
                HienThiDanhSachNhanVien();
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
            int res =BLL_NhanVien.DeleteNhanVien(txtMaNhanVien.Text.Trim());
            if (res > 0)
            {
                HienThiDanhSachNhanVien();
                ResetValues();
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;          
            this.Close();

        }
        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked == true)
            {
                chkNu.Checked = false;
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked == true)
            {
                chkNam.Checked = false;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
