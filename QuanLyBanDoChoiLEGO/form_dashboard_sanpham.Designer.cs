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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard_sanpham));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_age_range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPMNHOM1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_type = new System.Windows.Forms.Label();
            this.lbl_product_gender = new System.Windows.Forms.Label();
            this.lbl_product_quantity = new System.Windows.Forms.Label();
            this.lbl_product_age_range = new System.Windows.Forms.Label();
            this.lbl_product_price = new System.Windows.Forms.Label();
            this.textbox_product_type = new System.Windows.Forms.TextBox();
            this.textbox_product_gender = new System.Windows.Forms.TextBox();
            this.textbox_product_quantity = new System.Windows.Forms.TextBox();
            this.textbox_product_age_range = new System.Windows.Forms.TextBox();
            this.textbox_product_price = new System.Windows.Forms.TextBox();
            this.pRODUCTTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter();
            this.textbox_product_name = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.picbox_product = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(13, 12);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 37);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Nhập kho";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(127, 12);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(147, 37);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Cập nhật kho";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
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
            this.dgv_product.DataSource = this.pRODUCTBindingSource;
            this.dgv_product.Location = new System.Drawing.Point(0, 55);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.Size = new System.Drawing.Size(559, 487);
            this.dgv_product.TabIndex = 3;
            this.dgv_product.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellEnter);
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
            this.col_product_name.ReadOnly = true;
            // 
            // col_id_type
            // 
            this.col_id_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_id_type.DataPropertyName = "id_type";
            this.col_id_type.HeaderText = "Loại sản phẩm";
            this.col_id_type.MinimumWidth = 100;
            this.col_id_type.Name = "col_id_type";
            this.col_id_type.ReadOnly = true;
            // 
            // col_gender
            // 
            this.col_gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_gender.DataPropertyName = "gender";
            this.col_gender.HeaderText = "Loại giới tính";
            this.col_gender.MinimumWidth = 50;
            this.col_gender.Name = "col_gender";
            this.col_gender.ReadOnly = true;
            this.col_gender.Width = 117;
            // 
            // col_age_range
            // 
            this.col_age_range.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_age_range.DataPropertyName = "id_age_range";
            this.col_age_range.HeaderText = "Độ tuổi";
            this.col_age_range.MinimumWidth = 75;
            this.col_age_range.Name = "col_age_range";
            this.col_age_range.ReadOnly = true;
            this.col_age_range.Width = 82;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.DataPropertyName = "price";
            this.col_price.HeaderText = "Giá tiền";
            this.col_price.MinimumWidth = 100;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
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
            this.col_product_desc.ReadOnly = true;
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
            // lbl_product_name
            // 
            this.lbl_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_name.Location = new System.Drawing.Point(577, 288);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(37, 17);
            this.lbl_product_name.TabIndex = 4;
            this.lbl_product_name.Text = "Tên:";
            // 
            // lbl_product_type
            // 
            this.lbl_product_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_type.AutoSize = true;
            this.lbl_product_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_product_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_type.Location = new System.Drawing.Point(577, 318);
            this.lbl_product_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_type.Name = "lbl_product_type";
            this.lbl_product_type.Size = new System.Drawing.Size(39, 17);
            this.lbl_product_type.TabIndex = 6;
            this.lbl_product_type.Text = "Loại:";
            // 
            // lbl_product_gender
            // 
            this.lbl_product_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_gender.AutoSize = true;
            this.lbl_product_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_product_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_gender.Location = new System.Drawing.Point(577, 347);
            this.lbl_product_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_gender.Name = "lbl_product_gender";
            this.lbl_product_gender.Size = new System.Drawing.Size(64, 17);
            this.lbl_product_gender.TabIndex = 8;
            this.lbl_product_gender.Text = "Giới tính:";
            // 
            // lbl_product_quantity
            // 
            this.lbl_product_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_quantity.AutoSize = true;
            this.lbl_product_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_product_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_quantity.Location = new System.Drawing.Point(577, 406);
            this.lbl_product_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_quantity.Name = "lbl_product_quantity";
            this.lbl_product_quantity.Size = new System.Drawing.Size(68, 17);
            this.lbl_product_quantity.TabIndex = 12;
            this.lbl_product_quantity.Text = "Số lượng:";
            // 
            // lbl_product_age_range
            // 
            this.lbl_product_age_range.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_age_range.AutoSize = true;
            this.lbl_product_age_range.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_age_range.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_product_age_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_age_range.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_age_range.Location = new System.Drawing.Point(577, 377);
            this.lbl_product_age_range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_age_range.Name = "lbl_product_age_range";
            this.lbl_product_age_range.Size = new System.Drawing.Size(57, 17);
            this.lbl_product_age_range.TabIndex = 10;
            this.lbl_product_age_range.Text = "Độ tuổi:";
            // 
            // lbl_product_price
            // 
            this.lbl_product_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_product_price.AutoSize = true;
            this.lbl_product_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_product_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_price.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_price.Location = new System.Drawing.Point(577, 436);
            this.lbl_product_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_price.Name = "lbl_product_price";
            this.lbl_product_price.Size = new System.Drawing.Size(61, 17);
            this.lbl_product_price.TabIndex = 14;
            this.lbl_product_price.Text = "Giá tiền:";
            // 
            // textbox_product_type
            // 
            this.textbox_product_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_product_type.Enabled = false;
            this.textbox_product_type.Location = new System.Drawing.Point(657, 314);
            this.textbox_product_type.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_type.Name = "textbox_product_type";
            this.textbox_product_type.Size = new System.Drawing.Size(157, 22);
            this.textbox_product_type.TabIndex = 7;
            // 
            // textbox_product_gender
            // 
            this.textbox_product_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_product_gender.Enabled = false;
            this.textbox_product_gender.Location = new System.Drawing.Point(657, 343);
            this.textbox_product_gender.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_gender.Name = "textbox_product_gender";
            this.textbox_product_gender.Size = new System.Drawing.Size(157, 22);
            this.textbox_product_gender.TabIndex = 9;
            // 
            // textbox_product_quantity
            // 
            this.textbox_product_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_product_quantity.Enabled = false;
            this.textbox_product_quantity.Location = new System.Drawing.Point(657, 402);
            this.textbox_product_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_quantity.Name = "textbox_product_quantity";
            this.textbox_product_quantity.Size = new System.Drawing.Size(157, 22);
            this.textbox_product_quantity.TabIndex = 13;
            // 
            // textbox_product_age_range
            // 
            this.textbox_product_age_range.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_product_age_range.Enabled = false;
            this.textbox_product_age_range.Location = new System.Drawing.Point(657, 373);
            this.textbox_product_age_range.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_age_range.Name = "textbox_product_age_range";
            this.textbox_product_age_range.Size = new System.Drawing.Size(157, 22);
            this.textbox_product_age_range.TabIndex = 11;
            // 
            // textbox_product_price
            // 
            this.textbox_product_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_product_price.Enabled = false;
            this.textbox_product_price.Location = new System.Drawing.Point(657, 432);
            this.textbox_product_price.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_price.Name = "textbox_product_price";
            this.textbox_product_price.Size = new System.Drawing.Size(157, 22);
            this.textbox_product_price.TabIndex = 15;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // textbox_product_name
            // 
            this.textbox_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_product_name.Enabled = false;
            this.textbox_product_name.Location = new System.Drawing.Point(657, 284);
            this.textbox_product_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_name.Name = "textbox_product_name";
            this.textbox_product_name.Size = new System.Drawing.Size(157, 22);
            this.textbox_product_name.TabIndex = 5;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(576, 463);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(240, 37);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Thistle;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(279, 12);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 37);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // picbox_product
            // 
            this.picbox_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbox_product.Image = global::QuanLyBanDoChoiLEGO.Properties.Resources.lego_placeholder;
            this.picbox_product.Location = new System.Drawing.Point(576, 55);
            this.picbox_product.Margin = new System.Windows.Forms.Padding(4);
            this.picbox_product.MinimumSize = new System.Drawing.Size(240, 222);
            this.picbox_product.Name = "picbox_product";
            this.picbox_product.Size = new System.Drawing.Size(240, 222);
            this.picbox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_product.TabIndex = 5;
            this.picbox_product.TabStop = false;
            // 
            // form_dashboard_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.textbox_product_name);
            this.Controls.Add(this.textbox_product_price);
            this.Controls.Add(this.textbox_product_quantity);
            this.Controls.Add(this.textbox_product_age_range);
            this.Controls.Add(this.textbox_product_gender);
            this.Controls.Add(this.textbox_product_type);
            this.Controls.Add(this.lbl_product_price);
            this.Controls.Add(this.lbl_product_age_range);
            this.Controls.Add(this.lbl_product_quantity);
            this.Controls.Add(this.lbl_product_gender);
            this.Controls.Add(this.lbl_product_type);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.picbox_product);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(847, 580);
            this.Name = "form_dashboard_sanpham";
            this.ShowIcon = false;
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_dashboard_sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMNHOM1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.BindingSource cNPMNHOM1DataSetBindingSource;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.PictureBox picbox_product;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.Label lbl_product_type;
        private System.Windows.Forms.Label lbl_product_gender;
        private System.Windows.Forms.Label lbl_product_quantity;
        private System.Windows.Forms.Label lbl_product_age_range;
        private System.Windows.Forms.Label lbl_product_price;
        private System.Windows.Forms.TextBox textbox_product_type;
        private System.Windows.Forms.TextBox textbox_product_gender;
        private System.Windows.Forms.TextBox textbox_product_quantity;
        private System.Windows.Forms.TextBox textbox_product_age_range;
        private System.Windows.Forms.TextBox textbox_product_price;
        private System.Windows.Forms.TextBox textbox_product_name;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_age_range;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_desc;
        public System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button btn_delete;
    }
}