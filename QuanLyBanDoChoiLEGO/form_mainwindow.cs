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

        public static bool is_admin = false;
        //public static ACCOUNT account;

        public form_mainwindow(ACCOUNT account)
        {
            InitializeComponent();
            //do stuff with account
            if (account.is_admin == 1)
            {
                is_admin = true;
                enableAdminControl(is_admin);
            }
            else { is_admin = false; }
        }

        private void enableAdminControl(bool is_admin = false)
        {
            if (is_admin)
            {
                btn_board_taikhoan.Enabled = true;
                btn_board_taikhoan.Visible = true;

                btn_board_banhang.Enabled = false;
                btn_board_banhang.Visible = false;
            }
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
                form_dashboard_lichsu f2 = new form_dashboard_lichsu(is_admin);
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
                form_dashboard_sanpham f2 = new form_dashboard_sanpham(is_admin);
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_mainwindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_board_taikhoan_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Tài khoản")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form_dashboard_taikhoan f2 = new form_dashboard_taikhoan();
                f2.MdiParent = this;
                f2.Show();
            }
        }
    }
}

