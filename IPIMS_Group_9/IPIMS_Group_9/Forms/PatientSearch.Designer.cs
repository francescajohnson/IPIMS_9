namespace IPIMS_Group_9.Forms
{
    partial class PatientSearch
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
            this.labelPatientSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
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
            // labelPatientSearch
            // 
            this.labelPatientSearch.AutoSize = true;
            this.labelPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientSearch.Location = new System.Drawing.Point(12, 43);
            this.labelPatientSearch.Name = "labelPatientSearch";
            this.labelPatientSearch.Size = new System.Drawing.Size(252, 36);
            this.labelPatientSearch.TabIndex = 33;
            this.labelPatientSearch.Text = "Search for Patient";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(442, 461);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 35);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "Initiate Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(this.labelDateOfBirth);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxLastName);
            this.groupBoxPatientInformation.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatientInformation.Controls.Add(this.labelLastName);
            this.groupBoxPatientInformation.Controls.Add(this.labelFirstName);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(12, 82);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(564, 78);
            this.groupBoxPatientInformation.TabIndex = 34;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(132, 46);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of Birth:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(207, 43);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(71, 20);
            this.textBoxDateOfBirth.TabIndex = 8;
            this.textBoxDateOfBirth.Text = "01/01/2121";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(351, 17);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(205, 20);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.Text = "Roberts";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(73, 17);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(205, 20);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.Text = "Julie";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(284, 20);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 20);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
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
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelPatientSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Name = "PatientSearch";
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

        private System.Windows.Forms.Label labelPatientSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPatientInformation;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
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