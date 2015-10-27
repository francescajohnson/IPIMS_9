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
            if (textBoxSymptoms.Text != "")
            {
                MessageBox.Show("The appointment has been scheduled and health conditions updated.");
                MessageBox.Show("The symptoms have been saved.");
               /* if (//checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked || checkBoxSuicide.Checked)
                {
                    MessageBox.Show("IPIMS will notify the healthcare provider with the severe conditions.");
                }
                if (checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked)
                {
                    MessageBox.Show("This is an emergency, an alert has been triggered to the available emergency doctor.");
                }*/
                if (checkBoxSuicide.Checked)
                {
                    MessageBox.Show("Please advise the patient to contact the National Suicide Prevention Line at 1(800)273-8255.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a description of the symptoms.");
            }
        }

        private void textBoxSymptoms_TextClicked(object sender, EventArgs e)
        {
            textBoxSymptoms.SelectAll();
        }

        private void textBoxFirstName_TextClicked(object sender, EventArgs e)
        {
            textBoxFirstName.SelectAll();
        }

        private void textBoxLastName_TextClicked(object sender, EventArgs e)
        {
            textBoxLastName.SelectAll();
        }

        private void textBoxDateOfBirth_TextClicked(object sender, EventArgs e)
        {
            textBoxDateOfBirth.SelectAll();
        }

        private void scheduled_appointment_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduled_appointment_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void ScheduleAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.scheduled_appointment_data' table. You can move, or remove it, as needed.
            this.scheduled_appointment_dataTableAdapter.Fill(this.iPIMS_9DataSet.scheduled_appointment_data);

        }
    }
}
