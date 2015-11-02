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
    public partial class EPrescription : Form
    {
        //declared local variables
        string first_name, last_name,medicine_name, dosage, quantity,lab_description, instruction, prescription_id;
        private DateTime date_of_birth;
        
            
        public EPrescription()
        {
            InitializeComponent();
        }

        private void EPrescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.patient_data' table. You can move, or remove it, as needed.
           // this.patient_dataTableAdapter.Fill(this.iPIMS_9DataSet.patient_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.e_prescription_data' table. You can move, or remove it, as needed.

           // this.e_prescription_dataTableAdapter.View1(this.iPIMS_9DataSet.e_prescription_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.update_healthcare_data' table. You can move, or remove it, as needed.
            // this.update_healthcare_dataTableAdapter.Fill(this.iPIMS_9DataSet.update_healthcare_data);
           
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string message = "Document sent to the printer"+ Environment.NewLine+"Do you want to print another prescription?";
            string title = "Printing...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // 

            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                //Do Nothing
            }

        }

        private void e_prescription_dataDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //do nothing
        }

     
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //  Set variables with the values from the textboxes
           first_name = first_NameTextBox.Text;
            last_name = last_NameTextBox.Text;
            date_of_birth = date_of_BirthDateTimePicker.Value.Date;
            medicine_name = medicine_NameTextBox.Text;
            dosage = dosageTextBox.Text;
            quantity = quantityTextBox.Text;
            lab_description = lab_DescriptionTextBox.Text;
            instruction = instructionTextBox.Text;
            prescription_id = prescription_IdTextBox.Text;


            string message = "Prescription created, do you want to create another prescription?";
            string title = "Prescription";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //create prescription
                Prescription();

                //close the form
                this.Close();
            }
        }
        void Prescription()
        {
            try
            {
                // Validate form and stop editing databinding source reader
                this.Validate();
                this.e_prescription_dataBindingSource1.EndEdit();

                // create new rows for prescription data
               // IPIMS_9DataSet.user_dataRow newUserDataRow;
               // IPIMS_9DataSet.patient_dataRow newPatientDataRow;
                IPIMS_9DataSet.e_prescription_dataRow newPrescriptionDataRow;
                newPrescriptionDataRow = iPIMS_9DataSet.e_prescription_data.Newe_prescription_dataRow();
               // newUserDataRow = iPIMS_9DataSet.user_data.Newuser_dataRow();
               // newPatientDataRow = iPIMS_9DataSet.patient_data.Newpatient_dataRow();

                // Fill the prescription data row with the variable data

                newPrescriptionDataRow.First_Name = first_name.ToString();
                newPrescriptionDataRow.Last_Name = last_name.ToString();
                newPrescriptionDataRow.Date_of_Birth = date_of_birth.Date;
                newPrescriptionDataRow.Medicine_Name = medicine_name.ToString();
                newPrescriptionDataRow.Dosage = int.Parse(dosage);
                newPrescriptionDataRow.Quantity = quantity.ToString();
                newPrescriptionDataRow.Lab_Description = lab_description.ToString();
                newPrescriptionDataRow.Instruction = instruction.ToString();
                newPrescriptionDataRow.Prescription_Id = int.Parse(prescription_id);
               
                //Add the row to the e_prescription_data table
                this.iPIMS_9DataSet.e_prescription_data.Rows.Add(newPrescriptionDataRow);

                //save the new rows to the database
                this.e_prescription_dataTableAdapter.Update(this.iPIMS_9DataSet.e_prescription_data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void view2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_prescription_dataTableAdapter.view2(this.iPIMS_9DataSet.e_prescription_data, first_NameToolStripTextBox1.Text, last_NameToolStripTextBox1.Text);
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
                this.e_prescription_dataTableAdapter.view2(this.iPIMS_9DataSet.e_prescription_data, first_NameToolStripTextBox1.Text, last_NameToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
      
     }
}
