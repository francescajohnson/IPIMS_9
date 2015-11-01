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
    public partial class LoggingIn : Form
    {
         
        public LoggingIn()
        {
            /*SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True"; */
            InitializeComponent();
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);
       }

        private void LoggingIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.user_data' table. You can move, or remove it, as needed.
            // this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);
            /*SqlConnection con = new SqlConnection("Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");
            con.Open();  */
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(checkBoxNewUser.Checked == true)
            {
                // Must go to the registration page first
                this.Close();
                Registration formR = new Registration();
                formR.Visible = true;
            }
        }
    }
}
