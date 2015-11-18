using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPIMS_Group_9
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void user_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.user_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);
            
            //fill fields with the user's profile information

            

        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            string password = "", newPassword = "", address = "", city = "", state = "", zip = "", phone = "", email = "";
            bool success = true;
            if (passwordTextBox.Text == passwordTextBox1.Text)
            {
                newPassword = passwordTextBox.Text;
            }
            else
            {
                success = false;
                warningLabel.Text = "Password did not match";
            }
            password = passwordTextBox.Text;
            address = street_AddressTextBox.Text;
            city = cityTextBox.Text;
            state = stateTextBox.Text;
            zip = zip_CodeTextBox.Text;
            phone = phone_NumberTextBox.Text;
            email = emailTextBox.Text;

            if(password == "" || address == "" || city == "" || state == "" || zip == "" || phone == "" || email == "")
            {
                success = false;
                warningLabel2.Text = "All fields required";
            }
            
            if(success == true)
            {
                //update these strings in the current username's data row 
                //newPassword, address, city, state, zip, phone, email
            }
        }


    }
}
