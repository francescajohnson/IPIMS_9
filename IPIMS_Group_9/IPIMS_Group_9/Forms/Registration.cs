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
    public partial class Registration : Form
    {
        // Declared local variables:
        private string classification, first_name, last_name, gender, social_security_number, street_address, city, state, zip_code, phone_number, email, username, password, insurance_provider="", insurance_contact="";
        private DateTime date_of_birth;

        public Registration()
        {
            InitializeComponent();
        }
        private void classificationComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (classificationComboBox.Text == "Patient")
            {
                this.labelIdNumber.Text = "Social Security Number:";
                this.labelIdNumber.Location = new Point(361, 49);
                groupBoxMedicalInformation.Visible = true;
                
            }
            else if (classificationComboBox.Text == "Doctor")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (classificationComboBox.Text == "Nurse")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (classificationComboBox.Text == "Office Staff")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (classificationComboBox.Text == "Lab Staff")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
            else if (classificationComboBox.Text == "Research Staff")
            {
                this.labelIdNumber.Text = "ID:";
                this.labelIdNumber.Location = new Point(460, 49);
                groupBoxMedicalInformation.Visible = false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Defined local variables
            classification = classificationComboBox.SelectedItem.ToString();
            first_name = first_nameTextBox.Text;
            last_name = last_nameTextBox.Text;
            date_of_birth = date_of_birthDateTimePicker.Value.Date;      ////ToString("yyyy-mm-dd");
            gender = genderComboBox.Text;
            social_security_number = social_security_numberTextBox.Text;
            street_address = street_addressTextBox.Text;
            city = cityTextBox.Text;
            state = stateTextBox.Text;
            zip_code = zip_codeTextBox.Text;
            phone_number = phone_numberTextBox.Text;
            email = emailTextBox.Text;
            username = usernameTextBox.Text;
            password = passwordTextBox.Text;
            
            string message = "Would you like to login as this user now?";
            string title = "Do you want to Login as this newly registered user?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //Register user
                Register();
                //Show the LoggingIn form for user to login
                this.Close();
                LoggingIn formLI = new LoggingIn();
                formLI.Visible = true;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                //Register user 
                Register();
                //Show the Welcome form for current user to continue using IPIMS
                this.Close();
                Welcome formW = new Welcome();
                formW.Visible = true;
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                // Do Nothing, and return to registration form
            }
        }
        private void user_dataBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
            this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);

        }


        void Register()     // Function to call when the code should implement registration features
        {
            try
            {
                // Validate form and stop editing databinding source reader
                this.Validate();
                this.user_dataBindingSource1.EndEdit();

                //Create a new row with the values from the form
                IPIMS_9DataSet.user_dataRow newUserDataRow;
                newUserDataRow = iPIMS_9DataSet.user_data.Newuser_dataRow();
                newUserDataRow.classification = classification.ToString();
                newUserDataRow.first_name = first_name.ToString();
                newUserDataRow.last_name = last_name.ToString();
                newUserDataRow.gender = gender.ToString();
                /*int years = Int32.Parse(date_of_birth.Substring(6, 4));        //.TryParse(date_of_birth.Substring(6, 4));
                int months = Int32.Parse(date_of_birth.Substring(0, 2));
                int days = Int32.Parse(date_of_birth.Substring())*/
                newUserDataRow.date_of_birth = date_of_birth.Date;
                //newUserDataRow.date_of_birth.AddMonths(months);
                    //(date_of_birth.Substring(6, 4) + date_of_birth.Substring(0, 5));
                newUserDataRow.social_security_number = social_security_number.ToString();
                newUserDataRow.street_address = street_address.ToString();
                newUserDataRow.city = city.ToString();
                newUserDataRow.state = state.ToString();
                newUserDataRow.zip_code = zip_code.ToString();
                newUserDataRow.phone_number = phone_number.ToString();
                newUserDataRow.email = email.ToString();
                newUserDataRow.username = username.ToString();
                newUserDataRow.password = password.ToString();
                if (classification == "Patient")
                {
                    newUserDataRow.insurance_provider = insurance_providerTextBox.ToString();
                    newUserDataRow.insurance_contact = insurance_contactTextBox.ToString();
                }
                else
                {
                    newUserDataRow.insurance_provider = "";
                    newUserDataRow.insurance_contact = "";
                }

                //Add the row to the user_data table
                this.iPIMS_9DataSet.user_data.Rows.Add(newUserDataRow);

                //Save the new row to the database
                this.user_dataTableAdapter.Update(this.iPIMS_9DataSet.user_data);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}