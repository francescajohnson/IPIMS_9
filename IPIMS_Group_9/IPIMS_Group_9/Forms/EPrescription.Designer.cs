namespace IPIMS_Group_9.Forms
{
    partial class EPrescription
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
            this.comboBoxDoctorSelection = new System.Windows.Forms.ComboBox();
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.textBoxLabDescription = new System.Windows.Forms.TextBox();
            this.labelLabDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDosage = new System.Windows.Forms.Label();
            this.textBoxMedicine = new System.Windows.Forms.TextBox();
            this.labelMedicine = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEPrescriptions = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listBoxEPrescriptions = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.patientServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewApptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleApptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEPrescribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExistingEPrescribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExistingEPrescribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printExistingEPrescribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLabRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLabRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOfTypeOfPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOfPatientPopulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutOfIPIMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPatientInformation.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDoctorSelection
            // 
            this.comboBoxDoctorSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDoctorSelection.FormattingEnabled = true;
            this.comboBoxDoctorSelection.Items.AddRange(new object[] {
            "Dr. Thomas Smith",
            "Dr. Susan Enriquez",
            "Dr. Linda Chattin"});
            this.comboBoxDoctorSelection.Location = new System.Drawing.Point(152, 186);
            this.comboBoxDoctorSelection.Name = "comboBoxDoctorSelection";
            this.comboBoxDoctorSelection.Size = new System.Drawing.Size(284, 23);
            this.comboBoxDoctorSelection.TabIndex = 50;
            this.comboBoxDoctorSelection.Text = "Select Doctor:";
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(this.textBoxLabDescription);
            this.groupBoxPatientInformation.Controls.Add(this.labelLabDescription);
            this.groupBoxPatientInformation.Controls.Add(this.textBox1);
            this.groupBoxPatientInformation.Controls.Add(this.labelDosage);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxMedicine);
            this.groupBoxPatientInformation.Controls.Add(this.labelMedicine);
            this.groupBoxPatientInformation.Controls.Add(this.labelDateOfBirth);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxLastName);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatientInformation.Controls.Add(this.labelLastName);
            this.groupBoxPatientInformation.Controls.Add(this.labelFirstName);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(12, 75);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(564, 100);
            this.groupBoxPatientInformation.TabIndex = 46;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information";
            // 
            // textBoxLabDescription
            // 
            this.textBoxLabDescription.Location = new System.Drawing.Point(96, 69);
            this.textBoxLabDescription.Name = "textBoxLabDescription";
            this.textBoxLabDescription.Size = new System.Drawing.Size(447, 20);
            this.textBoxLabDescription.TabIndex = 15;
            this.textBoxLabDescription.Text = "X-Ray left hip";
            // 
            // labelLabDescription
            // 
            this.labelLabDescription.AutoSize = true;
            this.labelLabDescription.Location = new System.Drawing.Point(6, 72);
            this.labelLabDescription.Name = "labelLabDescription";
            this.labelLabDescription.Size = new System.Drawing.Size(84, 13);
            this.labelLabDescription.TabIndex = 14;
            this.labelLabDescription.Text = "Lab Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "500 mg";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Location = new System.Drawing.Point(222, 46);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(47, 13);
            this.labelDosage.TabIndex = 12;
            this.labelDosage.Text = "Dosage:";
            // 
            // textBoxMedicine
            // 
            this.textBoxMedicine.Location = new System.Drawing.Point(96, 43);
            this.textBoxMedicine.Name = "textBoxMedicine";
            this.textBoxMedicine.Size = new System.Drawing.Size(120, 20);
            this.textBoxMedicine.TabIndex = 11;
            this.textBoxMedicine.Text = "Acetaminophen";
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.Location = new System.Drawing.Point(6, 46);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(84, 13);
            this.labelMedicine.TabIndex = 10;
            this.labelMedicine.Text = "Medicine Name:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(397, 22);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of Birth:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(472, 19);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(71, 20);
            this.textBoxDateOfBirth.TabIndex = 8;
            this.textBoxDateOfBirth.Text = "01/01/2121";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(271, 19);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(120, 20);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.Text = "Roberts";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(78, 19);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 20);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.Text = "Julie";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(204, 22);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 22);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelEPrescriptions
            // 
            this.labelEPrescriptions.AutoSize = true;
            this.labelEPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEPrescriptions.Location = new System.Drawing.Point(12, 36);
            this.labelEPrescriptions.Name = "labelEPrescriptions";
            this.labelEPrescriptions.Size = new System.Drawing.Size(498, 36);
            this.labelEPrescriptions.TabIndex = 44;
            this.labelEPrescriptions.Text = "E-Prescriptions (Medicine and Labs)";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(512, 461);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(70, 35);
            this.buttonPrint.TabIndex = 49;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(513, 181);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(70, 35);
            this.buttonCreate.TabIndex = 48;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(12, 181);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(70, 35);
            this.buttonView.TabIndex = 47;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(12, 461);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(70, 35);
            this.buttonEdit.TabIndex = 51;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // listBoxEPrescriptions
            // 
            this.listBoxEPrescriptions.FormattingEnabled = true;
            this.listBoxEPrescriptions.Location = new System.Drawing.Point(12, 222);
            this.listBoxEPrescriptions.Name = "listBoxEPrescriptions";
            this.listBoxEPrescriptions.Size = new System.Drawing.Size(570, 225);
            this.listBoxEPrescriptions.TabIndex = 43;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientServicesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(594, 24);
            this.menuStrip.TabIndex = 52;
            this.menuStrip.Text = "menuStrip1";
            // 
            // patientServicesToolStripMenuItem
            // 
            this.patientServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForPatientToolStripMenuItem,
            this.updatePatientToolStripMenuItem,
            this.viewAppointmentsToolStripMenuItem,
            this.ePrescriptionToolStripMenuItem,
            this.viewPatientProfileToolStripMenuItem});
            this.patientServicesToolStripMenuItem.Name = "patientServicesToolStripMenuItem";
            this.patientServicesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.patientServicesToolStripMenuItem.Text = "Patient Services";
            // 
            // searchForPatientToolStripMenuItem
            // 
            this.searchForPatientToolStripMenuItem.Name = "searchForPatientToolStripMenuItem";
            this.searchForPatientToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.searchForPatientToolStripMenuItem.Text = "Emergency Alerts";
            // 
            // updatePatientToolStripMenuItem
            // 
            this.updatePatientToolStripMenuItem.Name = "updatePatientToolStripMenuItem";
            this.updatePatientToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.updatePatientToolStripMenuItem.Text = "Update Patient Healthcare";
            // 
            // viewAppointmentsToolStripMenuItem
            // 
            this.viewAppointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewApptToolStripMenuItem,
            this.scheduleApptToolStripMenuItem});
            this.viewAppointmentsToolStripMenuItem.Name = "viewAppointmentsToolStripMenuItem";
            this.viewAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.viewAppointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // viewApptToolStripMenuItem
            // 
            this.viewApptToolStripMenuItem.Name = "viewApptToolStripMenuItem";
            this.viewApptToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.viewApptToolStripMenuItem.Text = "View";
            // 
            // scheduleApptToolStripMenuItem
            // 
            this.scheduleApptToolStripMenuItem.Name = "scheduleApptToolStripMenuItem";
            this.scheduleApptToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scheduleApptToolStripMenuItem.Text = "Schedule";
            // 
            // ePrescriptionToolStripMenuItem
            // 
            this.ePrescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewEPrescribeToolStripMenuItem,
            this.viewExistingEPrescribeToolStripMenuItem,
            this.editExistingEPrescribeToolStripMenuItem,
            this.printExistingEPrescribeToolStripMenuItem});
            this.ePrescriptionToolStripMenuItem.Name = "ePrescriptionToolStripMenuItem";
            this.ePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.ePrescriptionToolStripMenuItem.Text = "E-Prescription (Medicine/Lab)";
            // 
            // createNewEPrescribeToolStripMenuItem
            // 
            this.createNewEPrescribeToolStripMenuItem.Name = "createNewEPrescribeToolStripMenuItem";
            this.createNewEPrescribeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createNewEPrescribeToolStripMenuItem.Text = "Create New";
            // 
            // viewExistingEPrescribeToolStripMenuItem
            // 
            this.viewExistingEPrescribeToolStripMenuItem.Name = "viewExistingEPrescribeToolStripMenuItem";
            this.viewExistingEPrescribeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewExistingEPrescribeToolStripMenuItem.Text = "View Existing";
            // 
            // editExistingEPrescribeToolStripMenuItem
            // 
            this.editExistingEPrescribeToolStripMenuItem.Name = "editExistingEPrescribeToolStripMenuItem";
            this.editExistingEPrescribeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editExistingEPrescribeToolStripMenuItem.Text = "Edit Existing";
            // 
            // printExistingEPrescribeToolStripMenuItem
            // 
            this.printExistingEPrescribeToolStripMenuItem.Name = "printExistingEPrescribeToolStripMenuItem";
            this.printExistingEPrescribeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.printExistingEPrescribeToolStripMenuItem.Text = "Print Existing";
            // 
            // viewPatientProfileToolStripMenuItem
            // 
            this.viewPatientProfileToolStripMenuItem.Name = "viewPatientProfileToolStripMenuItem";
            this.viewPatientProfileToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.viewPatientProfileToolStripMenuItem.Text = "View Patient Profile Information";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchRecordsToolStripMenuItem,
            this.editLabRequestToolStripMenuItem,
            this.editLabRecordToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.reportsToolStripMenuItem.Text = "Lab Records";
            // 
            // searchRecordsToolStripMenuItem
            // 
            this.searchRecordsToolStripMenuItem.Name = "searchRecordsToolStripMenuItem";
            this.searchRecordsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.searchRecordsToolStripMenuItem.Text = "Add Lab Record";
            // 
            // editLabRequestToolStripMenuItem
            // 
            this.editLabRequestToolStripMenuItem.Name = "editLabRequestToolStripMenuItem";
            this.editLabRequestToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editLabRequestToolStripMenuItem.Text = "View Lab Record";
            // 
            // editLabRecordToolStripMenuItem
            // 
            this.editLabRecordToolStripMenuItem.Name = "editLabRecordToolStripMenuItem";
            this.editLabRecordToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editLabRecordToolStripMenuItem.Text = "Edit Lab Record";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileInformationToolStripMenuItem,
            this.report2ToolStripMenuItem,
            this.analysisOfTypeOfPatientsToolStripMenuItem,
            this.analysisOfPatientPopulationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.toolsToolStripMenuItem.Text = "Reporting";
            // 
            // editProfileInformationToolStripMenuItem
            // 
            this.editProfileInformationToolStripMenuItem.Name = "editProfileInformationToolStripMenuItem";
            this.editProfileInformationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.editProfileInformationToolStripMenuItem.Text = "Analysis of health outcomes";
            // 
            // report2ToolStripMenuItem
            // 
            this.report2ToolStripMenuItem.Name = "report2ToolStripMenuItem";
            this.report2ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.report2ToolStripMenuItem.Text = "Tracking of the admission rates";
            // 
            // analysisOfTypeOfPatientsToolStripMenuItem
            // 
            this.analysisOfTypeOfPatientsToolStripMenuItem.Name = "analysisOfTypeOfPatientsToolStripMenuItem";
            this.analysisOfTypeOfPatientsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.analysisOfTypeOfPatientsToolStripMenuItem.Text = "Analysis of type of patients";
            // 
            // analysisOfPatientPopulationToolStripMenuItem
            // 
            this.analysisOfPatientPopulationToolStripMenuItem.Name = "analysisOfPatientPopulationToolStripMenuItem";
            this.analysisOfPatientPopulationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.analysisOfPatientPopulationToolStripMenuItem.Text = "Analysis of patient population";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.logoutToolStripMenuItem.Text = "Profile Tools";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutOfIPIMSToolStripMenuItem});
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem1.Text = "Logout";
            // 
            // logoutOfIPIMSToolStripMenuItem
            // 
            this.logoutOfIPIMSToolStripMenuItem.Name = "logoutOfIPIMSToolStripMenuItem";
            this.logoutOfIPIMSToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.logoutOfIPIMSToolStripMenuItem.Text = "Logout of IPIMS";
            // 
            // EPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.comboBoxDoctorSelection);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Controls.Add(this.labelEPrescriptions);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxEPrescriptions);
            this.Name = "EPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.groupBoxPatientInformation.ResumeLayout(false);
            this.groupBoxPatientInformation.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDoctorSelection;
        private System.Windows.Forms.GroupBox groupBoxPatientInformation;
        private System.Windows.Forms.TextBox textBoxLabDescription;
        private System.Windows.Forms.Label labelLabDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.TextBox textBoxMedicine;
        private System.Windows.Forms.Label labelMedicine;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEPrescriptions;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListBox listBoxEPrescriptions;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem patientServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewApptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleApptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ePrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEPrescribeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExistingEPrescribeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExistingEPrescribeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printExistingEPrescribeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLabRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLabRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisOfTypeOfPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisOfPatientPopulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutOfIPIMSToolStripMenuItem;
    }
}