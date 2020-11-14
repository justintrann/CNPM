
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
            this.tabpage_account = new System.Windows.Forms.TabPage();
            this.tabpage_staff = new System.Windows.Forms.TabPage();
            this.groupbox_staff = new System.Windows.Forms.GroupBox();
            this.dtp_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.cbox_id = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.textbox_phone_number = new System.Windows.Forms.TextBox();
            this.lbl_date_of_birth = new System.Windows.Forms.Label();
            this.textbox_staff_name = new System.Windows.Forms.TextBox();
            this.lbl_staff_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.tab_account = new System.Windows.Forms.TabControl();
            this.sTAFFTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.STAFFTableAdapter();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_home_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_citizen_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_home_address = new System.Windows.Forms.Label();
            this.textbox_home_address = new System.Windows.Forms.TextBox();
            this.lbl_citizen_id = new System.Windows.Forms.Label();
            this.textbox_citizen_id = new System.Windows.Forms.TextBox();
            this.tabpage_staff.SuspendLayout();
            this.groupbox_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.tab_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpage_account
            // 
            this.tabpage_account.Location = new System.Drawing.Point(4, 22);
            this.tabpage_account.Name = "tabpage_account";
            this.tabpage_account.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_account.Size = new System.Drawing.Size(1003, 395);
            this.tabpage_account.TabIndex = 2;
            this.tabpage_account.Text = "Tài khoản";
            this.tabpage_account.UseVisualStyleBackColor = true;
            // 
            // tabpage_staff
            // 
            this.tabpage_staff.Controls.Add(this.groupbox_staff);
            this.tabpage_staff.Controls.Add(this.dgv_staff);
            this.tabpage_staff.Location = new System.Drawing.Point(4, 22);
            this.tabpage_staff.Name = "tabpage_staff";
            this.tabpage_staff.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_staff.Size = new System.Drawing.Size(1003, 395);
            this.tabpage_staff.TabIndex = 1;
            this.tabpage_staff.Text = "Nhân viên";
            this.tabpage_staff.UseVisualStyleBackColor = true;
            // 
            // groupbox_staff
            // 
            this.groupbox_staff.Controls.Add(this.lbl_citizen_id);
            this.groupbox_staff.Controls.Add(this.textbox_citizen_id);
            this.groupbox_staff.Controls.Add(this.lbl_home_address);
            this.groupbox_staff.Controls.Add(this.textbox_home_address);
            this.groupbox_staff.Controls.Add(this.dtp_date_of_birth);
            this.groupbox_staff.Controls.Add(this.cbox_id);
            this.groupbox_staff.Controls.Add(this.btn_delete);
            this.groupbox_staff.Controls.Add(this.btn_add);
            this.groupbox_staff.Controls.Add(this.btn_edit);
            this.groupbox_staff.Controls.Add(this.btn_save);
            this.groupbox_staff.Controls.Add(this.btn_refresh);
            this.groupbox_staff.Controls.Add(this.lbl_phone_number);
            this.groupbox_staff.Controls.Add(this.textbox_phone_number);
            this.groupbox_staff.Controls.Add(this.lbl_date_of_birth);
            this.groupbox_staff.Controls.Add(this.textbox_staff_name);
            this.groupbox_staff.Controls.Add(this.lbl_staff_name);
            this.groupbox_staff.Controls.Add(this.lbl_id);
            this.groupbox_staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupbox_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_staff.Location = new System.Drawing.Point(3, 3);
            this.groupbox_staff.Name = "groupbox_staff";
            this.groupbox_staff.Size = new System.Drawing.Size(359, 389);
            this.groupbox_staff.TabIndex = 4;
            this.groupbox_staff.TabStop = false;
            this.groupbox_staff.Text = "Thông tin nhân viên";
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dtp_date_of_birth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTAFFBindingSource, "date_of_birth", true));
            this.dtp_date_of_birth.Enabled = false;
            this.dtp_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(92, 88);
            this.dtp_date_of_birth.Name = "dtp_date_of_birth";
            this.dtp_date_of_birth.Size = new System.Drawing.Size(218, 22);
            this.dtp_date_of_birth.TabIndex = 2;
            // 
            // cbox_id
            // 
            this.cbox_id.DataSource = this.sTAFFBindingSource;
            this.cbox_id.DisplayMember = "id";
            this.cbox_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_id.FormattingEnabled = true;
            this.cbox_id.Location = new System.Drawing.Point(92, 30);
            this.cbox_id.Name = "cbox_id";
            this.cbox_id.Size = new System.Drawing.Size(218, 24);
            this.cbox_id.TabIndex = 0;
            this.cbox_id.ValueMember = "id";
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
            this.btn_delete.Location = new System.Drawing.Point(247, 295);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 30);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(20, 295);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 30);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(20, 331);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 30);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(131, 295);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(131, 331);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_phone_number.Location = new System.Drawing.Point(50, 119);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(35, 16);
            this.lbl_phone_number.TabIndex = 1;
            this.lbl_phone_number.Text = "SĐT";
            // 
            // textbox_phone_number
            // 
            this.textbox_phone_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "phone_number", true));
            this.textbox_phone_number.Enabled = false;
            this.textbox_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_phone_number.Location = new System.Drawing.Point(91, 116);
            this.textbox_phone_number.MaxLength = 11;
            this.textbox_phone_number.Name = "textbox_phone_number";
            this.textbox_phone_number.Size = new System.Drawing.Size(219, 22);
            this.textbox_phone_number.TabIndex = 4;
            // 
            // lbl_date_of_birth
            // 
            this.lbl_date_of_birth.AutoSize = true;
            this.lbl_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_date_of_birth.Location = new System.Drawing.Point(17, 92);
            this.lbl_date_of_birth.Name = "lbl_date_of_birth";
            this.lbl_date_of_birth.Size = new System.Drawing.Size(68, 16);
            this.lbl_date_of_birth.TabIndex = 1;
            this.lbl_date_of_birth.Text = "Ngày sinh";
            // 
            // textbox_staff_name
            // 
            this.textbox_staff_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "staff_name", true));
            this.textbox_staff_name.Enabled = false;
            this.textbox_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_staff_name.Location = new System.Drawing.Point(92, 60);
            this.textbox_staff_name.MaxLength = 50;
            this.textbox_staff_name.Name = "textbox_staff_name";
            this.textbox_staff_name.Size = new System.Drawing.Size(218, 22);
            this.textbox_staff_name.TabIndex = 1;
            // 
            // lbl_staff_name
            // 
            this.lbl_staff_name.AutoSize = true;
            this.lbl_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_staff_name.Location = new System.Drawing.Point(17, 63);
            this.lbl_staff_name.Name = "lbl_staff_name";
            this.lbl_staff_name.Size = new System.Drawing.Size(69, 16);
            this.lbl_staff_name.TabIndex = 1;
            this.lbl_staff_name.Text = "Họ tên NV";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_id.Location = new System.Drawing.Point(36, 33);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(49, 16);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Mã NV";
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_staff.AutoGenerateColumns = false;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_staff_name,
            this.col_phone_number,
            this.col_date_of_birth,
            this.col_home_address,
            this.col_citizen_id});
            this.dgv_staff.DataSource = this.sTAFFBindingSource;
            this.dgv_staff.Location = new System.Drawing.Point(368, 3);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.Size = new System.Drawing.Size(632, 389);
            this.dgv_staff.TabIndex = 3;
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // tab_account
            // 
            this.tab_account.Controls.Add(this.tabpage_staff);
            this.tab_account.Controls.Add(this.tabpage_account);
            this.tab_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_account.Location = new System.Drawing.Point(0, 0);
            this.tab_account.Name = "tab_account";
            this.tab_account.SelectedIndex = 0;
            this.tab_account.Size = new System.Drawing.Size(1011, 421);
            this.tab_account.TabIndex = 3;
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
            // 
            // col_staff_name
            // 
            this.col_staff_name.DataPropertyName = "staff_name";
            this.col_staff_name.HeaderText = "Họ và tên";
            this.col_staff_name.Name = "col_staff_name";
            this.col_staff_name.ReadOnly = true;
            // 
            // col_phone_number
            // 
            this.col_phone_number.DataPropertyName = "phone_number";
            this.col_phone_number.HeaderText = "Số điện thoại";
            this.col_phone_number.Name = "col_phone_number";
            this.col_phone_number.ReadOnly = true;
            // 
            // col_date_of_birth
            // 
            this.col_date_of_birth.DataPropertyName = "date_of_birth";
            this.col_date_of_birth.HeaderText = "Ngày sinh";
            this.col_date_of_birth.Name = "col_date_of_birth";
            this.col_date_of_birth.ReadOnly = true;
            // 
            // col_home_address
            // 
            this.col_home_address.DataPropertyName = "home_address";
            this.col_home_address.HeaderText = "Địa chỉ nhà";
            this.col_home_address.Name = "col_home_address";
            this.col_home_address.ReadOnly = true;
            // 
            // col_citizen_id
            // 
            this.col_citizen_id.DataPropertyName = "citizen_id";
            this.col_citizen_id.HeaderText = "CMND";
            this.col_citizen_id.Name = "col_citizen_id";
            this.col_citizen_id.ReadOnly = true;
            // 
            // lbl_home_address
            // 
            this.lbl_home_address.AutoSize = true;
            this.lbl_home_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_home_address.Location = new System.Drawing.Point(17, 181);
            this.lbl_home_address.Name = "lbl_home_address";
            this.lbl_home_address.Size = new System.Drawing.Size(73, 16);
            this.lbl_home_address.TabIndex = 11;
            this.lbl_home_address.Text = "Địa chỉ nhà";
            // 
            // textbox_home_address
            // 
            this.textbox_home_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "home_address", true));
            this.textbox_home_address.Enabled = false;
            this.textbox_home_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_home_address.Location = new System.Drawing.Point(20, 200);
            this.textbox_home_address.MaxLength = 100;
            this.textbox_home_address.Multiline = true;
            this.textbox_home_address.Name = "textbox_home_address";
            this.textbox_home_address.Size = new System.Drawing.Size(294, 65);
            this.textbox_home_address.TabIndex = 12;
            // 
            // lbl_citizen_id
            // 
            this.lbl_citizen_id.AutoSize = true;
            this.lbl_citizen_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_citizen_id.Location = new System.Drawing.Point(37, 148);
            this.lbl_citizen_id.Name = "lbl_citizen_id";
            this.lbl_citizen_id.Size = new System.Drawing.Size(48, 16);
            this.lbl_citizen_id.TabIndex = 13;
            this.lbl_citizen_id.Text = "CMND";
            // 
            // textbox_citizen_id
            // 
            this.textbox_citizen_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "citizen_id", true));
            this.textbox_citizen_id.Enabled = false;
            this.textbox_citizen_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_citizen_id.Location = new System.Drawing.Point(91, 145);
            this.textbox_citizen_id.MaxLength = 11;
            this.textbox_citizen_id.Name = "textbox_citizen_id";
            this.textbox_citizen_id.Size = new System.Drawing.Size(219, 22);
            this.textbox_citizen_id.TabIndex = 14;
            // 
            // form_dashboard_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 421);
            this.Controls.Add(this.tab_account);
            this.Name = "form_dashboard_taikhoan";
            this.Text = "Quản lí tài khoản";
            this.Load += new System.EventHandler(this.form_dashboard_taikhoan_Load);
            this.tabpage_staff.ResumeLayout(false);
            this.groupbox_staff.ResumeLayout(false);
            this.groupbox_staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.tab_account.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpage_account;
        private System.Windows.Forms.TabPage tabpage_staff;
        private System.Windows.Forms.GroupBox groupbox_staff;
        private System.Windows.Forms.DateTimePicker dtp_date_of_birth;
        private System.Windows.Forms.ComboBox cbox_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.TextBox textbox_phone_number;
        private System.Windows.Forms.Label lbl_date_of_birth;
        private System.Windows.Forms.TextBox textbox_staff_name;
        private System.Windows.Forms.Label lbl_staff_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.TabControl tab_account;
        private CNPM_NHOM_1DataSet cNPM_NHOM_1DataSet;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_home_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_citizen_id;
        private System.Windows.Forms.Label lbl_home_address;
        private System.Windows.Forms.TextBox textbox_home_address;
        private System.Windows.Forms.Label lbl_citizen_id;
        private System.Windows.Forms.TextBox textbox_citizen_id;
    }
}