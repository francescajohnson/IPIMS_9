﻿namespace IPIMS_Group_9.Forms
{
    partial class ViewAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointments));
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            this.tabPageUpcomingAppointments = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePastAppointments = new System.Windows.Forms.TabPage();
            this.labelViewAppointment = new System.Windows.Forms.Label();
            this.groupBoxPatientInformation = new System.Windows.Forms.GroupBox();
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.patient_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.patient_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.patient_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.patient_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.groupBoxPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingNavigator)).BeginInit();
            this.patient_dataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUpcomingAppointments
            // 
            this.tabPageUpcomingAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpcomingAppointments.Name = "tabPageUpcomingAppointments";
            this.tabPageUpcomingAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpcomingAppointments.Size = new System.Drawing.Size(562, 297);
            this.tabPageUpcomingAppointments.TabIndex = 0;
            this.tabPageUpcomingAppointments.Text = "Upcoming Appointments";
            this.tabPageUpcomingAppointments.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUpcomingAppointments);
            this.tabControl1.Controls.Add(this.tabPagePastAppointments);
            this.tabControl1.Location = new System.Drawing.Point(12, 167);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 323);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPagePastAppointments
            // 
            this.tabPagePastAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPagePastAppointments.Name = "tabPagePastAppointments";
            this.tabPagePastAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePastAppointments.Size = new System.Drawing.Size(562, 401);
            this.tabPagePastAppointments.TabIndex = 1;
            this.tabPagePastAppointments.Text = "Past Appointments";
            this.tabPagePastAppointments.UseVisualStyleBackColor = true;
            // 
            // labelViewAppointment
            // 
            this.labelViewAppointment.AutoSize = true;
            this.labelViewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAppointment.Location = new System.Drawing.Point(12, 30);
            this.labelViewAppointment.Name = "labelViewAppointment";
            this.labelViewAppointment.Size = new System.Drawing.Size(272, 36);
            this.labelViewAppointment.TabIndex = 35;
            this.labelViewAppointment.Text = "View Appointments";
            // 
            // groupBoxPatientInformation
            // 
            this.groupBoxPatientInformation.Controls.Add(date_of_BirthLabel);
            this.groupBoxPatientInformation.Controls.Add(this.date_of_BirthDateTimePicker);
            this.groupBoxPatientInformation.Controls.Add(last_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.last_NameTextBox);
            this.groupBoxPatientInformation.Controls.Add(first_NameLabel);
            this.groupBoxPatientInformation.Controls.Add(this.first_NameTextBox);
            this.groupBoxPatientInformation.Location = new System.Drawing.Point(12, 69);
            this.groupBoxPatientInformation.Name = "groupBoxPatientInformation";
            this.groupBoxPatientInformation.Size = new System.Drawing.Size(564, 94);
            this.groupBoxPatientInformation.TabIndex = 38;
            this.groupBoxPatientInformation.TabStop = false;
            this.groupBoxPatientInformation.Text = "Patient Information:";
            // 
            // iPIMS_9DataSet
            // 
            this.iPIMS_9DataSet.DataSetName = "IPIMS_9DataSet";
            this.iPIMS_9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_dataBindingSource
            // 
            this.patient_dataBindingSource.DataMember = "patient_data";
            this.patient_dataBindingSource.DataSource = this.iPIMS_9DataSet;
            // 
            // patient_dataTableAdapter
            // 
            this.patient_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.e_prescription_dataTableAdapter = null;
            this.tableAdapterManager.patient_dataTableAdapter = this.patient_dataTableAdapter;
            this.tableAdapterManager.scheduled_appointment_dataTableAdapter = null;
            this.tableAdapterManager.update_healthcare_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_dataTableAdapter = null;
            // 
            // patient_dataBindingNavigator
            // 
            this.patient_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patient_dataBindingNavigator.BindingSource = this.patient_dataBindingSource;
            this.patient_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patient_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patient_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patient_dataBindingNavigatorSaveItem});
            this.patient_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patient_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patient_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patient_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patient_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patient_dataBindingNavigator.Name = "patient_dataBindingNavigator";
            this.patient_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patient_dataBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.patient_dataBindingNavigator.TabIndex = 39;
            this.patient_dataBindingNavigator.Text = "bindingNavigator1";
            this.patient_dataBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // patient_dataBindingNavigatorSaveItem
            // 
            this.patient_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patient_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patient_dataBindingNavigatorSaveItem.Image")));
            this.patient_dataBindingNavigatorSaveItem.Name = "patient_dataBindingNavigatorSaveItem";
            this.patient_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.patient_dataBindingNavigatorSaveItem.Text = "Save Data";
            this.patient_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.patient_dataBindingNavigatorSaveItem_Click);
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(9, 22);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 0;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_dataBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(75, 19);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 1;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(214, 22);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 2;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_dataBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(281, 19);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 3;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(12, 59);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 4;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patient_dataBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(87, 55);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(511, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 35);
            this.buttonSearch.TabIndex = 40;
            this.buttonSearch.Text = "View";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.patient_dataBindingNavigator);
            this.Controls.Add(this.groupBoxPatientInformation);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelViewAppointment);
            this.Name = "ViewAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.ViewAppointments_Load);
            this.tabControl1.ResumeLayout(false);
            this.groupBoxPatientInformation.ResumeLayout(false);
            this.groupBoxPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingNavigator)).EndInit();
            this.patient_dataBindingNavigator.ResumeLayout(false);
            this.patient_dataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUpcomingAppointments;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePastAppointments;
        private System.Windows.Forms.Label labelViewAppointment;
        private System.Windows.Forms.GroupBox groupBoxPatientInformation;
        private IPIMS_9DataSet iPIMS_9DataSet;
        private System.Windows.Forms.BindingSource patient_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.patient_dataTableAdapter patient_dataTableAdapter;
        private IPIMS_9DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patient_dataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patient_dataBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.Button buttonSearch;
    }
}