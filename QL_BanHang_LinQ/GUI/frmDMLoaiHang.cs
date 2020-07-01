using QL_BanHang_LinQ.BS_Layer;
using QL_BanHang_LinQ.DB_Layer;
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
    public partial class frmDMLoaiHang : Form
    {
        public frmDMLoaiHang()
        {
            InitializeComponent();
        }
        List<LoaiHang> dsLH = new List<LoaiHang>();
        private void frmDMLoaiHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiHang();
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLoaiHang.Columns[0].HeaderText = "Mã LH";
            dgvLoaiHang.Columns[1].HeaderText = "Tên loại hàng";
        }
        private void HienThiDanhSachLoaiHang()
        {
            dsLH = Query_DAL.LayToanBoLoaiHang();
            dgvLoaiHang.DataSource = dsLH;
            txtMaLoaiHang.Enabled = false;
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
            txtMaLoaiHang.Enabled = false;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaLoaiHang.Text = "";
            txtTenLoaiHang.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaLoaiHang.Enabled = true;
            txtMaLoaiHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoaiHang LH = new LoaiHang();
            LH.MaLoaiHang = txtMaLoaiHang.Text;
            LH.TenLoaiHang = txtTenLoaiHang.Text;
            int res = BLL_LoaiHang.InsertLoaiHang(LH);
            if (res >0)
            {
                MessageBox.Show("Thêm loại hàng thành công");
                HienThiDanhSachLoaiHang();
                ResetValues();
            }    
            else if(res==0)
            {
                MessageBox.Show("Mã loại hàng đã tồn tại");
            }    
            else
            {
                MessageBox.Show("Thêm loại hàng thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiHang LH = new LoaiHang();
            LH.MaLoaiHang = txtMaLoaiHang.Text;
            LH.TenLoaiHang = txtTenLoaiHang.Text;
            int res =BLL_LoaiHang.UpdateLoaiHang(LH);
            if(res > 0)
            {
                MessageBox.Show("Sửa loại hàng thành công");
                HienThiDanhSachLoaiHang();
            }
            else
            {
                MessageBox.Show("Sửa loại hàng thất bại");
            }    
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dlr == DialogResult.Cancel || dlr == DialogResult.No)
                return;
            int res = BLL_LoaiHang.DeleteLoaiHang(txtMaLoaiHang.Text.Trim());
            if (res > 0)
            {
                HienThiDanhSachLoaiHang();
                ResetValues();
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void dgvLoaiHang_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHang.Rows.Count < 1)
                return;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiHang.Focus();
                return;
            }
            if (dgvLoaiHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Hiển thị thông tin lên bảng thông tin chi tiết
            int indexRow = dgvLoaiHang.SelectedRows[0].Index;
            txtMaLoaiHang.Text = dgvLoaiHang[0, indexRow].Value.ToString();
            txtTenLoaiHang.Text = dgvLoaiHang[1, indexRow].Value.ToString();           
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
