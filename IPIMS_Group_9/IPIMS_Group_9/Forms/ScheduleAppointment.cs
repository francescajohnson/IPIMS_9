using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

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
            string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=K:\Kavita\ASU\CSE 360 SE\Project\IPIMS_Group_9 Table Adapter\IPIMS_9-master\IPIMS_9-master\IPIMS_Group_9\IPIMS_Group_9\IPIMS_9.mdf;Integrated Security=True");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO scheduled_appointment_data (Patient_Id,First_Name, Last_Name,Date_of_Birth, Symptoms, Appointment_Date) VALUES (@Patient_Id, @First_Name, @Last_Name, @Date_of_Birth, @Symptoms, @Appointment_Date)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                
                cmd.Parameters.AddWithValue("@First_Name", first_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Last_Name", last_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Patient_Id", patient_IdTextBox.Text);
                cmd.Parameters.AddWithValue("@Date_of_Birth", date_of_BirthDateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Symptoms", symptomsTextBox.Text);
                cmd.Parameters.AddWithValue("@Appointment_Date", appointment_DateDateTimePicker.Value.Date);
               // cmd.Parameters.AddWithValue("@Has_Weakness", has_WeaknessCheckBox.text);
                //cmd.Parameters.AddWithValue("@Appointment_Time", appointment_TimeDateTimePicker.Text);
                connection.Open();
                cmd.ExecuteNonQuery();

            }
                //  cmd.Parameters.AddWithValue("@Prescription_Date", prescription_DateDateTimePicker.Value.Date);
                // cmd.Parameters.AddWithValue("@Dosage", dosageTextBox.Text);
                //cmd.Parameters.AddWithValue("@Medicine_Name", medicine_NameTextBox.Text);
                //cmd.Parameters.AddWithValue("@Quantity", quantityTextBox.Text);
                // cmd.Parameters.AddWithValue("@Lab_Description", lab_DescriptionTextBox.Text);
                //cmd.Parameters.AddWithValue("@Doctor_Name", doctor_NameTextBox.Text);
                //cmd.Parameters.AddWithValue("@Instruction", instructionTextBox.Text);


             
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

        private void symptomsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScheduleAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.patient_data' table. You can move, or remove it, as needed.
          //  this.patient_dataTableAdapter.Fill(this.iPIMS_9DataSet.patient_data);

        }
    }
}

