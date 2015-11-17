namespace IPIMS_Group_9.Forms
{
    partial class UpdateHealthcareCondition
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label has_Blood_in_UrineLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            this.groupBoxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUpdateHealthcareConditions = new System.Windows.Forms.Label();
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
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.updatehealthcaredataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.update_healthcare_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.update_healthcare_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.is_SuicidalCheckBox = new System.Windows.Forms.CheckBox();
            this.is_WheezingCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Blood_in_UrineCheckBox = new System.Windows.Forms.CheckBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.has_Leg_PainCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Chest_PainsCheckBox = new System.Windows.Forms.CheckBox();
            this.has_WeaknessCheckBox = new System.Windows.Forms.CheckBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            has_Blood_in_UrineLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            this.groupBoxPersonalInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatehealthcaredataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersonalInformation
            // 
            this.groupBoxPersonalInformation.Controls.Add(date_of_BirthLabel);
            this.groupBoxPersonalInformation.Controls.Add(this.date_of_BirthDateTimePicker);
            this.groupBoxPersonalInformation.Controls.Add(last_NameLabel);
            this.groupBoxPersonalInformation.Controls.Add(this.last_NameTextBox);
            this.groupBoxPersonalInformation.Controls.Add(first_NameLabel);
            this.groupBoxPersonalInformation.Controls.Add(this.first_NameTextBox);
            this.groupBoxPersonalInformation.Controls.Add(symptomsLabel);
            this.groupBoxPersonalInformation.Controls.Add(this.symptomsTextBox);
            this.groupBoxPersonalInformation.Location = new System.Drawing.Point(13, 77);
            this.groupBoxPersonalInformation.Name = "groupBoxPersonalInformation";
            this.groupBoxPersonalInformation.Size = new System.Drawing.Size(571, 167);
            this.groupBoxPersonalInformation.TabIndex = 41;
            this.groupBoxPersonalInformation.TabStop = false;
            this.groupBoxPersonalInformation.Text = "Personal Information:";
            this.groupBoxPersonalInformation.Enter += new System.EventHandler(this.groupBoxPersonalInformation_Enter);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 195);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is the Patient experiencing any of the following?";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(463, 262);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 35);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(463, 459);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 35);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelUpdateHealthcareConditions
            // 
            this.labelUpdateHealthcareConditions.AutoSize = true;
            this.labelUpdateHealthcareConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateHealthcareConditions.Location = new System.Drawing.Point(12, 38);
            this.labelUpdateHealthcareConditions.Name = "labelUpdateHealthcareConditions";
            this.labelUpdateHealthcareConditions.Size = new System.Drawing.Size(412, 36);
            this.labelUpdateHealthcareConditions.TabIndex = 35;
            this.labelUpdateHealthcareConditions.Text = "Update Healthcare Conditions";
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
            this.menuStrip.TabIndex = 42;
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
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updatehealthcaredataBindingSource
            // 
            this.updatehealthcaredataBindingSource.DataMember = "update_healthcare_data";
            this.updatehealthcaredataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // update_healthcare_dataTableAdapter
            // 
            this.update_healthcare_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.e_prescription_dataTableAdapter = null;
            this.tableAdapterManager.patient_dataTableAdapter = null;
            this.tableAdapterManager.scheduled_appointment_dataTableAdapter = null;
            this.tableAdapterManager.update_healthcare_dataTableAdapter = this.update_healthcare_dataTableAdapter;
            this.tableAdapterManager.UpdateOrder = IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_dataTableAdapter = null;
            // 
            // is_SuicidalCheckBox
            // 
            this.is_SuicidalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.updatehealthcaredataBindingSource, "Is_Suicidal", true));
            this.is_SuicidalCheckBox.Location = new System.Drawing.Point(44, 38);
            this.is_SuicidalCheckBox.Name = "is_SuicidalCheckBox";
            this.is_SuicidalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_SuicidalCheckBox.TabIndex = 62;
            this.is_SuicidalCheckBox.Text = "Suicidal";
            this.is_SuicidalCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_WheezingCheckBox
            // 
            this.is_WheezingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.updatehealthcaredataBindingSource, "Is_Wheezing", true));
            this.is_WheezingCheckBox.Location = new System.Drawing.Point(44, 87);
            this.is_WheezingCheckBox.Name = "is_WheezingCheckBox";
            this.is_WheezingCheckBox.Size = new System.Drawing.Size(108, 24);
            this.is_WheezingCheckBox.TabIndex = 63;
            this.is_WheezingCheckBox.Text = "Wheezing";
            this.is_WheezingCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Blood_in_UrineLabel
            // 
            has_Blood_in_UrineLabel.AutoSize = true;
            has_Blood_in_UrineLabel.Location = new System.Drawing.Point(240, 55);
            has_Blood_in_UrineLabel.Name = "has_Blood_in_UrineLabel";
            has_Blood_in_UrineLabel.Size = new System.Drawing.Size(0, 20);
            has_Blood_in_UrineLabel.TabIndex = 63;
            // 
            // has_Blood_in_UrineCheckBox
            // 
            this.has_Blood_in_UrineCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.updatehealthcaredataBindingSource, "Has_Blood_in_Urine", true));
            this.has_Blood_in_UrineCheckBox.Location = new System.Drawing.Point(44, 142);
            this.has_Blood_in_UrineCheckBox.Name = "has_Blood_in_UrineCheckBox";
            this.has_Blood_in_UrineCheckBox.Size = new System.Drawing.Size(174, 24);
            this.has_Blood_in_UrineCheckBox.TabIndex = 64;
            this.has_Blood_in_UrineCheckBox.Text = "Urinary Concerns";
            this.has_Blood_in_UrineCheckBox.UseVisualStyleBackColor = true;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(11, 95);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(58, 13);
            symptomsLabel.TabIndex = 12;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.updatehealthcaredataBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(74, 95);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(100, 20);
            this.symptomsTextBox.TabIndex = 13;
            this.symptomsTextBox.TextChanged += new System.EventHandler(this.symptomsTextBox_TextChanged);
            // 
            // has_Leg_PainCheckBox
            // 
            this.has_Leg_PainCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.updatehealthcaredataBindingSource, "Has_Weakness", true));
            this.has_Leg_PainCheckBox.Location = new System.Drawing.Point(244, 38);
            this.has_Leg_PainCheckBox.Name = "has_Leg_PainCheckBox";
            this.has_Leg_PainCheckBox.Size = new System.Drawing.Size(104, 24);
            this.has_Leg_PainCheckBox.TabIndex = 65;
            this.has_Leg_PainCheckBox.Text = "Leg Pain";
            this.has_Leg_PainCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Chest_PainsCheckBox
            // 
            this.has_Chest_PainsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.updatehealthcaredataBindingSource, "Has_Chest_Pains", true));
            this.has_Chest_PainsCheckBox.Location = new System.Drawing.Point(244, 87);
            this.has_Chest_PainsCheckBox.Name = "has_Chest_PainsCheckBox";
            this.has_Chest_PainsCheckBox.Size = new System.Drawing.Size(151, 24);
            this.has_Chest_PainsCheckBox.TabIndex = 66;
            this.has_Chest_PainsCheckBox.Text = "Chest Pain";
            this.has_Chest_PainsCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_WeaknessCheckBox
            // 
            this.has_WeaknessCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.updatehealthcaredataBindingSource, "Has_Weakness", true));
            this.has_WeaknessCheckBox.Location = new System.Drawing.Point(244, 142);
            this.has_WeaknessCheckBox.Name = "has_WeaknessCheckBox";
            this.has_WeaknessCheckBox.Size = new System.Drawing.Size(118, 24);
            this.has_WeaknessCheckBox.TabIndex = 67;
            this.has_WeaknessCheckBox.Text = "Weakness";
            this.has_WeaknessCheckBox.UseVisualStyleBackColor = true;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(9, 42);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 13;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.updatehealthcaredataBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(74, 39);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 14;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(189, 42);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 14;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.updatehealthcaredataBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(256, 39);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 15;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(382, 42);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 15;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.updatehealthcaredataBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(457, 39);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 16;
            // 
            // UpdateHealthcareCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxPersonalInformation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelUpdateHealthcareConditions);
            this.Name = "UpdateHealthcareCondition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.UpdateHealthcareCondition_Load);
            this.groupBoxPersonalInformation.ResumeLayout(false);
            this.groupBoxPersonalInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatehealthcaredataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonalInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelUpdateHealthcareConditions;
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
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource updatehealthcaredataBindingSource;
        private IPIMS_9DataSetTableAdapters.update_healthcare_dataTableAdapter update_healthcare_dataTableAdapter;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.CheckBox has_WeaknessCheckBox;
        private System.Windows.Forms.CheckBox has_Chest_PainsCheckBox;
        private System.Windows.Forms.CheckBox has_Leg_PainCheckBox;
        private System.Windows.Forms.CheckBox has_Blood_in_UrineCheckBox;
        private System.Windows.Forms.CheckBox is_WheezingCheckBox;
        private System.Windows.Forms.CheckBox is_SuicidalCheckBox;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
    }
}