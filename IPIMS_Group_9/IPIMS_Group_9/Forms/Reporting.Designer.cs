namespace IPIMS_Group_9.Forms
{
    partial class Reporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporting));
            this.tabPageHealthOutcomes = new System.Windows.Forms.TabPage();
            this.scheduled_appointment_dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patient_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPIMS_9DataSet = new IPIMS_Group_9.IPIMS_9DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdmissionRates = new System.Windows.Forms.TabPage();
            this.tabPageTypePatients = new System.Windows.Forms.TabPage();
            this.tabPagePatientPopulations = new System.Windows.Forms.TabPage();
            this.labelViewReports = new System.Windows.Forms.Label();
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
            this.user_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.user_dataTableAdapter();
            this.tableAdapterManager = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.TableAdapterManager();
            this.patient_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.patient_dataTableAdapter();
            this.scheduled_appointment_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduled_appointment_dataTableAdapter = new IPIMS_Group_9.IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPageHealthOutcomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAdmissionRates.SuspendLayout();
            this.tabPageTypePatients.SuspendLayout();
            this.tabPagePatientPopulations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingNavigator)).BeginInit();
            this.user_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageHealthOutcomes
            // 
            this.tabPageHealthOutcomes.AutoScroll = true;
            this.tabPageHealthOutcomes.Controls.Add(this.dataGridView1);
            this.tabPageHealthOutcomes.Location = new System.Drawing.Point(8, 45);
            this.tabPageHealthOutcomes.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageHealthOutcomes.Name = "tabPageHealthOutcomes";
            this.tabPageHealthOutcomes.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageHealthOutcomes.Size = new System.Drawing.Size(1124, 778);
            this.tabPageHealthOutcomes.TabIndex = 0;
            this.tabPageHealthOutcomes.Text = "Health Outcomes";
            this.tabPageHealthOutcomes.UseVisualStyleBackColor = true;
            // 
            // scheduled_appointment_dataBindingSource1
            // 
            this.scheduled_appointment_dataBindingSource1.DataMember = "FK_patient_data_scheduled_appointment_data";
            this.scheduled_appointment_dataBindingSource1.DataSource = this.patient_dataBindingSource;
            // 
            // patient_dataBindingSource
            // 
            this.patient_dataBindingSource.DataMember = "FK_user_data_patient_data";
            this.patient_dataBindingSource.DataSource = this.user_dataBindingSource;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHealthOutcomes);
            this.tabControl1.Controls.Add(this.tabPageAdmissionRates);
            this.tabControl1.Controls.Add(this.tabPageTypePatients);
            this.tabControl1.Controls.Add(this.tabPagePatientPopulations);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 110);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 831);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPageAdmissionRates
            // 
            this.tabPageAdmissionRates.Controls.Add(this.dataGridView2);
            this.tabPageAdmissionRates.Location = new System.Drawing.Point(8, 45);
            this.tabPageAdmissionRates.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageAdmissionRates.Name = "tabPageAdmissionRates";
            this.tabPageAdmissionRates.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageAdmissionRates.Size = new System.Drawing.Size(1124, 778);
            this.tabPageAdmissionRates.TabIndex = 1;
            this.tabPageAdmissionRates.Text = "Admission Rates";
            this.tabPageAdmissionRates.UseVisualStyleBackColor = true;
            // 
            // tabPageTypePatients
            // 
            this.tabPageTypePatients.Controls.Add(this.dataGridView3);
            this.tabPageTypePatients.Location = new System.Drawing.Point(8, 45);
            this.tabPageTypePatients.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageTypePatients.Name = "tabPageTypePatients";
            this.tabPageTypePatients.Size = new System.Drawing.Size(1124, 778);
            this.tabPageTypePatients.TabIndex = 2;
            this.tabPageTypePatients.Text = "Type of Patients";
            this.tabPageTypePatients.UseVisualStyleBackColor = true;
            // 
            // tabPagePatientPopulations
            // 
            this.tabPagePatientPopulations.Controls.Add(this.dataGridView4);
            this.tabPagePatientPopulations.Location = new System.Drawing.Point(8, 45);
            this.tabPagePatientPopulations.Margin = new System.Windows.Forms.Padding(6);
            this.tabPagePatientPopulations.Name = "tabPagePatientPopulations";
            this.tabPagePatientPopulations.Size = new System.Drawing.Size(1124, 778);
            this.tabPagePatientPopulations.TabIndex = 3;
            this.tabPagePatientPopulations.Text = "Patient Populations";
            this.tabPagePatientPopulations.UseVisualStyleBackColor = true;
            // 
            // labelViewReports
            // 
            this.labelViewReports.AutoSize = true;
            this.labelViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewReports.Location = new System.Drawing.Point(24, 35);
            this.labelViewReports.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelViewReports.Name = "labelViewReports";
            this.labelViewReports.Size = new System.Drawing.Size(672, 67);
            this.labelViewReports.TabIndex = 38;
            this.labelViewReports.Text = "Research and Reporting";
            // 
            // user_dataBindingNavigator
            // 
            this.user_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user_dataBindingNavigator.BindingSource = this.user_dataBindingSource;
            this.user_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_dataBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
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
            this.user_dataBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.user_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user_dataBindingNavigator.Size = new System.Drawing.Size(1188, 48);
            this.user_dataBindingNavigator.TabIndex = 40;
            this.user_dataBindingNavigator.Text = "bindingNavigator1";
            this.user_dataBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 45);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 45);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // user_dataBindingNavigatorSaveItem
            // 
            this.user_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_dataBindingNavigatorSaveItem.Image")));
            this.user_dataBindingNavigatorSaveItem.Name = "user_dataBindingNavigatorSaveItem";
            this.user_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 45);
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
            // patient_dataTableAdapter
            // 
            this.patient_dataTableAdapter.ClearBeforeFill = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 760);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1120, 760);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(2, 9);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1120, 760);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(2, 9);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 33;
            this.dataGridView4.Size = new System.Drawing.Size(1120, 760);
            this.dataGridView4.TabIndex = 2;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 963);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelViewReports);
            this.Controls.Add(this.user_dataBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Reporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.Reporting_Load);
            this.tabPageHealthOutcomes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPIMS_9DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdmissionRates.ResumeLayout(false);
            this.tabPageTypePatients.ResumeLayout(false);
            this.tabPagePatientPopulations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_dataBindingNavigator)).EndInit();
            this.user_dataBindingNavigator.ResumeLayout(false);
            this.user_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduled_appointment_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageHealthOutcomes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdmissionRates;
        private System.Windows.Forms.TabPage tabPageTypePatients;
        private System.Windows.Forms.TabPage tabPagePatientPopulations;
        private System.Windows.Forms.Label labelViewReports;
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
        private System.Windows.Forms.BindingSource patient_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.patient_dataTableAdapter patient_dataTableAdapter;
        private System.Windows.Forms.BindingSource scheduled_appointment_dataBindingSource;
        private IPIMS_9DataSetTableAdapters.scheduled_appointment_dataTableAdapter scheduled_appointment_dataTableAdapter;
        private System.Windows.Forms.BindingSource scheduled_appointment_dataBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}