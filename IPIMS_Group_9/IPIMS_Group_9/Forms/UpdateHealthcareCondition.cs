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
        string first_name, last_name, symptoms;
        bool blood_in_urine, chest_pains, suicidal, leg_pain, weakness, wheezing;
        private DateTime date_of_birth;

        public UpdateHealthcareCondition()
        {
            InitializeComponent();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            first_name = first_NameTextBox.Text;
            last_name = last_NameTextBox.Text;
            date_of_birth = date_of_BirthDateTimePicker.Value.Date;
            symptoms = symptomsTextBox.Text;
            blood_in_urine = has_Blood_in_UrineCheckBox.Checked;
            chest_pains = has_Chest_PainsCheckBox.Checked;
            suicidal = is_SuicidalCheckBox.Checked;
            leg_pain = has_Chest_PainsCheckBox.Checked;
            weakness = has_WeaknessCheckBox.Checked;
            wheezing = is_WheezingCheckBox.Checked;

          
            /*
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
            }*/
        }

        private void groupBoxPersonalInformation_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateHealthcareCondition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.update_healthcare_data' table. You can move, or remove it, as needed.
            this.update_healthcare_dataTableAdapter.Fill(this.iPIMS_9DataSet.update_healthcare_data);

        }

        private void symptomsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
