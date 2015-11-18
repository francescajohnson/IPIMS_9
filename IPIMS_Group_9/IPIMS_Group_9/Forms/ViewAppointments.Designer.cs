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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelViewAppointment = new System.Windows.Forms.Label();
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
            this.scheduled_appointment_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.scheduled_appointment_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.scheduled_appointment_dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelsearchAppointment = new System.Windows.Forms.Label();
            this.checkBoxPatient = new System.Windows.Forms.CheckBox();
            this.checkBoxDoctor = new System.Windows.Forms.CheckBox();
            this.doctor_NameComboBox = new System.Windows.Forms.ComboBox();
            this.doctor_Namelabel = new System.Windows.Forms.Label();
            this.first_NameLabel = new System.Windows.Forms.Label();
            this.last_NameLabel = new System.Windows.Forms.Label();
            this.Dob_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingNavigator)).BeginInit();
            this.scheduled_appointment_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // scheduled_appointment_dataBindingNavigator
            // 
            this.scheduled_appointment_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scheduled_appointment_dataBindingNavigator.BindingSource = this.scheduled_appointment_dataBindingSource;
            this.scheduled_appointment_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scheduled_appointment_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.scheduled_appointment_dataBindingNavigator.Size = new System.Drawing.Size(622, 25);
            this.scheduled_appointment_dataBindingNavigator.TabIndex = 36;
            this.scheduled_appointment_dataBindingNavigator.Text = "bindingNavigator1";
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
            // scheduled_appointment_dataBindingNavigatorSaveItem
            // 
            this.scheduled_appointment_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduled_appointment_dataBindingNavigatorSaveItem.Image")));
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Name = "scheduled_appointment_dataBindingNavigatorSaveItem";
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Text = "Save Data";
            this.scheduled_appointment_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.scheduled_appointment_dataBindingNavigatorSaveItem_Click);
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
            // scheduled_appointment_dataDataGridView
            // 
            this.scheduled_appointment_dataDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduled_appointment_dataDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scheduled_appointment_dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduled_appointment_dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.scheduled_appointment_dataDataGridView.DataSource = this.scheduled_appointment_dataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scheduled_appointment_dataDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.scheduled_appointment_dataDataGridView.Location = new System.Drawing.Point(11, 313);
            this.scheduled_appointment_dataDataGridView.Name = "scheduled_appointment_dataDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduled_appointment_dataDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.scheduled_appointment_dataDataGridView.Size = new System.Drawing.Size(591, 185);
            this.scheduled_appointment_dataDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_of_Birth";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_of_Birth";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Appointment_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Appointment_Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Appointment_Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "Appointment_Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Doctor_Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Doctor_Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Patient_Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Patient_Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(134, 115);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.first_NameTextBox.TabIndex = 37;
            this.first_NameTextBox.Visible = false;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(397, 115);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.last_NameTextBox.TabIndex = 38;
            this.last_NameTextBox.Visible = false;
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduled_appointment_dataBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(134, 156);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 39;
            this.date_of_BirthDateTimePicker.Visible = false;
            // 
            // labelsearchAppointment
            // 
            this.labelsearchAppointment.AutoSize = true;
            this.labelsearchAppointment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelsearchAppointment.Location = new System.Drawing.Point(55, 87);
            this.labelsearchAppointment.Name = "labelsearchAppointment";
            this.labelsearchAppointment.Size = new System.Drawing.Size(118, 13);
            this.labelsearchAppointment.TabIndex = 40;
            this.labelsearchAppointment.Text = "Search Appointment By";
            // 
            // checkBoxPatient
            // 
            this.checkBoxPatient.AutoSize = true;
            this.checkBoxPatient.Location = new System.Drawing.Point(206, 87);
            this.checkBoxPatient.Name = "checkBoxPatient";
            this.checkBoxPatient.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPatient.TabIndex = 41;
            this.checkBoxPatient.Text = "Patient";
            this.checkBoxPatient.UseVisualStyleBackColor = true;
            this.checkBoxPatient.CheckedChanged += new System.EventHandler(this.checkBoxPatient_CheckedChanged);
            // 
            // checkBoxDoctor
            // 
            this.checkBoxDoctor.AutoSize = true;
            this.checkBoxDoctor.Location = new System.Drawing.Point(317, 87);
            this.checkBoxDoctor.Name = "checkBoxDoctor";
            this.checkBoxDoctor.Size = new System.Drawing.Size(58, 17);
            this.checkBoxDoctor.TabIndex = 42;
            this.checkBoxDoctor.Text = "Doctor";
            this.checkBoxDoctor.UseVisualStyleBackColor = true;
            this.checkBoxDoctor.CheckedChanged += new System.EventHandler(this.checkBoxDoctor_CheckedChanged);
            // 
            // doctor_NameComboBox
            // 
            this.doctor_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduled_appointment_dataBindingSource, "Doctor_Name", true));
            this.doctor_NameComboBox.FormattingEnabled = true;
            this.doctor_NameComboBox.Location = new System.Drawing.Point(143, 115);
            this.doctor_NameComboBox.Name = "doctor_NameComboBox";
            this.doctor_NameComboBox.Size = new System.Drawing.Size(150, 21);
            this.doctor_NameComboBox.TabIndex = 45;
            this.doctor_NameComboBox.Visible = false;
            // 
            // doctor_Namelabel
            // 
            this.doctor_Namelabel.AutoSize = true;
            this.doctor_Namelabel.Location = new System.Drawing.Point(59, 118);
            this.doctor_Namelabel.Name = "doctor_Namelabel";
            this.doctor_Namelabel.Size = new System.Drawing.Size(73, 13);
            this.doctor_Namelabel.TabIndex = 46;
            this.doctor_Namelabel.Text = "Doctor Name:";
            this.doctor_Namelabel.Visible = false;
            // 
            // first_NameLabel
            // 
            this.first_NameLabel.AutoSize = true;
            this.first_NameLabel.Location = new System.Drawing.Point(55, 118);
            this.first_NameLabel.Name = "first_NameLabel";
            this.first_NameLabel.Size = new System.Drawing.Size(60, 13);
            this.first_NameLabel.TabIndex = 47;
            this.first_NameLabel.Text = "First Name:";
            this.first_NameLabel.Visible = false;
            // 
            // last_NameLabel
            // 
            this.last_NameLabel.AutoSize = true;
            this.last_NameLabel.Location = new System.Drawing.Point(315, 118);
            this.last_NameLabel.Name = "last_NameLabel";
            this.last_NameLabel.Size = new System.Drawing.Size(61, 13);
            this.last_NameLabel.TabIndex = 48;
            this.last_NameLabel.Text = "Last Name:";
            this.last_NameLabel.Visible = false;
            // 
            // Dob_Label
            // 
            this.Dob_Label.AutoSize = true;
            this.Dob_Label.Location = new System.Drawing.Point(55, 162);
            this.Dob_Label.Name = "Dob_Label";
            this.Dob_Label.Size = new System.Drawing.Size(69, 13);
            this.Dob_Label.TabIndex = 49;
            this.Dob_Label.Text = "Date of Birth:";
            this.Dob_Label.Visible = false;
            // 
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.Dob_Label);
            this.Controls.Add(this.last_NameLabel);
            this.Controls.Add(this.first_NameLabel);
            this.Controls.Add(this.doctor_Namelabel);
            this.Controls.Add(this.doctor_NameComboBox);
            this.Controls.Add(this.checkBoxDoctor);
            this.Controls.Add(this.checkBoxPatient);
            this.Controls.Add(this.labelsearchAppointment);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.scheduled_appointment_dataDataGridView);
            this.Controls.Add(this.scheduled_appointment_dataBindingNavigator);
            this.Controls.Add(this.labelViewAppointment);
            this.Name = "ViewAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.ViewAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingNavigator)).EndInit();
            this.scheduled_appointment_dataBindingNavigator.ResumeLayout(false);
            this.scheduled_appointment_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewAppointment;
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
        private System.Windows.Forms.DataGridView scheduled_appointment_dataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.Label labelsearchAppointment;
        private System.Windows.Forms.CheckBox checkBoxPatient;
        private System.Windows.Forms.CheckBox checkBoxDoctor;
        private System.Windows.Forms.ComboBox doctor_NameComboBox;
        private System.Windows.Forms.Label doctor_Namelabel;
        private System.Windows.Forms.Label first_NameLabel;
        private System.Windows.Forms.Label last_NameLabel;
        private System.Windows.Forms.Label Dob_Label;
    }
}