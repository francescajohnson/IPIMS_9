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
    public partial class Welcome : Form
    {
        private string username;
        public Welcome(string username)
        {
            InitializeComponent();
            username = username;
        }
        //
        //Menu Items
        //
        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateHealthcareCondition formUHC = new UpdateHealthcareCondition();
            formUHC.Visible = true;
        }
        private void searchForPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmergencyAlert formEA = new EmergencyAlert();
            formEA.Visible = true;
        }
        private void viewApptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAppointments formVA = new ViewAppointments();
            formVA.Visible = true;
        }
        private void createNewEPrescribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }
        private void scheduleApptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleAppointment formSA = new ScheduleAppointment();
            formSA.Visible = true;
        }
        private void viewExistingEPrescribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }
        private void editExistingEPrescribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }
        private void printExistingEPrescribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }
        private void viewPatientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPatientInformation formVPI = new ViewPatientInformation();
            formVPI.Visible = true;
        }
        private void searchRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }

        private void editLabRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }

        private void editLabRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile formEditP = new EditProfile();
            formEditP.Visible = true;
        }

        private void logoutOfIPIMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to logout of the system at this time?";
            string title = "Confirm Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message,title,buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Logout of system

            }
            else if(result == System.Windows.Forms.DialogResult.No)
            {
                //Do Nothing
            }

        }




    }
}
