namespace IPIMS_Group_9.Forms
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
            this.tabPageUpcomingAppointments = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePastAppointments = new System.Windows.Forms.TabPage();
            this.labelViewAppointment = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUpcomingAppointments
            // 
            this.tabPageUpcomingAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpcomingAppointments.Name = "tabPageUpcomingAppointments";
            this.tabPageUpcomingAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpcomingAppointments.Size = new System.Drawing.Size(562, 401);
            this.tabPageUpcomingAppointments.TabIndex = 0;
            this.tabPageUpcomingAppointments.Text = "Upcoming Appointments";
            this.tabPageUpcomingAppointments.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUpcomingAppointments);
            this.tabControl1.Controls.Add(this.tabPagePastAppointments);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 427);
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
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelViewAppointment);
            this.Name = "ViewAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUpcomingAppointments;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePastAppointments;
        private System.Windows.Forms.Label labelViewAppointment;
    }
}