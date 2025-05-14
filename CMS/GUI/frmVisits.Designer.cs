namespace CMS.GUI
{
    partial class frmVisits
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
            this.lblManageVisits = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbMedicalConsultation = new System.Windows.Forms.GroupBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.txtPrescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.txtVisitID = new System.Windows.Forms.TextBox();
            this.lblVisitId = new System.Windows.Forms.Label();
            this.lblVisitDate = new System.Windows.Forms.Label();
            this.grbDoctor = new System.Windows.Forms.GroupBox();
            this.txtDoctorFirstName = new System.Windows.Forms.TextBox();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.cboDoctorId = new System.Windows.Forms.ComboBox();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.lblDoctorFirstName = new System.Windows.Forms.Label();
            this.grbPatient = new System.Windows.Forms.GroupBox();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.cboPatientId = new System.Windows.Forms.ComboBox();
            this.lblPatientFirstName = new System.Windows.Forms.Label();
            this.txtPatientFirstName = new System.Windows.Forms.TextBox();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.txtPatientLastName = new System.Windows.Forms.TextBox();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.dgvManageVisit = new System.Windows.Forms.DataGridView();
            this.pnlHead.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.grbMedicalConsultation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbDoctor.SuspendLayout();
            this.grbPatient.SuspendLayout();
            this.pnlFoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Transparent;
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.lblManageVisits);
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
            this.btnClose.Location = new System.Drawing.Point(1546, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Transparent;
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(44, 43);
            this.btnClose.TabIndex = 28;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblManageVisits
            // 
            this.lblManageVisits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManageVisits.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblManageVisits.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblManageVisits.Location = new System.Drawing.Point(3, 0);
            this.lblManageVisits.Name = "lblManageVisits";
            this.lblManageVisits.Size = new System.Drawing.Size(1587, 57);
            this.lblManageVisits.TabIndex = 0;
            this.lblManageVisits.Text = "Manage Visit";
            this.lblManageVisits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Transparent;
            this.panelBody.Controls.Add(this.grbMedicalConsultation);
            this.panelBody.Controls.Add(this.groupBox1);
            this.panelBody.Controls.Add(this.grbDoctor);
            this.panelBody.Controls.Add(this.grbPatient);
            this.panelBody.Controls.Add(this.btnReload);
            this.panelBody.Controls.Add(this.btnDelete);
            this.panelBody.Controls.Add(this.btnEdit);
            this.panelBody.Controls.Add(this.btnAdd);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBody.Location = new System.Drawing.Point(0, 60);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1593, 319);
            this.panelBody.TabIndex = 29;
            // 
            // grbMedicalConsultation
            // 
            this.grbMedicalConsultation.Controls.Add(this.lblDiagnosis);
            this.grbMedicalConsultation.Controls.Add(this.txtDiagnosis);
            this.grbMedicalConsultation.Controls.Add(this.lblPrescription);
            this.grbMedicalConsultation.Controls.Add(this.txtPrescription);
            this.grbMedicalConsultation.Location = new System.Drawing.Point(960, 6);
            this.grbMedicalConsultation.Name = "grbMedicalConsultation";
            this.grbMedicalConsultation.Size = new System.Drawing.Size(621, 307);
            this.grbMedicalConsultation.TabIndex = 90;
            this.grbMedicalConsultation.TabStop = false;
            this.grbMedicalConsultation.Text = "Medical consultation";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.Location = new System.Drawing.Point(16, 21);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(126, 33);
            this.lblDiagnosis.TabIndex = 75;
            this.lblDiagnosis.Text = "Diagnosis";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnosis.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(179, 18);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(421, 97);
            this.txtDiagnosis.TabIndex = 74;
            this.txtDiagnosis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiagnosis_KeyPress);
            // 
            // lblPrescription
            // 
            this.lblPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.Location = new System.Drawing.Point(16, 130);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(150, 33);
            this.lblPrescription.TabIndex = 73;
            this.lblPrescription.Text = "Prescription";
            // 
            // txtPrescription
            // 
            this.txtPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescription.Location = new System.Drawing.Point(179, 127);
            this.txtPrescription.Multiline = true;
            this.txtPrescription.Name = "txtPrescription";
            this.txtPrescription.Size = new System.Drawing.Size(415, 174);
            this.txtPrescription.TabIndex = 72;
            this.txtPrescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrescription_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpVisitDate);
            this.groupBox1.Controls.Add(this.txtVisitID);
            this.groupBox1.Controls.Add(this.lblVisitId);
            this.groupBox1.Controls.Add(this.lblVisitDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 75);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.dtpVisitDate.Location = new System.Drawing.Point(500, 21);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(415, 39);
            this.dtpVisitDate.TabIndex = 79;
            // 
            // txtVisitID
            // 
            this.txtVisitID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitID.Location = new System.Drawing.Point(197, 21);
            this.txtVisitID.Name = "txtVisitID";
            this.txtVisitID.ReadOnly = true;
            this.txtVisitID.Size = new System.Drawing.Size(141, 39);
            this.txtVisitID.TabIndex = 60;
            // 
            // lblVisitId
            // 
            this.lblVisitId.AutoSize = true;
            this.lblVisitId.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitId.Location = new System.Drawing.Point(16, 24);
            this.lblVisitId.Name = "lblVisitId";
            this.lblVisitId.Size = new System.Drawing.Size(103, 33);
            this.lblVisitId.TabIndex = 61;
            this.lblVisitId.Text = "Visit ID";
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisitDate.AutoSize = true;
            this.lblVisitDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitDate.Location = new System.Drawing.Point(353, 24);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(127, 33);
            this.lblVisitDate.TabIndex = 67;
            this.lblVisitDate.Text = "Visit Date";
            // 
            // grbDoctor
            // 
            this.grbDoctor.Controls.Add(this.txtDoctorFirstName);
            this.grbDoctor.Controls.Add(this.lblDoctorId);
            this.grbDoctor.Controls.Add(this.txtDoctorLastName);
            this.grbDoctor.Controls.Add(this.cboDoctorId);
            this.grbDoctor.Controls.Add(this.lblDoctorLastName);
            this.grbDoctor.Controls.Add(this.lblDoctorFirstName);
            this.grbDoctor.Location = new System.Drawing.Point(12, 176);
            this.grbDoctor.Name = "grbDoctor";
            this.grbDoctor.Size = new System.Drawing.Size(921, 75);
            this.grbDoctor.TabIndex = 89;
            this.grbDoctor.TabStop = false;
            this.grbDoctor.Text = "Doctor";
            // 
            // txtDoctorFirstName
            // 
            this.txtDoctorFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorFirstName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorFirstName.Location = new System.Drawing.Point(491, 26);
            this.txtDoctorFirstName.Name = "txtDoctorFirstName";
            this.txtDoctorFirstName.ReadOnly = true;
            this.txtDoctorFirstName.Size = new System.Drawing.Size(135, 39);
            this.txtDoctorFirstName.TabIndex = 84;
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
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoctorLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorLastName.Location = new System.Drawing.Point(771, 26);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.ReadOnly = true;
            this.txtDoctorLastName.Size = new System.Drawing.Size(135, 39);
            this.txtDoctorLastName.TabIndex = 86;
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
            this.cboDoctorId.SelectedIndexChanged += new System.EventHandler(this.cboDoctorId_SelectedIndexChanged);
            // 
            // lblDoctorLastName
            // 
            this.lblDoctorLastName.AutoSize = true;
            this.lblDoctorLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorLastName.Location = new System.Drawing.Point(632, 29);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(133, 33);
            this.lblDoctorLastName.TabIndex = 85;
            this.lblDoctorLastName.Text = "Last Name";
            // 
            // lblDoctorFirstName
            // 
            this.lblDoctorFirstName.AutoSize = true;
            this.lblDoctorFirstName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorFirstName.Location = new System.Drawing.Point(344, 29);
            this.lblDoctorFirstName.Name = "lblDoctorFirstName";
            this.lblDoctorFirstName.Size = new System.Drawing.Size(138, 33);
            this.lblDoctorFirstName.TabIndex = 83;
            this.lblDoctorFirstName.Text = "First Name";
            // 
            // grbPatient
            // 
            this.grbPatient.Controls.Add(this.lblPatientId);
            this.grbPatient.Controls.Add(this.cboPatientId);
            this.grbPatient.Controls.Add(this.lblPatientFirstName);
            this.grbPatient.Controls.Add(this.txtPatientFirstName);
            this.grbPatient.Controls.Add(this.lblPatientLastName);
            this.grbPatient.Controls.Add(this.txtPatientLastName);
            this.grbPatient.Location = new System.Drawing.Point(12, 91);
            this.grbPatient.Name = "grbPatient";
            this.grbPatient.Size = new System.Drawing.Size(921, 75);
            this.grbPatient.TabIndex = 88;
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
            this.cboPatientId.SelectedIndexChanged += new System.EventHandler(this.cboPatientId_SelectedIndexChanged);
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
            this.txtPatientFirstName.ReadOnly = true;
            this.txtPatientFirstName.Size = new System.Drawing.Size(135, 39);
            this.txtPatientFirstName.TabIndex = 80;
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientLastName.Location = new System.Drawing.Point(632, 23);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(133, 33);
            this.lblPatientLastName.TabIndex = 81;
            this.lblPatientLastName.Text = "Last Name";
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientLastName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientLastName.Location = new System.Drawing.Point(771, 20);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.ReadOnly = true;
            this.txtPatientLastName.Size = new System.Drawing.Size(135, 39);
            this.txtPatientLastName.TabIndex = 82;
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
            this.btnReload.Location = new System.Drawing.Point(784, 265);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(141, 50);
            this.btnReload.TabIndex = 59;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(526, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 50);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(268, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 50);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(10, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 50);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlFoot
            // 
            this.pnlFoot.BackColor = System.Drawing.Color.Transparent;
            this.pnlFoot.Controls.Add(this.dgvManageVisit);
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoot.Location = new System.Drawing.Point(0, 379);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(1593, 468);
            this.pnlFoot.TabIndex = 30;
            // 
            // dgvManageVisit
            // 
            this.dgvManageVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageVisit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvManageVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageVisit.Location = new System.Drawing.Point(12, 6);
            this.dgvManageVisit.Name = "dgvManageVisit";
            this.dgvManageVisit.RowHeadersWidth = 51;
            this.dgvManageVisit.RowTemplate.Height = 24;
            this.dgvManageVisit.Size = new System.Drawing.Size(1568, 450);
            this.dgvManageVisit.TabIndex = 0;
            this.dgvManageVisit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageVisit_CellClick);
            // 
            // frmVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1593, 847);
            this.Controls.Add(this.pnlFoot);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisits";
            this.Text = "frmVisits";
            this.Load += new System.EventHandler(this.frmVisits_Load);
            this.pnlHead.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.grbMedicalConsultation.ResumeLayout(false);
            this.grbMedicalConsultation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDoctor.ResumeLayout(false);
            this.grbDoctor.PerformLayout();
            this.grbPatient.ResumeLayout(false);
            this.grbPatient.PerformLayout();
            this.pnlFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblManageVisits;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label lblVisitDate;
        private System.Windows.Forms.Label lblVisitId;
        private System.Windows.Forms.TextBox txtVisitID;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.DataGridView dgvManageVisit;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.GroupBox grbPatient;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.ComboBox cboPatientId;
        private System.Windows.Forms.Label lblPatientFirstName;
        private System.Windows.Forms.TextBox txtPatientFirstName;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.TextBox txtPatientLastName;
        private System.Windows.Forms.GroupBox grbDoctor;
        private System.Windows.Forms.TextBox txtDoctorFirstName;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.ComboBox cboDoctorId;
        private System.Windows.Forms.Label lblDoctorLastName;
        private System.Windows.Forms.Label lblDoctorFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbMedicalConsultation;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.TextBox txtPrescription;
    }
}