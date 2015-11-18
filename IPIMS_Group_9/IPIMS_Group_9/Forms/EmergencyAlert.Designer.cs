namespace IPIMS_Group_9.Forms
{
    partial class EmergencyAlert
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
            this.date_of_BirthLabel = new System.Windows.Forms.Label();
            this.last_NameLabel = new System.Windows.Forms.Label();
            this.first_NameLabel = new System.Windows.Forms.Label();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.has_Blood_in_UrineLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.has_WeaknessCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Chest_PainsCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Leg_PainCheckBox = new System.Windows.Forms.CheckBox();
            this.has_Blood_in_UrineCheckBox = new System.Windows.Forms.CheckBox();
            this.is_WheezingCheckBox = new System.Windows.Forms.CheckBox();
            this.is_SuicidalCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEmergencyAlert = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_of_BirthLabel
            // 
            this.date_of_BirthLabel.AutoSize = true;
            this.date_of_BirthLabel.Location = new System.Drawing.Point(391, 103);
            this.date_of_BirthLabel.Name = "date_of_BirthLabel";
            this.date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            this.date_of_BirthLabel.TabIndex = 59;
            this.date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // last_NameLabel
            // 
            this.last_NameLabel.AutoSize = true;
            this.last_NameLabel.Location = new System.Drawing.Point(198, 103);
            this.last_NameLabel.Name = "last_NameLabel";
            this.last_NameLabel.Size = new System.Drawing.Size(61, 13);
            this.last_NameLabel.TabIndex = 57;
            this.last_NameLabel.Text = "Last Name:";
            // 
            // first_NameLabel
            // 
            this.first_NameLabel.AutoSize = true;
            this.first_NameLabel.Location = new System.Drawing.Point(18, 103);
            this.first_NameLabel.Name = "first_NameLabel";
            this.first_NameLabel.Size = new System.Drawing.Size(60, 13);
            this.first_NameLabel.TabIndex = 55;
            this.first_NameLabel.Text = "First Name:";
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Location = new System.Drawing.Point(20, 156);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(58, 13);
            this.symptomsLabel.TabIndex = 54;
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // has_Blood_in_UrineLabel
            // 
            this.has_Blood_in_UrineLabel.AutoSize = true;
            this.has_Blood_in_UrineLabel.Location = new System.Drawing.Point(233, 69);
            this.has_Blood_in_UrineLabel.Name = "has_Blood_in_UrineLabel";
            this.has_Blood_in_UrineLabel.Size = new System.Drawing.Size(0, 26);
            this.has_Blood_in_UrineLabel.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.has_WeaknessCheckBox);
            this.groupBox1.Controls.Add(this.has_Chest_PainsCheckBox);
            this.groupBox1.Controls.Add(this.has_Leg_PainCheckBox);
            this.groupBox1.Controls.Add(this.has_Blood_in_UrineLabel);
            this.groupBox1.Controls.Add(this.has_Blood_in_UrineCheckBox);
            this.groupBox1.Controls.Add(this.is_WheezingCheckBox);
            this.groupBox1.Controls.Add(this.is_SuicidalCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 232);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emergency Alert Conditions Include:";
            // 
            // has_WeaknessCheckBox
            // 
            this.has_WeaknessCheckBox.Location = new System.Drawing.Point(37, 158);
            this.has_WeaknessCheckBox.Name = "has_WeaknessCheckBox";
            this.has_WeaknessCheckBox.Size = new System.Drawing.Size(146, 35);
            this.has_WeaknessCheckBox.TabIndex = 74;
            this.has_WeaknessCheckBox.Text = "Weakness";
            this.has_WeaknessCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Chest_PainsCheckBox
            // 
            this.has_Chest_PainsCheckBox.Location = new System.Drawing.Point(189, 101);
            this.has_Chest_PainsCheckBox.Name = "has_Chest_PainsCheckBox";
            this.has_Chest_PainsCheckBox.Size = new System.Drawing.Size(149, 38);
            this.has_Chest_PainsCheckBox.TabIndex = 73;
            this.has_Chest_PainsCheckBox.Text = "Chest Pain";
            this.has_Chest_PainsCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Leg_PainCheckBox
            // 
            this.has_Leg_PainCheckBox.Location = new System.Drawing.Point(189, 52);
            this.has_Leg_PainCheckBox.Name = "has_Leg_PainCheckBox";
            this.has_Leg_PainCheckBox.Size = new System.Drawing.Size(102, 34);
            this.has_Leg_PainCheckBox.TabIndex = 72;
            this.has_Leg_PainCheckBox.Text = "Leg Pain";
            this.has_Leg_PainCheckBox.UseVisualStyleBackColor = true;
            // 
            // has_Blood_in_UrineCheckBox
            // 
            this.has_Blood_in_UrineCheckBox.Location = new System.Drawing.Point(189, 156);
            this.has_Blood_in_UrineCheckBox.Name = "has_Blood_in_UrineCheckBox";
            this.has_Blood_in_UrineCheckBox.Size = new System.Drawing.Size(275, 37);
            this.has_Blood_in_UrineCheckBox.TabIndex = 71;
            this.has_Blood_in_UrineCheckBox.Text = "Urinary Concerns";
            this.has_Blood_in_UrineCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_WheezingCheckBox
            // 
            this.is_WheezingCheckBox.Location = new System.Drawing.Point(37, 101);
            this.is_WheezingCheckBox.Name = "is_WheezingCheckBox";
            this.is_WheezingCheckBox.Size = new System.Drawing.Size(150, 34);
            this.is_WheezingCheckBox.TabIndex = 70;
            this.is_WheezingCheckBox.Text = "Wheezing";
            this.is_WheezingCheckBox.UseVisualStyleBackColor = true;
            // 
            // is_SuicidalCheckBox
            // 
            this.is_SuicidalCheckBox.Location = new System.Drawing.Point(37, 52);
            this.is_SuicidalCheckBox.Name = "is_SuicidalCheckBox";
            this.is_SuicidalCheckBox.Size = new System.Drawing.Size(134, 34);
            this.is_SuicidalCheckBox.TabIndex = 68;
            this.is_SuicidalCheckBox.Text = "Suicidal";
            this.is_SuicidalCheckBox.UseVisualStyleBackColor = true;
            this.is_SuicidalCheckBox.CheckedChanged += new System.EventHandler(this.is_SuicidalCheckBox_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(463, 461);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 35);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEmergencyAlert
            // 
            this.labelEmergencyAlert.AutoSize = true;
            this.labelEmergencyAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmergencyAlert.Location = new System.Drawing.Point(12, 44);
            this.labelEmergencyAlert.Name = "labelEmergencyAlert";
            this.labelEmergencyAlert.Size = new System.Drawing.Size(408, 36);
            this.labelEmergencyAlert.TabIndex = 46;
            this.labelEmergencyAlert.Text = "Send Doctor Emergency Alert";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(463, 264);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 35);
            this.buttonClear.TabIndex = 50;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(466, 100);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.date_of_BirthDateTimePicker.TabIndex = 61;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.Location = new System.Drawing.Point(265, 100);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 60;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Location = new System.Drawing.Point(83, 100);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 58;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(83, 156);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(463, 87);
            this.symptomsTextBox.TabIndex = 56;
            // 
            // EmergencyAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(this.last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(this.first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEmergencyAlert);
            this.Controls.Add(this.buttonClear);
            this.Name = "EmergencyAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.Load += new System.EventHandler(this.EmergencyAlert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEmergencyAlert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.CheckBox has_WeaknessCheckBox;
        private System.Windows.Forms.CheckBox has_Chest_PainsCheckBox;
        private System.Windows.Forms.CheckBox has_Leg_PainCheckBox;
        private System.Windows.Forms.CheckBox has_Blood_in_UrineCheckBox;
        private System.Windows.Forms.CheckBox is_WheezingCheckBox;
        private System.Windows.Forms.CheckBox is_SuicidalCheckBox;
        private System.Windows.Forms.Label date_of_BirthLabel;
        private System.Windows.Forms.Label last_NameLabel;
        private System.Windows.Forms.Label first_NameLabel;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.Label has_Blood_in_UrineLabel;
    }
}