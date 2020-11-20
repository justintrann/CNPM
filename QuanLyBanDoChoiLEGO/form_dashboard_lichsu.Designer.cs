namespace QuanLyBanDoChoiLEGO
{
    partial class form_dashboard_lichsu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard_lichsu));
            this.textbox_search_product = new System.Windows.Forms.TextBox();
            this.dataGridViewNhap = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_input_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofpurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasebilldescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASEBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.sTORAGE_HISTORYTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.STORAGE_HISTORYTableAdapter();
            this.dpk_search_by_date = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cNPMNHOM1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter();
            this.checkbox_search_by_time = new System.Windows.Forms.CheckBox();
            this.pURCHASE_BILLTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PURCHASE_BILLTableAdapter();
            this.btn_search = new System.Windows.Forms.Button();
            this.sTORAGEHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPMNHOM1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEBILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORAGEHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_search_product
            // 
            this.textbox_search_product.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search_product.Location = new System.Drawing.Point(48, 13);
            this.textbox_search_product.MinimumSize = new System.Drawing.Size(349, 30);
            this.textbox_search_product.Name = "textbox_search_product";
            this.textbox_search_product.Size = new System.Drawing.Size(349, 30);
            this.textbox_search_product.TabIndex = 3;
            // 
            // dataGridViewNhap
            // 
            this.dataGridViewNhap.AllowUserToAddRows = false;
            this.dataGridViewNhap.AllowUserToDeleteRows = false;
            this.dataGridViewNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_product_name,
            this.col_input_date,
            this.col_quantity});
            this.dataGridViewNhap.Location = new System.Drawing.Point(403, 58);
            this.dataGridViewNhap.Name = "dataGridViewNhap";
            this.dataGridViewNhap.ReadOnly = true;
            this.dataGridViewNhap.RowHeadersWidth = 51;
            this.dataGridViewNhap.RowTemplate.Height = 24;
            this.dataGridViewNhap.Size = new System.Drawing.Size(499, 459);
            this.dataGridViewNhap.TabIndex = 9;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id_product";
            this.col_id.HeaderText = "Mã sản phẩm";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 125;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.DataPropertyName = "product_name";
            this.col_product_name.HeaderText = "Tên sản phẩm";
            this.col_product_name.MinimumWidth = 50;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_input_date
            // 
            this.col_input_date.DataPropertyName = "input_date";
            this.col_input_date.HeaderText = "Ngày nhập";
            this.col_input_date.MinimumWidth = 6;
            this.col_input_date.Name = "col_input_date";
            this.col_input_date.ReadOnly = true;
            this.col_input_date.Width = 125;
            // 
            // col_quantity
            // 
            this.col_quantity.DataPropertyName = "quantity";
            this.col_quantity.HeaderText = "Số lượng";
            this.col_quantity.MinimumWidth = 6;
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.ReadOnly = true;
            this.col_quantity.Width = 125;
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.AllowUserToAddRows = false;
            this.dataGridViewBan.AllowUserToDeleteRows = false;
            this.dataGridViewBan.AutoGenerateColumns = false;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idstaffDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.dateofpurchaseDataGridViewTextBoxColumn,
            this.purchasebilldescDataGridViewTextBoxColumn,
            this.totalcostDataGridViewTextBoxColumn});
            this.dataGridViewBan.DataSource = this.pURCHASEBILLBindingSource;
            this.dataGridViewBan.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.ReadOnly = true;
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.RowTemplate.Height = 24;
            this.dataGridViewBan.Size = new System.Drawing.Size(385, 459);
            this.dataGridViewBan.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID hóa đơn";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idstaffDataGridViewTextBoxColumn
            // 
            this.idstaffDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idstaffDataGridViewTextBoxColumn.DataPropertyName = "id_staff";
            this.idstaffDataGridViewTextBoxColumn.HeaderText = "ID nhân viên";
            this.idstaffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstaffDataGridViewTextBoxColumn.Name = "idstaffDataGridViewTextBoxColumn";
            this.idstaffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "ID khách hàng";
            this.idcustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            this.idcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofpurchaseDataGridViewTextBoxColumn
            // 
            this.dateofpurchaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofpurchaseDataGridViewTextBoxColumn.DataPropertyName = "date_of_purchase";
            this.dateofpurchaseDataGridViewTextBoxColumn.HeaderText = "Ngày mua hàng";
            this.dateofpurchaseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofpurchaseDataGridViewTextBoxColumn.Name = "dateofpurchaseDataGridViewTextBoxColumn";
            this.dateofpurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasebilldescDataGridViewTextBoxColumn
            // 
            this.purchasebilldescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchasebilldescDataGridViewTextBoxColumn.DataPropertyName = "purchase_bill_desc";
            this.purchasebilldescDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.purchasebilldescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasebilldescDataGridViewTextBoxColumn.Name = "purchasebilldescDataGridViewTextBoxColumn";
            this.purchasebilldescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalcostDataGridViewTextBoxColumn
            // 
            this.totalcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalcostDataGridViewTextBoxColumn.DataPropertyName = "total_cost";
            this.totalcostDataGridViewTextBoxColumn.HeaderText = "Tổng số tiền";
            this.totalcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalcostDataGridViewTextBoxColumn.Name = "totalcostDataGridViewTextBoxColumn";
            this.totalcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pURCHASEBILLBindingSource
            // 
            this.pURCHASEBILLBindingSource.DataMember = "PURCHASE_BILL";
            this.pURCHASEBILLBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTORAGE_HISTORYTableAdapter
            // 
            this.sTORAGE_HISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // dpk_search_by_date
            // 
            this.dpk_search_by_date.Location = new System.Drawing.Point(531, 19);
            this.dpk_search_by_date.Name = "dpk_search_by_date";
            this.dpk_search_by_date.Size = new System.Drawing.Size(280, 22);
            this.dpk_search_by_date.TabIndex = 11;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Red;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(817, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 33);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cNPMNHOM1DataSetBindingSource1
            // 
            this.cNPMNHOM1DataSetBindingSource1.DataSource = this.cNPM_NHOM_1DataSet;
            this.cNPMNHOM1DataSetBindingSource1.Position = 0;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // checkbox_search_by_time
            // 
            this.checkbox_search_by_time.AutoSize = true;
            this.checkbox_search_by_time.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_search_by_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_search_by_time.ForeColor = System.Drawing.Color.Black;
            this.checkbox_search_by_time.Location = new System.Drawing.Point(404, 18);
            this.checkbox_search_by_time.Name = "checkbox_search_by_time";
            this.checkbox_search_by_time.Size = new System.Drawing.Size(121, 21);
            this.checkbox_search_by_time.TabIndex = 13;
            this.checkbox_search_by_time.Text = "Theo thời gian";
            this.checkbox_search_by_time.UseVisualStyleBackColor = false;
            // 
            // pURCHASE_BILLTableAdapter
            // 
            this.pURCHASE_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(12, 12);
            this.btn_search.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 30);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // sTORAGEHISTORYBindingSource
            // 
            this.sTORAGEHISTORYBindingSource.DataMember = "STORAGE_HISTORY";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataSource = this.cNPMNHOM1DataSetBindingSource;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.Blue;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(898, 14);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 33);
            this.buttonXoa.TabIndex = 14;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // form_dashboard_lichsu
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 529);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.checkbox_search_by_time);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dpk_search_by_date);
            this.Controls.Add(this.dataGridViewBan);
            this.Controls.Add(this.dataGridViewNhap);
            this.Controls.Add(this.textbox_search_product);
            this.Controls.Add(this.btn_search);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 497);
            this.Name = "form_dashboard_lichsu";
            this.ShowIcon = false;
            this.Text = "Lịch sử";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_dashboard_lichsu_Load);
            this.Resize += new System.EventHandler(this.form_history_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEBILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORAGEHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_search_product;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridViewNhap;
        private System.Windows.Forms.DataGridView dataGridViewBan;
        private System.Windows.Forms.BindingSource cNPMNHOM1DataSetBindingSource;
        private System.Windows.Forms.BindingSource sTORAGEHISTORYBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.STORAGE_HISTORYTableAdapter sTORAGE_HISTORYTableAdapter;
        private System.Windows.Forms.DateTimePicker dpk_search_by_date;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.BindingSource cNPMNHOM1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.CheckBox checkbox_search_by_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_input_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.BindingSource pURCHASEBILLBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PURCHASE_BILLTableAdapter pURCHASE_BILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofpurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasebilldescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonXoa;
    }
}