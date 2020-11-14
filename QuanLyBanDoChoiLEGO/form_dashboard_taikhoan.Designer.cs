
namespace QuanLyBanDoChoiLEGO
{
    partial class form_dashboard_taikhoan
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grb_WorkerInfo = new System.Windows.Forms.GroupBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbo_Phai = new System.Windows.Forms.ComboBox();
            this.cbo_MaNV = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_Phai = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sTAFFTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.STAFFTableAdapter();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.grb_WorkerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grb_WorkerInfo);
            this.tabPage2.Controls.Add(this.dgv_staff);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grb_WorkerInfo
            // 
            this.grb_WorkerInfo.Controls.Add(this.dtp_NgaySinh);
            this.grb_WorkerInfo.Controls.Add(this.cbo_Phai);
            this.grb_WorkerInfo.Controls.Add(this.cbo_MaNV);
            this.grb_WorkerInfo.Controls.Add(this.btn_delete);
            this.grb_WorkerInfo.Controls.Add(this.btn_add);
            this.grb_WorkerInfo.Controls.Add(this.btn_edit);
            this.grb_WorkerInfo.Controls.Add(this.btn_save);
            this.grb_WorkerInfo.Controls.Add(this.btn_refresh);
            this.grb_WorkerInfo.Controls.Add(this.lbl_SDT);
            this.grb_WorkerInfo.Controls.Add(this.txt_SDT);
            this.grb_WorkerInfo.Controls.Add(this.lbl_Phai);
            this.grb_WorkerInfo.Controls.Add(this.lbl_NgaySinh);
            this.grb_WorkerInfo.Controls.Add(this.txt_HoTen);
            this.grb_WorkerInfo.Controls.Add(this.lbl_HoTen);
            this.grb_WorkerInfo.Controls.Add(this.lbl_MaNV);
            this.grb_WorkerInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_WorkerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_WorkerInfo.Location = new System.Drawing.Point(3, 3);
            this.grb_WorkerInfo.Name = "grb_WorkerInfo";
            this.grb_WorkerInfo.Size = new System.Drawing.Size(359, 389);
            this.grb_WorkerInfo.TabIndex = 4;
            this.grb_WorkerInfo.TabStop = false;
            this.grb_WorkerInfo.Text = "Thông tin nhân viên";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dtp_NgaySinh.Enabled = false;
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(92, 88);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(102, 22);
            this.dtp_NgaySinh.TabIndex = 2;
            // 
            // cbo_Phai
            // 
            this.cbo_Phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Phai.Enabled = false;
            this.cbo_Phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Phai.FormattingEnabled = true;
            this.cbo_Phai.Location = new System.Drawing.Point(247, 88);
            this.cbo_Phai.Name = "cbo_Phai";
            this.cbo_Phai.Size = new System.Drawing.Size(63, 24);
            this.cbo_Phai.TabIndex = 3;
            // 
            // cbo_MaNV
            // 
            this.cbo_MaNV.DataSource = this.sTAFFBindingSource;
            this.cbo_MaNV.DisplayMember = "id";
            this.cbo_MaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaNV.FormattingEnabled = true;
            this.cbo_MaNV.Location = new System.Drawing.Point(92, 30);
            this.cbo_MaNV.Name = "cbo_MaNV";
            this.cbo_MaNV.Size = new System.Drawing.Size(218, 24);
            this.cbo_MaNV.TabIndex = 0;
            this.cbo_MaNV.ValueMember = "id";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(247, 176);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 30);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(20, 176);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 30);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(20, 212);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 30);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(131, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(131, 212);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_SDT.Location = new System.Drawing.Point(50, 119);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(35, 16);
            this.lbl_SDT.TabIndex = 1;
            this.lbl_SDT.Text = "SĐT";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_SDT.Location = new System.Drawing.Point(91, 116);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(219, 22);
            this.txt_SDT.TabIndex = 4;
            // 
            // lbl_Phai
            // 
            this.lbl_Phai.AutoSize = true;
            this.lbl_Phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_Phai.Location = new System.Drawing.Point(203, 92);
            this.lbl_Phai.Name = "lbl_Phai";
            this.lbl_Phai.Size = new System.Drawing.Size(35, 16);
            this.lbl_Phai.TabIndex = 1;
            this.lbl_Phai.Text = "Phái";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_NgaySinh.Location = new System.Drawing.Point(17, 92);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(68, 16);
            this.lbl_NgaySinh.TabIndex = 1;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_HoTen.Location = new System.Drawing.Point(92, 60);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(218, 22);
            this.txt_HoTen.TabIndex = 1;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_HoTen.Location = new System.Drawing.Point(17, 63);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(69, 16);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ tên NV";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_MaNV.Location = new System.Drawing.Point(36, 33);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(49, 16);
            this.lbl_MaNV.TabIndex = 1;
            this.lbl_MaNV.Text = "Mã NV";
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_HoTen,
            this.col_Phai,
            this.col_SDT,
            this.col_NgayVaoLam});
            this.dgv_staff.Location = new System.Drawing.Point(368, 3);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.Size = new System.Drawing.Size(578, 389);
            this.dgv_staff.TabIndex = 3;
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 421);
            this.tabControl1.TabIndex = 3;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "Mã nhân viên";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 75;
            // 
            // col_HoTen
            // 
            this.col_HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_HoTen.DataPropertyName = "HOTEN";
            this.col_HoTen.HeaderText = "Họ và tên";
            this.col_HoTen.Name = "col_HoTen";
            this.col_HoTen.ReadOnly = true;
            // 
            // col_Phai
            // 
            this.col_Phai.DataPropertyName = "PHAI";
            this.col_Phai.HeaderText = "Phái";
            this.col_Phai.Name = "col_Phai";
            this.col_Phai.ReadOnly = true;
            this.col_Phai.Width = 50;
            // 
            // col_SDT
            // 
            this.col_SDT.DataPropertyName = "SODT";
            this.col_SDT.HeaderText = "Số điện thoại";
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.ReadOnly = true;
            // 
            // col_NgayVaoLam
            // 
            this.col_NgayVaoLam.DataPropertyName = "NGVL";
            this.col_NgayVaoLam.HeaderText = "Ngày nhận việc";
            this.col_NgayVaoLam.Name = "col_NgayVaoLam";
            this.col_NgayVaoLam.ReadOnly = true;
            // 
            // form_dashboard_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "form_dashboard_taikhoan";
            this.Text = "Quản lí tài khoản";
            this.Load += new System.EventHandler(this.form_dashboard_taikhoan_Load);
            this.tabPage2.ResumeLayout(false);
            this.grb_WorkerInfo.ResumeLayout(false);
            this.grb_WorkerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grb_WorkerInfo;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.ComboBox cbo_Phai;
        private System.Windows.Forms.ComboBox cbo_MaNV;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_Phai;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.TabControl tabControl1;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayVaoLam;
    }
}