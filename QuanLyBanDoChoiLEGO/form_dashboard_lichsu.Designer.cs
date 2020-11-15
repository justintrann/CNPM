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
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridViewNhap = new System.Windows.Forms.DataGridView();
            this.sTORAGEHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.cNPMNHOM1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORAGE_HISTORYTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.STORAGE_HISTORYTableAdapter();
            this.dpk_search_by_date = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cNPMNHOM1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter();
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.checkbox_search_by_time = new System.Windows.Forms.CheckBox();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_input_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORAGEHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
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
            // sTORAGEHISTORYBindingSource
            // 
            this.sTORAGEHISTORYBindingSource.DataMember = "STORAGE_HISTORY";
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBan.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.RowHeadersWidth = 51;
            this.dataGridViewBan.RowTemplate.Height = 24;
            this.dataGridViewBan.Size = new System.Drawing.Size(385, 459);
            this.dataGridViewBan.TabIndex = 10;
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
            this.btn_refresh.Location = new System.Drawing.Point(827, 19);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cNPMNHOM1DataSetBindingSource1
            // 
            this.cNPMNHOM1DataSetBindingSource1.DataSource = this.cNPM_NHOM_1DataSet;
            this.cNPMNHOM1DataSetBindingSource1.Position = 0;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataSource = this.cNPMNHOM1DataSetBindingSource;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkbox_search_by_time
            // 
            this.checkbox_search_by_time.AutoSize = true;
            this.checkbox_search_by_time.Location = new System.Drawing.Point(404, 18);
            this.checkbox_search_by_time.Name = "checkbox_search_by_time";
            this.checkbox_search_by_time.Size = new System.Drawing.Size(121, 21);
            this.checkbox_search_by_time.TabIndex = 13;
            this.checkbox_search_by_time.Text = "Theo thời gian";
            this.checkbox_search_by_time.UseVisualStyleBackColor = true;
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
            // form_dashboard_lichsu
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.checkbox_search_by_time);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.dpk_search_by_date);
            this.Controls.Add(this.dataGridViewBan);
            this.Controls.Add(this.dataGridViewNhap);
            this.Controls.Add(this.textbox_search_product);
            this.Controls.Add(this.btn_search);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "form_dashboard_lichsu";
            this.Text = "Lịch sử";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_dashboard_lichsu_Load);
            this.Resize += new System.EventHandler(this.form_history_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORAGEHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
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
    }
}