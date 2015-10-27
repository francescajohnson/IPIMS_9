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
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.update_healthcare_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.update_healthcare_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.update_healthcare_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.groupBoxPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_healthcare_dataBindingSource)).BeginInit();
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
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
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
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.scheduled_appointment_dataTableAdapter = null;
            this.tableAdapterManager.update_healthcare_dataTableAdapter = this.update_healthcare_dataTableAdapter;
            this.tableAdapterManager.UpdateOrder = IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_dataTableAdapter = null;
            // 
            // EPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 516);
            this.Controls.Add(this.comboBoxDoctorSelection);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Controls.Add(this.labelEPrescriptions);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonEdit);
            this.Name = "EPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.EPrescription_Load);
            this.groupBoxPatientInformation.ResumeLayout(false);
            this.groupBoxPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_healthcare_dataBindingSource)).EndInit();
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
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource update_healthcare_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.update_healthcare_dataTableAdapter update_healthcare_dataTableAdapter;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}