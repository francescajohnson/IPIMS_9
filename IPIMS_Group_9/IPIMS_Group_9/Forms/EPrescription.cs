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
           /* first_name = first_NameTextBox.Text;
            last_name = last_NameTextBox.Text;
            date_of_birth = date_of_BirthDateTimePicker.Value.Date;
            medicine_name = medicine_NameTextBox.Text;
            dosage = dosageTextBox.Text;
            quantity = quantityTextBox.Text;
            lab_description = lab_DescriptionTextBox.Text;
            instruction = instructionTextBox.Text;
            prescription_id = prescription_IdTextBox.Text;*/
            string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\AMINA\Documents\IPIMS_Group_9\IPIMS_Group_9\IPIMS_9.mdf;Integrated Security=True");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO e_prescription_data (Patient_Id,First_Name, Last_Name,Dosage,Prescription_Name,Medicine_Name,Quantity,Lab_Description,Doctor_Name,Instruction) VALUES (@Patient_Id, @First_Name, @Last_Name,@Prescription_Name, @Dosage, @Medicine_Name, @Quantity, @Lab_Description, @Doctor_Name, @Instruction)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Patient_Id", patient_IdTextBox.Text);
                cmd.Parameters.AddWithValue("@First_Name", first_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Last_Name", last_NameTextBox.Text);
             //   cmd.Parameters.AddWithValue("@Date_of_Birth", date_of_BirthDateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Prescription_Name", prescription_NameTextBox.Text);
              //  cmd.Parameters.AddWithValue("@Prescription_Date", prescription_DateDateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Dosage", dosageTextBox.Text);
                cmd.Parameters.AddWithValue("@Medicine_Name", medicine_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Quantity", quantityTextBox.Text);
                cmd.Parameters.AddWithValue("@Lab_Description", lab_DescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@Doctor_Name", doctor_NameTextBox.Text);
                 cmd.Parameters.AddWithValue("@Instruction", instructionTextBox.Text);

                
                connection.Open();
                cmd.ExecuteNonQuery();
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
