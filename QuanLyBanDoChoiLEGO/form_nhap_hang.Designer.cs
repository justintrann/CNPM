namespace QuanLyBanDoChoiLEGO
{
    partial class form_nhap_hang
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.textbox_product_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_product_type = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cbox_gender = new System.Windows.Forms.ComboBox();
            this.cbox_product_type = new System.Windows.Forms.ComboBox();
            this.pRODUCTTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.cbox_age_range = new System.Windows.Forms.ComboBox();
            this.aGERANGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_age_range = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.numud_quantity = new System.Windows.Forms.NumericUpDown();
            this.numud_price = new System.Windows.Forms.NumericUpDown();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pRODUCT_TYPETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter();
            this.aGE_RANGETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.AGE_RANGETableAdapter();
            this.textbox_product_desc = new System.Windows.Forms.TextBox();
            this.lbl_product_desc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGERANGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_price)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(12, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(101, 13);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Thông tin sản phẩm";
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Location = new System.Drawing.Point(32, 58);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(78, 13);
            this.lbl_product_name.TabIndex = 1;
            this.lbl_product_name.Text = "Tên sản phẩm:";
            // 
            // textbox_product_name
            // 
            this.textbox_product_name.Location = new System.Drawing.Point(113, 55);
            this.textbox_product_name.Name = "textbox_product_name";
            this.textbox_product_name.Size = new System.Drawing.Size(157, 20);
            this.textbox_product_name.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(195, 298);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_product_type
            // 
            this.lbl_product_type.AutoSize = true;
            this.lbl_product_type.Location = new System.Drawing.Point(32, 82);
            this.lbl_product_type.Name = "lbl_product_type";
            this.lbl_product_type.Size = new System.Drawing.Size(79, 13);
            this.lbl_product_type.TabIndex = 3;
            this.lbl_product_type.Text = "Loại sản phẩm:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(32, 106);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(50, 13);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "Giới tính:";
            // 
            // cbox_gender
            // 
            this.cbox_gender.FormattingEnabled = true;
            this.cbox_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbox_gender.Location = new System.Drawing.Point(113, 102);
            this.cbox_gender.Name = "cbox_gender";
            this.cbox_gender.Size = new System.Drawing.Size(157, 21);
            this.cbox_gender.TabIndex = 6;
            this.cbox_gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_KeyPress);
            // 
            // cbox_product_type
            // 
            this.cbox_product_type.DataSource = this.pRODUCTTYPEBindingSource;
            this.cbox_product_type.DisplayMember = "product_type_name";
            this.cbox_product_type.FormattingEnabled = true;
            this.cbox_product_type.Location = new System.Drawing.Point(113, 78);
            this.cbox_product_type.Name = "cbox_product_type";
            this.cbox_product_type.Size = new System.Drawing.Size(157, 21);
            this.cbox_product_type.TabIndex = 4;
            this.cbox_product_type.ValueMember = "id";
            this.cbox_product_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_KeyPress);
            // 
            // pRODUCTTYPEBindingSource
            // 
            this.pRODUCTTYPEBindingSource.DataMember = "PRODUCT_TYPE";
            this.pRODUCTTYPEBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbox_age_range
            // 
            this.cbox_age_range.DataSource = this.aGERANGEBindingSource;
            this.cbox_age_range.DisplayMember = "age_range_name";
            this.cbox_age_range.FormattingEnabled = true;
            this.cbox_age_range.Location = new System.Drawing.Point(113, 126);
            this.cbox_age_range.Name = "cbox_age_range";
            this.cbox_age_range.Size = new System.Drawing.Size(157, 21);
            this.cbox_age_range.TabIndex = 8;
            this.cbox_age_range.ValueMember = "id";
            this.cbox_age_range.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_KeyPress);
            // 
            // aGERANGEBindingSource
            // 
            this.aGERANGEBindingSource.DataMember = "AGE_RANGE";
            this.aGERANGEBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // lbl_age_range
            // 
            this.lbl_age_range.AutoSize = true;
            this.lbl_age_range.Location = new System.Drawing.Point(32, 130);
            this.lbl_age_range.Name = "lbl_age_range";
            this.lbl_age_range.Size = new System.Drawing.Size(44, 13);
            this.lbl_age_range.TabIndex = 7;
            this.lbl_age_range.Text = "Độ tuổi:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(32, 178);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(46, 13);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Giá tiền:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(32, 154);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(52, 13);
            this.lbl_quantity.TabIndex = 9;
            this.lbl_quantity.Text = "Số lượng:";
            // 
            // numud_quantity
            // 
            this.numud_quantity.Location = new System.Drawing.Point(113, 150);
            this.numud_quantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numud_quantity.Name = "numud_quantity";
            this.numud_quantity.Size = new System.Drawing.Size(157, 20);
            this.numud_quantity.TabIndex = 10;
            this.numud_quantity.ThousandsSeparator = true;
            // 
            // numud_price
            // 
            this.numud_price.DecimalPlaces = 2;
            this.numud_price.Location = new System.Drawing.Point(113, 173);
            this.numud_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numud_price.Name = "numud_price";
            this.numud_price.Size = new System.Drawing.Size(157, 20);
            this.numud_price.TabIndex = 12;
            this.numud_price.ThousandsSeparator = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(114, 298);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pRODUCT_TYPETableAdapter
            // 
            this.pRODUCT_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // aGE_RANGETableAdapter
            // 
            this.aGE_RANGETableAdapter.ClearBeforeFill = true;
            // 
            // textbox_product_desc
            // 
            this.textbox_product_desc.Location = new System.Drawing.Point(36, 226);
            this.textbox_product_desc.MaxLength = 100;
            this.textbox_product_desc.Multiline = true;
            this.textbox_product_desc.Name = "textbox_product_desc";
            this.textbox_product_desc.Size = new System.Drawing.Size(234, 58);
            this.textbox_product_desc.TabIndex = 15;
            // 
            // lbl_product_desc
            // 
            this.lbl_product_desc.AutoSize = true;
            this.lbl_product_desc.Location = new System.Drawing.Point(33, 202);
            this.lbl_product_desc.Name = "lbl_product_desc";
            this.lbl_product_desc.Size = new System.Drawing.Size(37, 13);
            this.lbl_product_desc.TabIndex = 16;
            this.lbl_product_desc.Text = "Mô tả:";
            // 
            // form_nhap_hang
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(305, 347);
            this.Controls.Add(this.lbl_product_desc);
            this.Controls.Add(this.textbox_product_desc);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.numud_price);
            this.Controls.Add(this.numud_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.cbox_age_range);
            this.Controls.Add(this.lbl_age_range);
            this.Controls.Add(this.cbox_product_type);
            this.Controls.Add(this.cbox_gender);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_product_type);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textbox_product_name);
            this.Controls.Add(this.lbl_product_name);
            this.Controls.Add(this.lbl_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_nhap_hang";
            this.Text = "Nhập sản phẩm mới";
            this.Load += new System.EventHandler(this.form_nhap_hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGERANGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.TextBox textbox_product_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_product_type;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cbox_gender;
        private System.Windows.Forms.ComboBox cbox_product_type;
        private System.Windows.Forms.ComboBox cbox_age_range;
        private System.Windows.Forms.Label lbl_age_range;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.NumericUpDown numud_quantity;
        private System.Windows.Forms.NumericUpDown numud_price;
        private System.Windows.Forms.Button btn_cancel;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTTYPEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter pRODUCT_TYPETableAdapter;
        private System.Windows.Forms.BindingSource aGERANGEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.AGE_RANGETableAdapter aGE_RANGETableAdapter;
        private System.Windows.Forms.TextBox textbox_product_desc;
        private System.Windows.Forms.Label lbl_product_desc;
    }
}