﻿using System;
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
    public partial class form_dashboard_sanpham : Form
    {
        public form_dashboard_sanpham()
        {
            InitializeComponent();
        }

        private void form_dashboard_sanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.cNPM_NHOM_1DataSet.PRODUCT);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_nhap_hang form = new form_nhap_hang();
            DialogResult dialog_result = form.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP");
        }

        private void btn_storage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP");
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
                p.id,
                p.id_type,
                p.product_name,
                p.id_age_range,
                //p.QUYEN,
                //p.KICHHOAT
            });
            //LoadCboMaTK();
        }

        private void displayProductInfo(PRODUCT product)
        {
            textbox_product_name.Text = product.product_name.ToString();
            textbox_product_type.Text = product.id_type.ToString();
            //textbox_product_gender.Text = product.gender.ToString();
            switch (product.gender)
            {
                case 0: textbox_product_gender.Text = "Nam"; break;
                case 1: textbox_product_gender.Text = "Nữ"; break;
                default: textbox_product_gender.Text = "Khác"; break;
            }
            textbox_product_age_range.Text = product.id_age_range.ToString();
            
            textbox_product_quantity.Text = product.quantity.ToString();
            textbox_product_price.Text = product.price.ToString();
            picbox_product.Image = Image.FromFile("../../../" + product.img_path.ToString());
        }
    }
}
