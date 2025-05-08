namespace CMS.GUI
{
    partial class frmManageAppointments
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblManageAppointments = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.pictureBoxDoctor = new System.Windows.Forms.PictureBox();
            this.grbAppointment = new System.Windows.Forms.GroupBox();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentsStatus = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.grbDoctor = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboDoctorId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbPatient = new System.Windows.Forms.GroupBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.cboPatientId = new System.Windows.Forms.ComboBox();
            this.lblPatientFirstName = new System.Windows.Forms.Label();
            this.txtPatientFirstName = new System.Windows.Forms.TextBox();
            this.txtPatientLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.cboKindFind = new System.Windows.Forms.ComboBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.dgvManageAppointments = new System.Windows.Forms.DataGridView();
            this.pnlHead.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoctor)).BeginInit();
            this.grbAppointment.SuspendLayout();
            this.grbDoctor.SuspendLayout();
            this.grbPatient.SuspendLayout();
            this.panelFoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Transparent;
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.lblManageAppointments);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1593, 60);
            this.pnlHead.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.FocusedColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1546, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Transparent;
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(44, 43);
            this.btnClose.TabIndex = 23;
            // 
            // lblManageAppointments
            // 
            this.lblManageAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManageAppointments.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblManageAppointments.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblManageAppointments.Location = new System.Drawing.Point(3, 0);
            this.lblManageAppointments.Name = "lblManageAppointments";
            this.lblManageAppointments.Size = new System.Drawing.Size(1587, 57);
            this.lblManageAppointments.TabIndex = 0;
            this.lblManageAppointments.Text = "Manage Appointments";
            this.lblManageAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.pictureBoxDoctor);
            this.panelBody.Controls.Add(this.grbAppointment);
            this.panelBody.Controls.Add(this.grbDoctor);
            this.panelBody.Controls.Add(this.grbPatient);
            this.panelBody.Controls.Add(this.txtFindText);
            this.panelBody.Controls.Add(this.cboKindFind);
            this.panelBody.Controls.Add(this.btnFind);
            this.panelBody.Controls.Add(this.btnReload);
            this.panelBody.Controls.Add(this.btnDelete);
            this.panelBody.Controls.Add(this.btnEdit);
            this.panelBody.Controls.Add(this.btnAdd);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBody.Location = new System.Drawing.Point(0, 60);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1593, 397);
            this.panelBody.TabIndex = 29;
            // 
            // pictureBoxDoctor
            // 
            this.pictureBoxDoctor.Location = new System.Drawing.Point(952, 6);
            this.pictureBoxDoctor.Name = "pictureBoxDoctor";
            this.pictureBoxDoctor.Size = new System.Drawing.Size(629, 314);
            this.pictureBoxDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoctor.TabIndex = 89;
            this.pictureBoxDoctor.TabStop = false;
            // 
            // grbAppointment
            // 
            this.grbAppointment.Controls.Add(this.lblAppointmentId);
            this.grbAppointment.Controls.Add(this.txtAppointmentId);
            this.grbAppointment.Controls.Add(this.txtLicenseNumber);
            this.grbAppointment.Controls.Add(this.dtpAppointmentDate);
            this.grbAppointment.Controls.Add(this.lblAppointmentsStatus);
            this.grbAppointment.Controls.Add(this.lblAppointmentDate);
            this.grbAppointment.Location = new System.Drawing.Point(12, 6);
            this.grbAppointment.Name = "grbAppointment";
            this.grbAppointment.Size = new System.Drawing.Size(921, 142);
            this.grbAppointment.TabIndex = 88;
            this.grbAppointment.TabStop = false;
            this.grbAppointment.Text = "Appointment";
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.AutoSize = true;
            this.lblAppointmentId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentId.Location = new System.Drawing.Point(6, 23);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(195, 33);
            this.lblAppointmentId.TabIndex = 61;
            this.lblAppointmentId.Text = "Appointment ID";
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentId.Location = new System.Drawing.Point(205, 20);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.ReadOnly = true;
            this.txtAppointmentId.Size = new System.Drawing.Size(141, 39);
            this.txtAppointmentId.TabIndex = 60;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicenseNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNumber.Location = new System.Drawing.Point(260, 81);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(646, 39);
            this.txtLicenseNumber.TabIndex = 70;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dtpAppointmentDate.Location = new System.Drawing.Point(444, 20);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(462, 39);
            this.dtpAppointmentDate.TabIndex = 78;
            // 
            // lblAppointmentsStatus
            // 
            this.lblAppointmentsStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointmentsStatus.AutoSize = true;
            this.lblAppointmentsStatus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentsStatus.Location = new System.Drawing.Point(7, 84);
            this.lblAppointmentsStatus.Name = "lblAppointmentsStatus";
            this.lblAppointmentsStatus.Size = new System.Drawing.Size(247, 33);
            this.lblAppointmentsStatus.TabIndex = 71;
            this.lblAppointmentsStatus.Text = "Appointments Status";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(371, 23);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(67, 33);
            this.lblAppointmentDate.TabIndex = 67;
            this.lblAppointmentDate.Text = "Date";
            // 
            // grbDoctor
            // 
            this.grbDoctor.Controls.Add(this.textBox3);
            this.grbDoctor.Controls.Add(this.lblDoctorId);
            this.grbDoctor.Controls.Add(this.textBox2);
            this.grbDoctor.Controls.Add(this.cboDoctorId);
            this.grbDoctor.Controls.Add(this.label1);
            this.grbDoctor.Controls.Add(this.label2);
            this.grbDoctor.Location = new System.Drawing.Point(12, 245);
            this.grbDoctor.Name = "grbDoctor";
            this.grbDoctor.Size = new System.Drawing.Size(921, 75);
            this.grbDoctor.TabIndex = 88;
            this.grbDoctor.TabStop = false;
            this.grbDoctor.Text = "Doctor";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(491, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 39);
            this.textBox3.TabIndex = 84;
            // 
            // lblDoctorId
            // 
            this.lblDoctorId.AutoSize = true;
            this.lblDoctorId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorId.Location = new System.Drawing.Point(7, 29);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(127, 33);
            this.lblDoctorId.TabIndex = 65;
            this.lblDoctorId.Text = "Doctor ID";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(771, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 39);
            this.textBox2.TabIndex = 86;
            // 
            // cboDoctorId
            // 
            this.cboDoctorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDoctorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctorId.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cboDoctorId.FormattingEnabled = true;
            this.cboDoctorId.Location = new System.Drawing.Point(197, 26);
            this.cboDoctorId.Name = "cboDoctorId";
            this.cboDoctorId.Size = new System.Drawing.Size(141, 39);
            this.cboDoctorId.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 85;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 83;
            this.label2.Text = "First Name";
            // 
            // grbPatient
            // 
            this.grbPatient.Controls.Add(this.lblPatientId);
            this.grbPatient.Controls.Add(this.cboPatientId);
            this.grbPatient.Controls.Add(this.lblPatientFirstName);
            this.grbPatient.Controls.Add(this.txtPatientFirstName);
            this.grbPatient.Controls.Add(this.txtPatientLastName);
            this.grbPatient.Controls.Add(this.textBox1);
            this.grbPatient.Location = new System.Drawing.Point(12, 154);
            this.grbPatient.Name = "grbPatient";
            this.grbPatient.Size = new System.Drawing.Size(921, 75);
            this.grbPatient.TabIndex = 87;
            this.grbPatient.TabStop = false;
            this.grbPatient.Text = "Patient";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.Location = new System.Drawing.Point(6, 23);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(128, 33);
            this.lblPatientId.TabIndex = 63;
            this.lblPatientId.Text = "Patient ID";
            // 
            // cboPatientId
            // 
            this.cboPatientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPatientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatientId.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cboPatientId.FormattingEnabled = true;
            this.cboPatientId.Location = new System.Drawing.Point(197, 20);
            this.cboPatientId.Name = "cboPatientId";
            this.cboPatientId.Size = new System.Drawing.Size(141, 39);
            this.cboPatientId.TabIndex = 76;
            // 
            // lblPatientFirstName
            // 
            this.lblPatientFirstName.AutoSize = true;
            this.lblPatientFirstName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientFirstName.Location = new System.Drawing.Point(344, 23);
            this.lblPatientFirstName.Name = "lblPatientFirstName";
            this.lblPatientFirstName.Size = new System.Drawing.Size(138, 33);
            this.lblPatientFirstName.TabIndex = 79;
            this.lblPatientFirstName.Text = "First Name";
            // 
            // txtPatientFirstName
            // 
            this.txtPatientFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientFirstName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientFirstName.Location = new System.Drawing.Point(491, 20);
            this.txtPatientFirstName.Name = "txtPatientFirstName";
            this.txtPatientFirstName.Size = new System.Drawing.Size(135, 39);
            this.txtPatientFirstName.TabIndex = 80;
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.AutoSize = true;
            this.txtPatientLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientLastName.Location = new System.Drawing.Point(632, 23);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Size = new System.Drawing.Size(133, 33);
            this.txtPatientLastName.TabIndex = 81;
            this.txtPatientLastName.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(771, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 39);
            this.textBox1.TabIndex = 82;
            // 
            // txtFindText
            // 
            this.txtFindText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindText.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindText.Location = new System.Drawing.Point(1075, 341);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(345, 39);
            this.txtFindText.TabIndex = 75;
            // 
            // cboKindFind
            // 
            this.cboKindFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKindFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKindFind.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cboKindFind.FormattingEnabled = true;
            this.cboKindFind.Location = new System.Drawing.Point(1433, 341);
            this.cboKindFind.Name = "cboKindFind";
            this.cboKindFind.Size = new System.Drawing.Size(148, 39);
            this.cboKindFind.TabIndex = 74;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BorderRadius = 18;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(833, 335);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(208, 50);
            this.btnFind.TabIndex = 73;
            this.btnFind.Text = "Find";
            // 
            // btnReload
            // 
            this.btnReload.BorderRadius = 18;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(589, 336);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(141, 50);
            this.btnReload.TabIndex = 59;
            this.btnReload.Text = "Reload";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 18;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(396, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 50);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 18;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(203, 336);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 50);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 18;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 50);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelFoot
            // 
            this.panelFoot.Controls.Add(this.dgvManageAppointments);
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFoot.Location = new System.Drawing.Point(0, 457);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(1593, 390);
            this.panelFoot.TabIndex = 30;
            // 
            // dgvManageAppointments
            // 
            this.dgvManageAppointments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvManageAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageAppointments.Location = new System.Drawing.Point(10, 6);
            this.dgvManageAppointments.Name = "dgvManageAppointments";
            this.dgvManageAppointments.RowHeadersWidth = 51;
            this.dgvManageAppointments.RowTemplate.Height = 24;
            this.dgvManageAppointments.Size = new System.Drawing.Size(1571, 500);
            this.dgvManageAppointments.TabIndex = 0;
            // 
            // frmManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 847);
            this.Controls.Add(this.panelFoot);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManageAppointments";
            this.Text = "frmManageAppointments";
            this.Load += new System.EventHandler(this.frmManageAppointments_Load);
            this.pnlHead.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoctor)).EndInit();
            this.grbAppointment.ResumeLayout(false);
            this.grbAppointment.PerformLayout();
            this.grbDoctor.ResumeLayout(false);
            this.grbDoctor.PerformLayout();
            this.grbPatient.ResumeLayout(false);
            this.grbPatient.PerformLayout();
            this.panelFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblManageAppointments;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.ComboBox cboKindFind;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label lblAppointmentsStatus;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.ComboBox cboPatientId;
        private System.Windows.Forms.ComboBox cboDoctorId;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblPatientFirstName;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.DataGridView dgvManageAppointments;
        private System.Windows.Forms.TextBox txtPatientFirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtPatientLastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbPatient;
        private System.Windows.Forms.GroupBox grbDoctor;
        private System.Windows.Forms.GroupBox grbAppointment;
        private System.Windows.Forms.PictureBox pictureBoxDoctor;
    }
}