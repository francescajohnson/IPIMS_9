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
    public partial class EmergencyAlert : Form
    {
        public EmergencyAlert()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
       /*     if (textBoxSymptoms.Text != "")
            {
                MessageBox.Show("Our staff will contact you, as soon as possible.");
                MessageBox.Show("Thank you for updating your health conditions.");
                MessageBox.Show("The symptoms have been saved.");
                if (checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked || checkBoxSuicide.Checked)
                {
                    MessageBox.Show("IPIMS will notify the healthcare provider with your severe condition and symptoms.");
                }
                if (checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked)
                {
                    MessageBox.Show("This is an emergency, an alert has been triggered to the available emergency doctor.");
                }
                if (checkBoxSuicide.Checked)
                {
                    MessageBox.Show("Please contact the National Suicide Prevention Line at 1(800)273-8255.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a description of the symptoms.");
            }*/
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            first_NameTextBox.Text = "";
            last_NameTextBox.Text = "";
            date_of_BirthDateTimePicker.Value = DateTime.Today;
            symptomsTextBox.Text = "";
            has_Blood_in_UrineCheckBox.Checked = false;
            has_Chest_PainsCheckBox.Checked = false;
            is_SuicidalCheckBox.Checked = false;
            has_Leg_PainCheckBox.Checked = false;
            has_WeaknessCheckBox.Checked = false;
            is_WheezingCheckBox.Checked = false;
        }

        private void EmergencyAlert_Load(object sender, EventArgs e)
        {

        }

        private void is_SuicidalCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
