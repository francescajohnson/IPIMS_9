namespace IPIMS_Group_9
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.groupBoxLoginInformation = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.groupBoxContactInformation = new System.Windows.Forms.GroupBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.labelEditProfile = new System.Windows.Forms.Label();
            this.groupBoxAddressInformation = new System.Windows.Forms.GroupBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStreetAddress = new System.Windows.Forms.Label();
            this.user_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.user_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
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
            this.user_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.user_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.warningLabel2 = new System.Windows.Forms.Label();
            this.groupBoxLoginInformation.SuspendLayout();
            this.groupBoxContactInformation.SuspendLayout();
            this.groupBoxAddressInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingNavigator)).BeginInit();
            this.user_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(336, 49);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(53, 13);
            this.labelZipCode.TabIndex = 13;
            this.labelZipCode.Text = "Zip Code:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(186, 49);
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
            // groupBoxLoginInformation
            // 
            this.groupBoxLoginInformation.Controls.Add(this.textBox2);
            this.groupBoxLoginInformation.Controls.Add(this.textBox1);
            this.groupBoxLoginInformation.Controls.Add(this.labelPassword);
            this.groupBoxLoginInformation.Controls.Add(this.labelConfirmPassword);
            this.groupBoxLoginInformation.Location = new System.Drawing.Point(12, 82);
            this.groupBoxLoginInformation.Name = "groupBoxLoginInformation";
            this.groupBoxLoginInformation.Size = new System.Drawing.Size(278, 84);
            this.groupBoxLoginInformation.TabIndex = 36;
            this.groupBoxLoginInformation.TabStop = false;
            this.groupBoxLoginInformation.Text = "Login Information:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 20);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(96, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Change Password:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(9, 49);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.labelConfirmPassword.TabIndex = 6;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProfile.Location = new System.Drawing.Point(460, 461);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(122, 35);
            this.buttonEditProfile.TabIndex = 38;
            this.buttonEditProfile.Text = "Edit Profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // groupBoxContactInformation
            // 
            this.groupBoxContactInformation.Controls.Add(this.labelEmailAddress);
            this.groupBoxContactInformation.Controls.Add(this.labelPhoneNumber);
            this.groupBoxContactInformation.Controls.Add(this.emailBox);
            this.groupBoxContactInformation.Controls.Add(this.phoneBox);
            this.groupBoxContactInformation.Location = new System.Drawing.Point(12, 262);
            this.groupBoxContactInformation.Name = "groupBoxContactInformation";
            this.groupBoxContactInformation.Size = new System.Drawing.Size(278, 84);
            this.groupBoxContactInformation.TabIndex = 35;
            this.groupBoxContactInformation.TabStop = false;
            this.groupBoxContactInformation.Text = "Contact Information:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(94, 46);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 9;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(94, 17);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 9;
            // 
            // labelEditProfile
            // 
            this.labelEditProfile.AutoSize = true;
            this.labelEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditProfile.Location = new System.Drawing.Point(12, 43);
            this.labelEditProfile.Name = "labelEditProfile";
            this.labelEditProfile.Size = new System.Drawing.Size(160, 36);
            this.labelEditProfile.TabIndex = 33;
            this.labelEditProfile.Text = "Edit Profile";
            // 
            // groupBoxAddressInformation
            // 
            this.groupBoxAddressInformation.Controls.Add(this.stateBox);
            this.groupBoxAddressInformation.Controls.Add(this.labelZipCode);
            this.groupBoxAddressInformation.Controls.Add(this.labelState);
            this.groupBoxAddressInformation.Controls.Add(this.labelCity);
            this.groupBoxAddressInformation.Controls.Add(this.groupBox2);
            this.groupBoxAddressInformation.Controls.Add(this.labelStreetAddress);
            this.groupBoxAddressInformation.Location = new System.Drawing.Point(12, 172);
            this.groupBoxAddressInformation.Name = "groupBoxAddressInformation";
            this.groupBoxAddressInformation.Size = new System.Drawing.Size(564, 84);
            this.groupBoxAddressInformation.TabIndex = 34;
            this.groupBoxAddressInformation.TabStop = false;
            this.groupBoxAddressInformation.Text = "Address Information:";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(227, 46);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 20);
            this.stateBox.TabIndex = 9;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(92, 46);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zipCodeBox);
            this.groupBox2.Controls.Add(this.cityBox);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.addressBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 84);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information:";
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(395, 46);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeBox.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(227, 46);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(92, 17);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(418, 20);
            this.addressBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Street Address:";
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
            // user_dataBindingNavigator
            // 
            this.user_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user_dataBindingNavigator.BindingSource = this.user_dataBindingSource;
            this.user_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_dataBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.user_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.user_dataBindingNavigatorSaveItem});
            this.user_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.user_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.user_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.user_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.user_dataBindingNavigator.Name = "user_dataBindingNavigator";
            this.user_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user_dataBindingNavigator.Size = new System.Drawing.Size(602, 25);
            this.user_dataBindingNavigator.TabIndex = 39;
            this.user_dataBindingNavigator.Text = "bindingNavigator1";
            this.user_dataBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // user_dataBindingSource
            // 
            this.user_dataBindingSource.DataMember = "user_data";
            this.user_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // user_dataBindingNavigatorSaveItem
            // 
            this.user_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_dataBindingNavigatorSaveItem.Image")));
            this.user_dataBindingNavigatorSaveItem.Name = "user_dataBindingNavigatorSaveItem";
            this.user_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.user_dataBindingNavigatorSaveItem.Text = "Save Data";
            this.user_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.user_dataBindingNavigatorSaveItem_Click);
            // 
            // user_dataTableAdapter
            // 
            this.user_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.e_prescription_dataTableAdapter = null;
            this.tableAdapterManager.patient_dataTableAdapter = null;
            this.tableAdapterManager.scheduled_appointment_dataTableAdapter = null;
            this.tableAdapterManager.update_healthcare_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_dataTableAdapter = this.user_dataTableAdapter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordBox2);
            this.groupBox1.Controls.Add(this.passwordBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 84);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information:";
            // 
            // passwordBox2
            // 
            this.passwordBox2.Location = new System.Drawing.Point(108, 43);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Size = new System.Drawing.Size(100, 20);
            this.passwordBox2.TabIndex = 9;
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(108, 17);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(100, 20);
            this.passwordBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(101, 461);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 40;
            // 
            // warningLabel2
            // 
            this.warningLabel2.AutoSize = true;
            this.warningLabel2.Location = new System.Drawing.Point(103, 432);
            this.warningLabel2.Name = "warningLabel2";
            this.warningLabel2.Size = new System.Drawing.Size(0, 13);
            this.warningLabel2.TabIndex = 40;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 516);
            this.Controls.Add(this.warningLabel2);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.user_dataBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxLoginInformation);
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.groupBoxContactInformation);
            this.Controls.Add(this.labelEditProfile);
            this.Controls.Add(this.groupBoxAddressInformation);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.groupBoxLoginInformation.ResumeLayout(false);
            this.groupBoxLoginInformation.PerformLayout();
            this.groupBoxContactInformation.ResumeLayout(false);
            this.groupBoxContactInformation.PerformLayout();
            this.groupBoxAddressInformation.ResumeLayout(false);
            this.groupBoxAddressInformation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingNavigator)).EndInit();
            this.user_dataBindingNavigator.ResumeLayout(false);
            this.user_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.GroupBox groupBoxLoginInformation;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.GroupBox groupBoxContactInformation;
        private System.Windows.Forms.Label labelEditProfile;
        private System.Windows.Forms.GroupBox groupBoxAddressInformation;
        private System.Windows.Forms.Label labelStreetAddress;
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource user_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.user_dataTableAdapter user_dataTableAdapter;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_dataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton user_dataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox zipCodeBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label warningLabel2;
    }
}