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
        private SqlConnection con;
        public LoggingIn()
        {
            InitializeComponent();
            con = new SqlConnection(@"data source=(localdb)\v11.0;initial catalog=IPIMS_9;Integrated Security=SSPI");
            con.Open();
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);
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
            if (checkBoxNewUser.Checked == true)
            {
                // Must go to the registration page first
                this.Close();
                Registration formR = new Registration();
                formR.Visible = true;
            }
            try
            {
                if (!(usernameTextBox.Text == string.Empty))
                {
                    if (!(passwordTextBox.Text == string.Empty))
                    {
                        con = new SqlConnection(@"data source=(localdb)\v11.0;initial catalog=IPIMS_9;Integrated Security=SSPI");
                        con.Open();
                        string userid = usernameTextBox.Text;
                        string password = passwordTextBox.Text;
                        SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + usernameTextBox.Text + "'and password='" + passwordTextBox.Text + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0 && dt.Rows.Count < 2)
                        {
                            this.Close();
                            Welcome formW = new Welcome();
                            formW.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login please check username and password, and try again.");
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
