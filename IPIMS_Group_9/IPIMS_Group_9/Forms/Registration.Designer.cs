namespace IPIMS_Group_9.Forms
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxContactInformation = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.user_dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.groupBoxMedicalInformation = new System.Windows.Forms.GroupBox();
            this.insurance_contactTextBox = new System.Windows.Forms.TextBox();
            this.insurance_providerTextBox = new System.Windows.Forms.TextBox();
            this.labelHealthInsuranceNumber = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classificationComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxUserInformation = new System.Windows.Forms.GroupBox();
            this.social_security_numberTextBox = new System.Windows.Forms.TextBox();
            this.date_of_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.labelIdNumber = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxAddressInformation = new System.Windows.Forms.GroupBox();
            this.zip_codeTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.street_addressTextBox = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreetAddress = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.user_dataBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.user_dataBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.user_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.groupBoxContactInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxMedicalInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxUserInformation.SuspendLayout();
            this.groupBoxAddressInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource1BindingNavigator)).BeginInit();
            this.user_dataBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health Insurance:";
            // 
            // groupBoxContactInformation
            // 
            this.groupBoxContactInformation.Controls.Add(this.emailTextBox);
            this.groupBoxContactInformation.Controls.Add(this.phone_numberTextBox);
            this.groupBoxContactInformation.Controls.Add(this.labelEmailAddress);
            this.groupBoxContactInformation.Controls.Add(this.labelPhoneNumber);
            this.groupBoxContactInformation.Location = new System.Drawing.Point(13, 287);
            this.groupBoxContactInformation.Name = "groupBoxContactInformation";
            this.groupBoxContactInformation.Size = new System.Drawing.Size(278, 84);
            this.groupBoxContactInformation.TabIndex = 22;
            this.groupBoxContactInformation.TabStop = false;
            this.groupBoxContactInformation.Text = "Contact Information:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(94, 46);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(178, 20);
            this.emailTextBox.TabIndex = 27;
            // 
            // user_dataBindingSource1
            // 
            this.user_dataBindingSource1.DataMember = "user_data";
            this.user_dataBindingSource1.DataSource = this.iPIMS_9DataSet;
            // 
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(94, 17);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(178, 20);
            this.phone_numberTextBox.TabIndex = 27;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(12, 49);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.labelEmailAddress.TabIndex = 6;
            this.labelEmailAddress.Text = "Email Address:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(7, 20);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 0;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.labelUsername);
            this.groupBox2.Location = new System.Drawing.Point(297, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 84);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Information:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(71, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(201, 20);
            this.passwordTextBox.TabIndex = 27;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(71, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 20);
            this.usernameTextBox.TabIndex = 27;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 49);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(7, 20);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(345, 49);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(53, 13);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Zip Code:";
            // 
            // groupBoxMedicalInformation
            // 
            this.groupBoxMedicalInformation.Controls.Add(this.insurance_contactTextBox);
            this.groupBoxMedicalInformation.Controls.Add(this.insurance_providerTextBox);
            this.groupBoxMedicalInformation.Controls.Add(this.labelHealthInsuranceNumber);
            this.groupBoxMedicalInformation.Controls.Add(this.label2);
            this.groupBoxMedicalInformation.Location = new System.Drawing.Point(12, 377);
            this.groupBoxMedicalInformation.Name = "groupBoxMedicalInformation";
            this.groupBoxMedicalInformation.Size = new System.Drawing.Size(409, 91);
            this.groupBoxMedicalInformation.TabIndex = 24;
            this.groupBoxMedicalInformation.TabStop = false;
            this.groupBoxMedicalInformation.Text = "Patient Medical Information:";
            this.groupBoxMedicalInformation.Visible = false;
            // 
            // insurance_contactTextBox
            // 
            this.insurance_contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "insurance_contact", true));
            this.insurance_contactTextBox.Location = new System.Drawing.Point(104, 43);
            this.insurance_contactTextBox.Name = "insurance_contactTextBox";
            this.insurance_contactTextBox.Size = new System.Drawing.Size(299, 20);
            this.insurance_contactTextBox.TabIndex = 27;
            // 
            // insurance_providerTextBox
            // 
            this.insurance_providerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "insurance_provider", true));
            this.insurance_providerTextBox.Location = new System.Drawing.Point(104, 17);
            this.insurance_providerTextBox.Name = "insurance_providerTextBox";
            this.insurance_providerTextBox.Size = new System.Drawing.Size(299, 20);
            this.insurance_providerTextBox.TabIndex = 27;
            // 
            // labelHealthInsuranceNumber
            // 
            this.labelHealthInsuranceNumber.AutoSize = true;
            this.labelHealthInsuranceNumber.Location = new System.Drawing.Point(51, 46);
            this.labelHealthInsuranceNumber.Name = "labelHealthInsuranceNumber";
            this.labelHealthInsuranceNumber.Size = new System.Drawing.Size(47, 13);
            this.labelHealthInsuranceNumber.TabIndex = 5;
            this.labelHealthInsuranceNumber.Text = "Contact:";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.Location = new System.Drawing.Point(12, 21);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(175, 36);
            this.labelRegistration.TabIndex = 18;
            this.labelRegistration.Text = "Registration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classificationComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 40);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select the User\'s classification below:";
            // 
            // classificationComboBox
            // 
            this.classificationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "classification", true));
            this.classificationComboBox.FormattingEnabled = true;
            this.classificationComboBox.Items.AddRange(new object[] {
            "Patient",
            "Doctor",
            "Nurse",
            "Office Staff",
            "Lab Staff",
            "Research Staff"});
            this.classificationComboBox.Location = new System.Drawing.Point(6, 13);
            this.classificationComboBox.Name = "classificationComboBox";
            this.classificationComboBox.Size = new System.Drawing.Size(221, 21);
            this.classificationComboBox.TabIndex = 27;
            this.classificationComboBox.SelectedIndexChanged += new System.EventHandler(this.classificationComboBox_SelectedIndexChanged_1);
            // 
            // groupBoxUserInformation
            // 
            this.groupBoxUserInformation.Controls.Add(this.social_security_numberTextBox);
            this.groupBoxUserInformation.Controls.Add(this.date_of_birthDateTimePicker);
            this.groupBoxUserInformation.Controls.Add(this.genderComboBox);
            this.groupBoxUserInformation.Controls.Add(this.last_nameTextBox);
            this.groupBoxUserInformation.Controls.Add(this.first_nameTextBox);
            this.groupBoxUserInformation.Controls.Add(this.labelIdNumber);
            this.groupBoxUserInformation.Controls.Add(this.labelDateOfBirth);
            this.groupBoxUserInformation.Controls.Add(this.labelGender);
            this.groupBoxUserInformation.Controls.Add(this.labelLastName);
            this.groupBoxUserInformation.Controls.Add(this.labelFirstName);
            this.groupBoxUserInformation.Location = new System.Drawing.Point(13, 107);
            this.groupBoxUserInformation.Name = "groupBoxUserInformation";
            this.groupBoxUserInformation.Size = new System.Drawing.Size(564, 84);
            this.groupBoxUserInformation.TabIndex = 20;
            this.groupBoxUserInformation.TabStop = false;
            this.groupBoxUserInformation.Text = "User Information:";
            // 
            // social_security_numberTextBox
            // 
            this.social_security_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "social_security_number", true));
            this.social_security_numberTextBox.Location = new System.Drawing.Point(487, 46);
            this.social_security_numberTextBox.Name = "social_security_numberTextBox";
            this.social_security_numberTextBox.Size = new System.Drawing.Size(71, 20);
            this.social_security_numberTextBox.TabIndex = 27;
            // 
            // date_of_birthDateTimePicker
            // 
            this.date_of_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.user_dataBindingSource1, "date_of_birth", true));
            this.date_of_birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_birthDateTimePicker.Location = new System.Drawing.Point(240, 47);
            this.date_of_birthDateTimePicker.Name = "date_of_birthDateTimePicker";
            this.date_of_birthDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.date_of_birthDateTimePicker.TabIndex = 27;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderComboBox.Location = new System.Drawing.Point(92, 47);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(67, 21);
            this.genderComboBox.TabIndex = 27;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(351, 17);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(207, 20);
            this.last_nameTextBox.TabIndex = 27;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(73, 17);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(205, 20);
            this.first_nameTextBox.TabIndex = 27;
            // 
            // labelIdNumber
            // 
            this.labelIdNumber.AutoSize = true;
            this.labelIdNumber.Location = new System.Drawing.Point(460, 49);
            this.labelIdNumber.Name = "labelIdNumber";
            this.labelIdNumber.Size = new System.Drawing.Size(21, 13);
            this.labelIdNumber.TabIndex = 11;
            this.labelIdNumber.Text = "ID:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(165, 49);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of Birth:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(41, 50);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 13);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender:";
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
            // groupBoxAddressInformation
            // 
            this.groupBoxAddressInformation.Controls.Add(this.zip_codeTextBox);
            this.groupBoxAddressInformation.Controls.Add(this.stateTextBox);
            this.groupBoxAddressInformation.Controls.Add(this.cityTextBox);
            this.groupBoxAddressInformation.Controls.Add(this.street_addressTextBox);
            this.groupBoxAddressInformation.Controls.Add(this.labelZipCode);
            this.groupBoxAddressInformation.Controls.Add(this.labelState);
            this.groupBoxAddressInformation.Controls.Add(this.labelCity);
            this.groupBoxAddressInformation.Controls.Add(this.labelStreetAddress);
            this.groupBoxAddressInformation.Location = new System.Drawing.Point(13, 197);
            this.groupBoxAddressInformation.Name = "groupBoxAddressInformation";
            this.groupBoxAddressInformation.Size = new System.Drawing.Size(564, 84);
            this.groupBoxAddressInformation.TabIndex = 21;
            this.groupBoxAddressInformation.TabStop = false;
            this.groupBoxAddressInformation.Text = "Address Information:";
            // 
            // zip_codeTextBox
            // 
            this.zip_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "zip_code", true));
            this.zip_codeTextBox.Location = new System.Drawing.Point(404, 46);
            this.zip_codeTextBox.Name = "zip_codeTextBox";
            this.zip_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zip_codeTextBox.TabIndex = 27;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(239, 46);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 27;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(92, 46);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 27;
            // 
            // street_addressTextBox
            // 
            this.street_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource1, "street_address", true));
            this.street_addressTextBox.Location = new System.Drawing.Point(92, 17);
            this.street_addressTextBox.Name = "street_addressTextBox";
            this.street_addressTextBox.Size = new System.Drawing.Size(466, 20);
            this.street_addressTextBox.TabIndex = 27;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(198, 49);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "State:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(59, 49);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "City:";
            // 
            // labelStreetAddress
            // 
            this.labelStreetAddress.AutoSize = true;
            this.labelStreetAddress.Location = new System.Drawing.Point(7, 20);
            this.labelStreetAddress.Name = "labelStreetAddress";
            this.labelStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.labelStreetAddress.TabIndex = 0;
            this.labelStreetAddress.Text = "Street Address:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(460, 446);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(122, 35);
            this.buttonRegister.TabIndex = 25;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // user_dataBindingSource1BindingNavigator
            // 
            this.user_dataBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.user_dataBindingSource1BindingNavigator.BindingSource = this.user_dataBindingSource1;
            this.user_dataBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.user_dataBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.user_dataBindingSource1BindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.user_dataBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.user_dataBindingSource1BindingNavigatorSaveItem});
            this.user_dataBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user_dataBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.user_dataBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.user_dataBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.user_dataBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.user_dataBindingSource1BindingNavigator.Name = "user_dataBindingSource1BindingNavigator";
            this.user_dataBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.user_dataBindingSource1BindingNavigator.Size = new System.Drawing.Size(602, 25);
            this.user_dataBindingSource1BindingNavigator.TabIndex = 26;
            this.user_dataBindingSource1BindingNavigator.Text = "bindingNavigator1";
            this.user_dataBindingSource1BindingNavigator.Visible = false;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // user_dataBindingSource1BindingNavigatorSaveItem
            // 
            this.user_dataBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_dataBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_dataBindingSource1BindingNavigatorSaveItem.Image")));
            this.user_dataBindingSource1BindingNavigatorSaveItem.Name = "user_dataBindingSource1BindingNavigatorSaveItem";
            this.user_dataBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.user_dataBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.user_dataBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.user_dataBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // user_dataTableAdapter
            // 
            this.user_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.scheduled_appointment_dataTableAdapter = null;
            this.tableAdapterManager.update_healthcare_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_dataTableAdapter = this.user_dataTableAdapter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 502);
            this.Controls.Add(this.user_dataBindingSource1BindingNavigator);
            this.Controls.Add(this.groupBoxContactInformation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxMedicalInformation);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUserInformation);
            this.Controls.Add(this.groupBoxAddressInformation);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBoxContactInformation.ResumeLayout(false);
            this.groupBoxContactInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxMedicalInformation.ResumeLayout(false);
            this.groupBoxMedicalInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxUserInformation.ResumeLayout(false);
            this.groupBoxUserInformation.PerformLayout();
            this.groupBoxAddressInformation.ResumeLayout(false);
            this.groupBoxAddressInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource1BindingNavigator)).EndInit();
            this.user_dataBindingSource1BindingNavigator.ResumeLayout(false);
            this.user_dataBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxContactInformation;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.GroupBox groupBoxMedicalInformation;
        private System.Windows.Forms.Label labelHealthInsuranceNumber;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxUserInformation;
        private System.Windows.Forms.Label labelIdNumber;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupBoxAddressInformation;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreetAddress;
        private System.Windows.Forms.Button buttonRegister;
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource user_dataBindingSource1;
        private IPIMS_9DataSetTableAdapters.user_dataTableAdapter user_dataTableAdapter;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_dataBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton user_dataBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox classificationComboBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox social_security_numberTextBox;
        private System.Windows.Forms.DateTimePicker date_of_birthDateTimePicker;
        private System.Windows.Forms.TextBox zip_codeTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox street_addressTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox insurance_contactTextBox;
        private System.Windows.Forms.TextBox insurance_providerTextBox;
    }
}