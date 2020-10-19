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
    public partial class form_dashboard_banhang : Form
    {
        int listViewOffset;

        public form_dashboard_banhang()
        {
            InitializeComponent();
            listViewOffset = 24;
            
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Đơn Thanh Toán")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_customer_information f2 = new form_customer_information();
                f2.Show();
            }
        }

        private void form_dashboard_banhang_Resize(object sender, EventArgs e)
        {
            listViewProduct.Width = getNewListViewWidth();
            listViewProduct.Height = getNewListViewHeight();
            listViewIsSelectedProduct.Width = getNewListViewWidth() - 11;
            listViewIsSelectedProduct.Height = getNewListViewHeight() - textBoxTongTien.Height - 20;
            textBoxTongTien.Width = getNewTextBoxWidth();

            listViewIsSelectedProduct.Location = new Point(this.Width / 2, listViewIsSelectedProduct.Location.Y);
            labelTongTien.Location = new Point(this.Width / 2, buttonCheckOut.Location.Y);
            textBoxTongTien.Location = new Point(labelTongTien.Location.X + labelTongTien.Size.Width, buttonCheckOut.Location.Y);
        }

        private int getNewListViewWidth()
        {
            return this.Width / 2 - listViewOffset;
        }

        private int getNewTextBoxWidth()
        {
            return getNewListViewWidth() - buttonCheckOut.Width - labelTongTien.Width - listViewOffset;
        }

        private int getNewListViewHeight()
        {
            return this.Height - 117;
        }
    }
}
