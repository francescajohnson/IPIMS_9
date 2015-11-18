using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IPIMS_Group_9.Forms
{
    public partial class Reporting : Form
    {
        public Reporting()
        {
            InitializeComponent();
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.scheduled_appointment_data' table. You can move, or remove it, as needed.
            //this.scheduled_appointment_dataTableAdapter.Fill(this.iPIMS_9DataSet.scheduled_appointment_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.scheduled_appointment_data' table. You can move, or remove it, as needed.
            //this.scheduled_appointment_dataTableAdapter.Fill(this.iPIMS_9DataSet.scheduled_appointment_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.patient_data' table. You can move, or remove it, as needed.
            //this.patient_dataTableAdapter.Fill(this.iPIMS_9DataSet.patient_data);
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.user_data' table. You can move, or remove it, as needed.
            //this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);

            //scheduled_appointment_dataDataGridView

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\IPIMS_9.mdf;Integrated Security=True";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            string s1 = "Select First_Name, Last_Name, Appointment_Date, Symptoms from scheduled_appointment_data";

            command.CommandText = s1;

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data;

            string s2 = "Select Patient_Id, First_Name, Last_Name from patient_data";
            command.CommandText = s2;

            DataTable data2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            adapter.Fill(data2);
            dataGridView2.DataSource = data2;


            string s3 = "Select First_Name, Last_Name, Is_Smoker, Is_Drug_user from patient_data";
            command.CommandText = s3;

            DataTable data3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter(command);
            adapter.Fill(data3);
            dataGridView3.DataSource = data3;


            string s4 = "Select First_Name, Last_Name, Age, Country_of_Origin from patient_data";
            command.CommandText = s4;

            DataTable data4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(command);
            adapter.Fill(data4);
            dataGridView4.DataSource = data4;


        }

        private void user_dataDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void scheduled_appointment_dataDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
