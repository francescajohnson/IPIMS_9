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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label has_WeaknessLabel;
            System.Windows.Forms.Label has_Chest_PainsLabel;
            System.Windows.Forms.Label has_Leg_PainLabel;
            System.Windows.Forms.Label has_Blood_in_UrineLabel;
            System.Windows.Forms.Label is_WheezingLabel;
            System.Windows.Forms.Label is_SuicidalLabel;
            System.Windows.Forms.Label appointment_DateLabel;
            System.Windows.Forms.Label appointment_TimeLabel;
            System.Windows.Forms.Label patient_IdLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleAppointment));
            System.Windows.Forms.Label doctor_NameLabel;
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patient_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.patient_IdTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.scheduled_appointment_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.labelScheduleAppointment = new System.Windows.Forms.Label();
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appointment_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.is_SuicidalCheckBox = new System.Windows.Forms.CheckBox();
            this.is_WheezingCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Blood_in_UrineCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Leg_PainCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Chest_PainsCheckBox = new System.Windows.Forms.CheckBox();
            this.has_WeaknessCheckBox = new System.Windows.Forms.CheckBox();
            this.scheduled_appointment_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.scheduled_appointment_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduled_appointment_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patient_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.patient_dataTableAdapter();
            this.scheduled_appointment_dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctor_NameTextBox = new System.Windows.Forms.TextBox();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            has_WeaknessLabel = new System.Windows.Forms.Label();
            has_Chest_PainsLabel = new System.Windows.Forms.Label();
            has_Leg_PainLabel = new System.Windows.Forms.Label();
            has_Blood_in_UrineLabel = new System.Windows.Forms.Label();
            is_WheezingLabel = new System.Windows.Forms.Label();
            is_SuicidalLabel = new System.Windows.Forms.Label();
            appointment_DateLabel = new System.Windows.Forms.Label();
            appointment_TimeLabel = new System.Windows.Forms.Label();
            patient_IdLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            doctor_NameLabel = new System.Windows.Forms.Label();
            this.groupBoxPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingNavigator)).BeginInit();
            this.scheduled_appointment_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(16, 25);
            first_NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 0;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(219, 25);
            last_NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 2;
            last_NameLabel.Text = "Last Name:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(16, 51);
            symptomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(58, 13);
            symptomsLabel.TabIndex = 4;
            symptomsLabel.Text = "Symptoms:";
            // 
            // has_WeaknessLabel
            // 
            has_WeaknessLabel.AutoSize = true;
            has_WeaknessLabel.Location = new System.Drawing.Point(14, 19);
            has_WeaknessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            has_WeaknessLabel.Name = "has_WeaknessLabel";
            has_WeaknessLabel.Size = new System.Drawing.Size(96, 13);
            has_WeaknessLabel.TabIndex = 0;
            has_WeaknessLabel.Text = "Has Weakness:";
            // 
            // has_Chest_PainsLabel
            // 
            has_Chest_PainsLabel.AutoSize = true;
            has_Chest_PainsLabel.Location = new System.Drawing.Point(14, 41);
            has_Chest_PainsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            has_Chest_PainsLabel.Name = "has_Chest_PainsLabel";
            has_Chest_PainsLabel.Size = new System.Drawing.Size(104, 13);
            has_Chest_PainsLabel.TabIndex = 2;
            has_Chest_PainsLabel.Text = "Has Chest Pains:";
            // 
            // has_Leg_PainLabel
            // 
            has_Leg_PainLabel.AutoSize = true;
            has_Leg_PainLabel.Location = new System.Drawing.Point(14, 64);
            has_Leg_PainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            has_Leg_PainLabel.Name = "has_Leg_PainLabel";
            has_Leg_PainLabel.Size = new System.Drawing.Size(87, 13);
            has_Leg_PainLabel.TabIndex = 4;
            has_Leg_PainLabel.Text = "Has Leg Pain:";
            // 
            // has_Blood_in_UrineLabel
            // 
            has_Blood_in_UrineLabel.AutoSize = true;
            has_Blood_in_UrineLabel.Location = new System.Drawing.Point(14, 89);
            has_Blood_in_UrineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            has_Blood_in_UrineLabel.Name = "has_Blood_in_UrineLabel";
            has_Blood_in_UrineLabel.Size = new System.Drawing.Size(117, 13);
            has_Blood_in_UrineLabel.TabIndex = 6;
            has_Blood_in_UrineLabel.Text = "Has Blood in Urine:";
            // 
            // is_WheezingLabel
            // 
            is_WheezingLabel.AutoSize = true;
            is_WheezingLabel.Location = new System.Drawing.Point(14, 110);
            is_WheezingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            is_WheezingLabel.Name = "is_WheezingLabel";
            is_WheezingLabel.Size = new System.Drawing.Size(81, 13);
            is_WheezingLabel.TabIndex = 8;
            is_WheezingLabel.Text = "Is Wheezing:";
            // 
            // is_SuicidalLabel
            // 
            is_SuicidalLabel.AutoSize = true;
            is_SuicidalLabel.Location = new System.Drawing.Point(14, 136);
            is_SuicidalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            is_SuicidalLabel.Name = "is_SuicidalLabel";
            is_SuicidalLabel.Size = new System.Drawing.Size(70, 13);
            is_SuicidalLabel.TabIndex = 10;
            is_SuicidalLabel.Text = "Is Suicidal:";
            // 
            // appointment_DateLabel
            // 
            appointment_DateLabel.AutoSize = true;
            appointment_DateLabel.Location = new System.Drawing.Point(5, 76);
            appointment_DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appointment_DateLabel.Name = "appointment_DateLabel";
            appointment_DateLabel.Size = new System.Drawing.Size(95, 13);
            appointment_DateLabel.TabIndex = 39;
            appointment_DateLabel.Text = "Appointment Date:";
            // 
            // appointment_TimeLabel
            // 
            appointment_TimeLabel.AutoSize = true;
            appointment_TimeLabel.Location = new System.Drawing.Point(5, 114);
            appointment_TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appointment_TimeLabel.Name = "appointment_TimeLabel";
            appointment_TimeLabel.Size = new System.Drawing.Size(95, 13);
            appointment_TimeLabel.TabIndex = 40;
            appointment_TimeLabel.Text = "Appointment Time:";
            // 
            // patient_IdLabel
            // 
            patient_IdLabel.AutoSize = true;
            patient_IdLabel.Location = new System.Drawing.Point(423, 25);
            patient_IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            patient_IdLabel.Name = "patient_IdLabel";
            patient_IdLabel.Size = new System.Drawing.Size(55, 13);
            patient_IdLabel.TabIndex = 6;
            patient_IdLabel.Text = "Patient Id:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(7, 121);
            date_of_BirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 8;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(date_of_BirthLabel);
            this.groupBoxPatientInformation.Controls.Add(this.date_of_BirthDateTimePicker);
            this.groupBoxPatientInformation.Controls.Add(patient_IdLabel);
            this.groupBoxPatientInformation.Controls.Add(this.patient_IdTextBox);
            this.groupBoxPatientInformation.Controls.Add(symptomsLabel);
            this.groupBoxPatientInformation.Controls.Add(this.symptomsTextBox);
            this.groupBoxPatientInformation.Controls.Add(last_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.last_NameTextBox);
            this.groupBoxPatientInformation.Controls.Add(first_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.first_NameTextBox);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(12, 75);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(598, 150);
            this.groupBoxPatientInformation.TabIndex = 35;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information:";
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patient_dataBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(78, 115);
            this.date_of_BirthDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 9;
            // 
            // patient_dataBindingSource
            // 
            this.patient_dataBindingSource.DataMember = "patient_data";
            this.patient_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_IdTextBox
            // 
            this.patient_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_dataBindingSource, "Patient_Id", true));
            this.patient_IdTextBox.Location = new System.Drawing.Point(481, 21);
            this.patient_IdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patient_IdTextBox.Name = "patient_IdTextBox";
            this.patient_IdTextBox.Size = new System.Drawing.Size(76, 20);
            this.patient_IdTextBox.TabIndex = 7;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(78, 48);
            this.symptomsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(479, 62);
            this.symptomsTextBox.TabIndex = 5;
            this.symptomsTextBox.TextChanged += new System.EventHandler(this.symptomsTextBox_TextChanged);
            // 
            // scheduled_appointment_dataBindingSource
            // 
            this.scheduled_appointment_dataBindingSource.DataMember = "scheduled_appointment_data";
            this.scheduled_appointment_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(283, 21);
            this.last_NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(76, 20);
            this.last_NameTextBox.TabIndex = 3;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(80, 21);
            this.first_NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(76, 20);
            this.first_NameTextBox.TabIndex = 1;
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
            this.groupBox1.Controls.Add(doctor_NameLabel);
            this.groupBox1.Controls.Add(this.doctor_NameTextBox);
            this.groupBox1.Controls.Add(appointment_TimeLabel);
            this.groupBox1.Controls.Add(this.appointment_TimeDateTimePicker);
            this.groupBox1.Controls.Add(appointment_DateLabel);
            this.groupBox1.Controls.Add(this.appointment_DateDateTimePicker);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 252);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar and Doctor Selection for Appointment Scheduling:";
            // 
            // appointment_TimeDateTimePicker
            // 
            this.appointment_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduled_appointment_dataBindingSource, "Appointment_Time", true));
            this.appointment_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointment_TimeDateTimePicker.Location = new System.Drawing.Point(104, 108);
            this.appointment_TimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointment_TimeDateTimePicker.Name = "appointment_TimeDateTimePicker";
            this.appointment_TimeDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.appointment_TimeDateTimePicker.TabIndex = 41;
            // 
            // appointment_DateDateTimePicker
            // 
            this.appointment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduled_appointment_dataBindingSource, "Appointment_Date", true));
            this.appointment_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointment_DateDateTimePicker.Location = new System.Drawing.Point(104, 73);
            this.appointment_DateDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointment_DateDateTimePicker.Name = "appointment_DateDateTimePicker";
            this.appointment_DateDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.appointment_DateDateTimePicker.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(is_SuicidalLabel);
            this.groupBox2.Controls.Add(this.is_SuicidalCheckBox);
            this.groupBox2.Controls.Add(is_WheezingLabel);
            this.groupBox2.Controls.Add(this.is_WheezingCheckBox);
            this.groupBox2.Controls.Add(has_Blood_in_UrineLabel);
            this.groupBox2.Controls.Add(this.has_Blood_in_UrineCheckBox);
            this.groupBox2.Controls.Add(has_Leg_PainLabel);
            this.groupBox2.Controls.Add(this.has_Leg_PainCheckBox);
            this.groupBox2.Controls.Add(has_Chest_PainsLabel);
            this.groupBox2.Controls.Add(this.has_Chest_PainsCheckBox);
            this.groupBox2.Controls.Add(has_WeaknessLabel);
            this.groupBox2.Controls.Add(this.has_WeaknessCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(262, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 170);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Is the Patient experiencing any of the following?";
            // 
            // is_SuicidalCheckBox
            // 
            this.is_SuicidalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Is_Suicidal", true));
            this.is_SuicidalCheckBox.Location = new System.Drawing.Point(89, 132);
            this.is_SuicidalCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.is_SuicidalCheckBox.Name = "is_SuicidalCheckBox";
            this.is_SuicidalCheckBox.Size = new System.Drawing.Size(78, 20);
            this.is_SuicidalCheckBox.TabIndex = 11;
            this.is_SuicidalCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_WheezingCheckBox
            // 
            this.is_WheezingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Is_Wheezing", true));
            this.is_WheezingCheckBox.Location = new System.Drawing.Point(97, 106);
            this.is_WheezingCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.is_WheezingCheckBox.Name = "is_WheezingCheckBox";
            this.is_WheezingCheckBox.Size = new System.Drawing.Size(78, 20);
            this.is_WheezingCheckBox.TabIndex = 9;
            this.is_WheezingCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Blood_in_UrineCheckBox
            // 
            this.has_Blood_in_UrineCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Blood_in_Urine", true));
            this.has_Blood_in_UrineCheckBox.Location = new System.Drawing.Point(130, 84);
            this.has_Blood_in_UrineCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.has_Blood_in_UrineCheckBox.Name = "has_Blood_in_UrineCheckBox";
            this.has_Blood_in_UrineCheckBox.Size = new System.Drawing.Size(78, 20);
            this.has_Blood_in_UrineCheckBox.TabIndex = 7;
            this.has_Blood_in_UrineCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Leg_PainCheckBox
            // 
            this.has_Leg_PainCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Leg_Pain", true));
            this.has_Leg_PainCheckBox.Location = new System.Drawing.Point(101, 60);
            this.has_Leg_PainCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.has_Leg_PainCheckBox.Name = "has_Leg_PainCheckBox";
            this.has_Leg_PainCheckBox.Size = new System.Drawing.Size(78, 20);
            this.has_Leg_PainCheckBox.TabIndex = 5;
            this.has_Leg_PainCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Chest_PainsCheckBox
            // 
            this.has_Chest_PainsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Chest_Pains", true));
            this.has_Chest_PainsCheckBox.Location = new System.Drawing.Point(115, 37);
            this.has_Chest_PainsCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.has_Chest_PainsCheckBox.Name = "has_Chest_PainsCheckBox";
            this.has_Chest_PainsCheckBox.Size = new System.Drawing.Size(78, 20);
            this.has_Chest_PainsCheckBox.TabIndex = 3;
            this.has_Chest_PainsCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_WeaknessCheckBox
            // 
            this.has_WeaknessCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Weakness", true));
            this.has_WeaknessCheckBox.Location = new System.Drawing.Point(108, 15);
            this.has_WeaknessCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.has_WeaknessCheckBox.Name = "has_WeaknessCheckBox";
            this.has_WeaknessCheckBox.Size = new System.Drawing.Size(78, 20);
            this.has_WeaknessCheckBox.TabIndex = 1;
            this.has_WeaknessCheckBox.UseVisualStyleBackColor = true;
            // 
            // scheduled_appointment_dataTableAdapter
            // 
            this.scheduled_appointment_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.e_prescription_dataTableAdapter = null;
            this.tableAdapterManager.patient_dataTableAdapter = null;
            this.tableAdapterManager.scheduled_appointment_dataTableAdapter = this.scheduled_appointment_dataTableAdapter;
            this.tableAdapterManager.update_healthcare_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_dataTableAdapter = null;
            // 
            // scheduled_appointment_dataBindingNavigator
            // 
            this.scheduled_appointment_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scheduled_appointment_dataBindingNavigator.BindingSource = this.scheduled_appointment_dataBindingSource;
            this.scheduled_appointment_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scheduled_appointment_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scheduled_appointment_dataBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.scheduled_appointment_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.scheduled_appointment_dataBindingNavigatorSaveItem});
            this.scheduled_appointment_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scheduled_appointment_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scheduled_appointment_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scheduled_appointment_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scheduled_appointment_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scheduled_appointment_dataBindingNavigator.Name = "scheduled_appointment_dataBindingNavigator";
            this.scheduled_appointment_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scheduled_appointment_dataBindingNavigator.Size = new System.Drawing.Size(610, 27);
            this.scheduled_appointment_dataBindingNavigator.TabIndex = 39;
            this.scheduled_appointment_dataBindingNavigator.Text = "bindingNavigator1";
            this.scheduled_appointment_dataBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // scheduled_appointment_dataBindingNavigatorSaveItem
            // 
            this.scheduled_appointment_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduled_appointment_dataBindingNavigatorSaveItem.Image")));
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Name = "scheduled_appointment_dataBindingNavigatorSaveItem";
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // patient_dataTableAdapter
            // 
            this.patient_dataTableAdapter.ClearBeforeFill = true;
            // 
            // scheduled_appointment_dataBindingSource1
            // 
            this.scheduled_appointment_dataBindingSource1.DataMember = "FK_patient_data_scheduled_appointment_data";
            this.scheduled_appointment_dataBindingSource1.DataSource = this.patient_dataBindingSource;
            // 
            // doctor_NameLabel
            // 
            doctor_NameLabel.AutoSize = true;
            doctor_NameLabel.Location = new System.Drawing.Point(10, 34);
            doctor_NameLabel.Name = "doctor_NameLabel";
            doctor_NameLabel.Size = new System.Drawing.Size(73, 13);
            doctor_NameLabel.TabIndex = 41;
            doctor_NameLabel.Text = "Doctor Name:";
            // 
            // doctor_NameTextBox
            // 
            this.doctor_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource1, "Doctor_Name", true));
            this.doctor_NameTextBox.Location = new System.Drawing.Point(89, 31);
            this.doctor_NameTextBox.Name = "doctor_NameTextBox";
            this.doctor_NameTextBox.Size = new System.Drawing.Size(157, 20);
            this.doctor_NameTextBox.TabIndex = 42;
            // 
            // ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 502);
            this.Controls.Add(this.scheduled_appointment_dataBindingNavigator);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Controls.Add(this.labelScheduleAppointment);
            this.Controls.Add(this.buttonScheduleAppointment);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.ScheduleAppointment_Load);
            this.groupBoxPatientInformation.ResumeLayout(false);
            this.groupBoxPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingNavigator)).EndInit();
            this.scheduled_appointment_dataBindingNavigator.ResumeLayout(false);
            this.scheduled_appointment_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatientInformation;
        private System.Windows.Forms.Label labelScheduleAppointment;
        private System.Windows.Forms.Button buttonScheduleAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource scheduled_appointment_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter scheduled_appointment_dataTableAdapter;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scheduled_appointment_dataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton scheduled_appointment_dataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.DateTimePicker appointment_TimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker appointment_DateDateTimePicker;
        private System.Windows.Forms.CheckBox is_SuicidalCheckBox;
        private System.Windows.Forms.CheckBox is_WheezingCheckBox;
        private System.Windows.Forms.CheckBox has_Blood_in_UrineCheckBox;
        private System.Windows.Forms.CheckBox has_Leg_PainCheckBox;
        private System.Windows.Forms.CheckBox has_Chest_PainsCheckBox;
        private System.Windows.Forms.CheckBox has_WeaknessCheckBox;
        private System.Windows.Forms.BindingSource patient_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.patient_dataTableAdapter patient_dataTableAdapter;
        private System.Windows.Forms.TextBox patient_IdTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox doctor_NameTextBox;
        private System.Windows.Forms.BindingSource scheduled_appointment_dataBindingSource1;
    }
}