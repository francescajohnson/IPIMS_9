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
    public partial class UpdateHealthcareCondition : Form
    {
        public UpdateHealthcareCondition()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxDateOfBirth.Text = "";
            textBoxSymptoms.Text = "";
            checkBoxBloodUrine.Checked = false;
            checkBoxChestPains.Checked = false;
            checkBoxSuicide.Checked = false;
            checkBoxTenderness.Checked = false;
            checkBoxWeakness.Checked = false;
            checkBoxWheezing.Checked = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxSymptoms.Text != "")
            {
                MessageBox.Show("Thank you for updating the health conditions.");
                MessageBox.Show("The symptoms have been saved.");
                if (checkBoxWeakness.Checked || checkBoxChestPains.Checked || checkBoxTenderness.Checked || checkBoxBloodUrine.Checked || checkBoxWheezing.Checked || checkBoxSuicide.Checked)
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
            }
        }
    }
}
