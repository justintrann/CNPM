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
    public partial class form_nhap_hang : Form
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=LAPTOP-C7M7T04D\SQLEXPRESS;Initial Catalog=CNPM_NHOM_1;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public form_nhap_hang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            CNPM_NHOM_1Entities11 en = new CNPM_NHOM_1Entities11();
            PRODUCT_TYPE type = new PRODUCT_TYPE();
            PRODUCT product = new PRODUCT();
            STORAGE storage = new STORAGE();

            type.id = Convert.ToInt32(textBoxIDLoai.Text);
            type.product_type_name = textBoxTenLoai.Text;

            product.id = Convert.ToInt32(textBoxIDSanPham.Text);
            product.id_type = Convert.ToInt32(textBoxIDLoai.Text);
            product.product_name = textBoxTenSanPham.Text;
            product.gender = comboBoxGioiTinh.Text;
            product.age_range = comboBoxDoTuoi.Text;
            product.price = Convert.ToDouble(textBoxDonGia.Text);

            /*storage.id_type = Convert.ToInt32(textBoxIDLoai.Text);
            storage.product_type_name = textBoxTenLoai.Text;
            storage.id_product = Convert.ToInt32(textBoxIDSanPham.Text);
            storage.product_name = textBoxTenSanPham.Text;
            storage.gender = comboBoxGioiTinh.Text;
            storage.age_range = comboBoxDoTuoi.Text;
            storage.quantity = Convert.ToInt32(textBoxSoLuong.Text);
            product.price = storage.price = Convert.ToDouble(textBoxDonGia.Text);*/

            en.PRODUCT_TYPE.Add(type);
            en.PRODUCTs.Add(product);
            //en.STORAGEs.Add(storage);

            en.SaveChanges();

            MessageBox.Show("Đã lưu.");
            this.Close();
        }
    }
}
