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

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patient_dataTableAdapter.search(this.iPIMS_9DataSet.patient_data, first_NameToolStripTextBox.Text, last_NameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patient_dataTableAdapter.search(this.iPIMS_9DataSet.patient_data, first_NameToolStripTextBox.Text, last_NameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        
    }
}
