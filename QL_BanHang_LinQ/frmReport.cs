using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang_LinQ
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_BanHang.TheBill' table. You can move, or remove it, as needed.
            this.TheBillTableAdapter.Fill(this.QL_BanHang.TheBill, this.Tag.ToString().Trim());

            this.reportViewer1.RefreshReport();
        }
    }
}
