namespace IPIMS_Group_9.Forms
{
    partial class ScheduleAppointment
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
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxSymptoms = new System.Windows.Forms.TextBox();
            this.labelSymptoms = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelScheduleAppointment = new System.Windows.Forms.Label();
            this.comboBoxDoctorSelection = new System.Windows.Forms.ComboBox();
            this.monthCalendarScheduling = new System.Windows.Forms.MonthCalendar();
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSuicide = new System.Windows.Forms.CheckBox();
            this.checkBoxWheezing = new System.Windows.Forms.CheckBox();
            this.checkBoxBloodUrine = new System.Windows.Forms.CheckBox();
            this.checkBoxTenderness = new System.Windows.Forms.CheckBox();
            this.checkBoxChestPains = new System.Windows.Forms.CheckBox();
            this.checkBoxWeakness = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(this.labelDateOfBirth);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxSymptoms);
            this.groupBoxPatientInformation.Controls.Add(this.labelSymptoms);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxLastName);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatientInformation.Controls.Add(this.labelLastName);
            this.groupBoxPatientInformation.Controls.Add(this.labelFirstName);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(12, 75);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(564, 150);
            this.groupBoxPatientInformation.TabIndex = 35;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(392, 22);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of Birth:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(467, 19);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(71, 20);
            this.textBoxDateOfBirth.TabIndex = 8;
            this.textBoxDateOfBirth.TextChanged += new System.EventHandler(this.textBoxDateOfBirth_TextClicked);
            // 
            // textBoxSymptoms
            // 
            this.textBoxSymptoms.Location = new System.Drawing.Point(73, 45);
            this.textBoxSymptoms.Multiline = true;
            this.textBoxSymptoms.Name = "textBoxSymptoms";
            this.textBoxSymptoms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSymptoms.Size = new System.Drawing.Size(465, 97);
            this.textBoxSymptoms.TabIndex = 7;
            this.textBoxSymptoms.TextChanged += new System.EventHandler(this.textBoxSymptoms_TextClicked);
            // 
            // labelSymptoms
            // 
            this.labelSymptoms.AutoSize = true;
            this.labelSymptoms.Location = new System.Drawing.Point(9, 48);
            this.labelSymptoms.Name = "labelSymptoms";
            this.labelSymptoms.Size = new System.Drawing.Size(58, 13);
            this.labelSymptoms.TabIndex = 6;
            this.labelSymptoms.Text = "Symptoms:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(266, 19);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(120, 20);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextClicked);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(73, 19);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 20);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextClicked);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(199, 22);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 22);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelScheduleAppointment
            // 
            this.labelScheduleAppointment.AutoSize = true;
            this.labelScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheduleAppointment.Location = new System.Drawing.Point(12, 36);
            this.labelScheduleAppointment.Name = "labelScheduleAppointment";
            this.labelScheduleAppointment.Size = new System.Drawing.Size(316, 36);
            this.labelScheduleAppointment.TabIndex = 34;
            this.labelScheduleAppointment.Text = "Schedule Appointment";
            // 
            // comboBoxDoctorSelection
            // 
            this.comboBoxDoctorSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDoctorSelection.FormattingEnabled = true;
            this.comboBoxDoctorSelection.Items.AddRange(new object[] {
            "Dr. Thomas Smith",
            "Dr. Susan Enriquez",
            "Dr. Linda Chattin"});
            this.comboBoxDoctorSelection.Location = new System.Drawing.Point(273, 25);
            this.comboBoxDoctorSelection.Name = "comboBoxDoctorSelection";
            this.comboBoxDoctorSelection.Size = new System.Drawing.Size(284, 26);
            this.comboBoxDoctorSelection.TabIndex = 2;
            this.comboBoxDoctorSelection.Text = "Select the Doctor for the Appointment";
            // 
            // monthCalendarScheduling
            // 
            this.monthCalendarScheduling.Location = new System.Drawing.Point(5, 25);
            this.monthCalendarScheduling.Name = "monthCalendarScheduling";
            this.monthCalendarScheduling.TabIndex = 0;
            // 
            // buttonScheduleAppointment
            // 
            this.buttonScheduleAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleAppointment.Location = new System.Drawing.Point(376, 461);
            this.buttonScheduleAppointment.Name = "buttonScheduleAppointment";
            this.buttonScheduleAppointment.Size = new System.Drawing.Size(206, 35);
            this.buttonScheduleAppointment.TabIndex = 37;
            this.buttonScheduleAppointment.Text = "Schedule Appointment";
            this.buttonScheduleAppointment.UseVisualStyleBackColor = true;
            this.buttonScheduleAppointment.Click += new System.EventHandler(this.buttonScheduleAppointment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBoxDoctorSelection);
            this.groupBox1.Controls.Add(this.monthCalendarScheduling);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 224);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar and Doctor Selection for Appointment Scheduling:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSuicide);
            this.groupBox2.Controls.Add(this.checkBoxWheezing);
            this.groupBox2.Controls.Add(this.checkBoxBloodUrine);
            this.groupBox2.Controls.Add(this.checkBoxTenderness);
            this.groupBox2.Controls.Add(this.checkBoxChestPains);
            this.groupBox2.Controls.Add(this.checkBoxWeakness);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(262, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 156);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Is the Patient experiencing any of the following?";
            // 
            // checkBoxSuicide
            // 
            this.checkBoxSuicide.AutoSize = true;
            this.checkBoxSuicide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSuicide.Location = new System.Drawing.Point(6, 133);
            this.checkBoxSuicide.Name = "checkBoxSuicide";
            this.checkBoxSuicide.Size = new System.Drawing.Size(107, 17);
            this.checkBoxSuicide.TabIndex = 40;
            this.checkBoxSuicide.Text = "Suicidal thoughts";
            this.checkBoxSuicide.UseVisualStyleBackColor = true;
            // 
            // checkBoxWheezing
            // 
            this.checkBoxWheezing.AutoSize = true;
            this.checkBoxWheezing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWheezing.Location = new System.Drawing.Point(6, 110);
            this.checkBoxWheezing.Name = "checkBoxWheezing";
            this.checkBoxWheezing.Size = new System.Drawing.Size(148, 17);
            this.checkBoxWheezing.TabIndex = 39;
            this.checkBoxWheezing.Text = "Wheezing while breathing";
            this.checkBoxWheezing.UseVisualStyleBackColor = true;
            // 
            // checkBoxBloodUrine
            // 
            this.checkBoxBloodUrine.AutoSize = true;
            this.checkBoxBloodUrine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBloodUrine.Location = new System.Drawing.Point(6, 87);
            this.checkBoxBloodUrine.Name = "checkBoxBloodUrine";
            this.checkBoxBloodUrine.Size = new System.Drawing.Size(150, 17);
            this.checkBoxBloodUrine.TabIndex = 38;
            this.checkBoxBloodUrine.Text = "Blood in the patient\'s urine";
            this.checkBoxBloodUrine.UseVisualStyleBackColor = true;
            // 
            // checkBoxTenderness
            // 
            this.checkBoxTenderness.AutoSize = true;
            this.checkBoxTenderness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTenderness.Location = new System.Drawing.Point(6, 64);
            this.checkBoxTenderness.Name = "checkBoxTenderness";
            this.checkBoxTenderness.Size = new System.Drawing.Size(229, 17);
            this.checkBoxTenderness.TabIndex = 37;
            this.checkBoxTenderness.Text = "Tenderness and pain in the back of the leg";
            this.checkBoxTenderness.UseVisualStyleBackColor = true;
            // 
            // checkBoxChestPains
            // 
            this.checkBoxChestPains.AutoSize = true;
            this.checkBoxChestPains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChestPains.Location = new System.Drawing.Point(6, 41);
            this.checkBoxChestPains.Name = "checkBoxChestPains";
            this.checkBoxChestPains.Size = new System.Drawing.Size(81, 17);
            this.checkBoxChestPains.TabIndex = 36;
            this.checkBoxChestPains.Text = "Chest pains";
            this.checkBoxChestPains.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeakness
            // 
            this.checkBoxWeakness.AutoSize = true;
            this.checkBoxWeakness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWeakness.Location = new System.Drawing.Point(6, 18);
            this.checkBoxWeakness.Name = "checkBoxWeakness";
            this.checkBoxWeakness.Size = new System.Drawing.Size(170, 17);
            this.checkBoxWeakness.TabIndex = 35;
            this.checkBoxWeakness.Text = "Weakness in arms and/or legs";
            this.checkBoxWeakness.UseVisualStyleBackColor = true;
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
            this.menuStrip.TabIndex = 38;
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
            // ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Controls.Add(this.labelScheduleAppointment);
            this.Controls.Add(this.buttonScheduleAppointment);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.groupBoxPatientInformation.ResumeLayout(false);
            this.groupBoxPatientInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatientInformation;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxSymptoms;
        private System.Windows.Forms.Label labelSymptoms;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelScheduleAppointment;
        private System.Windows.Forms.ComboBox comboBoxDoctorSelection;
        private System.Windows.Forms.MonthCalendar monthCalendarScheduling;
        private System.Windows.Forms.Button buttonScheduleAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSuicide;
        private System.Windows.Forms.CheckBox checkBoxWheezing;
        private System.Windows.Forms.CheckBox checkBoxBloodUrine;
        private System.Windows.Forms.CheckBox checkBoxTenderness;
        private System.Windows.Forms.CheckBox checkBoxChestPains;
        private System.Windows.Forms.CheckBox checkBoxWeakness;
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