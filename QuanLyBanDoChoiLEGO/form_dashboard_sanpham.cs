using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_sanpham : Form
    {
        public static bool is_admin = false;
        public form_dashboard_sanpham()
        {
            InitializeComponent();
        }

        public form_dashboard_sanpham(bool admin = false)
        {
            InitializeComponent();
            //do stuff with account
            if (admin)
            {
                is_admin = true;
                enableAdminControl(is_admin);
            }
            else { is_admin = false; }

        }

        private void form_dashboard_sanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT);
            loadDataFromDatabase();
            //displayProductInfo();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_san_pham_thong_bao thongbao = new form_san_pham_thong_bao();
            DialogResult result = thongbao.ShowDialog();
            loadDataFromDatabase();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            form_update_sanpham update = new form_update_sanpham();
            DialogResult result = update.ShowDialog();
            loadDataFromDatabase();
        }

        private void dgv_product_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0) return;

            int id = int.Parse(dgv_product.Rows[indexRow].Cells[0].Value.ToString());

            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            PRODUCT product = db.PRODUCTs.Where(p => p.id == id).SingleOrDefault();
            if (product != null)
            {
                displayProductInfo(product);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadDataFromDatabase();
        }

        private void loadDataFromDatabase()
        {
            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            dgv_product.DataSource = db.PRODUCTs.Select(p => new
            {
                id = p.id,
                id_type = p.PRODUCT_TYPE.product_type_name,
                product_name = p.product_name,
                id_age_range = p.AGE_RANGE.age_range_name,
                gender = HelperClass.getGenderString(p.gender),
                price = p.price,
                quantity = p.quantity,
                product_desc = p.product_desc
            });
        }
        
        private void displayProductInfo(PRODUCT product)
        {
            textbox_product_name.Text = product.product_name.ToString();
            textbox_product_type.Text = HelperClass.getProductTypeNameString(product.id_type);
            textbox_product_gender.Text = HelperClass.getGenderString(product.gender);
            textbox_product_age_range.Text = HelperClass.getAgeRangeString(product.id_age_range);
            textbox_product_quantity.Text = product.quantity.ToString();
            textbox_product_price.Text = product.price.ToString();

            string filepath = "../../../" + product.img_path.ToString();
            picbox_product.Image = getImageFromFile(filepath);
        }

        private Image getImageFromFile(string filepath)
        {
            Image image;
            try
            {
                image = Image.FromFile(filepath);
            }
            catch (FileNotFoundException)
            {
                image = Properties.Resources.lego_placeholder;
                //throw;
            }
            return image;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            form_delete_sanpham delete = new form_delete_sanpham();
            DialogResult result = delete.ShowDialog();
            loadDataFromDatabase();
        }
        private void enableAdminControl(bool is_admin = false)
        {
            if (is_admin)
            {
                btn_delete.Enabled = true;
                btn_delete.Visible = true;
            }
        }
    }
}
