using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.BLL;
using CMS.DML;

namespace CMS.GUI
{
    public partial class frmVisits : Form
    {
        private TabPage parentTab; // Lưu tham chiếu đến tab chứa frm1 (Page 1 hoặc Page 2)
        private TabControl tabControl; // Lưu tham chiếu đến TabControl
        private string[] genderEN = { "Male", "Female" };
        private string[] genderVN = { "Nam", "Nữ" };
        private string[] headTitleEng = { "VisitId", "PatientId", "Patient First Name", "Patient Last Name", "DoctorId", "Doctor First Name", "Doctor Last Name", "VisitDate", "Diagnosis", "Prescription", };
        private string[] headTitleVN = { "Mã khám", "Mã bệnh nhân", "Tên bệnh nhân", "Họ bệnh nhân", "Mã bác sĩ", "Tên bác sĩ", "Họ bác sĩ", "Ngày khám", "Chẩn đoán", "Đơn thuốc", };
        private static string[] kindFindEng = { "Patient First Name", "Firt name", "Phone" };
        private static string[] kindFindVN = { "CCCD", "Tên", "Điện thoại" };
        private readonly string selectAll = "GetVisitsWithPatientAndDoctorNames";
        void frmVisits_Load_()
        {
            //chèn ảnh cho nut thoát
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconClose))
            {
                btnClose.Image = Image.FromStream(ms);
            }
            dtpVisitDate.Value = DateTime.Now;

            //thiết lập ngôn ngữ cho header datagridview và load dữ liệu lên form khi form load
            if (UTIL.Language.Lang.Equals("vn"))
            {
                dgvManageVisit.Rows.Clear();
                UTIL.UTIL.showDataToDataGridview(dgvManageVisit, "GetVisitsWithPatientAndDoctorNames", headTitleVN);
            }
            else
            {
                dgvManageVisit.Rows.Clear();
                UTIL.UTIL.showDataToDataGridview(dgvManageVisit, "GetVisitsWithPatientAndDoctorNames", headTitleEng);
            }

            //add data combobox 
            UTIL.UTIL.AddDataToComboBoxWithSQLQuery("getALlDoctors", cboDoctorId, "DoctorId");
            //thiết lập combobox mặc định cho gender
            cboDoctorId.SelectedIndex = 0;
            UTIL.UTIL.AddDataToComboBoxWithSQLQuery("getALlPatients", cboPatientId, "PatientId");
            //thiết lập combobox mặc định cho gender
            cboPatientId.SelectedIndex = 0;

            ////add data combobox kind find
            //if (UTIL.Language.Lang.Equals("vn"))
            //{
            //    for (int i = 0; i < kindFindVN.Length; i++)
            //    {
            //        cboKindFind.Items.Add(kindFindVN[i]);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < kindFindEng.Length; i++)
            //    {
            //        cboKindFind.Items.Add(kindFindEng[i]);
            //    }
            //}
            ////thiết lập combobox mặc định cho gender
            //cboKindFind.SelectedIndex = 0;
        }

        //code cho nút reload
        private void btnReload_Click_()
        {
            if (UTIL.Language.Lang.Equals("vn"))
            {
                UTIL.UTIL.showDataToDataGridview(dgvManageVisit, selectAll, headTitleVN);
            }
            else
            {
                UTIL.UTIL.showDataToDataGridview(dgvManageVisit, selectAll, headTitleEng);
            }
        }

        //code cho nút thêm
        private void btnAdd_Click_()
        {
            VisitBLL bll = new VisitBLL(); //tạo bll để gọi các hàm kiểm tra

            if (string.IsNullOrEmpty(txtDoctorFirstName.Text) || string.IsNullOrEmpty(txtDoctorLastName.Text) ||
                string.IsNullOrEmpty(txtPatientFirstName.Text) || string.IsNullOrEmpty(txtPatientLastName.Text))
            {
                MessageBox.Show("Name Patient and Doctor is not null", "Notif", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VisitDML dml = new VisitDML(); //tạo dml để set giá trị cho model
                dml.PatientId1 = int.Parse(cboPatientId.SelectedItem.ToString().Trim());
                dml.DoctorId1 = int.Parse(cboDoctorId.SelectedItem.ToString().Trim());
                dml.VisitDate1 = dtpVisitDate.Value;
                dml.Diagnosis1 = txtDiagnosis.Text.Trim();
                dml.Prescription1 = txtPrescription.Text.Trim();
                bll.Insert(dml);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnReload_Click_();
            }
        }

        //code cho nút chỉnh sửa
        private void btnEdit_Click_()
        {
            try
            {
                VisitBLL bll = new VisitBLL();//tạo bll để gọi các hàm kiểm tra
                if (bll.checkVisitsByID(int.Parse(txtVisitID.Text.Trim())))
                {
                    try
                    {
                        VisitDML dml = new VisitDML();//tạo dml để set giá trị cho model
                        dml.VisitId1 = int.Parse(txtVisitID.Text.Trim());
                        dml.PatientId1 = int.Parse(cboPatientId.SelectedItem.ToString().Trim());
                        dml.DoctorId1 = int.Parse(cboDoctorId.SelectedItem.ToString().Trim());
                        dml.VisitDate1 = dtpVisitDate.Value;
                        dml.Diagnosis1 = txtDiagnosis.Text.Trim();
                        dml.Prescription1 = txtPrescription.Text.Trim();

                        bll.Update(dml);
                        MessageBox.Show("Chỉnh sửa thành công bac si co id \"" + txtVisitID.Text.Trim() + "\"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnReload_Click_();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa co id \"" + txtVisitID.Text.Trim() + "\" trong database" + Environment.NewLine + "Chon 1 dong de chinh sua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Chưa co id  \"" + txtVisitID.Text.Trim() + "\" trong database" + Environment.NewLine + "Chon 1 dong de chinh sua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //code nút xóa
        private void btnDelete_Click_()
        {
            VisitBLL bll = new VisitBLL();
            if (bll.checkVisitsByID(int.Parse(txtVisitID.Text.Trim())))
            {
                try
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        VisitDML dml = new VisitDML();
                        dml.VisitId1 = int.Parse(txtVisitID.Text.Trim());

                        bll.Delete(dml);
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        //thiết lập ngôn ngữ cho header datagridview và load dữ liệu lên form khi form load
                        btnReload_Click_();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("có liên kết, không thể xóa: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có \"" + txtVisitID.Text.Trim() + "\" trong database", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //==========================================================================================
        public frmVisits(TabPage parentTab, TabControl tabControl)
        {
            InitializeComponent();
            this.parentTab = parentTab;
            this.tabControl = tabControl;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click_();
        }

        private void frmVisits_Load(object sender, EventArgs e)
        {
            frmVisits_Load_();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (parentTab != null && tabControl != null)
            {
                tabControl.TabPages.Remove(parentTab); // Xóa tab khỏi TabControl
            }
        }

        private void dgvManageVisit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtVisitID, dgvManageVisit, 0, e);
            UTIL.UTIL.getDataFromDatagridviewFillCombobox(cboPatientId, dgvManageVisit, 1, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtPatientFirstName, dgvManageVisit, 2, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtPatientLastName, dgvManageVisit, 3, e);
            UTIL.UTIL.getDataFromDatagridviewFillCombobox(cboDoctorId, dgvManageVisit, 4, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtDoctorFirstName, dgvManageVisit, 5, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtDoctorLastName, dgvManageVisit, 6, e);
            UTIL.UTIL.getDataFromDatagridviewFillDateTimePicker(dtpVisitDate, dgvManageVisit, 7, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtDiagnosis, dgvManageVisit, 8, e);
            UTIL.UTIL.getDataFromDatagridviewFillTextbox(txtPrescription, dgvManageVisit, 9, e);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click_();
            txtDiagnosis.ResetText();
            txtDoctorFirstName.ResetText();
            txtDoctorLastName.ResetText();
            txtPatientFirstName.ResetText();
            txtPatientLastName.ResetText();
            txtPrescription.ResetText();
            txtVisitID.ResetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click_();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            btnReload_Click_();
            txtDiagnosis.ResetText();
            txtDoctorFirstName.ResetText();
            txtDoctorLastName.ResetText();
            txtPatientFirstName.ResetText();
            txtPatientLastName.ResetText();
            txtPrescription.ResetText();
            txtVisitID.ResetText();

        }
        private void cboPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("getALlPatientsById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PatientId", int.Parse(cboPatientId.SelectedItem.ToString().Trim()));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy FirstName từ cột 0 và gán vào txtFirstName
                                txtPatientFirstName.Text = reader[1].ToString();
                                txtPatientLastName.Text = reader[2].ToString();
                            }
                            else
                            {
                                // Nếu không tìm thấy bệnh nhân, xóa txtFirstName
                                txtPatientFirstName.Text = string.Empty;
                                txtPatientLastName.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (xóa txtFirstName và hiển thị thông báo)
                txtPatientFirstName.Text = string.Empty;
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDoctorId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("getDoctorById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DoctorId", int.Parse(cboDoctorId.SelectedItem.ToString().Trim()));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy FirstName từ cột 0 và gán vào txtFirstName
                                txtDoctorFirstName.Text = reader[1].ToString();
                                txtDoctorLastName.Text = reader[2].ToString();
                            }
                            else
                            {
                                // Nếu không tìm thấy bệnh nhân, xóa txtFirstName
                                txtDoctorFirstName.Text = string.Empty;
                                txtDoctorLastName.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (xóa txtFirstName và hiển thị thông báo)
                txtDoctorFirstName.Text = string.Empty;
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
