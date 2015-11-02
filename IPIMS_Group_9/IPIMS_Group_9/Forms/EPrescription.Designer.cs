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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label medicine_NameLabel;
            System.Windows.Forms.Label dosageLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label lab_DescriptionLabel;
            System.Windows.Forms.Label instructionLabel;
            System.Windows.Forms.Label prescription_IdLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label first_NameLabel;
            this.labelEPrescriptions = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.e_prescription_dataDataGridView = new System.Windows.Forms.DataGridView();
            this.e_prescription_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.prescription_IdTextBox = new System.Windows.Forms.TextBox();
            this.e_prescription_dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patient_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.lab_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.medicine_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.first_NameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.last_NameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.last_NameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.vIEW1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.view2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.first_NameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.first_NameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.last_NameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.last_NameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.view2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.update_healthcare_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.update_healthcare_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.update_healthcare_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.e_prescription_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.e_prescription_dataTableAdapter();
            this.patient_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.patient_dataTableAdapter();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            medicine_NameLabel = new System.Windows.Forms.Label();
            dosageLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            lab_DescriptionLabel = new System.Windows.Forms.Label();
            instructionLabel = new System.Windows.Forms.Label();
            prescription_IdLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.e_prescription_dataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_prescription_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            this.groupBoxPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_prescription_dataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).BeginInit();
            this.view2ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_healthcare_dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // medicine_NameLabel
            // 
            medicine_NameLabel.AutoSize = true;
            medicine_NameLabel.Location = new System.Drawing.Point(6, 46);
            medicine_NameLabel.Name = "medicine_NameLabel";
            medicine_NameLabel.Size = new System.Drawing.Size(84, 13);
            medicine_NameLabel.TabIndex = 25;
            medicine_NameLabel.Text = "Medicine Name:";
            // 
            // dosageLabel
            // 
            dosageLabel.AutoSize = true;
            dosageLabel.Location = new System.Drawing.Point(207, 46);
            dosageLabel.Name = "dosageLabel";
            dosageLabel.Size = new System.Drawing.Size(47, 13);
            dosageLabel.TabIndex = 26;
            dosageLabel.Text = "Dosage:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(380, 43);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 27;
            quantityLabel.Text = "Quantity:";
            // 
            // lab_DescriptionLabel
            // 
            lab_DescriptionLabel.AutoSize = true;
            lab_DescriptionLabel.Location = new System.Drawing.Point(11, 71);
            lab_DescriptionLabel.Name = "lab_DescriptionLabel";
            lab_DescriptionLabel.Size = new System.Drawing.Size(84, 13);
            lab_DescriptionLabel.TabIndex = 28;
            lab_DescriptionLabel.Text = "Lab Description:";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new System.Drawing.Point(216, 75);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new System.Drawing.Size(59, 13);
            instructionLabel.TabIndex = 29;
            instructionLabel.Text = "Instruction:";
            // 
            // prescription_IdLabel
            // 
            prescription_IdLabel.AutoSize = true;
            prescription_IdLabel.Location = new System.Drawing.Point(387, 75);
            prescription_IdLabel.Name = "prescription_IdLabel";
            prescription_IdLabel.Size = new System.Drawing.Size(77, 13);
            prescription_IdLabel.TabIndex = 30;
            prescription_IdLabel.Text = "Prescription Id:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(366, 22);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 24;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(193, 22);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 23;
            last_NameLabel.Text = "Last Name:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(21, 22);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 22;
            first_NameLabel.Text = "First Name:";
            // 
            // labelEPrescriptions
            // 
            this.labelEPrescriptions.AutoSize = true;
            this.labelEPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEPrescriptions.Location = new System.Drawing.Point(7, 71);
            this.labelEPrescriptions.Name = "labelEPrescriptions";
            this.labelEPrescriptions.Size = new System.Drawing.Size(455, 36);
            this.labelEPrescriptions.TabIndex = 30;
            this.labelEPrescriptions.Text = "E-Prescriptions and Lab Records";
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
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(281, 461);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(70, 35);
            this.buttonCreate.TabIndex = 48;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
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
            // e_prescription_dataDataGridView
            // 
            this.e_prescription_dataDataGridView.AutoGenerateColumns = false;
            this.e_prescription_dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.e_prescription_dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12});
            this.e_prescription_dataDataGridView.DataSource = this.e_prescription_dataBindingSource;
            this.e_prescription_dataDataGridView.Location = new System.Drawing.Point(9, 222);
            this.e_prescription_dataDataGridView.Name = "e_prescription_dataDataGridView";
            this.e_prescription_dataDataGridView.ReadOnly = true;
            this.e_prescription_dataDataGridView.Size = new System.Drawing.Size(679, 220);
            this.e_prescription_dataDataGridView.TabIndex = 51;
            this.e_prescription_dataDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.e_prescription_dataDataGridView_CellContentClick);
            // 
            // e_prescription_dataBindingSource
            // 
            this.e_prescription_dataBindingSource.DataMember = "e_prescription_data";
            this.e_prescription_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(prescription_IdLabel);
            this.groupBoxPatientInformation.Controls.Add(this.prescription_IdTextBox);
            this.groupBoxPatientInformation.Controls.Add(instructionLabel);
            this.groupBoxPatientInformation.Controls.Add(this.instructionTextBox);
            this.groupBoxPatientInformation.Controls.Add(lab_DescriptionLabel);
            this.groupBoxPatientInformation.Controls.Add(this.lab_DescriptionTextBox);
            this.groupBoxPatientInformation.Controls.Add(quantityLabel);
            this.groupBoxPatientInformation.Controls.Add(this.quantityTextBox);
            this.groupBoxPatientInformation.Controls.Add(dosageLabel);
            this.groupBoxPatientInformation.Controls.Add(this.dosageTextBox);
            this.groupBoxPatientInformation.Controls.Add(medicine_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.medicine_NameTextBox);
            this.groupBoxPatientInformation.Controls.Add(date_of_BirthLabel);
            this.groupBoxPatientInformation.Controls.Add(this.date_of_BirthDateTimePicker);
            this.groupBoxPatientInformation.Controls.Add(last_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.last_NameTextBox);
            this.groupBoxPatientInformation.Controls.Add(first_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.first_NameTextBox);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(9, 116);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(676, 100);
            this.groupBoxPatientInformation.TabIndex = 46;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information";
            // 
            // prescription_IdTextBox
            // 
            this.prescription_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Prescription_Id", true));
            this.prescription_IdTextBox.Location = new System.Drawing.Point(470, 72);
            this.prescription_IdTextBox.Name = "prescription_IdTextBox";
            this.prescription_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.prescription_IdTextBox.TabIndex = 31;
            // 
            // e_prescription_dataBindingSource1
            // 
            this.e_prescription_dataBindingSource1.DataMember = "FK_patient_data_e_prescription_data";
            this.e_prescription_dataBindingSource1.DataSource = this.patient_dataBindingSource;
            // 
            // patient_dataBindingSource
            // 
            this.patient_dataBindingSource.DataMember = "patient_data";
            this.patient_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Instruction", true));
            this.instructionTextBox.Location = new System.Drawing.Point(281, 72);
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(100, 20);
            this.instructionTextBox.TabIndex = 30;
            // 
            // lab_DescriptionTextBox
            // 
            this.lab_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Lab_Description", true));
            this.lab_DescriptionTextBox.Location = new System.Drawing.Point(101, 68);
            this.lab_DescriptionTextBox.Name = "lab_DescriptionTextBox";
            this.lab_DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.lab_DescriptionTextBox.TabIndex = 29;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(435, 40);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 28;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Dosage", true));
            this.dosageTextBox.Location = new System.Drawing.Point(260, 43);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(100, 20);
            this.dosageTextBox.TabIndex = 27;
            // 
            // medicine_NameTextBox
            // 
            this.medicine_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Medicine_Name", true));
            this.medicine_NameTextBox.Location = new System.Drawing.Point(96, 43);
            this.medicine_NameTextBox.Name = "medicine_NameTextBox";
            this.medicine_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicine_NameTextBox.TabIndex = 26;
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.e_prescription_dataBindingSource1, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(441, 18);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 25;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(260, 19);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 24;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.e_prescription_dataBindingSource1, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(87, 19);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 23;
            // 
            // first_NameToolStripLabel
            // 
            this.first_NameToolStripLabel.Name = "first_NameToolStripLabel";
            this.first_NameToolStripLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // first_NameToolStripTextBox
            // 
            this.first_NameToolStripTextBox.Name = "first_NameToolStripTextBox";
            this.first_NameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // last_NameToolStripLabel
            // 
            this.last_NameToolStripLabel.Name = "last_NameToolStripLabel";
            this.last_NameToolStripLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // last_NameToolStripTextBox
            // 
            this.last_NameToolStripTextBox.Name = "last_NameToolStripTextBox";
            this.last_NameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // vIEW1ToolStripButton
            // 
            this.vIEW1ToolStripButton.Name = "vIEW1ToolStripButton";
            this.vIEW1ToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 35);
            this.button1.TabIndex = 52;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view2ToolStrip
            // 
            this.view2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.first_NameToolStripLabel1,
            this.first_NameToolStripTextBox1,
            this.last_NameToolStripLabel1,
            this.last_NameToolStripTextBox1,
            this.view2ToolStripButton});
            this.view2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.view2ToolStrip.Name = "view2ToolStrip";
            this.view2ToolStrip.Size = new System.Drawing.Size(708, 25);
            this.view2ToolStrip.TabIndex = 54;
            this.view2ToolStrip.Text = "view2ToolStrip";
            // 
            // first_NameToolStripLabel1
            // 
            this.first_NameToolStripLabel1.Name = "first_NameToolStripLabel1";
            this.first_NameToolStripLabel1.Size = new System.Drawing.Size(69, 22);
            this.first_NameToolStripLabel1.Text = "First_Name:";
            // 
            // first_NameToolStripTextBox1
            // 
            this.first_NameToolStripTextBox1.Name = "first_NameToolStripTextBox1";
            this.first_NameToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // last_NameToolStripLabel1
            // 
            this.last_NameToolStripLabel1.Name = "last_NameToolStripLabel1";
            this.last_NameToolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.last_NameToolStripLabel1.Text = "Last_Name:";
            // 
            // last_NameToolStripTextBox1
            // 
            this.last_NameToolStripTextBox1.Name = "last_NameToolStripTextBox1";
            this.last_NameToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // view2ToolStripButton
            // 
            this.view2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.view2ToolStripButton.Name = "view2ToolStripButton";
            this.view2ToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.view2ToolStripButton.Text = "View";
            // 
            // update_healthcare_dataBindingSource
            // 
            this.update_healthcare_dataBindingSource.DataMember = "update_healthcare_data";
            this.update_healthcare_dataBindingSource.DataSource = this.iPIMS_9DataSet;
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
            // e_prescription_dataTableAdapter
            // 
            this.e_prescription_dataTableAdapter.ClearBeforeFill = true;
            // 
            // patient_dataTableAdapter
            // 
            this.patient_dataTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Instruction";
            this.dataGridViewTextBoxColumn12.HeaderText = "Instruction";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Dosage";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dosage";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Medicine_Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Medicine_Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Lab_Description";
            this.dataGridViewTextBoxColumn10.HeaderText = "Lab_Description";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Prescription_Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Prescription_Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 95;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prescription_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prescription_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // EPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 516);
            this.Controls.Add(this.view2ToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.e_prescription_dataDataGridView);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Controls.Add(this.labelEPrescriptions);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonEdit);
            this.Name = "EPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.EPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_prescription_dataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_prescription_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            this.groupBoxPatientInformation.ResumeLayout(false);
            this.groupBoxPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_prescription_dataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).EndInit();
            this.view2ToolStrip.ResumeLayout(false);
            this.view2ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_healthcare_dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEPrescriptions;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonEdit;
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource update_healthcare_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.update_healthcare_dataTableAdapter update_healthcare_dataTableAdapter;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource e_prescription_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.e_prescription_dataTableAdapter e_prescription_dataTableAdapter;
        private System.Windows.Forms.DataGridView e_prescription_dataDataGridView;
        private System.Windows.Forms.GroupBox groupBoxPatientInformation;
        private System.Windows.Forms.BindingSource patient_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.patient_dataTableAdapter patient_dataTableAdapter;
        private System.Windows.Forms.BindingSource e_prescription_dataBindingSource1;
        private System.Windows.Forms.TextBox lab_DescriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.TextBox medicine_NameTextBox;
        private System.Windows.Forms.TextBox prescription_IdTextBox;
        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.ToolStripLabel first_NameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox first_NameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel last_NameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox last_NameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton vIEW1ToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip view2ToolStrip;
        private System.Windows.Forms.ToolStripLabel first_NameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox first_NameToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel last_NameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox last_NameToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton view2ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}