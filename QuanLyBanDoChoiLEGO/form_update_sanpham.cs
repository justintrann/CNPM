using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_update_sanpham : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C7M7T04D\SQLEXPRESS;Initial Catalog=CNPM_NHOM_1;Integrated Security=True");
        //SqlCommand cmd, cmd2;

        public form_update_sanpham()
        {
            InitializeComponent();
        }

        private void form_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.AGE_RANGE' table. You can move, or remove it, as needed.
            this.aGE_RANGETableAdapter.Fill(this.cNPM_NHOM_1DataSet.AGE_RANGE);
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PRODUCT_TYPE' table. You can move, or remove it, as needed.
            this.pRODUCT_TYPETableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT_TYPE);
            this.aGE_RANGETableAdapter.Fill(this.cNPM_NHOM_1DataSet.AGE_RANGE);
            this.pRODUCT_TYPETableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT_TYPE);
            cbox_product_type.Text = HelperClass.defaultSelectString;
            cbox_age_range.Text = HelperClass.defaultSelectString;
            cbox_gender.Text = HelperClass.defaultSelectString;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            bool result = updateProduct();
            if (result) { DialogResult = DialogResult.OK; this.Close(); }
        }

        private bool updateProduct()
        {
            if (String.IsNullOrEmpty(textbox_product_name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (cbox_product_type.Text == HelperClass.defaultSelectString)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cbox_gender.Text == HelperClass.defaultSelectString)
                {
                    MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cbox_age_range.Text == HelperClass.defaultSelectString)
                {
                    MessageBox.Show("Vui lòng chọn độ tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string product_id = textbox_product_id.Text;
                CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

                PRODUCT new_product = db.PRODUCTs.SingleOrDefault(p => p.id == Convert.ToInt32(product_id));

                if (new_product != null)
                {
                    new_product.product_name = textbox_product_name.Text;
                    new_product.id_type = (byte)cbox_product_type.SelectedValue;
                    new_product.gender = HelperClass.getGenderValue(cbox_gender.SelectedItem.ToString());
                    new_product.id_age_range = (byte)cbox_age_range.SelectedValue;
                    new_product.quantity = (int)numud_quantity.Value;
                    new_product.price = (double)numud_price.Value;
                    new_product.product_desc = textbox_product_desc.Text;
                    new_product.img_path = "";
                    db.SubmitChanges();
                    return true;
                }

                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
