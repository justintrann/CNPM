using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_nhap_hang : Form
    {
        public form_nhap_hang()
        {
            InitializeComponent();
        }
        private void comboBoxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = tableCollection[comboBoxSheet.SelectedItem.ToString()];
            //dataGridViewSanPham.DataSource = data;
            if (data != null)
            {
                if (data.TableName == "NhapLoaiSanPham")
                {
                    dataGridViewSanPham.DataSource = pRODUCTTYPEBindingSource;
                    List<PRODUCT_TYPE> product_types = new List<PRODUCT_TYPE>();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        PRODUCT_TYPE product_type = new PRODUCT_TYPE();
                        product_type.product_type_name = data.Rows[i]["Tên chủ đề sản phẩm"].ToString();
                        product_type.product_type_desc = data.Rows[i]["Mô tả"].ToString();

                        product_types.Add(product_type);
                    }
                    pRODUCTTYPEBindingSource.DataSource = product_types;
                }
                else if (data.TableName == "NhapSanPham")
                {
                    dataGridViewSanPham.DataSource = pRODUCTBindingSource;
                    List<PRODUCT> products = new List<PRODUCT>();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        PRODUCT product = new PRODUCT();
                        product.id_type = Convert.ToInt32(data.Rows[i]["ID loại sản phẩm"]);
                        product.gender = IsInt(data.Rows[i]["Giới tính"].ToString());
                        product.age_range = IsInt(data.Rows[i]["Độ tuổi"].ToString());
                        product.product_name = data.Rows[i]["Tên sản phẩm"].ToString();
                        product.price = Convert.ToInt32(data.Rows[i]["Đơn giá"]);
                        product.img_path = data.Rows[i]["Hình ảnh"].ToString();
                        product.product_desc = data.Rows[i]["Mô tả"].ToString();

                        products.Add(product);
                    }
                    pRODUCTBindingSource.DataSource = products;
                }
                else if (data.TableName == "NhapKho")
                {
                    dataGridViewSanPham.DataSource = sTORAGEBindingSource;
                    List<STORAGE> storages = new List<STORAGE>();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        STORAGE storage = new STORAGE();
                        storage.id_type = Convert.ToInt32(data.Rows[i]["ID loại sản phẩm"]);
                        storage.quantity = Convert.ToInt32(data.Rows[i]["Số lượng"]);
                        storage.price = Convert.ToDouble(data.Rows[i]["Đơn giá"]);
                        storage.input_date = Convert.ToDateTime(data.Rows[i]["Ngày nhập"]);

                        storages.Add(storage);
                    }
                    sTORAGEBindingSource.DataSource = storages;
                }
            }
        }
        DataTableCollection tableCollection;
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBoxDiaChi.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                comboBoxSheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                {
                                    comboBoxSheet.Items.Add(table.TableName); //them Sheet vào comboBox
                                }
                            }
                        }
                    }
                    catch
                    {
                        string title = "Thông báo";
                        string message = "Không thể thực hiện. Xin hãy đóng file Excel để có thể tiếp tục.";
                        MessageBox.Show(message,title);
                        textBoxDiaChi.Text = "";
                    }
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-C7M7T04D\SQLEXPRESS;Initial Catalog=CNPM_NHOM_1;Integrated Security=True";
                switch (comboBoxSheet.Text)
                {
                    case "NhapLoaiSanPham":
                        DapperPlusManager.Entity<PRODUCT_TYPE>().Table("PRODUCT_TYPE");
                        List<PRODUCT_TYPE> product_types = pRODUCTTYPEBindingSource.DataSource as List<PRODUCT_TYPE>;
                        if (product_types != null)
                        {
                            using (SqlConnection db = new SqlConnection(connectionString))
                            {
                                db.BulkInsert(product_types);
                            }
                        }
                        MessageBox.Show("Hoàn tất!!!");
                        break;
                    case "NhapSanPham":
                        DapperPlusManager.Entity<PRODUCT>().Table("PRODUCT");
                        List<PRODUCT> products = pRODUCTBindingSource.DataSource as List<PRODUCT>;
                        if (products != null)
                        {
                            using (SqlConnection db = new SqlConnection(connectionString))
                            {
                                db.BulkInsert(products);
                            }
                        }
                        MessageBox.Show("Hoàn tất!!!");
                        break;
                    case "NhapKho":
                        DapperPlusManager.Entity<STORAGE>().Table("STORAGE");
                        List<STORAGE> storages = sTORAGEBindingSource.DataSource as List<STORAGE>;
                        if (storages != null)
                        {
                            using (SqlConnection db = new SqlConnection(connectionString))
                            {
                                db.BulkInsert(storages);
                            }
                        }
                        MessageBox.Show("Hoàn tất!!!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_nhap_hang_Load(object sender, EventArgs e)
        {
            
            try {
                // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PRODUCT' table. You can move, or remove it, as needed.
                this.pRODUCTTableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT);
                // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.STORAGE' table. You can move, or remove it, as needed.
                this.sTORAGETableAdapter.Fill(this.cNPM_NHOM_1DataSet.STORAGE);
                // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PRODUCT_TYPE' table. You can move, or remove it, as needed.
                this.pRODUCT_TYPETableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT_TYPE);
            }
            catch (Exception ex) { }
        }
        public int IsInt(string input)
        {
            int i = 0;
            string[] numbers = Regex.Split(input, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    i = int.Parse(value);
                    break;
                }
            }
            return i;
        }
    }
}
