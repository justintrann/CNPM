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
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }
        public static int loggedIn;
        public ACCOUNT account = new ACCOUNT();
        private bool is_valid = false;
        private void btn_login_Click(object sender, EventArgs e)
        {
            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

            //truy vấn tài khoản trong CSDL
            account = db.ACCOUNTs.Where(p => p.username == textbox_username.Text && p.pass == textbox_password.Text).SingleOrDefault();
            
            if (account == null)
            {
                MessageBox.Show("Sai tài khoản/mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
/*
                if (account.is_verified == false)
                {
                    MessageBox.Show("Tài khoản chưa được kích hoạt\n" +
                        "Vui lòng liên hệ admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                else
                {
                    is_valid = true;
                    //quyền bình thường
                    if (account.is_admin == 0)
                    {
                        MessageBox.Show("Xin chào " + account.username, "Đăng nhập thành công", MessageBoxButtons.OK);
                        DialogResult = DialogResult.OK;
                    }
                    //quyền admin
                    if (account.is_admin == 1)
                    {
                        MessageBox.Show("Xin chào " + account.username + "\nbạn đang đăng nhập bằng quyền admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        DialogResult = DialogResult.OK;
                    }
                }
*/
                is_valid = true;
                //quyền bình thường
                if (account.is_admin == 0)
                {
                    loggedIn = (int)db.ACCOUNTs.Where(t => t.username == textbox_username.Text).Select(z => z.id_staff).SingleOrDefault();
                    MessageBox.Show("Xin chào " + account.username, "Đăng nhập thành công", MessageBoxButtons.OK);
                    DialogResult = DialogResult.OK;
                }
                //quyền admin
                if (account.is_admin == 1)
                {
                   // loggedIn = (byte)db.ACCOUNTs.Where(t => t.username == textbox_username.Text).Select(t => t.id).SingleOrDefault();
                    MessageBox.Show("Xin chào " + account.username + "\nbạn đang đăng nhập bằng quyền admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    DialogResult = DialogResult.OK;
                }
            }

            if (is_valid)
            {
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void login_textboxes_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textbox_username.Text) && String.IsNullOrEmpty(textbox_password.Text))
            {
                btn_login.Enabled = false;
            }
            else
            {
                btn_login.Enabled = true;
            }
        }
    }
}
