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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleAppointment));
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label appointment_DateLabel;
            System.Windows.Forms.Label appointment_TimeLabel;
            System.Windows.Forms.Label doctor_NameLabel;
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.labelScheduleAppointment = new System.Windows.Forms.Label();
            this.buttonScheduleAppointment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scheduled_appointment_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
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
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.appointment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointment_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.has_WeaknessCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Chest_PainsCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Leg_PainCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Blood_in_UrineCheckBox = new System.Windows.Forms.CheckBox();
            this.is_WheezingCheckBox = new System.Windows.Forms.CheckBox();
            this.is_SuicidalCheckBox = new System.Windows.Forms.CheckBox();
            this.doctor_NameComboBox = new System.Windows.Forms.ComboBox();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            appointment_DateLabel = new System.Windows.Forms.Label();
            appointment_TimeLabel = new System.Windows.Forms.Label();
            doctor_NameLabel = new System.Windows.Forms.Label();
            this.groupBoxPatientInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingNavigator)).BeginInit();
            this.scheduled_appointment_dataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(this.symptomsTextBox);
            this.groupBoxPatientInformation.Controls.Add(symptomsLabel);
            this.groupBoxPatientInformation.Controls.Add(date_of_BirthLabel);
            this.groupBoxPatientInformation.Controls.Add(last_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.date_of_BirthDateTimePicker);
            this.groupBoxPatientInformation.Controls.Add(this.last_NameTextBox);
            this.groupBoxPatientInformation.Controls.Add(first_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.first_NameTextBox);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(12, 75);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(564, 163);
            this.groupBoxPatientInformation.TabIndex = 35;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information:";
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
            this.groupBox1.Controls.Add(this.doctor_NameComboBox);
            this.groupBox1.Controls.Add(appointment_TimeLabel);
            this.groupBox1.Controls.Add(this.appointment_TimeDateTimePicker);
            this.groupBox1.Controls.Add(appointment_DateLabel);
            this.groupBox1.Controls.Add(this.appointment_DateDateTimePicker);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 211);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar and Doctor Selection for Appointment Scheduling:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.is_SuicidalCheckBox);
            this.groupBox2.Controls.Add(this.is_WheezingCheckBox);
            this.groupBox2.Controls.Add(this.has_Blood_in_UrineCheckBox);
            this.groupBox2.Controls.Add(this.has_Leg_PainCheckBox);
            this.groupBox2.Controls.Add(this.has_Chest_PainsCheckBox);
            this.groupBox2.Controls.Add(this.has_WeaknessCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(262, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 162);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Is the Patient experiencing any of the following?";
            // 
            // scheduled_appointment_dataBindingSource
            // 
            this.scheduled_appointment_dataBindingSource.DataMember = "scheduled_appointment_data";
            this.scheduled_appointment_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.scheduled_appointment_dataBindingNavigator.Size = new System.Drawing.Size(594, 27);
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
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(7, 25);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 42;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(73, 22);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 43;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(195, 25);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 43;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(262, 22);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 44;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(380, 26);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 50;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduled_appointment_dataBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(455, 22);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 51;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(7, 61);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(58, 13);
            symptomsLabel.TabIndex = 50;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(71, 61);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(464, 87);
            this.symptomsTextBox.TabIndex = 51;
            // 
            // appointment_DateLabel
            // 
            appointment_DateLabel.AutoSize = true;
            appointment_DateLabel.Location = new System.Drawing.Point(7, 51);
            appointment_DateLabel.Name = "appointment_DateLabel";
            appointment_DateLabel.Size = new System.Drawing.Size(95, 13);
            appointment_DateLabel.TabIndex = 39;
            appointment_DateLabel.Text = "Appointment Date:";
            // 
            // appointment_DateDateTimePicker
            // 
            this.appointment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduled_appointment_dataBindingSource, "Appointment_Date", true));
            this.appointment_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointment_DateDateTimePicker.Location = new System.Drawing.Point(108, 51);
            this.appointment_DateDateTimePicker.Name = "appointment_DateDateTimePicker";
            this.appointment_DateDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.appointment_DateDateTimePicker.TabIndex = 40;
            // 
            // appointment_TimeLabel
            // 
            appointment_TimeLabel.AutoSize = true;
            appointment_TimeLabel.Location = new System.Drawing.Point(7, 117);
            appointment_TimeLabel.Name = "appointment_TimeLabel";
            appointment_TimeLabel.Size = new System.Drawing.Size(95, 13);
            appointment_TimeLabel.TabIndex = 40;
            appointment_TimeLabel.Text = "Appointment Time:";
            // 
            // appointment_TimeDateTimePicker
            // 
            this.appointment_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduled_appointment_dataBindingSource, "Appointment_Time", true));
            this.appointment_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.appointment_TimeDateTimePicker.Location = new System.Drawing.Point(108, 117);
            this.appointment_TimeDateTimePicker.Name = "appointment_TimeDateTimePicker";
            this.appointment_TimeDateTimePicker.ShowUpDown = true;
            this.appointment_TimeDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.appointment_TimeDateTimePicker.TabIndex = 41;
            this.appointment_TimeDateTimePicker.ValueChanged += new System.EventHandler(this.appointment_TimeDateTimePicker_ValueChanged);
            // 
            // has_WeaknessCheckBox
            // 
            this.has_WeaknessCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Weakness", true));
            this.has_WeaknessCheckBox.Location = new System.Drawing.Point(16, 31);
            this.has_WeaknessCheckBox.Name = "has_WeaknessCheckBox";
            this.has_WeaknessCheckBox.Size = new System.Drawing.Size(104, 24);
            this.has_WeaknessCheckBox.TabIndex = 1;
            this.has_WeaknessCheckBox.Text = "Weakness";
            this.has_WeaknessCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Chest_PainsCheckBox
            // 
            this.has_Chest_PainsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Chest_Pains", true));
            this.has_Chest_PainsCheckBox.Location = new System.Drawing.Point(16, 73);
            this.has_Chest_PainsCheckBox.Name = "has_Chest_PainsCheckBox";
            this.has_Chest_PainsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.has_Chest_PainsCheckBox.TabIndex = 2;
            this.has_Chest_PainsCheckBox.Text = "Chest Pain";
            this.has_Chest_PainsCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Leg_PainCheckBox
            // 
            this.has_Leg_PainCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Leg_Pain", true));
            this.has_Leg_PainCheckBox.Location = new System.Drawing.Point(16, 121);
            this.has_Leg_PainCheckBox.Name = "has_Leg_PainCheckBox";
            this.has_Leg_PainCheckBox.Size = new System.Drawing.Size(104, 24);
            this.has_Leg_PainCheckBox.TabIndex = 3;
            this.has_Leg_PainCheckBox.Text = "Leg Pain";
            this.has_Leg_PainCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Blood_in_UrineCheckBox
            // 
            this.has_Blood_in_UrineCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Has_Blood_in_Urine", true));
            this.has_Blood_in_UrineCheckBox.Location = new System.Drawing.Point(121, 31);
            this.has_Blood_in_UrineCheckBox.Name = "has_Blood_in_UrineCheckBox";
            this.has_Blood_in_UrineCheckBox.Size = new System.Drawing.Size(125, 24);
            this.has_Blood_in_UrineCheckBox.TabIndex = 4;
            this.has_Blood_in_UrineCheckBox.Text = "Urinary Concerns";
            this.has_Blood_in_UrineCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_WheezingCheckBox
            // 
            this.is_WheezingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Is_Wheezing", true));
            this.is_WheezingCheckBox.Location = new System.Drawing.Point(121, 73);
            this.is_WheezingCheckBox.Name = "is_WheezingCheckBox";
            this.is_WheezingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_WheezingCheckBox.TabIndex = 5;
            this.is_WheezingCheckBox.Text = "Wheezing";
            this.is_WheezingCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_SuicidalCheckBox
            // 
            this.is_SuicidalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduled_appointment_dataBindingSource, "Is_Suicidal", true));
            this.is_SuicidalCheckBox.Location = new System.Drawing.Point(121, 121);
            this.is_SuicidalCheckBox.Name = "is_SuicidalCheckBox";
            this.is_SuicidalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_SuicidalCheckBox.TabIndex = 6;
            this.is_SuicidalCheckBox.Text = "Suicidal";
            this.is_SuicidalCheckBox.UseVisualStyleBackColor = true;
            // 
            // doctor_NameLabel
            // 
            doctor_NameLabel.AutoSize = true;
            doctor_NameLabel.Location = new System.Drawing.Point(7, 177);
            doctor_NameLabel.Name = "doctor_NameLabel";
            doctor_NameLabel.Size = new System.Drawing.Size(42, 13);
            doctor_NameLabel.TabIndex = 41;
            doctor_NameLabel.Text = "Doctor:";
            // 
            // doctor_NameComboBox
            // 
            this.doctor_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Doctor_Name", true));
            this.doctor_NameComboBox.FormattingEnabled = true;
            this.doctor_NameComboBox.Items.AddRange(new object[] {
            "Dr. John Smith",
            "Dr. Jane Doe",
            "Dr. Emma Jones"});
            this.doctor_NameComboBox.Location = new System.Drawing.Point(71, 174);
            this.doctor_NameComboBox.Name = "doctor_NameComboBox";
            this.doctor_NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.doctor_NameComboBox.TabIndex = 42;
            // 
            // ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 502);
            this.Controls.Add(this.scheduled_appointment_dataBindingNavigator);
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
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingNavigator)).EndInit();
            this.scheduled_appointment_dataBindingNavigator.ResumeLayout(false);
            this.scheduled_appointment_dataBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.DateTimePicker appointment_TimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker appointment_DateDateTimePicker;
        private System.Windows.Forms.CheckBox has_Leg_PainCheckBox;
        private System.Windows.Forms.CheckBox has_Chest_PainsCheckBox;
        private System.Windows.Forms.CheckBox has_WeaknessCheckBox;
        private System.Windows.Forms.CheckBox is_SuicidalCheckBox;
        private System.Windows.Forms.CheckBox is_WheezingCheckBox;
        private System.Windows.Forms.CheckBox has_Blood_in_UrineCheckBox;
        private System.Windows.Forms.ComboBox doctor_NameComboBox;
    }
}