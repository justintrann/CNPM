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
    public partial class form_nhap_hang : Form
    {
        public form_nhap_hang()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_nhap_hang_Load(object sender, EventArgs e)
        {
            this.aGE_RANGETableAdapter.Fill(this.cNPM_NHOM_1DataSet.AGE_RANGE);
            this.pRODUCT_TYPETableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT_TYPE);
            cbox_product_type.Text = HelperClass.defaultSelectString;
            cbox_age_range.Text = HelperClass.defaultSelectString;
            cbox_gender.Text = HelperClass.defaultSelectString;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        private bool addProduct()
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

                string product_name = textbox_product_name.Text;
                CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

                PRODUCT new_product = db.PRODUCTs.Where(p => p.product_name == product_name).SingleOrDefault();


                //if (new_product == null)
                //{
                //    new_product = new PRODUCT();
                //    new_product.id = 100;
                //    new_product.product_name = textbox_product_name.Text;
                //    new_product.id_type = (byte)cbox_product_type.SelectedValue;
                //    new_product.gender = (byte)cbox_gender.SelectedValue.ToString();
                //    new_product.id_age_range = (byte)cbox_age_range.SelectedValue;
                //    new_product.quantity = (int)numud_quantity.Value;
                //    new_product.price = (double)numud_price.Value;
                //    new_product.product_desc = textbox_product_desc.Text;
                //    new_product.img_path = "";
                //    db.PRODUCTs.InsertOnSubmit(new_product);
                //    db.SubmitChanges();
                //    return true;
                //}

                if (new_product == null)
                {
                    new_product = new PRODUCT();
                    new_product.product_name = textbox_product_name.Text;
                    new_product.id_type = (byte)cbox_product_type.SelectedValue;
                    new_product.gender = HelperClass.getGenderValue(cbox_gender.SelectedItem.ToString());
                    new_product.id_age_range = (byte)cbox_age_range.SelectedValue;
                    new_product.quantity = (int)numud_quantity.Value;
                    new_product.price = (double)numud_price.Value;
                    new_product.product_desc = textbox_product_desc.Text;
                    new_product.img_path = "";
                    db.PRODUCTs.InsertOnSubmit(new_product);
                    db.SubmitChanges();
                    return true;
                }

                else
                {
                    MessageBox.Show("Bị trùng tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void cbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
