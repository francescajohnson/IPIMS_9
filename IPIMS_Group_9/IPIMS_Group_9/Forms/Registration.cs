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
        string classification, first_name, last_name, gender, social_security_number, street_address, city, state, zip_code, phone_number, email, username, password, insurance_provider="", insurance_contact="";
        string date_of_birth;

        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            classification = classificationComboBox.SelectedItem.ToString();
            first_name = first_nameTextBox.Text;
            last_name = last_nameTextBox.Text;
            date_of_birth = date_of_birthDateTimePicker.Text;
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

                
                //this.Hide();
			//String^ constring = L"datasource=localhost;port=3306;username=root;password=Group9IPIMS";
			//MySqlConnection^ conDataBase = gcnew MySqlConnection(constring);
			/*MySqlCommand^ cmdDataBase = gcnew MySqlCommand("INSERT INTO `group9_ipims`.`user_data` (`classification`, `first_name`,	`last_name`, `gender`,`date_of_birth`, `social_security_number`, `street_address`, `city`, `state`, `zip_code`, `phone_number`, `email`, `username`, `password`, `insurance_provider`, `insurance_contact`) VALUES (classification, '" + first_name + "', '" + last_name + "', '" + gender + "', '" + date_of_birth + "', '" + social_security_number + "', '" + street_address + "', '" + city + "', '" + state + "', '" + zip_code + "', '" + phone_number + "', '" + email + "', '" + username + "', '" + password + "', '" + insurance_provider + "', '" + insurance_contact + "'); ", conDataBase);*/
			/*MySqlCommand^ cmdDataBase = gcnew MySqlCommand("INSERT INTO `group9_ipims`.`user_data` (`classification`, `first_name`,	`last_name`, `gender`,`date_of_birth`, `social_security_number`, `street_address`, `city`, `state`, `zip_code`, `phone_number`, `email`, `username`, `password`, `insurance_provider`, `insurance_contact`) VALUES ('" + classification.ToString() + "' , '" + this->textBoxFirstName->Text + "', '" + this->textBoxLastName->Text + "','" + genderFound.ToString() + "', '" + this->textBoxDateOfBirth->Text->Substring(6, 4) + "-" + this->textBoxDateOfBirth->Text->Substring(0, 5) + "', '" + this->textBoxIdNumber->Text + "', '" + this->textBoxStreetAddress->Text + "', '" + this->textBoxCity->Text + "', '" + this->textBoxState->Text + "', '" + this->textBoxZipCode->Text + "', '" + this->textBoxPhoneNumber->Text + "', '" + this->textBoxEmailAddress->Text + "', '" + this->textBoxUsername->Text + "', '" + this->textBoxPassword->Text + "', '" + this->textBoxHealthInsurance->Text + "', '" + this->textBoxHealthInsuranceNumber->Text + "'); ", conDataBase);

			MySqlDataReader^ myReader;
			try {
				conDataBase->Open();
				myReader = cmdDataBase->ExecuteReader();
			}
			catch (Exception^ ex){
				MessageBox::Show(ex->Message);
			}
			IPIMS_Group9::LoggingIn^ lIn = gcnew LoggingIn();
			lIn->ShowDialog();
			lIn->Show();
			break;

                */

                try
                {
                    // Register user and then show the LoggingIn form
                    //Create a new row
                    this.Validate();
                    this.user_dataBindingSource1.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);
                   //this.user_dataTableAdapter.Insert(classification, first_name, last_name, gender, 'date_of_birth.Substring(6,4) + date_of_birth.Substring(0,5)', social_security_number, street_address, city, state, zip_code, phone_number, email, username, password, insurance_provider, insurance_contact);
                    this.Hide();
                    LoggingIn formLI = new LoggingIn();
                    formLI.Visible = true;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                // Register user and then show the Welcome form
                this.Validate();
                this.user_dataBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

                this.Hide();
            }
            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                // Do Nothing, and return to registration form
            }
        }
        private void user_dataBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_dataBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iPIMS_9DataSet);

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.user_data' table. You can move, or remove it, as needed.
            // this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);

        }

        private void classificationComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(classificationComboBox.Text == "Patient")
            {
                this.labelIdNumber.Text = "Social Security Number:";
                this.labelIdNumber.Location = new Point(327, 49);
                groupBoxMedicalInformation.Visible = true;
            //insurance_provider = insurance_providerTextBox.Text;
            //insurance_contact = insurance_contactTextBox.Text;

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



    }
}