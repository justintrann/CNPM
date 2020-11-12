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
    public partial class form_nhap_hang : Form
    {
        public form_nhap_hang()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_nhap_hang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.AGE_RANGE' table. You can move, or remove it, as needed.
            this.aGE_RANGETableAdapter.Fill(this.cNPM_NHOM_1DataSet.AGE_RANGE);
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PRODUCT_TYPE' table. You can move, or remove it, as needed.
            this.pRODUCT_TYPETableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT_TYPE);

        }
    }
}
