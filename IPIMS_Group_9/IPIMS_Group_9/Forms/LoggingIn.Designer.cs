namespace IPIMS_Group_9.Forms
{
    partial class LoggingIn
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggingIn));
            this.groupBoxLoginInformation = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.labelPleaseLogin = new System.Windows.Forms.Label();
            this.checkBoxNewUser = new System.Windows.Forms.CheckBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.user_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.user_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.user_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.user_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.scheduled_appointment_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduled_appointment_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.groupBoxLoginInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingNavigator)).BeginInit();
            this.user_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(6, 22);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 27;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(8, 67);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 28;
            passwordLabel.Text = "Password:";
            // 
            // groupBoxLoginInformation
            // 
            this.groupBoxLoginInformation.Controls.Add(passwordLabel);
            this.groupBoxLoginInformation.Controls.Add(this.passwordTextBox);
            this.groupBoxLoginInformation.Controls.Add(usernameLabel);
            this.groupBoxLoginInformation.Controls.Add(this.usernameTextBox);
            this.groupBoxLoginInformation.Location = new System.Drawing.Point(217, 197);
            this.groupBoxLoginInformation.Name = "groupBoxLoginInformation";
            this.groupBoxLoginInformation.Size = new System.Drawing.Size(292, 99);
            this.groupBoxLoginInformation.TabIndex = 24;
            this.groupBoxLoginInformation.TabStop = false;
            this.groupBoxLoginInformation.Text = "Login Information:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(70, 64);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(216, 20);
            this.passwordTextBox.TabIndex = 29;
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
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_dataBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(70, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(216, 20);
            this.usernameTextBox.TabIndex = 28;
            // 
            // labelPleaseLogin
            // 
            this.labelPleaseLogin.AutoSize = true;
            this.labelPleaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPleaseLogin.Location = new System.Drawing.Point(103, 134);
            this.labelPleaseLogin.Name = "labelPleaseLogin";
            this.labelPleaseLogin.Size = new System.Drawing.Size(148, 17);
            this.labelPleaseLogin.TabIndex = 23;
            this.labelPleaseLogin.Text = "Please login below.";
            // 
            // checkBoxNewUser
            // 
            this.checkBoxNewUser.AutoSize = true;
            this.checkBoxNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNewUser.Location = new System.Drawing.Point(254, 302);
            this.checkBoxNewUser.Name = "checkBoxNewUser";
            this.checkBoxNewUser.Size = new System.Drawing.Size(205, 30);
            this.checkBoxNewUser.TabIndex = 26;
            this.checkBoxNewUser.Text = "New user?\r\nSelect Check Box to Register, please.";
            this.checkBoxNewUser.UseVisualStyleBackColor = true;
            this.checkBoxNewUser.CheckedChanged += new System.EventHandler(this.checkBoxNewUser_CheckedChanged);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(302, 370);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(115, 35);
            this.buttonContinue.TabIndex = 25;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
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
            this.user_dataBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.user_dataBindingNavigator.TabIndex = 27;
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
            // 
            // scheduled_appointment_dataBindingSource
            // 
            this.scheduled_appointment_dataBindingSource.DataMember = "scheduled_appointment_data";
            this.scheduled_appointment_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // scheduled_appointment_dataTableAdapter
            // 
            this.scheduled_appointment_dataTableAdapter.ClearBeforeFill = true;
            // 
            // LoggingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.user_dataBindingNavigator);
            this.Controls.Add(this.groupBoxLoginInformation);
            this.Controls.Add(this.labelPleaseLogin);
            this.Controls.Add(this.checkBoxNewUser);
            this.Controls.Add(this.buttonContinue);
            this.Name = "LoggingIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.LoggingIn_Load);
            this.groupBoxLoginInformation.ResumeLayout(false);
            this.groupBoxLoginInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingNavigator)).EndInit();
            this.user_dataBindingNavigator.ResumeLayout(false);
            this.user_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoginInformation;
        private System.Windows.Forms.Label labelPleaseLogin;
        private System.Windows.Forms.CheckBox checkBoxNewUser;
        private System.Windows.Forms.Button buttonContinue;
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
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.BindingSource scheduled_appointment_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter scheduled_appointment_dataTableAdapter;
    }
}