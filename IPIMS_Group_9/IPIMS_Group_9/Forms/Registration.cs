using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPIMS_Group_9.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string message = "Would you like to login as this user now?";
            string title = "Do you want to Login as this newly registered user?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Register user and then show the LoggingIn form
                this.Validate();
                this.user_dataBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.group9_ipimsDataSet);
                this.user_dataTableAdapter.Fill(this.group9_ipimsDataSet.user_data);
                this.Hide();
                LoggingIn formLI = new LoggingIn();
                formLI.Visible = true;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                // Register user and then show the Welcome form
                this.Validate();
                this.user_dataBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.group9_ipimsDataSet);
                this.user_dataTableAdapter.Fill(this.group9_ipimsDataSet.user_data);
                this.Hide();
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                // Do Nothing, and return to registration form
            }
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.group9_ipimsDataSet);
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group9_ipimsDataSet.user_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.group9_ipimsDataSet.user_data);
        }

        private void classificationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first_nameTextBox.SelectedText == "Patient")
            {
                this.labelIdNumber.Text = "Social Security Number:";
                this.labelIdNumber.Location = new Point(327, 49);
                groupBoxMedicalInformation.Visible = true;
            }
            else if (first_nameTextBox.SelectedText == "Doctor")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (first_nameTextBox.SelectedText == "Nurse")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (first_nameTextBox.SelectedText == "Office Staff")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (first_nameTextBox.SelectedText == "Lab Staff")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (first_nameTextBox.SelectedText == "Research Staff")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
        }

        private void user_dataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}