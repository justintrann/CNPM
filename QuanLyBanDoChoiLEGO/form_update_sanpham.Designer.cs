
namespace QuanLyBanDoChoiLEGO
{
    partial class form_update_sanpham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_product_desc = new System.Windows.Forms.Label();
            this.textbox_product_desc = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.numud_price = new System.Windows.Forms.NumericUpDown();
            this.numud_quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.cbox_age_range = new System.Windows.Forms.ComboBox();
            this.aGERANGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.lbl_age_range = new System.Windows.Forms.Label();
            this.cbox_product_type = new System.Windows.Forms.ComboBox();
            this.pRODUCTTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbox_gender = new System.Windows.Forms.ComboBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_product_type = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.textbox_product_name = new System.Windows.Forms.TextBox();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.textbox_product_id = new System.Windows.Forms.TextBox();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.pRODUCT_TYPETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter();
            this.aGE_RANGETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.AGE_RANGETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGERANGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_product_desc);
            this.groupBox1.Controls.Add(this.textbox_product_desc);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.numud_price);
            this.groupBox1.Controls.Add(this.numud_quantity);
            this.groupBox1.Controls.Add(this.lbl_price);
            this.groupBox1.Controls.Add(this.lbl_quantity);
            this.groupBox1.Controls.Add(this.cbox_age_range);
            this.groupBox1.Controls.Add(this.lbl_age_range);
            this.groupBox1.Controls.Add(this.cbox_product_type);
            this.groupBox1.Controls.Add(this.cbox_gender);
            this.groupBox1.Controls.Add(this.lbl_gender);
            this.groupBox1.Controls.Add(this.lbl_product_type);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.textbox_product_name);
            this.groupBox1.Controls.Add(this.lbl_product_name);
            this.groupBox1.Controls.Add(this.textbox_product_id);
            this.groupBox1.Controls.Add(this.lbl_product_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 417);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // lbl_product_desc
            // 
            this.lbl_product_desc.AutoSize = true;
            this.lbl_product_desc.Location = new System.Drawing.Point(32, 247);
            this.lbl_product_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_desc.Name = "lbl_product_desc";
            this.lbl_product_desc.Size = new System.Drawing.Size(47, 17);
            this.lbl_product_desc.TabIndex = 66;
            this.lbl_product_desc.Text = "Mô tả:";
            // 
            // textbox_product_desc
            // 
            this.textbox_product_desc.Location = new System.Drawing.Point(36, 276);
            this.textbox_product_desc.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_desc.MaxLength = 100;
            this.textbox_product_desc.Multiline = true;
            this.textbox_product_desc.Name = "textbox_product_desc";
            this.textbox_product_desc.Size = new System.Drawing.Size(311, 70);
            this.textbox_product_desc.TabIndex = 65;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(140, 365);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 64;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // numud_price
            // 
            this.numud_price.DecimalPlaces = 2;
            this.numud_price.Location = new System.Drawing.Point(139, 211);
            this.numud_price.Margin = new System.Windows.Forms.Padding(4);
            this.numud_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numud_price.Name = "numud_price";
            this.numud_price.Size = new System.Drawing.Size(209, 22);
            this.numud_price.TabIndex = 62;
            this.numud_price.ThousandsSeparator = true;
            // 
            // numud_quantity
            // 
            this.numud_quantity.Location = new System.Drawing.Point(139, 183);
            this.numud_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.numud_quantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numud_quantity.Name = "numud_quantity";
            this.numud_quantity.Size = new System.Drawing.Size(209, 22);
            this.numud_quantity.TabIndex = 60;
            this.numud_quantity.ThousandsSeparator = true;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(31, 217);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(61, 17);
            this.lbl_price.TabIndex = 61;
            this.lbl_price.Text = "Giá tiền:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(31, 188);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(68, 17);
            this.lbl_quantity.TabIndex = 59;
            this.lbl_quantity.Text = "Số lượng:";
            // 
            // cbox_age_range
            // 
            this.cbox_age_range.DataSource = this.aGERANGEBindingSource;
            this.cbox_age_range.DisplayMember = "age_range_name";
            this.cbox_age_range.FormattingEnabled = true;
            this.cbox_age_range.Location = new System.Drawing.Point(139, 153);
            this.cbox_age_range.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_age_range.Name = "cbox_age_range";
            this.cbox_age_range.Size = new System.Drawing.Size(208, 24);
            this.cbox_age_range.TabIndex = 58;
            this.cbox_age_range.ValueMember = "id";
            // 
            // aGERANGEBindingSource
            // 
            this.aGERANGEBindingSource.DataMember = "AGE_RANGE";
            this.aGERANGEBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_age_range
            // 
            this.lbl_age_range.AutoSize = true;
            this.lbl_age_range.Location = new System.Drawing.Point(31, 158);
            this.lbl_age_range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_age_range.Name = "lbl_age_range";
            this.lbl_age_range.Size = new System.Drawing.Size(57, 17);
            this.lbl_age_range.TabIndex = 57;
            this.lbl_age_range.Text = "Độ tuổi:";
            // 
            // cbox_product_type
            // 
            this.cbox_product_type.DataSource = this.pRODUCTTYPEBindingSource;
            this.cbox_product_type.DisplayMember = "product_type_name";
            this.cbox_product_type.FormattingEnabled = true;
            this.cbox_product_type.Location = new System.Drawing.Point(139, 94);
            this.cbox_product_type.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_product_type.Name = "cbox_product_type";
            this.cbox_product_type.Size = new System.Drawing.Size(208, 24);
            this.cbox_product_type.TabIndex = 54;
            this.cbox_product_type.ValueMember = "id";
            // 
            // pRODUCTTYPEBindingSource
            // 
            this.pRODUCTTYPEBindingSource.DataMember = "PRODUCT_TYPE";
            this.pRODUCTTYPEBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // cbox_gender
            // 
            this.cbox_gender.FormattingEnabled = true;
            this.cbox_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbox_gender.Location = new System.Drawing.Point(139, 124);
            this.cbox_gender.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_gender.Name = "cbox_gender";
            this.cbox_gender.Size = new System.Drawing.Size(208, 24);
            this.cbox_gender.TabIndex = 56;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(31, 128);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(64, 17);
            this.lbl_gender.TabIndex = 55;
            this.lbl_gender.Text = "Giới tính:";
            // 
            // lbl_product_type
            // 
            this.lbl_product_type.AutoSize = true;
            this.lbl_product_type.Location = new System.Drawing.Point(31, 99);
            this.lbl_product_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_type.Name = "lbl_product_type";
            this.lbl_product_type.Size = new System.Drawing.Size(105, 17);
            this.lbl_product_type.TabIndex = 53;
            this.lbl_product_type.Text = "Loại sản phẩm:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(248, 365);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 63;
            this.btn_add.Text = "Lưu";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // textbox_product_name
            // 
            this.textbox_product_name.Location = new System.Drawing.Point(139, 66);
            this.textbox_product_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_name.Name = "textbox_product_name";
            this.textbox_product_name.Size = new System.Drawing.Size(208, 22);
            this.textbox_product_name.TabIndex = 52;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Location = new System.Drawing.Point(31, 69);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(103, 17);
            this.lbl_product_name.TabIndex = 51;
            this.lbl_product_name.Text = "Tên sản phẩm:";
            // 
            // textbox_product_id
            // 
            this.textbox_product_id.Location = new System.Drawing.Point(139, 36);
            this.textbox_product_id.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_id.Name = "textbox_product_id";
            this.textbox_product_id.Size = new System.Drawing.Size(209, 22);
            this.textbox_product_id.TabIndex = 50;
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Location = new System.Drawing.Point(31, 39);
            this.lbl_product_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(91, 17);
            this.lbl_product_id.TabIndex = 49;
            this.lbl_product_id.Text = "ID sản phẩm:";
            // 
            // pRODUCT_TYPETableAdapter
            // 
            this.pRODUCT_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // aGE_RANGETableAdapter
            // 
            this.aGE_RANGETableAdapter.ClearBeforeFill = true;
            // 
            // form_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 440);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_update";
            this.Text = "Cập nhật sản phẩm";
            this.Load += new System.EventHandler(this.form_update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGERANGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_product_desc;
        private System.Windows.Forms.TextBox textbox_product_desc;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.NumericUpDown numud_price;
        private System.Windows.Forms.NumericUpDown numud_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.ComboBox cbox_age_range;
        private System.Windows.Forms.Label lbl_age_range;
        private System.Windows.Forms.ComboBox cbox_product_type;
        private System.Windows.Forms.ComboBox cbox_gender;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_product_type;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textbox_product_name;
        private System.Windows.Forms.Label lbl_product_name;
        public System.Windows.Forms.TextBox textbox_product_id;
        private System.Windows.Forms.Label lbl_product_id;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTTYPEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter pRODUCT_TYPETableAdapter;
        private System.Windows.Forms.BindingSource aGERANGEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.AGE_RANGETableAdapter aGE_RANGETableAdapter;
    }
}