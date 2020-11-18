namespace QuanLyBanDoChoiLEGO
{
    partial class form_nhap_hang_2
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
            this.buttonImport = new System.Windows.Forms.Button();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.labelTenFile = new System.Windows.Forms.Label();
            this.labelSheet = new System.Windows.Forms.Label();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.labelNhapKho = new System.Windows.Forms.Label();
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.pRODUCTTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCT_TYPETableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter();
            this.sTORAGEHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORAGE_HISTORYTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.STORAGE_HISTORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORAGEHISTORYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(404, 456);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(94, 35);
            this.buttonImport.TabIndex = 15;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(78, 456);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.Size = new System.Drawing.Size(320, 24);
            this.comboBoxSheet.TabIndex = 14;
            this.comboBoxSheet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSheet_SelectedIndexChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Location = new System.Drawing.Point(1029, 425);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 35);
            this.buttonBrowse.TabIndex = 13;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(78, 428);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxDiaChi.Size = new System.Drawing.Size(945, 22);
            this.textBoxDiaChi.TabIndex = 12;
            // 
            // labelTenFile
            // 
            this.labelTenFile.AutoSize = true;
            this.labelTenFile.BackColor = System.Drawing.Color.Transparent;
            this.labelTenFile.ForeColor = System.Drawing.Color.White;
            this.labelTenFile.Location = new System.Drawing.Point(9, 428);
            this.labelTenFile.Name = "labelTenFile";
            this.labelTenFile.Size = new System.Drawing.Size(59, 17);
            this.labelTenFile.TabIndex = 11;
            this.labelTenFile.Text = "Tên File";
            // 
            // labelSheet
            // 
            this.labelSheet.AutoSize = true;
            this.labelSheet.BackColor = System.Drawing.Color.Transparent;
            this.labelSheet.ForeColor = System.Drawing.Color.White;
            this.labelSheet.Location = new System.Drawing.Point(23, 456);
            this.labelSheet.Name = "labelSheet";
            this.labelSheet.Size = new System.Drawing.Size(45, 17);
            this.labelSheet.TabIndex = 10;
            this.labelSheet.Text = "Sheet";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AllowUserToDeleteRows = false;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(1092, 355);
            this.dataGridViewSanPham.TabIndex = 9;
            // 
            // labelNhapKho
            // 
            this.labelNhapKho.AutoSize = true;
            this.labelNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.labelNhapKho.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapKho.Location = new System.Drawing.Point(403, 24);
            this.labelNhapKho.Name = "labelNhapKho";
            this.labelNhapKho.Size = new System.Drawing.Size(295, 26);
            this.labelNhapKho.TabIndex = 8;
            this.labelNhapKho.Text = "Xin mời nhập món hàng";
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
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // sTORAGEHISTORYBindingSource
            // 
            this.sTORAGEHISTORYBindingSource.DataMember = "STORAGE_HISTORY";
            this.sTORAGEHISTORYBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // sTORAGE_HISTORYTableAdapter
            // 
            this.sTORAGE_HISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // form_nhap_hang_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::QuanLyBanDoChoiLEGO.Properties.Resources.lego_wallpaper_hd_1366x768_1296312;
            this.ClientSize = new System.Drawing.Size(1114, 493);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.labelTenFile);
            this.Controls.Add(this.labelSheet);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.labelNhapKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_nhap_hang_2";
            this.Text = "form_nhap_hang_2";
            this.Load += new System.EventHandler(this.form_nhap_hang_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORAGEHISTORYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label labelTenFile;
        private System.Windows.Forms.Label labelSheet;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Label labelNhapKho;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTTYPEBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCT_TYPETableAdapter pRODUCT_TYPETableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.BindingSource sTORAGEHISTORYBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.STORAGE_HISTORYTableAdapter sTORAGE_HISTORYTableAdapter;
    }
}