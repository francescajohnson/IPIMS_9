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
    public partial class ScheduleAppointment : Form
    {
        public ScheduleAppointment()
        {
            InitializeComponent();
        }
       

 

        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            Xdb.AddX(textBox1.Text, textBox2.Text);
          MessageBox.Show("The appointment has been scheduled");
            /*
            if (textBoxSymptoms.Text != "")
            {
                MessageBox.Show("The appointment has been scheduled and health conditions updated.");
                MessageBox.Show("The symptoms have been saved.");
                if (//checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked || checkBoxSuicide.Checked)
                {
                    MessageBox.Show("IPIMS will notify the healthcare provider with the severe conditions.");
                }
                if (checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked)
                {
                    MessageBox.Show("This is an emergency, an alert has been triggered to the available emergency doctor.");
                }
                if (checkBoxSuicide.Checked)
                {
                    MessageBox.Show("Please advise the patient to contact the National Suicide Prevention Line at 1(800)273-8255.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a description of the symptoms.");
            }*/
           
           
        }
    

        private void searchForPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmergencyAlert formEA = new EmergencyAlert();
            formEA.Visible = true;
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateHealthcareCondition formUHC = new UpdateHealthcareCondition();
            formUHC.Visible = true;
        }

        private void viewApptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAppointments formVA = new ViewAppointments();
            formVA.Visible = true;
        }

        private void scheduleApptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleAppointment formSA = new ScheduleAppointment();
            formSA.Visible = true;
        }

        private void createNewEPrescribeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPrescription formEP = new EPrescription();
            formEP.Visible = true;
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

        private void editProfileInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting formR = new Reporting();
            formR.Visible = true;
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting formR = new Reporting();
            formR.Visible = true;
        }

        private void analysisOfTypeOfPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting formR = new Reporting();
            formR.Visible = true;
        }

        private void analysisOfPatientPopulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting formR = new Reporting();
            formR.Visible = true;
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProfile formEP = new EditProfile();
            formEP.Visible = true;
        }

        private void logoutOfIPIMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to logout of the system at this time?";
            string title = "Confirm Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                LoggingIn formLI = new LoggingIn();
                formLI.Visible = true;

            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                //Do Nothing
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        
    }
    
}
