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
    public partial class form_dashboard_lichsu : Form
    {
        int gridViewOffset;

        public form_dashboard_lichsu()
        {
            InitializeComponent();
            gridViewOffset = 24;

        }

        private void form_history_Resize(object sender, EventArgs e)
        {
            dataGridViewBan.Width = getNewGridViewWidth();
            dataGridViewBan.Height = getNewGridViewHeight();
            dataGridViewNhap.Width = getNewGridViewWidth() - 11;
            dataGridViewNhap.Height = getNewGridViewHeight();

            dataGridViewNhap.Location = new Point(this.Width / 2, dataGridViewNhap.Location.Y);
        }

        private int getNewGridViewWidth()
        {
            return this.Width / 2 - gridViewOffset;
        }

        private int getNewGridViewHeight()
        {
            return this.Height - 117;
        }

        private void form_dashboard_lichsu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PURCHASE_BILL' table. You can move, or remove it, as needed.
            this.pURCHASE_BILLTableAdapter.Fill(this.cNPM_NHOM_1DataSet.PURCHASE_BILL);
            loadDataFromDatabase();            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            string search_string = textbox_search_product.Text;
            if (String.IsNullOrWhiteSpace(search_string))
            { 
                if (checkbox_search_by_time.Checked)
                {
                    //search theo thời điểm
                    DateTime date_search = dpk_search_by_date.Value.Date.Date;
                    dataGridViewNhap.DataSource = db.STORAGE_HISTORies.OrderBy(p => p.input_date).Join(db.PRODUCTs, x => x.id_product, y => y.id, (x, y) => new
                    {
                        id_product = x.id_product,
                        product_name = y.product_name,
                        input_date = x.input_date,
                        quantity = x.quantity,
                    }).Where(p => p.input_date.Value.Date == date_search);
                }
                else
                    loadDataFromDatabase();
            }
            else
            {
                PRODUCT product = db.PRODUCTs.Where(p => p.product_name.StartsWith(search_string)).FirstOrDefault();
                if (product != null)
                {
                    int id = product.id;
                    if (checkbox_search_by_time.Checked)
                    {
                        //search theo thời điểm
                        //search theo ngay
                        DateTime date_search = dpk_search_by_date.Value.Date.Date;
                        dataGridViewNhap.DataSource = db.STORAGE_HISTORies.OrderBy(p => p.input_date).Join(db.PRODUCTs, x => x.id_product, y => y.id, (x, y) => new
                        {
                            id_product = x.id_product,
                            product_name = y.product_name,
                            input_date = x.input_date,
                            quantity = x.quantity,
                        }).Where(p => p.id_product == id && p.input_date.Value.Date == date_search);
                    }
                    else
                    {
                        dataGridViewNhap.DataSource = db.STORAGE_HISTORies.OrderBy(p => p.input_date).Join(db.PRODUCTs, x => x.id_product, y => y.id, (x, y) => new
                        {
                            id_product = x.id_product,
                            product_name = y.product_name,
                            input_date = x.input_date,
                            quantity = x.quantity,
                        }).Where(p => p.id_product == id);
                    }
                }
                else
                {
                    MessageBox.Show("Không thấy wtf");
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadDataFromDatabase();
        }

        private void loadDataFromDatabase()
        {
            //this.sTORAGE_HISTORYTableAdapter.Fill(this.cNPM_NHOM_1DataSet.STORAGE_HISTORY);
            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            //dataGridViewNhap.DataSource = db.PRODUCTs.OrderBy(p => p.id).Select(p => new
            //{
            //    product_name = p.product_name
            //});
            dataGridViewNhap.DataSource = db.STORAGE_HISTORies.OrderBy(p => p.input_date).Join(db.PRODUCTs, x => x.id_product, y => y.id, (x,y) => new
            {
                id_product = x.id_product,
                product_name = y.product_name,
                input_date = x.input_date,
                quantity = x.quantity,
                //DATE_TEST = x.input_date.Value.Date
            }) ;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            form_delete_sanpham_2 delete = new form_delete_sanpham_2();
            DialogResult result = delete.ShowDialog();
            loadDataFromDatabase();
        }
    }
}
