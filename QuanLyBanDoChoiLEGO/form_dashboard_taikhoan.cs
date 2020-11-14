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

        private void form_dashboard_taikhoan_Load(object sender, EventArgs e)
        {
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
        }

        private void enableStaffEditMode(bool value = true)
        {
            //button
            btn_save.Enabled = value;
            btn_add.Enabled = !value;
            btn_delete.Enabled = !value;
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            staff_mode = MODE.NOTHING;
            enableStaffEditMode(false);
            btn_edit.Text = "Sửa";

            LoadStaffTableFromDatabase();
            //clearStaffGroupBox();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool is_saved = editStaff();
            if (is_saved)
            {
                staff_mode = MODE.NOTHING;
                enableStaffEditMode(false);
                btn_edit.Text = "Sửa";

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
                            string message = "Khi bạn xóa nhân viên này, tài khoản id = " + account.id.ToString() + "cũng bị xóa\n Bạn có muốn tiếp tục?";
                            if (DialogResult.Yes == MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                db.ACCOUNTs.DeleteOnSubmit(account);
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
    }
}
