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
            this.groupBoxLoginInformation = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPleaseLogin = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.checkBoxNewUser = new System.Windows.Forms.CheckBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupBoxLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoginInformation
            // 
            this.groupBoxLoginInformation.Controls.Add(this.textBoxPassword);
            this.groupBoxLoginInformation.Controls.Add(this.labelPassword);
            this.groupBoxLoginInformation.Controls.Add(this.textBoxUsername);
            this.groupBoxLoginInformation.Controls.Add(this.labelUsername);
            this.groupBoxLoginInformation.Location = new System.Drawing.Point(217, 197);
            this.groupBoxLoginInformation.Name = "groupBoxLoginInformation";
            this.groupBoxLoginInformation.Size = new System.Drawing.Size(278, 84);
            this.groupBoxLoginInformation.TabIndex = 24;
            this.groupBoxLoginInformation.TabStop = false;
            this.groupBoxLoginInformation.Text = "Login Information:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(71, 46);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(201, 20);
            this.textBoxPassword.TabIndex = 7;
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
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(71, 17);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(201, 20);
            this.textBoxUsername.TabIndex = 4;
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
            // labelPleaseLogin
            // 
            this.labelPleaseLogin.AutoSize = true;
            this.labelPleaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPleaseLogin.Location = new System.Drawing.Point(103, 134);
            this.labelPleaseLogin.Name = "labelPleaseLogin";
            this.labelPleaseLogin.Size = new System.Drawing.Size(129, 17);
            this.labelPleaseLogin.TabIndex = 23;
            this.labelPleaseLogin.Text = "Please login below.";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(100, 98);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(138, 36);
            this.labelWelcome.TabIndex = 22;
            this.labelWelcome.Text = "Welcome";
            // 
            // checkBoxNewUser
            // 
            this.checkBoxNewUser.AutoSize = true;
            this.checkBoxNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNewUser.Location = new System.Drawing.Point(255, 287);
            this.checkBoxNewUser.Name = "checkBoxNewUser";
            this.checkBoxNewUser.Size = new System.Drawing.Size(205, 30);
            this.checkBoxNewUser.TabIndex = 26;
            this.checkBoxNewUser.Text = "New user?\r\nSelect Check Box to Register, please.";
            this.checkBoxNewUser.UseVisualStyleBackColor = true;
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
            // 
            // LoggingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 502);
            this.Controls.Add(this.groupBoxLoginInformation);
            this.Controls.Add(this.labelPleaseLogin);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.checkBoxNewUser);
            this.Controls.Add(this.buttonContinue);
            this.Name = "LoggingIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Patient Information System (IPIMS) - Group 9";
            this.groupBoxLoginInformation.ResumeLayout(false);
            this.groupBoxLoginInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoginInformation;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPleaseLogin;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.CheckBox checkBoxNewUser;
        private System.Windows.Forms.Button buttonContinue;
    }
}