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
    public partial class PatientSearch : Form
    {
        public PatientSearch()
        {
            InitializeComponent();
        }

        private void patient_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patient_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void PatientSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.scheduled_appointment_data' table. You can move, or remove it, as needed.
           // this.scheduled_appointment_dataTableAdapter.Fill(this.iPIMS_9DataSet.scheduled_appointment_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.user_data' table. You can move, or remove it, as needed.
          // this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.patient_data' table. You can move, or remove it, as needed.
          //  this.patient_dataTableAdapter.Fill(this.iPIMS_9DataSet.patient_data);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string SearchString1stName;
            string SearchStringLastName;
            DateTime dataOfBirth;
            //this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);
            //this.user_dataTableAdapter.PatientSearchFill(this.iPIMS_9DataSet.user_data);
            
            if (this.first_NameTextBox.Text == "")
            {
                return;

            }
            if (this.last_NameTextBox.Text == "")
            {
                return;

            }
            if (this.date_of_BirthDateTimePicker.Text == "")
            {
                return;

            }
            SearchString1stName = this.first_NameTextBox.Text;
            SearchStringLastName = this.last_NameTextBox.Text;
            //  this.user_dataTableAdapter.PatientSearchFill(this.iPIMS_9DataSet.user_data);
           // this.user_dataTableAdapter.PatientSearchFill(this.iPIMS_9DataSet.patient_data);
            //dataOfBirth = this.date_of_BirthDateTimePicker.Text;
            //first_name = first_NameTextBox.Text;
            //last_name = last_NameTextBox.Text;
            //date_of_birth = date_of_BirthDateTimePicker.Value.Date;
        }
    }
}
