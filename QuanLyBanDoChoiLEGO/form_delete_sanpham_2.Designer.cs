
namespace QuanLyBanDoChoiLEGO
{
    partial class form_delete_sanpham_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_delete_sanpham_2));
            this.aGERANGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.pRODUCTTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCT_TYPETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter();
            this.aGE_RANGETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.AGE_RANGETableAdapter();
            this.tabControlXoaNhapHang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn__cancel = new System.Windows.Forms.Button();
            this.btn_product_delete = new System.Windows.Forms.Button();
            this.lbl_product_id = new System.Windows.Forms.Label();
            this.textbox_product_id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_bill_delete = new System.Windows.Forms.Button();
            this.lbl_bill_id = new System.Windows.Forms.Label();
            this.textbox_bill_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aGERANGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).BeginInit();
            this.tabControlXoaNhapHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // pRODUCTTYPEBindingSource
            // 
            this.pRODUCTTYPEBindingSource.DataMember = "PRODUCT_TYPE";
            this.pRODUCTTYPEBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // pRODUCT_TYPETableAdapter
            // 
            this.pRODUCT_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // aGE_RANGETableAdapter
            // 
            this.aGE_RANGETableAdapter.ClearBeforeFill = true;
            // 
            // tabControlXoaNhapHang
            // 
            this.tabControlXoaNhapHang.Controls.Add(this.tabPage1);
            this.tabControlXoaNhapHang.Controls.Add(this.tabPage2);
            this.tabControlXoaNhapHang.Location = new System.Drawing.Point(12, 12);
            this.tabControlXoaNhapHang.Name = "tabControlXoaNhapHang";
            this.tabControlXoaNhapHang.SelectedIndex = 0;
            this.tabControlXoaNhapHang.Size = new System.Drawing.Size(337, 105);
            this.tabControlXoaNhapHang.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn__cancel);
            this.tabPage1.Controls.Add(this.btn_product_delete);
            this.tabPage1.Controls.Add(this.lbl_product_id);
            this.tabPage1.Controls.Add(this.textbox_product_id);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(329, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn__cancel
            // 
            this.btn__cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn__cancel.ForeColor = System.Drawing.Color.Black;
            this.btn__cancel.Location = new System.Drawing.Point(113, 37);
            this.btn__cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn__cancel.Name = "btn__cancel";
            this.btn__cancel.Size = new System.Drawing.Size(100, 28);
            this.btn__cancel.TabIndex = 64;
            this.btn__cancel.Text = "Hủy";
            this.btn__cancel.UseVisualStyleBackColor = true;
            // 
            // btn_product_delete
            // 
            this.btn_product_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_product_delete.Location = new System.Drawing.Point(221, 37);
            this.btn_product_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_product_delete.Name = "btn_product_delete";
            this.btn_product_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_product_delete.TabIndex = 63;
            this.btn_product_delete.Text = "Xóa";
            this.btn_product_delete.UseVisualStyleBackColor = true;
            this.btn_product_delete.Click += new System.EventHandler(this.btn_product_delete_Click);
            // 
            // lbl_product_id
            // 
            this.lbl_product_id.AutoSize = true;
            this.lbl_product_id.Location = new System.Drawing.Point(5, 10);
            this.lbl_product_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_id.Name = "lbl_product_id";
            this.lbl_product_id.Size = new System.Drawing.Size(91, 17);
            this.lbl_product_id.TabIndex = 49;
            this.lbl_product_id.Text = "ID sản phẩm:";
            // 
            // textbox_product_id
            // 
            this.textbox_product_id.Location = new System.Drawing.Point(113, 7);
            this.textbox_product_id.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_product_id.Name = "textbox_product_id";
            this.textbox_product_id.Size = new System.Drawing.Size(209, 22);
            this.textbox_product_id.TabIndex = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancel);
            this.tabPage2.Controls.Add(this.btn_bill_delete);
            this.tabPage2.Controls.Add(this.lbl_bill_id);
            this.tabPage2.Controls.Add(this.textbox_bill_id);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(114, 39);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 68;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_bill_delete
            // 
            this.btn_bill_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_bill_delete.Location = new System.Drawing.Point(222, 39);
            this.btn_bill_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bill_delete.Name = "btn_bill_delete";
            this.btn_bill_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_bill_delete.TabIndex = 67;
            this.btn_bill_delete.Text = "Xóa";
            this.btn_bill_delete.UseVisualStyleBackColor = true;
            this.btn_bill_delete.Click += new System.EventHandler(this.btn_bill_delete_Click);
            // 
            // lbl_bill_id
            // 
            this.lbl_bill_id.AutoSize = true;
            this.lbl_bill_id.Location = new System.Drawing.Point(6, 12);
            this.lbl_bill_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bill_id.Name = "lbl_bill_id";
            this.lbl_bill_id.Size = new System.Drawing.Size(91, 17);
            this.lbl_bill_id.TabIndex = 65;
            this.lbl_bill_id.Text = "ID sản phẩm:";
            // 
            // textbox_bill_id
            // 
            this.textbox_bill_id.Location = new System.Drawing.Point(114, 9);
            this.textbox_bill_id.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_bill_id.Name = "textbox_bill_id";
            this.textbox_bill_id.Size = new System.Drawing.Size(209, 22);
            this.textbox_bill_id.TabIndex = 66;
            // 
            // form_delete_sanpham_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDoChoiLEGO.Properties.Resources.lego_wallpaper_hd_1366x768_129631;
            this.ClientSize = new System.Drawing.Size(358, 131);
            this.Controls.Add(this.tabControlXoaNhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_delete_sanpham_2";
            this.Text = "Xóa sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.aGERANGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).EndInit();
            this.tabControlXoaNhapHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTTYPEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter pRODUCT_TYPETableAdapter;
        private System.Windows.Forms.BindingSource aGERANGEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.AGE_RANGETableAdapter aGE_RANGETableAdapter;
        private System.Windows.Forms.TabControl tabControlXoaNhapHang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn__cancel;
        private System.Windows.Forms.Button btn_product_delete;
        private System.Windows.Forms.Label lbl_product_id;
        public System.Windows.Forms.TextBox textbox_product_id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_bill_delete;
        private System.Windows.Forms.Label lbl_bill_id;
        public System.Windows.Forms.TextBox textbox_bill_id;
    }
}