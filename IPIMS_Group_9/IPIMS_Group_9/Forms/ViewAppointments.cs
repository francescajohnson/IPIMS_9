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
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.patient_data' table. You can move, or remove it, as needed.
            //this.patient_dataTableAdapter.Fill(this.iPIMS_9DataSet.patient_data);
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
            SearchPat.Visible = true;
            first_NameLabel.Visible = true;
            last_NameLabel.Visible = true;
            doctor_NameComboBox.Visible = false;
            doctor_Namelabel.Visible = false;
            Dob_Label.Visible = true;
            SearchDoc.Visible = false;
            scheduled_appointment_dataDataGridView.Visible = true;
            scheduled_appointment_dataDataGridView1.Visible = false;
        }

        private void checkBoxDoctor_CheckedChanged(object sender, EventArgs e)
        {

               checkBoxPatient.Checked = false;

               SearchPat.Visible = false;
            doctor_NameComboBox.Visible = true;
            doctor_Namelabel.Visible = true;
            first_NameTextBox.Visible = false;
          last_NameTextBox.Visible = false;
          date_of_BirthDateTimePicker.Visible = false;
          SearchDoc.Visible = true;
          first_NameLabel.Visible = false;
          last_NameLabel.Visible = false;
          Dob_Label.Visible = false;
          scheduled_appointment_dataDataGridView.Visible = false;
          scheduled_appointment_dataDataGridView1.Visible = true;
         
            
        }

        private void doctor_NameLabel2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.FillBy(this.iPIMS_9DataSet.scheduled_appointment_data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchappToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.Searchapp(this.iPIMS_9DataSet.scheduled_appointment_data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.search(this.iPIMS_9DataSet.scheduled_appointment_data, first_NameTextBox.Text, last_NameTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {/*
            try
            {
                this.scheduled_appointment_dataTableAdapter.search(this.iPIMS_9DataSet.scheduled_appointment_data, first_NameToolStripTextBox.Text, last_NameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void searchDocToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.searchDoc(this.iPIMS_9DataSet.scheduled_appointment_data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SearchDoc_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.DocSearch(this.iPIMS_9DataSet.scheduled_appointment_data, doctor_NameComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchdoc1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.searchdoc1(this.iPIMS_9DataSet.scheduled_appointment_data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchdoctorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.searchdoctor(this.iPIMS_9DataSet.scheduled_appointment_data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchdoctorToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchdoctToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.searchdoct(this.iPIMS_9DataSet.scheduled_appointment_data);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void docSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduled_appointment_dataTableAdapter.DocSearch(this.iPIMS_9DataSet.scheduled_appointment_data, doctor_NameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
