
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_dashboard_taikhoan));
            this.tabpage_account = new System.Windows.Forms.TabPage();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_NHOM_1DataSet = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSet();
            this.groupbox_account = new System.Windows.Forms.GroupBox();
            this.cbox_account_id_staff = new System.Windows.Forms.ComboBox();
            this.checkbox_activate = new System.Windows.Forms.CheckBox();
            this.checkbox_is_admin = new System.Windows.Forms.CheckBox();
            this.cbox_account_id = new System.Windows.Forms.ComboBox();
            this.btn_account_remove = new System.Windows.Forms.Button();
            this.btn_account_add = new System.Windows.Forms.Button();
            this.btn_account_edit = new System.Windows.Forms.Button();
            this.btn_account_save = new System.Windows.Forms.Button();
            this.btn_account_refresh = new System.Windows.Forms.Button();
            this.lbl_account_password = new System.Windows.Forms.Label();
            this.textbox_account_password = new System.Windows.Forms.TextBox();
            this.textbox_account_username = new System.Windows.Forms.TextBox();
            this.lbl_account_id_staff = new System.Windows.Forms.Label();
            this.lbl_account_username = new System.Windows.Forms.Label();
            this.lbl_account_id = new System.Windows.Forms.Label();
            this.tabpage_staff = new System.Windows.Forms.TabPage();
            this.groupbox_staff = new System.Windows.Forms.GroupBox();
            this.lbl_citizen_id = new System.Windows.Forms.Label();
            this.textbox_citizen_id = new System.Windows.Forms.TextBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_home_address = new System.Windows.Forms.Label();
            this.textbox_home_address = new System.Windows.Forms.TextBox();
            this.dtp_date_of_birth = new System.Windows.Forms.DateTimePicker();
            this.cbox_id = new System.Windows.Forms.ComboBox();
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
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_home_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_citizen_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_account = new System.Windows.Forms.TabControl();
            this.sTAFFTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.STAFFTableAdapter();
            this.aCCOUNTTableAdapter = new QuanLyBanDoChoiLEGO.CNPM_NHOM_1DataSetTableAdapters.ACCOUNTTableAdapter();
            this.tabpage_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).BeginInit();
            this.groupbox_account.SuspendLayout();
            this.tabpage_staff.SuspendLayout();
            this.groupbox_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.tab_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpage_account
            // 
            this.tabpage_account.Controls.Add(this.dgv_account);
            this.tabpage_account.Controls.Add(this.groupbox_account);
            this.tabpage_account.Location = new System.Drawing.Point(4, 25);
            this.tabpage_account.Margin = new System.Windows.Forms.Padding(4);
            this.tabpage_account.Name = "tabpage_account";
            this.tabpage_account.Padding = new System.Windows.Forms.Padding(4);
            this.tabpage_account.Size = new System.Drawing.Size(1283, 584);
            this.tabpage_account.TabIndex = 2;
            this.tabpage_account.Text = "Tài khoản";
            this.tabpage_account.UseVisualStyleBackColor = true;
            // 
            // dgv_account
            // 
            this.dgv_account.AllowUserToAddRows = false;
            this.dgv_account.AllowUserToDeleteRows = false;
            this.dgv_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_account.AutoGenerateColumns = false;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idstaffDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.isadminDataGridViewTextBoxColumn});
            this.dgv_account.DataSource = this.aCCOUNTBindingSource;
            this.dgv_account.Location = new System.Drawing.Point(457, 0);
            this.dgv_account.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.ReadOnly = true;
            this.dgv_account.RowHeadersWidth = 51;
            this.dgv_account.Size = new System.Drawing.Size(823, 581);
            this.dgv_account.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idstaffDataGridViewTextBoxColumn
            // 
            this.idstaffDataGridViewTextBoxColumn.DataPropertyName = "id_staff";
            this.idstaffDataGridViewTextBoxColumn.HeaderText = "id_staff";
            this.idstaffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstaffDataGridViewTextBoxColumn.Name = "idstaffDataGridViewTextBoxColumn";
            this.idstaffDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstaffDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            this.passDataGridViewTextBoxColumn.Width = 125;
            // 
            // isadminDataGridViewTextBoxColumn
            // 
            this.isadminDataGridViewTextBoxColumn.DataPropertyName = "is_admin";
            this.isadminDataGridViewTextBoxColumn.HeaderText = "is_admin";
            this.isadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isadminDataGridViewTextBoxColumn.Name = "isadminDataGridViewTextBoxColumn";
            this.isadminDataGridViewTextBoxColumn.ReadOnly = true;
            this.isadminDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // cNPM_NHOM_1DataSet
            // 
            this.cNPM_NHOM_1DataSet.DataSetName = "CNPM_NHOM_1DataSet";
            this.cNPM_NHOM_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupbox_account
            // 
            this.groupbox_account.Controls.Add(this.cbox_account_id_staff);
            this.groupbox_account.Controls.Add(this.checkbox_activate);
            this.groupbox_account.Controls.Add(this.checkbox_is_admin);
            this.groupbox_account.Controls.Add(this.cbox_account_id);
            this.groupbox_account.Controls.Add(this.btn_account_remove);
            this.groupbox_account.Controls.Add(this.btn_account_add);
            this.groupbox_account.Controls.Add(this.btn_account_edit);
            this.groupbox_account.Controls.Add(this.btn_account_save);
            this.groupbox_account.Controls.Add(this.btn_account_refresh);
            this.groupbox_account.Controls.Add(this.lbl_account_password);
            this.groupbox_account.Controls.Add(this.textbox_account_password);
            this.groupbox_account.Controls.Add(this.textbox_account_username);
            this.groupbox_account.Controls.Add(this.lbl_account_id_staff);
            this.groupbox_account.Controls.Add(this.lbl_account_username);
            this.groupbox_account.Controls.Add(this.lbl_account_id);
            this.groupbox_account.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupbox_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_account.Location = new System.Drawing.Point(4, 4);
            this.groupbox_account.Margin = new System.Windows.Forms.Padding(4);
            this.groupbox_account.Name = "groupbox_account";
            this.groupbox_account.Padding = new System.Windows.Forms.Padding(4);
            this.groupbox_account.Size = new System.Drawing.Size(445, 576);
            this.groupbox_account.TabIndex = 0;
            this.groupbox_account.TabStop = false;
            this.groupbox_account.Text = "Thông tin tài khoản";
            // 
            // cbox_account_id_staff
            // 
            this.cbox_account_id_staff.DataSource = this.aCCOUNTBindingSource;
            this.cbox_account_id_staff.DisplayMember = "id_staff";
            this.cbox_account_id_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_account_id_staff.Enabled = false;
            this.cbox_account_id_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_account_id_staff.FormattingEnabled = true;
            this.cbox_account_id_staff.Location = new System.Drawing.Point(332, 37);
            this.cbox_account_id_staff.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_account_id_staff.Name = "cbox_account_id_staff";
            this.cbox_account_id_staff.Size = new System.Drawing.Size(80, 28);
            this.cbox_account_id_staff.TabIndex = 3;
            this.cbox_account_id_staff.ValueMember = "id_staff";
            // 
            // checkbox_activate
            // 
            this.checkbox_activate.AutoSize = true;
            this.checkbox_activate.Enabled = false;
            this.checkbox_activate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_activate.Location = new System.Drawing.Point(313, 145);
            this.checkbox_activate.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_activate.Name = "checkbox_activate";
            this.checkbox_activate.Size = new System.Drawing.Size(101, 24);
            this.checkbox_activate.TabIndex = 9;
            this.checkbox_activate.Text = "Kích hoạt";
            this.checkbox_activate.UseVisualStyleBackColor = true;
            // 
            // checkbox_is_admin
            // 
            this.checkbox_is_admin.AutoSize = true;
            this.checkbox_is_admin.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aCCOUNTBindingSource, "is_admin", true));
            this.checkbox_is_admin.Enabled = false;
            this.checkbox_is_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_is_admin.Location = new System.Drawing.Point(208, 145);
            this.checkbox_is_admin.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_is_admin.Name = "checkbox_is_admin";
            this.checkbox_is_admin.Size = new System.Drawing.Size(78, 24);
            this.checkbox_is_admin.TabIndex = 8;
            this.checkbox_is_admin.Text = "Admin";
            this.checkbox_is_admin.UseVisualStyleBackColor = true;
            // 
            // cbox_account_id
            // 
            this.cbox_account_id.DataSource = this.aCCOUNTBindingSource;
            this.cbox_account_id.DisplayMember = "id";
            this.cbox_account_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_account_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_account_id.FormattingEnabled = true;
            this.cbox_account_id.Location = new System.Drawing.Point(149, 37);
            this.cbox_account_id.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_account_id.Name = "cbox_account_id";
            this.cbox_account_id.Size = new System.Drawing.Size(104, 28);
            this.cbox_account_id.TabIndex = 1;
            this.cbox_account_id.ValueMember = "id";
            // 
            // btn_account_remove
            // 
            this.btn_account_remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_account_remove.Location = new System.Drawing.Point(167, 288);
            this.btn_account_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_account_remove.Name = "btn_account_remove";
            this.btn_account_remove.Size = new System.Drawing.Size(131, 37);
            this.btn_account_remove.TabIndex = 14;
            this.btn_account_remove.Text = "Xóa";
            this.btn_account_remove.UseVisualStyleBackColor = true;
            this.btn_account_remove.Click += new System.EventHandler(this.btn_account_remove_Click);
            // 
            // btn_account_add
            // 
            this.btn_account_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_account_add.Location = new System.Drawing.Point(27, 229);
            this.btn_account_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_account_add.Name = "btn_account_add";
            this.btn_account_add.Size = new System.Drawing.Size(131, 37);
            this.btn_account_add.TabIndex = 10;
            this.btn_account_add.Text = "Thêm";
            this.btn_account_add.UseVisualStyleBackColor = true;
            this.btn_account_add.Click += new System.EventHandler(this.btn_account_add_Click);
            // 
            // btn_account_edit
            // 
            this.btn_account_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_account_edit.Location = new System.Drawing.Point(27, 288);
            this.btn_account_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_account_edit.Name = "btn_account_edit";
            this.btn_account_edit.Size = new System.Drawing.Size(131, 37);
            this.btn_account_edit.TabIndex = 13;
            this.btn_account_edit.Text = "Sửa";
            this.btn_account_edit.UseVisualStyleBackColor = true;
            this.btn_account_edit.Click += new System.EventHandler(this.btn_account_edit_Click);
            // 
            // btn_account_save
            // 
            this.btn_account_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_account_save.Enabled = false;
            this.btn_account_save.Location = new System.Drawing.Point(167, 229);
            this.btn_account_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_account_save.Name = "btn_account_save";
            this.btn_account_save.Size = new System.Drawing.Size(131, 37);
            this.btn_account_save.TabIndex = 11;
            this.btn_account_save.Text = "Lưu";
            this.btn_account_save.UseVisualStyleBackColor = true;
            this.btn_account_save.Click += new System.EventHandler(this.btn_account_save_Click);
            // 
            // btn_account_refresh
            // 
            this.btn_account_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_account_refresh.Location = new System.Drawing.Point(307, 229);
            this.btn_account_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_account_refresh.Name = "btn_account_refresh";
            this.btn_account_refresh.Size = new System.Drawing.Size(131, 37);
            this.btn_account_refresh.TabIndex = 12;
            this.btn_account_refresh.Text = "Tải lại";
            this.btn_account_refresh.UseVisualStyleBackColor = true;
            this.btn_account_refresh.Click += new System.EventHandler(this.btn_account_refresh_Click);
            // 
            // lbl_account_password
            // 
            this.lbl_account_password.AutoSize = true;
            this.lbl_account_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_account_password.Location = new System.Drawing.Point(59, 114);
            this.lbl_account_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account_password.Name = "lbl_account_password";
            this.lbl_account_password.Size = new System.Drawing.Size(77, 20);
            this.lbl_account_password.TabIndex = 6;
            this.lbl_account_password.Text = "Mật khẩu";
            // 
            // textbox_account_password
            // 
            this.textbox_account_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCCOUNTBindingSource, "pass", true));
            this.textbox_account_password.Enabled = false;
            this.textbox_account_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_account_password.Location = new System.Drawing.Point(149, 111);
            this.textbox_account_password.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_account_password.Name = "textbox_account_password";
            this.textbox_account_password.Size = new System.Drawing.Size(263, 26);
            this.textbox_account_password.TabIndex = 7;
            // 
            // textbox_account_username
            // 
            this.textbox_account_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCCOUNTBindingSource, "username", true));
            this.textbox_account_username.Enabled = false;
            this.textbox_account_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_account_username.Location = new System.Drawing.Point(149, 74);
            this.textbox_account_username.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_account_username.Name = "textbox_account_username";
            this.textbox_account_username.Size = new System.Drawing.Size(263, 26);
            this.textbox_account_username.TabIndex = 5;
            // 
            // lbl_account_id_staff
            // 
            this.lbl_account_id_staff.AutoSize = true;
            this.lbl_account_id_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_account_id_staff.Location = new System.Drawing.Point(263, 41);
            this.lbl_account_id_staff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account_id_staff.Name = "lbl_account_id_staff";
            this.lbl_account_id_staff.Size = new System.Drawing.Size(60, 20);
            this.lbl_account_id_staff.TabIndex = 2;
            this.lbl_account_id_staff.Text = "Mã NV";
            // 
            // lbl_account_username
            // 
            this.lbl_account_username.AutoSize = true;
            this.lbl_account_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_account_username.Location = new System.Drawing.Point(23, 78);
            this.lbl_account_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account_username.Name = "lbl_account_username";
            this.lbl_account_username.Size = new System.Drawing.Size(109, 20);
            this.lbl_account_username.TabIndex = 4;
            this.lbl_account_username.Text = "Tên tài khoản";
            // 
            // lbl_account_id
            // 
            this.lbl_account_id.AutoSize = true;
            this.lbl_account_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_account_id.Location = new System.Drawing.Point(79, 41);
            this.lbl_account_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account_id.Name = "lbl_account_id";
            this.lbl_account_id.Size = new System.Drawing.Size(58, 20);
            this.lbl_account_id.TabIndex = 0;
            this.lbl_account_id.Text = "Mã TK";
            // 
            // tabpage_staff
            // 
            this.tabpage_staff.Controls.Add(this.groupbox_staff);
            this.tabpage_staff.Controls.Add(this.dgv_staff);
            this.tabpage_staff.Location = new System.Drawing.Point(4, 25);
            this.tabpage_staff.Margin = new System.Windows.Forms.Padding(4);
            this.tabpage_staff.Name = "tabpage_staff";
            this.tabpage_staff.Padding = new System.Windows.Forms.Padding(4);
            this.tabpage_staff.Size = new System.Drawing.Size(1283, 584);
            this.tabpage_staff.TabIndex = 1;
            this.tabpage_staff.Text = "Nhân viên";
            this.tabpage_staff.UseVisualStyleBackColor = true;
            // 
            // groupbox_staff
            // 
            this.groupbox_staff.BackColor = System.Drawing.Color.White;
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
            this.groupbox_staff.ForeColor = System.Drawing.Color.Black;
            this.groupbox_staff.Location = new System.Drawing.Point(4, 4);
            this.groupbox_staff.Margin = new System.Windows.Forms.Padding(4);
            this.groupbox_staff.Name = "groupbox_staff";
            this.groupbox_staff.Padding = new System.Windows.Forms.Padding(4);
            this.groupbox_staff.Size = new System.Drawing.Size(479, 576);
            this.groupbox_staff.TabIndex = 0;
            this.groupbox_staff.TabStop = false;
            this.groupbox_staff.Text = "Thông tin nhân viên";
            // 
            // lbl_citizen_id
            // 
            this.lbl_citizen_id.AutoSize = true;
            this.lbl_citizen_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_citizen_id.Location = new System.Drawing.Point(49, 182);
            this.lbl_citizen_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_citizen_id.Name = "lbl_citizen_id";
            this.lbl_citizen_id.Size = new System.Drawing.Size(60, 20);
            this.lbl_citizen_id.TabIndex = 8;
            this.lbl_citizen_id.Text = "CMND";
            // 
            // textbox_citizen_id
            // 
            this.textbox_citizen_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "citizen_id", true));
            this.textbox_citizen_id.Enabled = false;
            this.textbox_citizen_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_citizen_id.Location = new System.Drawing.Point(121, 178);
            this.textbox_citizen_id.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_citizen_id.MaxLength = 11;
            this.textbox_citizen_id.Name = "textbox_citizen_id";
            this.textbox_citizen_id.Size = new System.Drawing.Size(291, 26);
            this.textbox_citizen_id.TabIndex = 9;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.cNPM_NHOM_1DataSet;
            // 
            // lbl_home_address
            // 
            this.lbl_home_address.AutoSize = true;
            this.lbl_home_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_home_address.Location = new System.Drawing.Point(23, 223);
            this.lbl_home_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home_address.Name = "lbl_home_address";
            this.lbl_home_address.Size = new System.Drawing.Size(93, 20);
            this.lbl_home_address.TabIndex = 10;
            this.lbl_home_address.Text = "Địa chỉ nhà";
            // 
            // textbox_home_address
            // 
            this.textbox_home_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "home_address", true));
            this.textbox_home_address.Enabled = false;
            this.textbox_home_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_home_address.Location = new System.Drawing.Point(27, 246);
            this.textbox_home_address.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_home_address.MaxLength = 100;
            this.textbox_home_address.Multiline = true;
            this.textbox_home_address.Name = "textbox_home_address";
            this.textbox_home_address.Size = new System.Drawing.Size(391, 79);
            this.textbox_home_address.TabIndex = 11;
            // 
            // dtp_date_of_birth
            // 
            this.dtp_date_of_birth.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dtp_date_of_birth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTAFFBindingSource, "date_of_birth", true));
            this.dtp_date_of_birth.Enabled = false;
            this.dtp_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_of_birth.Location = new System.Drawing.Point(123, 108);
            this.dtp_date_of_birth.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_date_of_birth.Name = "dtp_date_of_birth";
            this.dtp_date_of_birth.Size = new System.Drawing.Size(289, 26);
            this.dtp_date_of_birth.TabIndex = 5;
            // 
            // cbox_id
            // 
            this.cbox_id.DataSource = this.sTAFFBindingSource;
            this.cbox_id.DisplayMember = "id";
            this.cbox_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_id.FormattingEnabled = true;
            this.cbox_id.Location = new System.Drawing.Point(123, 37);
            this.cbox_id.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_id.Name = "cbox_id";
            this.cbox_id.Size = new System.Drawing.Size(289, 28);
            this.cbox_id.TabIndex = 1;
            this.cbox_id.ValueMember = "id";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(329, 363);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 37);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(27, 363);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 37);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(27, 407);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 37);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(175, 363);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 37);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(175, 407);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(133, 37);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_phone_number.Location = new System.Drawing.Point(67, 146);
            this.lbl_phone_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(42, 20);
            this.lbl_phone_number.TabIndex = 6;
            this.lbl_phone_number.Text = "SĐT";
            // 
            // textbox_phone_number
            // 
            this.textbox_phone_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "phone_number", true));
            this.textbox_phone_number.Enabled = false;
            this.textbox_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_phone_number.Location = new System.Drawing.Point(121, 143);
            this.textbox_phone_number.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_phone_number.MaxLength = 11;
            this.textbox_phone_number.Name = "textbox_phone_number";
            this.textbox_phone_number.Size = new System.Drawing.Size(291, 26);
            this.textbox_phone_number.TabIndex = 7;
            // 
            // lbl_date_of_birth
            // 
            this.lbl_date_of_birth.AutoSize = true;
            this.lbl_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_date_of_birth.Location = new System.Drawing.Point(23, 113);
            this.lbl_date_of_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date_of_birth.Name = "lbl_date_of_birth";
            this.lbl_date_of_birth.Size = new System.Drawing.Size(83, 20);
            this.lbl_date_of_birth.TabIndex = 4;
            this.lbl_date_of_birth.Text = "Ngày sinh";
            // 
            // textbox_staff_name
            // 
            this.textbox_staff_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "staff_name", true));
            this.textbox_staff_name.Enabled = false;
            this.textbox_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textbox_staff_name.Location = new System.Drawing.Point(123, 74);
            this.textbox_staff_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_staff_name.MaxLength = 50;
            this.textbox_staff_name.Name = "textbox_staff_name";
            this.textbox_staff_name.Size = new System.Drawing.Size(289, 26);
            this.textbox_staff_name.TabIndex = 3;
            // 
            // lbl_staff_name
            // 
            this.lbl_staff_name.AutoSize = true;
            this.lbl_staff_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_staff_name.Location = new System.Drawing.Point(23, 78);
            this.lbl_staff_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_staff_name.Name = "lbl_staff_name";
            this.lbl_staff_name.Size = new System.Drawing.Size(87, 20);
            this.lbl_staff_name.TabIndex = 2;
            this.lbl_staff_name.Text = "Họ tên NV";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_id.Location = new System.Drawing.Point(48, 41);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(60, 20);
            this.lbl_id.TabIndex = 0;
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
            this.dgv_staff.Location = new System.Drawing.Point(491, 4);
            this.dgv_staff.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.Size = new System.Drawing.Size(785, 574);
            this.dgv_staff.TabIndex = 1;
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "Mã nhân viên";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 125;
            // 
            // col_staff_name
            // 
            this.col_staff_name.DataPropertyName = "staff_name";
            this.col_staff_name.HeaderText = "Họ và tên";
            this.col_staff_name.MinimumWidth = 6;
            this.col_staff_name.Name = "col_staff_name";
            this.col_staff_name.ReadOnly = true;
            this.col_staff_name.Width = 125;
            // 
            // col_phone_number
            // 
            this.col_phone_number.DataPropertyName = "phone_number";
            this.col_phone_number.HeaderText = "Số điện thoại";
            this.col_phone_number.MinimumWidth = 6;
            this.col_phone_number.Name = "col_phone_number";
            this.col_phone_number.ReadOnly = true;
            this.col_phone_number.Width = 125;
            // 
            // col_date_of_birth
            // 
            this.col_date_of_birth.DataPropertyName = "date_of_birth";
            this.col_date_of_birth.HeaderText = "Ngày sinh";
            this.col_date_of_birth.MinimumWidth = 6;
            this.col_date_of_birth.Name = "col_date_of_birth";
            this.col_date_of_birth.ReadOnly = true;
            this.col_date_of_birth.Width = 125;
            // 
            // col_home_address
            // 
            this.col_home_address.DataPropertyName = "home_address";
            this.col_home_address.HeaderText = "Địa chỉ nhà";
            this.col_home_address.MinimumWidth = 6;
            this.col_home_address.Name = "col_home_address";
            this.col_home_address.ReadOnly = true;
            this.col_home_address.Width = 125;
            // 
            // col_citizen_id
            // 
            this.col_citizen_id.DataPropertyName = "citizen_id";
            this.col_citizen_id.HeaderText = "CMND";
            this.col_citizen_id.MinimumWidth = 6;
            this.col_citizen_id.Name = "col_citizen_id";
            this.col_citizen_id.ReadOnly = true;
            this.col_citizen_id.Width = 125;
            // 
            // tab_account
            // 
            this.tab_account.Controls.Add(this.tabpage_staff);
            this.tab_account.Controls.Add(this.tabpage_account);
            this.tab_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_account.Location = new System.Drawing.Point(0, 0);
            this.tab_account.Margin = new System.Windows.Forms.Padding(4);
            this.tab_account.Name = "tab_account";
            this.tab_account.SelectedIndex = 0;
            this.tab_account.Size = new System.Drawing.Size(1291, 613);
            this.tab_account.TabIndex = 0;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // form_dashboard_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 613);
            this.Controls.Add(this.tab_account);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_dashboard_taikhoan";
            this.ShowIcon = false;
            this.Text = "Quản lí tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_dashboard_taikhoan_Load);
            this.tabpage_account.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_NHOM_1DataSet)).EndInit();
            this.groupbox_account.ResumeLayout(false);
            this.groupbox_account.PerformLayout();
            this.tabpage_staff.ResumeLayout(false);
            this.groupbox_staff.ResumeLayout(false);
            this.groupbox_staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.GroupBox groupbox_account;
        private System.Windows.Forms.CheckBox checkbox_activate;
        private System.Windows.Forms.CheckBox checkbox_is_admin;
        private System.Windows.Forms.ComboBox cbox_account_id;
        private System.Windows.Forms.Button btn_account_remove;
        private System.Windows.Forms.Button btn_account_add;
        private System.Windows.Forms.Button btn_account_edit;
        private System.Windows.Forms.Button btn_account_save;
        private System.Windows.Forms.Button btn_account_refresh;
        private System.Windows.Forms.Label lbl_account_password;
        private System.Windows.Forms.TextBox textbox_account_password;
        private System.Windows.Forms.TextBox textbox_account_username;
        private System.Windows.Forms.Label lbl_account_id_staff;
        private System.Windows.Forms.Label lbl_account_username;
        private System.Windows.Forms.Label lbl_account_id;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private CNPM_NHOM_1DataSetTableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbox_account_id_staff;
    }
}