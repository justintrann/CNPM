using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_sanpham : Form
    {
        string connectionString = @"Data Source=LAPTOP-C7M7T04D\SQLEXPRESS;Initial Catalog=CNPM_NHOM_1;Integrated Security=True";
        internal static form_nhap_hang nhap_hang;
        internal static form_dashboard_sanpham san_pham;
        public form_dashboard_sanpham()
        {
            InitializeComponent();
            san_pham = this;
        }
        
       private void form_dashboard_san_pham_load(object render, EventArgs e)
        {
            /*SqlDataAdapter da = new SqlDataAdapter("SELECT  FROM ");
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;*/
        }
        private void buttonNhapKho_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-C7M7T04D\SQLEXPRESS;Initial Catalog=CNPM_NHOM_1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            
            nhap_hang = new form_nhap_hang();
            string message = "Bạn có muốn tiếp tục?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                nhap_hang.Show();
            }
        }
    }
}
