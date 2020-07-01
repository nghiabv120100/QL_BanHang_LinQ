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
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_BanHang_LinQ.GUI
{
    public partial class frmBieuDo : Form
    {
        public frmBieuDo()
        {
            InitializeComponent();
        }

        private void frmBieuDo_Load(object sender, EventArgs e)
        {
            DateTime dateStart = new DateTime(2019, 1, 1);
            DateTime dateEnd = DateTime.Now;
            LoadBieuDoSoLuong(dateStart, dateEnd);
            LoadPhanTramSoLuong(dateStart, dateEnd);
            LoadBieuDoTongTien(dateStart, dateEnd);
            LoadPhamTramTongTien(dateStart, dateEnd);
        }
        private void LoadBieuDoSoLuong(DateTime dateStart,DateTime dateEnd)
        {
            List<BieuDo> dsSL = new List<BieuDo>();
            chartSoLuong.DataSource = BLL_BieuDo.LaySoLieuBieuDo(dateStart, dateEnd);
            chartSoLuong.Series[0].XValueMember = "TenLoaiHang";
            chartSoLuong.Series[0].XValueType = ChartValueType.String;
            chartSoLuong.Series[0].YValueMembers = "SoLuong";
            chartSoLuong.Series[0].YValueType = ChartValueType.Int32;
        }
        private void LoadBieuDoTongTien(DateTime dateStart, DateTime dateEnd)
        {
            List<BieuDo> dsSL = new List<BieuDo>();
            chartTongTien.DataSource = BLL_BieuDo.LaySoLieuBieuDo(dateStart, dateEnd);
            chartTongTien.Series[0].XValueMember = "TenLoaiHang";
            chartTongTien.Series[0].XValueType = ChartValueType.String;
            chartTongTien.Series[0].YValueMembers = "TongTien";
            chartTongTien.Series[0].YValueType = ChartValueType.Int32;
        }
        private void LoadPhanTramSoLuong(DateTime dateStart,DateTime dateEnd)
        {
            List<BieuDo> dsSL = new List<BieuDo>();
            chartPercent.DataSource = BLL_BieuDo.LaySoLieuBieuDo(dateStart, dateEnd);
            chartPercent.Series[0].XValueMember = "TenLoaiHang";
            chartPercent.Series[0].XValueType = ChartValueType.String;
            chartPercent.Series[0].YValueMembers = "PhanTram";
            chartPercent.Series[0].YValueType = ChartValueType.Int32;

        }
        private void LoadPhamTramTongTien(DateTime dateStart, DateTime dateEnd)
        {
            List<BieuDo> dsSL = new List<BieuDo>();
           
            chart_PercentTongTien.DataSource = BLL_BieuDo.LaySoLieuBieuDo(dateStart, dateEnd);
            chart_PercentTongTien.Series[0].XValueMember = "TenLoaiHang";
            chart_PercentTongTien.Series[0].XValueType = ChartValueType.String;
            chart_PercentTongTien.Series[0].YValueMembers = "PhanTramTongTien";
            chart_PercentTongTien.Series[0].YValueType = ChartValueType.Int32;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DateTime dateStart = dtpStart.Value;
            DateTime dateEnd = dtpEnd.Value;
            LoadBieuDoSoLuong(dateStart,dateEnd);
            LoadPhanTramSoLuong(dateStart, dateEnd);
        }

        private void btnLamMoi_Thang_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value;
            DateTime dateStart = new DateTime(date.Year,date.Month,1,00,00,00); 
            DateTime dateEnd = dateStart.AddMonths(1);
            LoadBieuDoSoLuong(dateStart, dateEnd);
            LoadPhanTramSoLuong(dateStart, dateEnd);
        }

        private void btnLamMoi_Tab2_Click(object sender, EventArgs e)
        {
            DateTime dateStart = dtpStart_tab2.Value;
            DateTime dateEnd = dtpEnd_Tab2.Value;
            LoadBieuDoTongTien(dateStart, dateEnd);
            LoadPhamTramTongTien(dateStart, dateEnd);
        }

        private void btnLamMoi_Thang_Tab2_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value;
            DateTime dateStart = new DateTime(date.Year, date.Month, 1, 00, 00, 00);
            DateTime dateEnd = dateStart.AddMonths(1);
            LoadBieuDoTongTien(dateStart, dateEnd);
            LoadPhamTramTongTien(dateStart, dateEnd);
        }

        private void btnAll_SoLuong_Click(object sender, EventArgs e)
        {
            DateTime dateStart = new DateTime(2019, 1, 1);
            DateTime dateEnd = DateTime.Now;
            LoadBieuDoSoLuong(dateStart, dateEnd);
            LoadPhanTramSoLuong(dateStart, dateEnd);
        }

        private void btnAll_TongTien_Click(object sender, EventArgs e)
        {
            DateTime dateStart = new DateTime(2019, 1, 1);
            DateTime dateEnd = DateTime.Now;
            LoadBieuDoTongTien(dateStart, dateEnd);
            LoadPhamTramTongTien(dateStart, dateEnd);
        }
    }
}
