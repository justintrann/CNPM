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
            loadDataFromDatabase();            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            string search_string = textbox_search_product.Text;
            var products = db.STORAGE_HISTORies.Join(db.PRODUCTs, x => x.id_product, y => y.id, (x, y) => new
            {
                id_product = x.id_product,
                product_name = y.product_name,
                input_date = x.input_date,
                quantity = x.quantity,
            }).Where(p => p.product_name.StartsWith(search_string)).ToArray();
            if (String.IsNullOrWhiteSpace(search_string))
            {
                if (checkbox_search_by_time.Checked)
                {
                    //search theo thời điểm
                    DateTime date_search = dpk_search_by_date.Value.Date.Date;
                    dataGridViewNhap.DataSource = db.STORAGE_HISTORies.OrderByDescending(p => p.input_date).Join(db.PRODUCTs, x => x.id_product, y => y.id, (x, y) => new
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
                //PRODUCT[] products = db.PRODUCTs.Where(p => p.product_name.StartsWith(search_string)).Select(p => p).ToArray();
                if (checkbox_search_by_time.Checked)
                {
                    //search theo thời điểm
                    //search theo ngay
                    DateTime date_search = dpk_search_by_date.Value.Date.Date;
                    dataGridViewNhap.DataSource = products.Where(p => p.input_date.Value.Date == date_search).ToArray();
                }
                else
                {
                    dataGridViewNhap.DataSource = products;
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
    }
}
