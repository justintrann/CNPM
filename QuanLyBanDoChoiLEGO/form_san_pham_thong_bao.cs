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
    public partial class form_san_pham_thong_bao : Form
    {
        public form_san_pham_thong_bao()
        {
            InitializeComponent();
        }

        private void buttonThuCong_Click(object sender, EventArgs e)
        {
            form_nhap_hang nhaphang1 = new form_nhap_hang();
            DialogResult result = nhaphang1.ShowDialog();
            this.Close();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            form_nhap_hang_2 nhaphang2 = new form_nhap_hang_2();
            DialogResult result = nhaphang2.ShowDialog();
            this.Close();
        }
    }
}
