using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_taikhoan : Form
    {
        public form_dashboard_taikhoan()
        {
            InitializeComponent();
        }

        private void form_dashboard_taikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.cNPM_NHOM_1DataSet.STAFF);

        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
