namespace QuanLyBanDoChoiLEGO
{
    partial class form_dashboard_sanpham
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_storage = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPMNHOM1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.pRODUCTTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.picbox_product = new System.Windows.Forms.PictureBox();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_age_range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(10, 10);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Nhập kho";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(95, 10);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 30);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Cập nhật kho";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_storage
            // 
            this.btn_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_storage.Location = new System.Drawing.Point(209, 10);
            this.btn_storage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.Size = new System.Drawing.Size(101, 30);
            this.btn_storage.TabIndex = 2;
            this.btn_storage.Text = "Xem tồn kho";
            this.btn_storage.UseVisualStyleBackColor = true;
            // 
            // dgv_product
            // 
            this.dgv_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_product.AutoGenerateColumns = false;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_product_name,
            this.col_id_type,
            this.col_gender,
            this.col_age_range,
            this.col_price,
            this.col_quantity,
            this.col_product_desc});
            this.dgv_product.DataSource = this.pRODUCTBindingSource1;
            this.dgv_product.Location = new System.Drawing.Point(0, 45);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.Size = new System.Drawing.Size(379, 316);
            this.dgv_product.TabIndex = 4;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.cNPMNHOM1DataSetBindingSource;
            // 
            // cNPMNHOM1DataSetBindingSource
            // 
            this.cNPMNHOM1DataSetBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            this.cNPMNHOM1DataSetBindingSource.Position = 0;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.cNPMNHOM1DataSetBindingSource;
            // 
            // picbox_product
            // 
            this.picbox_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbox_product.Image = global::QuanLyBanDoChoiLEGO.Properties.Resources.lego_placeholder;
            this.picbox_product.Location = new System.Drawing.Point(392, 45);
            this.picbox_product.MinimumSize = new System.Drawing.Size(180, 180);
            this.picbox_product.Name = "picbox_product";
            this.picbox_product.Size = new System.Drawing.Size(180, 180);
            this.picbox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_product.TabIndex = 5;
            this.picbox_product.TabStop = false;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "Mã sản phẩm";
            this.col_id.MinimumWidth = 50;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 50;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.DataPropertyName = "product_name";
            this.col_product_name.HeaderText = "Tên sản phẩm";
            this.col_product_name.MinimumWidth = 135;
            this.col_product_name.Name = "col_product_name";
            // 
            // col_id_type
            // 
            this.col_id_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_id_type.DataPropertyName = "id_type";
            this.col_id_type.HeaderText = "Loại sản phẩm";
            this.col_id_type.MinimumWidth = 100;
            this.col_id_type.Name = "col_id_type";
            // 
            // col_gender
            // 
            this.col_gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_gender.DataPropertyName = "gender";
            this.col_gender.HeaderText = "Loại giới tính";
            this.col_gender.MinimumWidth = 50;
            this.col_gender.Name = "col_gender";
            this.col_gender.Width = 69;
            // 
            // col_age_range
            // 
            this.col_age_range.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_age_range.DataPropertyName = "age_range";
            this.col_age_range.HeaderText = "Độ tuổi";
            this.col_age_range.MinimumWidth = 75;
            this.col_age_range.Name = "col_age_range";
            this.col_age_range.Width = 75;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.DataPropertyName = "price";
            this.col_price.HeaderText = "Giá tiền";
            this.col_price.MinimumWidth = 100;
            this.col_price.Name = "col_price";
            // 
            // col_quantity
            // 
            this.col_quantity.DataPropertyName = "quantity";
            this.col_quantity.HeaderText = "Số lượng";
            this.col_quantity.MinimumWidth = 75;
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.ReadOnly = true;
            this.col_quantity.Width = 75;
            // 
            // col_product_desc
            // 
            this.col_product_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_desc.DataPropertyName = "product_desc";
            this.col_product_desc.HeaderText = "Mô tả";
            this.col_product_desc.MinimumWidth = 100;
            this.col_product_desc.Name = "col_product_desc";
            // 
            // form_dashboard_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.picbox_product);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.btn_storage);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "form_dashboard_sanpham";
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_dashboard_sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_storage;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.BindingSource cNPMNHOM1DataSetBindingSource;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private System.Windows.Forms.PictureBox picbox_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_age_range;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_desc;
    }
}