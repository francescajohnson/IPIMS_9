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
    public partial class ViewAppointments : Form
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }

        private void scheduled_appointment_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduled_appointment_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void ViewAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.scheduled_appointment_data' table. You can move, or remove it, as needed.
            //this.scheduled_appointment_dataTableAdapter.Fill(this.iPIMS_9DataSet.scheduled_appointment_data);
            //this.scheduled_appointment_dataTableAdapter.FillViewAppointmentBy(this.iPIMS_9DataSet.scheduled_appointment_data);
        }

        private void checkBoxPatient_CheckedChanged(object sender, EventArgs e)
        {
            
                checkBoxDoctor.Checked = false;
            
            first_NameTextBox.Visible = true;
            last_NameTextBox.Visible = true;
            date_of_BirthDateTimePicker.Visible = true;

            first_NameLabel.Visible = true;
            last_NameLabel.Visible = true;
            doctor_NameComboBox.Visible = false;
            doctor_Namelabel.Visible = false;
            Dob_Label.Visible = true; 

        }

        private void checkBoxDoctor_CheckedChanged(object sender, EventArgs e)
        {

               checkBoxPatient.Checked = false;
           
         
            doctor_NameComboBox.Visible = true;
            doctor_Namelabel.Visible = true;
            first_NameTextBox.Visible = false;
          last_NameTextBox.Visible = false;
          date_of_BirthDateTimePicker.Visible = false;

          first_NameLabel.Visible = false;
          last_NameLabel.Visible = false;
          Dob_Label.Visible = false;
         
            
        }

        private void doctor_NameLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
