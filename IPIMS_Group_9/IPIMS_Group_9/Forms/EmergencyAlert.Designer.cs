namespace IPIMS_Group_9.Forms
{
    partial class EmergencyAlert
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
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label has_Blood_in_UrineLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEmergencyAlert = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
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
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.has_WeaknessCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Chest_PainsCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Leg_PainCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Blood_in_UrineCheckBox = new System.Windows.Forms.CheckBox();
            this.is_WheezingCheckBox = new System.Windows.Forms.CheckBox();
            this.is_SuicidalCheckBox = new System.Windows.Forms.CheckBox();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            has_Blood_in_UrineLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.has_WeaknessCheckBox);
            this.groupBox1.Controls.Add(this.has_Chest_PainsCheckBox);
            this.groupBox1.Controls.Add(this.has_Leg_PainCheckBox);
            this.groupBox1.Controls.Add(has_Blood_in_UrineLabel);
            this.groupBox1.Controls.Add(this.has_Blood_in_UrineCheckBox);
            this.groupBox1.Controls.Add(this.is_WheezingCheckBox);
            this.groupBox1.Controls.Add(this.is_SuicidalCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 232);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emergency Alert Conditions Include:";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(463, 461);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 35);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEmergencyAlert
            // 
            this.labelEmergencyAlert.AutoSize = true;
            this.labelEmergencyAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmergencyAlert.Location = new System.Drawing.Point(12, 44);
            this.labelEmergencyAlert.Name = "labelEmergencyAlert";
            this.labelEmergencyAlert.Size = new System.Drawing.Size(408, 36);
            this.labelEmergencyAlert.TabIndex = 46;
            this.labelEmergencyAlert.Text = "Send Doctor Emergency Alert";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(463, 264);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 35);
            this.buttonClear.TabIndex = 50;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
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
            this.menuStrip.TabIndex = 53;
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
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(391, 103);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 59;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(466, 100);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 61;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(198, 103);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 57;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.Location = new System.Drawing.Point(265, 100);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 60;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(18, 103);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 55;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Location = new System.Drawing.Point(83, 100);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 58;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(20, 156);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(58, 13);
            symptomsLabel.TabIndex = 54;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(83, 156);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(463, 87);
            this.symptomsTextBox.TabIndex = 56;
            // 
            // has_WeaknessCheckBox
            // 
            this.has_WeaknessCheckBox.Location = new System.Drawing.Point(37, 158);
            this.has_WeaknessCheckBox.Name = "has_WeaknessCheckBox";
            this.has_WeaknessCheckBox.Size = new System.Drawing.Size(146, 35);
            this.has_WeaknessCheckBox.TabIndex = 74;
            this.has_WeaknessCheckBox.Text = "Weakness";
            this.has_WeaknessCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Chest_PainsCheckBox
            // 
            this.has_Chest_PainsCheckBox.Location = new System.Drawing.Point(189, 101);
            this.has_Chest_PainsCheckBox.Name = "has_Chest_PainsCheckBox";
            this.has_Chest_PainsCheckBox.Size = new System.Drawing.Size(149, 38);
            this.has_Chest_PainsCheckBox.TabIndex = 73;
            this.has_Chest_PainsCheckBox.Text = "Chest Pain";
            this.has_Chest_PainsCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Leg_PainCheckBox
            // 
            this.has_Leg_PainCheckBox.Location = new System.Drawing.Point(189, 52);
            this.has_Leg_PainCheckBox.Name = "has_Leg_PainCheckBox";
            this.has_Leg_PainCheckBox.Size = new System.Drawing.Size(102, 34);
            this.has_Leg_PainCheckBox.TabIndex = 72;
            this.has_Leg_PainCheckBox.Text = "Leg Pain";
            this.has_Leg_PainCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Blood_in_UrineLabel
            // 
            has_Blood_in_UrineLabel.AutoSize = true;
            has_Blood_in_UrineLabel.Location = new System.Drawing.Point(233, 69);
            has_Blood_in_UrineLabel.Name = "has_Blood_in_UrineLabel";
            has_Blood_in_UrineLabel.Size = new System.Drawing.Size(0, 26);
            has_Blood_in_UrineLabel.TabIndex = 69;
            // 
            // has_Blood_in_UrineCheckBox
            // 
            this.has_Blood_in_UrineCheckBox.Location = new System.Drawing.Point(189, 156);
            this.has_Blood_in_UrineCheckBox.Name = "has_Blood_in_UrineCheckBox";
            this.has_Blood_in_UrineCheckBox.Size = new System.Drawing.Size(275, 37);
            this.has_Blood_in_UrineCheckBox.TabIndex = 71;
            this.has_Blood_in_UrineCheckBox.Text = "Urinary Concerns";
            this.has_Blood_in_UrineCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_WheezingCheckBox
            // 
            this.is_WheezingCheckBox.Location = new System.Drawing.Point(37, 101);
            this.is_WheezingCheckBox.Name = "is_WheezingCheckBox";
            this.is_WheezingCheckBox.Size = new System.Drawing.Size(150, 34);
            this.is_WheezingCheckBox.TabIndex = 70;
            this.is_WheezingCheckBox.Text = "Wheezing";
            this.is_WheezingCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_SuicidalCheckBox
            // 
            this.is_SuicidalCheckBox.Location = new System.Drawing.Point(37, 52);
            this.is_SuicidalCheckBox.Name = "is_SuicidalCheckBox";
            this.is_SuicidalCheckBox.Size = new System.Drawing.Size(134, 34);
            this.is_SuicidalCheckBox.TabIndex = 68;
            this.is_SuicidalCheckBox.Text = "Suicidal";
            this.is_SuicidalCheckBox.UseVisualStyleBackColor = true;
            this.is_SuicidalCheckBox.CheckedChanged += new System.EventHandler(this.is_SuicidalCheckBox_CheckedChanged);
            // 
            // EmergencyAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEmergencyAlert);
            this.Controls.Add(this.buttonClear);
            this.Name = "EmergencyAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.EmergencyAlert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEmergencyAlert;
        private System.Windows.Forms.Button buttonClear;
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
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.CheckBox has_WeaknessCheckBox;
        private System.Windows.Forms.CheckBox has_Chest_PainsCheckBox;
        private System.Windows.Forms.CheckBox has_Leg_PainCheckBox;
        private System.Windows.Forms.CheckBox has_Blood_in_UrineCheckBox;
        private System.Windows.Forms.CheckBox is_WheezingCheckBox;
        private System.Windows.Forms.CheckBox is_SuicidalCheckBox;
    }
}