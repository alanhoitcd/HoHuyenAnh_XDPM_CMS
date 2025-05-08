using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.GUI
{
    public partial class frmManageAppointments : Form
    {
        string[] headTitleEng = { "AppointmentId", "Patient FirstName", "Patient LastName", "Doctor FirstName", "Doctor LastName", "Appointment Date", "Appointments Status", };
        string[] headTitleVN = { "Mã hẹn", "Tên bệnh nhân", "Họ bệnh nhân", "Tên bác sĩ", "Họ bác sĩ", "Ngày hẹn", "Trạng thái hẹn", };
        private void frmManageAppointments_Load_()
        {
            UTIL.UTIL.showDataToDataGridview(dgvManageAppointments, "GetAllAppointments", headTitleVN);
            //chèn ảnh
            using (MemoryStream ms = new MemoryStream(Properties.Resources.img001))
            {
                pictureBoxDoctor.Image = Image.FromStream(ms);
            }
            //add data combobox doctor id
            //UTIL.UTIL.AddDataToComboBox();
        }
        //==================================================
        public frmManageAppointments()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmManageAppointments_Load(object sender, EventArgs e)
        {
            frmManageAppointments_Load_();
        }
    }
}
