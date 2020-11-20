using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult login_result;
            ACCOUNT account = new ACCOUNT();
            using (var loginForm = new form_login())
            {
                login_result = loginForm.ShowDialog();
                account = loginForm.account;
            }

            if (login_result == DialogResult.OK)
            {
                Application.Run(new form_mainwindow(account));
            }
            //Application.Run(new form_login());
            //Application.Run(new form_mainwindow());
            //Application.Run(new form_dashboard_sanpham());
            //Application.Run(new form_dashboard_thongke());
        }
    }
}
