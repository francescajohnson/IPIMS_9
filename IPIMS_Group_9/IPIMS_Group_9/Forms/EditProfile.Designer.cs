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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label passwordLabel1;
            System.Windows.Forms.Label street_AddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zip_CodeLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label emailLabel;
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.groupBoxContactInformation = new System.Windows.Forms.GroupBox();
            this.labelEditProfile = new System.Windows.Forms.Label();
            this.groupBoxAddressInformation = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.warningLabel = new System.Windows.Forms.Label();
            this.warningLabel2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.street_AddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zip_CodeTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            passwordLabel = new System.Windows.Forms.Label();
            passwordLabel1 = new System.Windows.Forms.Label();
            street_AddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zip_CodeLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
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
            this.groupBoxContactInformation.Controls.Add(emailLabel);
            this.groupBoxContactInformation.Controls.Add(this.emailTextBox);
            this.groupBoxContactInformation.Controls.Add(phone_NumberLabel);
            this.groupBoxContactInformation.Controls.Add(this.phone_NumberTextBox);
            this.groupBoxContactInformation.Location = new System.Drawing.Point(12, 262);
            this.groupBoxContactInformation.Name = "groupBoxContactInformation";
            this.groupBoxContactInformation.Size = new System.Drawing.Size(278, 99);
            this.groupBoxContactInformation.TabIndex = 35;
            this.groupBoxContactInformation.TabStop = false;
            this.groupBoxContactInformation.Text = "Contact Information:";
            // 
            // labelEditProfile
            // 
            this.labelEditProfile.AutoSize = true;
            this.labelEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditProfile.Location = new System.Drawing.Point(12, 20);
            this.labelEditProfile.Name = "labelEditProfile";
            this.labelEditProfile.Size = new System.Drawing.Size(160, 36);
            this.labelEditProfile.TabIndex = 33;
            this.labelEditProfile.Text = "Edit Profile";
            // 
            // groupBoxAddressInformation
            // 
            this.groupBoxAddressInformation.Controls.Add(this.groupBox2);
            this.groupBoxAddressInformation.Controls.Add(this.labelStreetAddress);
            this.groupBoxAddressInformation.Location = new System.Drawing.Point(12, 172);
            this.groupBoxAddressInformation.Name = "groupBoxAddressInformation";
            this.groupBoxAddressInformation.Size = new System.Drawing.Size(564, 90);
            this.groupBoxAddressInformation.TabIndex = 34;
            this.groupBoxAddressInformation.TabStop = false;
            this.groupBoxAddressInformation.Text = "Address Information:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(zip_CodeLabel);
            this.groupBox2.Controls.Add(this.zip_CodeTextBox);
            this.groupBox2.Controls.Add(stateLabel);
            this.groupBox2.Controls.Add(this.stateTextBox);
            this.groupBox2.Controls.Add(cityLabel);
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Controls.Add(street_AddressLabel);
            this.groupBox2.Controls.Add(this.street_AddressTextBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 90);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information:";
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
            this.groupBox1.Controls.Add(passwordLabel1);
            this.groupBox1.Controls.Add(this.passwordTextBox1);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 107);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information:";
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
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(6, 25);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(96, 13);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Change Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(108, 22);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Location = new System.Drawing.Point(9, 62);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new System.Drawing.Size(94, 13);
            passwordLabel1.TabIndex = 9;
            passwordLabel1.Text = "Confirm Password:";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Password", true));
            this.passwordTextBox1.Location = new System.Drawing.Point(108, 62);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox1.TabIndex = 10;
            // 
            // street_AddressLabel
            // 
            street_AddressLabel.AutoSize = true;
            street_AddressLabel.Location = new System.Drawing.Point(9, 23);
            street_AddressLabel.Name = "street_AddressLabel";
            street_AddressLabel.Size = new System.Drawing.Size(79, 13);
            street_AddressLabel.TabIndex = 13;
            street_AddressLabel.Text = "Street Address:";
            // 
            // street_AddressTextBox
            // 
            this.street_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Street_Address", true));
            this.street_AddressTextBox.Location = new System.Drawing.Point(94, 20);
            this.street_AddressTextBox.Name = "street_AddressTextBox";
            this.street_AddressTextBox.Size = new System.Drawing.Size(401, 20);
            this.street_AddressTextBox.TabIndex = 14;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(10, 53);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(43, 50);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 15;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(167, 53);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(208, 50);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 16;
            // 
            // zip_CodeLabel
            // 
            zip_CodeLabel.AutoSize = true;
            zip_CodeLabel.Location = new System.Drawing.Point(336, 53);
            zip_CodeLabel.Name = "zip_CodeLabel";
            zip_CodeLabel.Size = new System.Drawing.Size(53, 13);
            zip_CodeLabel.TabIndex = 16;
            zip_CodeLabel.Text = "Zip Code:";
            // 
            // zip_CodeTextBox
            // 
            this.zip_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Zip_Code", true));
            this.zip_CodeTextBox.Location = new System.Drawing.Point(395, 50);
            this.zip_CodeTextBox.Name = "zip_CodeTextBox";
            this.zip_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zip_CodeTextBox.TabIndex = 17;
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(5, 26);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 0;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Phone_Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(92, 23);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_NumberTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 64);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(76, 13);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email Address:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(92, 61);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 3;
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
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.groupBoxContactInformation);
            this.Controls.Add(this.labelEditProfile);
            this.Controls.Add(this.groupBoxAddressInformation);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.EditProfile_Load);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label warningLabel2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.TextBox zip_CodeTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox street_AddressTextBox;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}