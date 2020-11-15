using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoChoiLEGO
{
    public partial class form_dashboard_taikhoan : Form
    {
        public form_dashboard_taikhoan()
        {
            InitializeComponent();
        }

        enum MODE { NOTHING, EDIT, ADD };
        MODE staff_mode = MODE.NOTHING;
        MODE account_mode = MODE.NOTHING;

        private void form_dashboard_taikhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.cNPM_NHOM_1DataSet.ACCOUNT);
            // TODO: This line of code loads data into the 'cNPM_NHOM_1DataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.cNPM_NHOM_1DataSet.STAFF);
            enableStaffEditMode(false);
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadStaffTableFromDatabase()
        {
            this.sTAFFTableAdapter.Fill(this.cNPM_NHOM_1DataSet.STAFF);
            //CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            //dgv_staff.DataSource = db.STAFFs.Select(p => new
            //{
            //    id = p.id,
            //    staff_name = p.staff_name,
            //    home_address = p.home_address,
            //    phone_number = p.phone_number,
            //    date_of_birth = p.date_of_birth,
            //    citizen_id = p.citizen_id
            //});
        }

        private void LoadAccountTableFromDatabase()
        {
            this.aCCOUNTTableAdapter.Fill(this.cNPM_NHOM_1DataSet.ACCOUNT);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (staff_mode != MODE.EDIT)
            {
                staff_mode = MODE.EDIT;
                enableStaffEditMode(true);
                btn_edit.Text = "Hủy";
            }
            else
            {
                staff_mode = MODE.NOTHING;
                enableStaffEditMode(false);
                btn_edit.Text = "Sửa";
            }
            btn_edit.Enabled = true;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            staff_mode = MODE.NOTHING;
            enableStaffEditMode(false);
            btn_add.Text = "Thêm";
            btn_edit.Text = "Sửa";

            LoadStaffTableFromDatabase();
            //clearStaffGroupBox();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            //bool is_saved = editStaff();
            //if (is_saved)
            //{
            //    staff_mode = MODE.NOTHING;
            //    enableStaffEditMode(false);
            //    btn_edit.Text = "Sửa";

            //    LoadStaffTableFromDatabase();
            //}

            bool is_saved = false;
            switch (staff_mode)
            {
                case MODE.NOTHING:
                    break;
                case MODE.EDIT:
                    is_saved = editStaff();
                    break;
                case MODE.ADD:
                    is_saved = addStaff();
                    break;
                default:
                    break;
            }
            
            if (is_saved)
            {
                enableStaffEditMode(false);
                btn_edit.Text = "Sửa";
                btn_add.Text = "Thêm";
                staff_mode = MODE.NOTHING;
                LoadStaffTableFromDatabase();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cbox_id.SelectedIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int id = (int)cbox_id.SelectedValue;

                    CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

                    STAFF staff = db.STAFFs.Where(p => p.id == id).SingleOrDefault();
                    if (staff != null)
                    {
                        ACCOUNT account = db.ACCOUNTs.Where(p => p.id_staff == id).SingleOrDefault();
                        if (account != null)
                        {
                            string message = "Khi bạn xóa nhân viên này, tài khoản id = " + account.id.ToString() + "sẽ mất liên kết\n Bạn có muốn tiếp tục?";
                            if (DialogResult.Yes == MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                account.id_staff = null;
                            }
                            else
                            {
                                staff_mode = MODE.NOTHING;
                                return;
                            }
                            //khi xóa nhân viên, tài khoản cũng bị xóa
                            //solution: thêm 1 cột kích hoạt để vô hiệu hóa tài khoản
                        }

                        db.STAFFs.DeleteOnSubmit(staff);
                        db.SubmitChanges();

                        LoadStaffTableFromDatabase();
                        //clearTextNV();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            staff_mode = MODE.NOTHING;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (staff_mode != MODE.ADD)
            {
                staff_mode = MODE.ADD;
                enableStaffEditMode(true);
                btn_add.Text = "Hủy";
                clearStaffGroupBox();
            }
            else
            {
                staff_mode = MODE.NOTHING;
                enableStaffEditMode(false);
                btn_add.Text = "Thêm";
                LoadStaffTableFromDatabase();
            }
            btn_add.Enabled = true;
        }
        
        private void enableStaffEditMode(bool value = true)
        {
            //button
            btn_save.Enabled = value;
            btn_add.Enabled = !value;
            btn_delete.Enabled = !value;
            btn_edit.Enabled = !value;
            //control
            cbox_id.Enabled = !value;
            textbox_staff_name.Enabled = value;
            textbox_home_address.Enabled = value;
            textbox_phone_number.Enabled = value;
            dtp_date_of_birth.Enabled = value;
            textbox_citizen_id.Enabled = value;
            dgv_staff.Enabled = !value;
            //EditMode
        }

        private void clearStaffGroupBox()
        {
            cbox_id.SelectedIndex = -1;
            textbox_staff_name.Text = "";
            textbox_phone_number.Text = "";
            textbox_home_address.Text = "";
            textbox_citizen_id.Text = "";
            dtp_date_of_birth.Value = DateTime.Now;
        }

        private bool editStaff()
        {
            if (cbox_id.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (String.IsNullOrEmpty(textbox_staff_name.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (String.IsNullOrEmpty(textbox_citizen_id.Text))
                {
                    MessageBox.Show("Vui lòng nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int id = (int)cbox_id.SelectedValue;
                CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

                STAFF staff = db.STAFFs.Where(p => p.id == id).SingleOrDefault();
                if (staff != null)
                {
                    staff.staff_name = textbox_staff_name.Text;
                    staff.phone_number = textbox_phone_number.Text;
                    staff.home_address = textbox_home_address.Text;
                    staff.date_of_birth = dtp_date_of_birth.Value;
                    staff.citizen_id = textbox_citizen_id.Text;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool addStaff()
        {
            string caption, title;
            if (String.IsNullOrEmpty(textbox_staff_name.Text))
            {
                caption = "Vui lòng nhập họ và tên";
                title = "Thông báo";
                MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(textbox_citizen_id.Text))
            {
                caption = "Vui lòng nhập CMND";
                title = "Thông báo";
                MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            STAFF staff = new STAFF();
            staff.staff_name = textbox_staff_name.Text;
            staff.date_of_birth = dtp_date_of_birth.Value;
            staff.phone_number = textbox_phone_number.Text;
            staff.home_address = textbox_home_address.Text;
            staff.citizen_id = textbox_citizen_id.Text;

            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            if (db.STAFFs.Where(p => p.id == staff.id).SingleOrDefault() == null)
            {
                db.STAFFs.InsertOnSubmit(staff);
                db.SubmitChanges();
                return true;
            }
            else
            {
                caption = "Bị trùng mã nhân viên";
                title = "Cảnh báo";
                MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private void btn_account_refresh_Click(object sender, EventArgs e)
        {
            account_mode = MODE.NOTHING;
            btn_account_add.Text = "Thêm";
            btn_account_edit.Text = "Sửa";
            enableAccountEditMode(false);
            LoadAccountTableFromDatabase();
        }

        private void btn_account_save_Click(object sender, EventArgs e)
        {
            bool is_saved = false;
            switch (account_mode)
            {
                case MODE.NOTHING:
                    break;
                case MODE.EDIT:
                    is_saved = editAccount();
                    break;
                case MODE.ADD:
                    is_saved = addAccount();
                    break;
                default:
                    break;
            }

            if (is_saved)
            {
                account_mode = MODE.NOTHING;
                btn_account_edit.Text = "Sửa";
                btn_account_add.Text = "Thêm";
                enableAccountEditMode(false);
                LoadAccountTableFromDatabase();
            }
        }

        private bool addAccount()
        {
            string caption, title;
            CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();
            if (String.IsNullOrEmpty(textbox_account_username.Text))
            {
                caption = "Vui lòng nhập tên tài khoản";
                title = "Thông báo";
                MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (db.ACCOUNTs.Where(p => p.username == textbox_account_username.Text).SingleOrDefault() != null)
            {
                MessageBox.Show("Tên tài khoản đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(textbox_account_password.Text))
            {
                caption = "Vui lòng nhập mật khẩu";
                title = "Thông báo";
                MessageBox.Show(caption, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            ACCOUNT account = new ACCOUNT();
            if (cbox_account_id_staff.SelectedIndex == -1)
            {
                account.id_staff = null;
            }
            else
            {
                if (db.STAFFs.Where(p => p.id == (int)cbox_account_id_staff.SelectedValue).SingleOrDefault() != null)
                {
                    account.id_staff = (int)cbox_account_id_staff.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            account.username = textbox_account_username.Text;
            account.pass = textbox_account_password.Text;
            if (checkbox_is_admin.Checked)
            {
                account.is_admin = 1;
            }
            else account.is_admin = 0;
            //account.activated = checkbox_activate.Checked
            db.ACCOUNTs.InsertOnSubmit(account);
            db.SubmitChanges();
            return true;
        }

        private bool editAccount()
        {
            if (cbox_account_id.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (String.IsNullOrEmpty(textbox_account_password.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int id = (int)cbox_account_id.SelectedValue;
                CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

                ACCOUNT account = db.ACCOUNTs.Where(p => p.id == id).SingleOrDefault();
                if (account != null)
                {
                    account.pass = textbox_account_password.Text;
                    account.id_staff = (int)cbox_account_id_staff.SelectedValue;
                    if (checkbox_is_admin.Checked)
                    {
                        account.is_admin = 1;
                    }
                    else account.is_admin = 0;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã tài khoản không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void btn_account_edit_Click(object sender, EventArgs e)
        {
            if (account_mode != MODE.EDIT)
            {
                account_mode = MODE.EDIT;
                enableAccountEditMode(true);
                btn_account_edit.Text = "Hủy";
            }
            else
            {
                account_mode = MODE.NOTHING;
                enableAccountEditMode(false);
                btn_account_edit.Text = "Sửa";
            }
            btn_account_edit.Enabled = true;
        }

        private void btn_account_add_Click(object sender, EventArgs e)
        {
            if (account_mode != MODE.ADD)
            {
                account_mode = MODE.ADD;
                enableAccountEditMode(true);
                btn_account_add.Text = "Hủy";
                clearAccountGroupBox();
            }
            else
            {
                account_mode = MODE.NOTHING;
                enableAccountEditMode(false);
                btn_account_add.Text = "Thêm";
                LoadAccountTableFromDatabase();
            }
            btn_account_add.Enabled = true;
        }

        private void clearAccountGroupBox()
        {
            cbox_account_id.SelectedIndex = -1;
            textbox_account_username.Text = "";
            textbox_account_password.Text = "";
            cbox_account_id_staff.SelectedIndex = -1;
            checkbox_is_admin.Checked = false;
        }

        private void btn_account_remove_Click(object sender, EventArgs e)
        {
            int id = (int)cbox_account_id.SelectedValue;
            if (id != -1)
            {
                CNPM_DataClassesDataContext db = new CNPM_DataClassesDataContext();

                ACCOUNT account = db.ACCOUNTs.Where(p => p.id == id).SingleOrDefault();
                if (account != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        db.ACCOUNTs.DeleteOnSubmit(account);
                        db.SubmitChanges();

                        LoadAccountTableFromDatabase();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            account_mode = MODE.NOTHING;
        }

        private void enableAccountEditMode(bool value = true)
        {
            //button
            btn_account_save.Enabled = value;
            btn_account_add.Enabled = !value;
            btn_account_remove.Enabled = !value;
            btn_account_edit.Enabled = !value;
            //control
            cbox_account_id.Enabled = !value;
            dgv_account.Enabled = !value;
            textbox_account_password.Enabled = value;
            textbox_phone_number.Enabled = value;
            cbox_account_id_staff.Enabled = value;
            checkbox_is_admin.Enabled = value;
            //EditMode
            switch (account_mode)
            {
                case MODE.ADD:
                    textbox_account_username.Enabled = true;
                    cbox_account_id_staff.DataSource = this.cNPM_NHOM_1DataSet.STAFF;
                    cbox_account_id_staff.DisplayMember = "id";
                    cbox_account_id_staff.ValueMember = "id";
                    break;
                case MODE.EDIT:
                    textbox_account_username.Enabled = false;
                    cbox_account_id_staff.DataSource = this.cNPM_NHOM_1DataSet.STAFF;
                    cbox_account_id_staff.DisplayMember = "id";
                    cbox_account_id_staff.ValueMember = "id";
                    break;
                default:
                    textbox_account_username.Enabled = false;
                    cbox_account_id_staff.DataSource = aCCOUNTBindingSource;
                    cbox_account_id_staff.DisplayMember = "id_staff";
                    cbox_account_id_staff.ValueMember = "id_staff";
                    break;
            }
        }
    }
}
