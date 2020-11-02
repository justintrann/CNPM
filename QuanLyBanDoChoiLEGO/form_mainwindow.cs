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
    public partial class form_mainwindow : Form
    {
        public form_mainwindow()
        {
            InitializeComponent();
        }

        private void btn_board_1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Bán Hàng")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_dashboard_banhang f2 = new form_dashboard_banhang();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void btn_board_2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Lịch sử")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_dashboard_lichsu f2 = new form_dashboard_lichsu();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void btn_board_3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Thống kê")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_dashboard_thongke f2 = new form_dashboard_thongke();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void btn_board_sanpham_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Sản phẩm")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_dashboard_sanpham f2 = new form_dashboard_sanpham();
                f2.MdiParent = this;
                f2.Show();
            }
        }
    }
}

