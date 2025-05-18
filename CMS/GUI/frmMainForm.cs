﻿//class frmMainForm : Form
using CMS.GUI;
using CMS.UTIL;
using CMS.VIEW;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace CMS
{
    public partial class frmMainForm : Form
    {
        string userName = "";
        //hàm cập nhật text ngôn ngữ mới cho các control
        private void UpdateLanguage()
        {
            //Đổi ngôn ngữ label Chào
            lblHello.Text = LanguageManager.GetString("lblHello") + " " + this.userName;

            //Đổi ngôn ngữ label logan
            lblLogan.Text = LanguageManager.GetString("lblLogan");

            //Đổi ngôn ngữ các toolstripmenu item of tsmiFile
            tsmiFile.Text = LanguageManager.GetString("tsmiFile");
            tsmiLogin.Text = LanguageManager.GetString("tsmiLogin");
            tsmiLogout.Text = LanguageManager.GetString("tsmiLogout");
            tsmiChangePassword.Text = LanguageManager.GetString("tsmiChangePassword");
            tsmiExit.Text = LanguageManager.GetString("tsmiExit");

            //Đổi ngôn ngữ các toolstripmenu item of tsmiManagement
            tsmiManagement.Text = LanguageManager.GetString("tsmiManagement");
            tsmiManagePatient.Text = LanguageManager.GetString("tsmiManagePatient");
            tsmiManageDoctors.Text = LanguageManager.GetString("tsmiManageDoctors");
            tsmiManageAppointments.Text = LanguageManager.GetString("tsmiManageAppointments");
            tsmiManageMedicineInventory.Text = LanguageManager.GetString("tsmiManageMedicineInventory");
            tsmiManageVisit.Text = LanguageManager.GetString("tsmiManageVisit");

            //Đổi ngôn ngữ các toolstripmenu item of tsmiPatientExamination
            tsmiPatientExamination.Text = LanguageManager.GetString("tsmiPatientExamination");
            tsmiManageExaminationHistory.Text = LanguageManager.GetString("tsmiManageExaminationHistory");
            tsmiManagePrescriptions.Text = LanguageManager.GetString("tsmiManagePrescriptions");


            //Đổi ngôn ngữ các toolstripmenu item of tsmiReports
            tsmiReports.Text = LanguageManager.GetString("tsmiReports");
            tsmiPatientListReport.Text = LanguageManager.GetString("tsmiPatientListReport");
            tsmiAppointmentScheduleReport.Text = LanguageManager.GetString("tsmiAppointmentScheduleReport");
            tsmiInventoryAndMedicineRevenueReport.Text = LanguageManager.GetString("tsmiInventoryAndMedicineRevenueReport");
            tsmiDoctorListReport.Text = LanguageManager.GetString("tsmiDoctorListReport");
            tsmiPatientListReport.Text = LanguageManager.GetString("tsmiPatientListReport");

            //Đổi ngôn ngữ các toolstripmenu item of tsmiSystem
            tsmiSystem.Text = LanguageManager.GetString("tsmiSystem");
            tsmiManageUserAccounts.Text = LanguageManager.GetString("tsmiManageUserAccounts");
            tsmiViewActivityLog.Text = LanguageManager.GetString("tsmiViewActivityLog");
            tsmiBackupAndRestoreDatabase.Text = LanguageManager.GetString("tsmiBackupAndRestoreDatabase");
            

            //Đổi ngôn ngữ các toolstripmenu item of tsmiHelp
            tsmiHelp.Text = LanguageManager.GetString("tsmiHelp");
            tsmiAboutSoftware.Text = LanguageManager.GetString("tsmiAboutSoftware");
            tsmiUserGuide.Text = LanguageManager.GetString("tsmiUserGuide");
            tsmiContactSupport.Text = LanguageManager.GetString("tsmiContactSupport");

            //Đổi ngôn ngữ các tabpage thuộc tabControlMain
            tabPagePatients.Text = LanguageManager.GetString("tabPagePatients");
            tabPageDoctors.Text = LanguageManager.GetString("tabPageDoctors");
            tabPageAppointments.Text = LanguageManager.GetString("tabPageAppointments");
            tabPageMedicineInventory.Text = LanguageManager.GetString("tabPageMedicineInventory");


        }

        //Hàm kiểm tra ngôn ngữ hiện tại và thay đổi ngôn ngữ mới
        private void ChangeLanguage()
        {
            if (UTIL.Language.Lang.Equals("en"))
            {
                //Gán giá trị mã ngôn ngữ mới cho Lang. Setter sẽ kiểm tra giá trị
                UTIL.Language.Lang = "vn";
                UTIL.LanguageManager.SetLanguage("vi-VN");

                //thay đổi ảnh icon ngôn ngữ
                using (MemoryStream ms = new MemoryStream(Properties.Resources.iconUSA))
                {
                    btnLang.Image = Image.FromStream(ms);
                }
            }
            else
            {
                //Gán giá trị mã ngôn ngữ mới cho Lang.// Setter sẽ kiểm tra giá trị
                UTIL.Language.Lang = "en";
                UTIL.LanguageManager.SetLanguage("en-US");

                //thay đổi ảnh icon ngôn ngữ
                using (MemoryStream ms = new MemoryStream(Properties.Resources.iconVietNam))
                {
                    btnLang.Image = Image.FromStream(ms);
                }
            }
            UpdateLanguage();
        }

        //hàm khi form chạy, truyền vào true == trạng thái chưa đăng nhập và ngược lại
        private void frmMainForm_Load_(bool on)
        {
            btnLang.Enabled = on;
            //Ẩn nút đổi giao diện, phát triển tính năng sau, còn chưa đổi màu được viền của tabControl được
            btnScreenMode.Hide();

            //thiết lập các ảnh icon cho toolmenustrip File item
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconLogin))
            {
                tsmiLogin.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconLogout))
            {
                tsmiLogout.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconChangePassword))
            {
                tsmiChangePassword.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconExit))
            {
                tsmiExit.Image = Image.FromStream(ms);
            }

            //thiết lập các ảnh icon cho toolmenustrip Menagement item
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManagePatients))
            {
                tsmiManagePatient.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManageDoctors))
            {
                tsmiManageDoctors.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManageAppointments))
            {
                tsmiManageAppointments.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManageMedicineInventory))
            {
                tsmiManageMedicineInventory.Image = Image.FromStream(ms);
            }

            //thiết lập các ảnh icon cho toolmenustrip Patient Examination item
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManageExaminationHistory))
            {
                tsmiManageExaminationHistory.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManagePrescription))
            {
                tsmiManagePrescriptions.Image = Image.FromStream(ms);
            }

            //thiết lập các ảnh icon cho toolmenustrip report item
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconPatientListReport))
            {
                tsmiPatientListReport.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconAppointmentScheduleReport))
            {
                tsmiAppointmentScheduleReport.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconInventoryandMedicineRevenueReport))
            {
                tsmiInventoryAndMedicineRevenueReport.Image = Image.FromStream(ms);
            }

            //thiết lập các ảnh icon cho toolmenustrip System item
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconManageUserAccounts))
            {
                tsmiManageUserAccounts.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconViewActivityLog))
            {
                tsmiViewActivityLog.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconBackupandRestoreDatabase))
            {
                tsmiBackupAndRestoreDatabase.Image = Image.FromStream(ms);
            }

            //thiết lập các ảnh icon cho toolmenustrip help item
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconAboutSoftware))
            {
                tsmiAboutSoftware.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconUserGuide))
            {
                tsmiUserGuide.Image = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(Properties.Resources.iconContactSupport))
            {
                tsmiContactSupport.Image = Image.FromStream(ms);
            }

            //Ẩn các menustrip
            tsmiManagement.Enabled = !on;
            tsmiPatientExamination.Enabled = !on;
            tsmiReports.Enabled = !on;
            tsmiSystem.Enabled = !on;
            tsmiLogout.Enabled = !on;
            tsmiChangePassword.Enabled = !on;
            //hiện các menustrip
            tsmiLogin.Enabled = on;
            //tắt các tool strip menu item, không làm kiệp, phát triển sau nếu có thời gian
            tsmiManageAppointments.Visible = false;
            tsmiManageMedicineInventory.Visible = false;
            tsmiPatientExamination.Visible = false;
            tsmiViewActivityLog.Visible = false;
            tsmiBackupAndRestoreDatabase.Visible = false;
            tsmiAppointmentScheduleReport.Visible = false;
            tsmiInventoryAndMedicineRevenueReport.Visible = false;
            tsmiDoctorListReport.Visible = false;

            //Ẩn Panel main, panelMain chứa các tabpage của tabcontrol, nhúng các form khác
            if (on)
            {
                pnlMain.Hide();
            }
            else
            {
                pnlMain.Show();
            }

            //Ẩn các tabcontrol
            tabControlMain.TabPages.Remove(tabPagePatients);
            tabControlMain.TabPages.Remove(tabPageDoctors);
            tabControlMain.TabPages.Remove(tabPageAppointments);
            tabControlMain.TabPages.Remove(tabPageMedicineInventory);
            tabControlMain.TabPages.Remove(tabPagePatientListReport);
            tabControlMain.TabPages.Remove(tabPageExamination);
            tabControlMain.TabPages.Remove(tabPagePrescriptions);
            tabControlMain.TabPages.Remove(tabPageAppointmentScheduleReport);
            tabControlMain.TabPages.Remove(tabPageInventoryAndMedicineRevenueReport);
            tabControlMain.TabPages.Remove(tabPageVisits);
        }
        //********************************************************************************************//
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            frmMainForm_Load_(true);
        }

        private void btnScreenMode_Click(object sender, EventArgs e)
        {
            //giao diện tối phát triển sau
            //ChangeScreenMode(btnScreenMode, statusLightMode);
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                frmMainForm_Load_(false);
                this.userName = "Hồ Huyền Anh";
                lblHello.Text = LanguageManager.GetString("lblHello") + " " + this.userName;
            }
            else
            {
                frmMainForm_Load_(true);
            }
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            frmMainForm_Load_(true);
            this.userName = "";
            lblHello.Text = LanguageManager.GetString("lblHello") + " " + this.userName;
        }

        private void tsmiManagePatient_Click(object sender, EventArgs e)
        {
            //Xóa nội dung tabpage
            tabPagePatients.Controls.Clear();

            //tạo các đối tượng form và truyền vào các tabpage của tabcontrol
            frmManagePatients frm = new frmManagePatients(tabPagePatients, tabControlMain);

            //thiết lập nhúng các form vào các tabpage
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;

            //Thêm các form vào tabpage
            tabPagePatients.Controls.Add(frm);

            //chuyển focus sang tabpage được chọn
            tabControlMain.SelectedTab = tabPagePatients;
            //Kiểm tra nếu tabpage bị ẩn thì mở lại
            if (!tabControlMain.TabPages.Contains(tabPagePatients))
            {
                tabControlMain.TabPages.Add(tabPagePatients);
            }
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void tsmiManageDoctors_Click(object sender, EventArgs e)
        {
            // Xóa nội dung tabpage
            tabPageDoctors.Controls.Clear();

            //tạo các đối tượng form và truyền vào các tabpage của tabcontrol
            frmManageDoctors frm = new frmManageDoctors(tabPageDoctors, tabControlMain);

            //thiết lập nhúng các form vào các tabpage
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;

            //Thêm các form vào tabpage
            tabPageDoctors.Controls.Add(frm);

            //chuyển focus sang tabpage được chọn
            tabControlMain.SelectedTab = tabPageDoctors;
            //Kiểm tra nếu tabpage bị ẩn thì mở lại
            if (!tabControlMain.TabPages.Contains(tabPageDoctors))
            {
                tabControlMain.TabPages.Add(tabPageDoctors);
            }
        }

        private void tsmiPatientListReport_Click(object sender, EventArgs e)
        {
            //Xóa nội dung tabpage
            tabPagePatientListReport.Controls.Clear();

            //tạo các đối tượng form và truyền vào các tabpage của tabcontrol
            frmPatientListReport frm = new frmPatientListReport(tabPagePatientListReport, tabControlMain);

            //thiết lập nhúng các form vào các tabpage
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;

            //Thêm các form vào tabpage
            tabPagePatientListReport.Controls.Add(frm);

            //chuyển focus sang tabpage được chọn
            tabControlMain.SelectedTab = tabPagePatientListReport;
            //Kiểm tra nếu tabpage bị ẩn thì mở lại
            if (!tabControlMain.TabPages.Contains(tabPagePatientListReport))
            {
                tabControlMain.TabPages.Add(tabPagePatientListReport);
            }
        }

        private void tsmiManageAppointments_Click(object sender, EventArgs e)
        {
            //frmManageAppointments frm = new frmManageAppointments();
            //frm.ShowDialog();

        }

        private void tsmiManageVisit_Click(object sender, EventArgs e)
        {
            //Xóa nội dung tabpage
            tabPageVisits.Controls.Clear();

            //tạo các đối tượng form và truyền vào các tabpage của tabcontrol
            frmVisits frm = new frmVisits(tabPageVisits, tabControlMain);

            //thiết lập nhúng các form vào các tabpage
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;

            //Thêm các form vào tabpage
            tabPageVisits.Controls.Add(frm);

            //chuyển focus sang tabpage được chọn
            tabControlMain.SelectedTab = tabPageVisits;
            //Kiểm tra nếu tabpage bị ẩn thì mở lại
            if (!tabControlMain.TabPages.Contains(tabPageVisits))
            {
                tabControlMain.TabPages.Add(tabPageVisits);
            }
        }
    }
}
