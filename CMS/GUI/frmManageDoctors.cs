using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.BLL;
using CMS.DAL;
using CMS.DML;

namespace CMS.GUI
{
    public partial class frmManageDoctors : Form
    {
        //code trong class form cần đưa lên tabPage
        private TabPage parentTab; // Lưu tham chiếu đến tab chứa frm1 (Page 1 hoặc Page 2)
        private TabControl tabControl; // Lưu tham chiếu đến TabControl
        string[] headTitleVN = { "Mã Bác Sĩ", "Tên", "Họ", "Chuyên Khoa", "Số Giấy Phép", "Lịch Làm Việc", };
        string[] headTitleEng = { "Doctor ID", "First Name", "Last Name", "Specialty", "LicenseNumber", "Schedule" };
        string[] cboSpecialtyEng = {
         "General Internal Medicine", "General Surgery","Pediatrics","Obstetrics and Gynecology","Cardiology",
        "Neurology","Pulmonology","Gastroenterology","Nephrology and Urology","Hematology and Blood Transfusion",
        "Oncology","Dermatology","Otorhinolaryngology (ENT)","Ophthalmology","Odonto-Stomatology","Traditional Medicine",
         "Physical Therapy and Rehabilitation",
        "Psychiatry","Anesthesiology and Intensive Care","Medical Imaging","Laboratory Medicine","Nuclear Medicine",
        "Pathology","Public Health","Preventive Medicine","Nutrition","Geriatrics","Pharmacy"};
        string[] cboSpecialtyVN = {
         "Nội tổng quát", "Ngoại tổng quát", "Nhi khoa", "Sản phụ khoa", "Tim mạch", "Thần kinh",
         "Hô hấp", "Tiêu hóa", "Thận - Tiết niệu", "Huyết học - Truyền máu", "Ung bướu", "Da liễu",
         "Tai - Mũi - Họng", "Mắt", "Răng - Hàm - Mặt", "Y học cổ truyền", "Vật lý trị liệu - Phục hồi chức năng",
         "Tâm thần","Gây mê hồi sức","Chẩn đoán hình ảnh","Xét nghiệm","Y học hạt nhân", "Giải phẫu bệnh",
         "Y tế công cộng", "Y học dự phòng", "Dinh dưỡng", "Lão khoa", "Dược"};
        string[] kindFindVN = { "Mã Bác Sĩ", "Tên", "Chuyên Khoa", "Số Giấy Phép", "Lịch Làm Việc" };
        string[] kindFindEng = { "Doctor ID", "First Name", "Specialty", "LicenseNumber", "Schedule" };
        string selectAll = "getALlDoctors";

        //code cho trạng thái form kho load
        void frmManageDoctors_Load_()
        {
            // Chèn ảnh cho nút thoát
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconClose))
            {
                btnClose.Image = Image.FromStream(ms);
            }

            //thêm ảnh nền
            using (MemoryStream ms = new MemoryStream(Properties.Resources.img001))
            {
                this.BackgroundImage = Image.FromStream(ms);
            }
            // Làm mờ ảnh nền
            this.BackgroundImage = UTIL.UTIL.MakeImageTransparent(this.BackgroundImage as Bitmap, 0.3f); // 0.3f là độ mờ (0.0f - 1.0f)

            // Thiết lập ngôn ngữ cho header DataGridView và load dữ liệu
            if (UTIL.Language.Lang.Equals("vn"))
            {
                dgvManageDoctors.Rows.Clear();
                UTIL.UTIL.showDataToDataGridview(dgvManageDoctors, "getALlDoctors", headTitleVN);
            }
            else
            {
                dgvManageDoctors.Rows.Clear();
                UTIL.UTIL.showDataToDataGridview(dgvManageDoctors, "getALlDoctors", headTitleEng);
            }

            // Thêm dữ liệu vào combobox tìm kiếm
            if (UTIL.Language.Lang.Equals("vn"))
            {
                for (int i = 0; i < kindFindVN.Length; i++)
                {
                    cboKindFind.Items.Add(kindFindVN[i]);
                }
            }
            else
            {
                for (int i = 0; i < kindFindEng.Length; i++)
                {
                    cboKindFind.Items.Add(kindFindEng[i]);
                }
            }
            cboKindFind.SelectedIndex = 0; // Mặc định chọn mục đầu tiên

            //add data combobox cboSpecialty
            if (UTIL.Language.Lang.Equals("vn"))
            {
                for (int i = 0; i < cboSpecialtyVN.Length; i++)
                {
                    cboSpecialty.Items.Add(cboSpecialtyVN[i]);
                }
            }
            else
            {
                for (int i = 0; i < cboSpecialtyEng.Length; i++)
                {
                    cboSpecialty.Items.Add(cboSpecialtyEng[i]);
                }
            }
            //thiết lập combobox mặc định cho gender
            cboSpecialty.SelectedIndex = 0;
        }

        //code cho nút reload
        private void btnReload_Click_()
        {
            if (UTIL.Language.Lang.Equals("vn"))
            {
                UTIL.UTIL.showDataToDataGridview(dgvManageDoctors, selectAll, headTitleVN);
            }
            else
            {
                UTIL.UTIL.showDataToDataGridview(dgvManageDoctors, selectAll, headTitleEng);
            }
        }

        //code cho nút thêm
        private void btnAdd_Click_()
        {
            DoctorsBLL bll = new DoctorsBLL(); //tạo bll để gọi các hàm kiểm tra
            if (bll.CheckDoctorsByLicenseNumber(txtLicenseNumber.Text.Trim()))
            {
                MessageBox.Show(txtLicenseNumber.Text + " is available", "Notif");
            }
            else
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)
                    || string.IsNullOrEmpty(txtLicenseNumber.Text) || string.IsNullOrEmpty(txtSchedule.Text))
                {
                    UTIL.UTIL.ShowMessage("First name, last name, License Number and Schedule is not null", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DoctorsDML dml = new DoctorsDML(); //tạo dml để set giá trị cho model
                    dml.FirstName1 = txtFirstName.Text.Trim();
                    dml.LastName1 = txtLastName.Text.Trim();
                    dml.Specialty1 = cboSpecialty.SelectedItem.ToString().Trim();
                    dml.LicenseNumber1 = txtLicenseNumber.Text.Trim();
                    dml.Schedule1 = txtSchedule.Text.Trim();

                    bll.Insert(dml);
                    UTIL.UTIL.ShowMessage("Added", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReload_Click_();
                }
            }
        }

        //code cho nút chỉnh sửa
        private void btnEdit_Click_()
        {
            try
            {
                DoctorsBLL bll = new DoctorsBLL();//tạo bll để gọi các hàm kiểm tra
                if (bll.CheckDoctorsByDoctorId(int.Parse(txtDoctorId.Text.Trim())))
                {
                    try
                    {
                        DoctorsDML dml = new DoctorsDML();//tạo dml để set giá trị cho model
                        dml.DoctorId1 = int.Parse(txtDoctorId.Text.Trim());
                        dml.FirstName1 = txtFirstName.Text.Trim();
                        dml.LastName1 = txtLastName.Text.Trim();
                        dml.Specialty1 = cboSpecialty.SelectedItem.ToString().Trim();
                        dml.LicenseNumber1 = txtLicenseNumber.Text.Trim();
                        dml.Schedule1 = txtSchedule.Text.Trim();

                        bll.Update(dml);
                        UTIL.UTIL.ShowMessage("Edited", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReload_Click_();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    UTIL.UTIL.ShowMessage("No ID yet", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                UTIL.UTIL.ShowMessage("Select a line to edit", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //code nút xóa
        private void btnDelete_Click_()
        {
            DoctorsBLL bll = new DoctorsBLL();
            if (bll.CheckDoctorsByDoctorId(int.Parse(txtDoctorId.Text.Trim())))
            {
                try
                {
                    if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DoctorsDML dml = new DoctorsDML();
                        dml.DoctorId1 = int.Parse(txtDoctorId.Text.Trim());

                        bll.Delete(dml);
                        UTIL.UTIL.ShowMessage("Deleted", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReload_Click_();
                    }
                }
                catch (Exception ex)
                {
                    UTIL.UTIL.ShowMessage("Linked, cannot be removed", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                UTIL.UTIL.ShowMessage("Doctor ID not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        private void btnFind_Click_()
        {
            try
            {
                // Xác định mảng tiêu chí tìm kiếm dựa trên ngôn ngữ
                string[] kindFind = UTIL.Language.Lang.Equals("vn") ? kindFindVN : kindFindEng;

                // Kiểm tra từ khóa tìm kiếm có rỗng không
                if (string.IsNullOrWhiteSpace(txtFindText.Text))
                {
                    UTIL.UTIL.ShowMessage("Enter the keyword you want to search", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFindText.Focus();
                    return;
                }

                // Khởi tạo DoctorsBLL
                DoctorsBLL bll = new DoctorsBLL();
                DataTable searchResult = null;
                string searchValue = txtFindText.Text.Trim();

                // Tìm kiếm dựa trên tiêu chí
                switch (cboKindFind.SelectedIndex)
                {
                    case 0: // Tìm kiếm theo Mã Bác Sĩ (DoctorId)
                        if (!int.TryParse(searchValue, out int doctorId))
                        {
                            UTIL.UTIL.ShowMessage("Doctor code must be numeric", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtFindText.Focus();
                            return;
                        }

                        if (!bll.CheckDoctorsByDoctorId(doctorId))
                        {
                            UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        searchResult = bll.GetDoctorById(doctorId);
                        break;

                    case 1: // Tìm kiếm theo Tên (FirstName)
                        if (!bll.CheckDoctorsByFirstName(searchValue))
                        {
                            UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        searchResult = bll.GetDoctorsByFirstName(searchValue);
                        break;

                    case 2: // Tìm kiếm theo Chuyên Khoa (Specialty)
                        if (!bll.CheckDoctorsBySpecialty(searchValue))
                        {
                            UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        searchResult = bll.GetDoctorsBySpecialty(searchValue);
                        break;

                    case 3: // Tìm kiếm theo Số Giấy Phép (LicenseNumber)
                        if (!bll.CheckDoctorsByLicenseNumber(searchValue))
                        {
                            UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        searchResult = bll.GetDoctorsByLicenseNumber(searchValue);
                        break;

                    case 4: // Tìm kiếm theo Lịch Làm Việc (Schedule)
                        if (!bll.CheckDoctorsBySchedule(searchValue))
                        {
                            UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        searchResult = bll.GetDoctorsBySchedule(searchValue);
                        break;

                    default:
                        UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Hiển thị kết quả lên DataGridView
                if (UTIL.Language.Lang.Equals("vn"))
                {
                    dgvManageDoctors.DataSource = searchResult;
                    for (int i = 0; i < headTitleVN.Length; i++)
                    {
                        dgvManageDoctors.Columns[i].HeaderText = headTitleVN[i];
                    }
                }
                else
                {
                    dgvManageDoctors.DataSource = searchResult;
                    for (int i = 0; i < headTitleEng.Length; i++)
                    {
                        dgvManageDoctors.Columns[i].HeaderText = headTitleEng[i];
                    }
                }
            }
            catch (Exception ex)
            {
                UTIL.UTIL.ShowMessage("Not found", "notif_", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //============================================================================

        public frmManageDoctors(TabPage parentTab, TabControl tabControl)
        {
            InitializeComponent();
            this.parentTab = parentTab;
            this.tabControl = tabControl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click_();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            btnReload_Click_();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (parentTab != null && tabControl != null)
            {
                tabControl.TabPages.Remove(parentTab); // Xóa tab khỏi TabControl
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click_();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click_();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            btnFind_Click_();
        }

        private void frmManageDoctors_Load(object sender, EventArgs e)
        {
            frmManageDoctors_Load_();
        }

        private void dgvManageDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvManageDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtDoctorId, dgvManageDoctors, 0, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtFirstName, dgvManageDoctors, 1, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtLastName, dgvManageDoctors, 2, e);
            UTIL.UTIL.getDataFromDatagridviewFillCombobox(cboSpecialty, dgvManageDoctors, 3, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtLicenseNumber, dgvManageDoctors, 4, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtSchedule, dgvManageDoctors, 5, e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //UTIL.UTIL.Textbox_KeyPress_OnlyNumber(sender, e);
            UTIL.UTIL.Textbox_KeyPress_LimitChar(sender, e, 50);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //UTIL.UTIL.Textbox_KeyPress_OnlyNumber(sender, e);
            UTIL.UTIL.Textbox_KeyPress_LimitChar(sender, e, 50);
        }

        private void cboSpecialty_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Kiểm tra xem độ dài văn bản hiện tại đã đạt đến giới hạn (50 ký tự) hay chưa
            if (textBox.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                // Nếu đã đạt giới hạn và ký tự vừa nhập không phải là phím điều khiển (ví dụ: Backspace),
                // thì hủy bỏ sự kiện KeyPress, ngăn không cho ký tự được nhập vào TextBox.
                e.Handled = true;
            }
        }

        private void txtLicenseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //UTIL.UTIL.Textbox_KeyPress_OnlyNumber(sender, e);
            UTIL.UTIL.Textbox_KeyPress_LimitChar(sender, e, 20);
        }

        private void txtSchedule_KeyPress(object sender, KeyPressEventArgs e)
        {
            //UTIL.UTIL.Textbox_KeyPress_OnlyNumber(sender, e);
            UTIL.UTIL.Textbox_KeyPress_LimitChar(sender, e, 100);
        }

        private void W(object sender, EventArgs e)
        {

        }
    }
}
