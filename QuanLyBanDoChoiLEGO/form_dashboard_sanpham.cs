using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public form_dashboard_sanpham()
        {
            InitializeComponent();
        }
        private void form_dashboard_sanpham_load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand query1 = new SqlCommand("SELECT * FROM PRODUCT", sqlCon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query1);
            da.Fill(dt);
            dataGridViewKho.DataSource = dt;
            sqlCon.Close();
        }
        private void buttonNhapKho_Click(object sender, EventArgs e)
        {
            form_nhap_hang f1 = new form_nhap_hang();
            f1.Show();
        }
    }
}
