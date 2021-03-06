﻿using System;
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
    public partial class Registration : Form
    {
        


        // Declared local variables:
        private string classification, first_name, last_name, gender, social_security_number, street_address, city, state, zip_code, phone_number, email, username, password;
        private DateTime date_of_birth;
        private string insurance_Provider = "", insurance_Contact_Number = "", medical_history = "", country_of_origin = "", doctor = "";
        private int age = 0;
        private bool smoker = false, drug_user = false;

        // Declared database variables for database calls
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr;
        private string constring;
        private SqlConnection cn;
        //        private SqlConnection cn = new SqlConnection(@"data source=(localdb)\v11.0;initial catalog=IPIMS_9;Integrated Security=SSPI");
        public Registration()
        {
            InitializeComponent();
            //constring = "@"data source=(localdb)\v11.0;initial catalog=IPIMS_9;Integrated Security=SSPI";
            // cn = new SqlConnection(@"Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\fjohnso3\\Source\\Repos\\IPIMS_9\\IPIMS_Group_9\\IPIMS_Group_9\\IPIMS_9.mdf;Integrated Security=True");
            /*cn = new SqlConnection(@"data source=.;initial catalog=IPIMS_9;Integrated Security=SSPI");   // ;User Id=[User];Password=");
            if (cn.State != ConnectionState.Open)
                cn.Open();
            // ;User ID=*****;Password=myPassword;
            cmd.CommandText = "SELECT * FROM [dbo].[user_data]";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            cn.Close();*/
        }
        private void classificationComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (classificationComboBox.Text == "Patient")
            {
                groupBoxMedicalInformation.Visible = true;
            }
            else if (classificationComboBox.Text == "Doctor" || classificationComboBox.Text == "Nurse" || classificationComboBox.Text == "Office Staff" ||
                classificationComboBox.Text == "Lab Staff" || classificationComboBox.Text == "Research Staff")
                groupBoxMedicalInformation.Visible = false;
        }
        private void is_SmokerCheckBox_CheckedChanged()
        {
            if (is_SmokerCheckBox.Checked)
            {
                smoker = true;
            } smoker = false;
        }
        private void is_Drug_UserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (is_Drug_UserCheckBox.Checked)
            {
                drug_user = true;
            } drug_user = false;
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Set variables with the values from the textboxes
            classification = classificationComboBox.Text;
            first_name = first_NameTextBox.Text;
            last_name = last_NameTextBox.Text;
            // date_of_birth = date_of_BirthDateTimePicker.Value.Date;
            gender = genderComboBox.Text;
            street_address = street_AddressTextBox.Text;
            city = cityTextBox.Text;
            state = stateTextBox.Text;
            zip_code = zip_CodeTextBox.Text;
            password = passwordTextBox.Text;
            username = usernameTextBox.Text;
            email = emailTextBox.Text;
            phone_number = phone_NumberTextBox.Text;

            if (classification == "Patient")
            {
                social_security_number = social_Security_NumberTextBox.Text;
                age = int.Parse(ageTextBox.Text);
                // need to calculate the age...
                // for testing 
                // age = ageTextBox.Text;
                country_of_origin = country_of_OriginTextBox.Text;
                insurance_Provider = health_Insurance_ProviderTextBox.Text;
                insurance_Contact_Number = health_Insurance_Contact_NumberTextBox.Text;
                medical_history = medical_HistoryTextBox.Text;
                doctor = doctor_NameComboBox.Text;
            }
            // After user presses the Register button, they will receive a prompt
            // Do they want to login as the newly registered user? Yes, No, or Cancel
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
                try
                {
                    Welcome formW = new Welcome();
                    formW.Visible = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
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
            // TODO: This line of code loads data into the 'iPIMS_9DataSet.patient_data' table. You can move, or remove it, as needed.
            // this.patient_dataTableAdapter.Fill(this.iPIMS_9DataSet.patient_data);
            // this.user_dataTableAdapter.Fill(this.iPIMS_9DataSet.user_data);



        }

        // Function to call when the code should implement registration features
        void Register()
        {
            try
            {
                // Validate form and stop editing databinding source reader
                this.Validate();
                this.user_dataBindingSource1.EndEdit();

                string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\E860536\Source\Group_9\IPIMS_9\IPIMS_9\IPIMS_Group_9\IPIMS_Group_9\IPIMS_9.mdf;Integrated Security=True");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO user_data (Classification,First_Name,Last_Name,Gender,Social_Security_Number,Street_Address,City,State,Zip_Code,Phone_Number,Email,Username,Password) VALUES (@Classification, @First_Name, @Last_Name, @Gender, @Social_Security_Number, @Street_Address, @City, @State, @Zip_Code, @Phone_Number, @Email, @Username, @Password)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
             
                cmd.Parameters.AddWithValue("@Classification", classification.ToString());
                cmd.Parameters.AddWithValue("@First_Name", first_name.ToString());
                cmd.Parameters.AddWithValue("@Last_Name", last_NameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender.ToString());
                cmd.Parameters.AddWithValue("@Social_Security_Number", social_security_number.ToString());
            
                cmd.Parameters.AddWithValue("@Street_Address", street_address.ToString());
                cmd.Parameters.AddWithValue("@City", city.ToString());
                cmd.Parameters.AddWithValue("@State", state.ToString());
                cmd.Parameters.AddWithValue("@Zip_Code", zip_code.ToString());
                cmd.Parameters.AddWithValue("@Phone_Number", phone_number.ToString());
                cmd.Parameters.AddWithValue("@Email", email.ToString());
                 cmd.Parameters.AddWithValue("@Username", username.ToString());
                cmd.Parameters.AddWithValue("@Password", password.ToString());

                
                connection.Open();
                cmd.ExecuteNonQuery();
            }
                
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmdPatient = new SqlCommand("INSERT INTO patient_data (Classification,First_Name,Last_Name,Age,Country_of_Origin,Health_Insurance_Provider,Health_Insurance_Contact_Number,Medical_History,Is_Smoker,Is_Drug_User,Doctor_Name) VALUES (@Classification, @First_Name, @Last_Name, @Age, @Country_of_Origin, @Health_Insurance_Provider, @Health_Insurance_Contact_Number, @Medical_History, @Is_Smoker, @Is_Drug_User, @Doctor_Name)");
                cmdPatient.CommandType = CommandType.Text;
                cmdPatient.Connection = connection;
             
                cmdPatient.Parameters.AddWithValue("@Classification", classification.ToString());
                cmdPatient.Parameters.AddWithValue("@First_Name", first_name.ToString());
                cmdPatient.Parameters.AddWithValue("@Last_Name", last_NameTextBox.Text);
                cmdPatient.Parameters.AddWithValue("@Age", age);
                cmdPatient.Parameters.AddWithValue("@Country_of_Origin", country_of_origin.ToString());
                cmdPatient.Parameters.AddWithValue("@Health_Insurance_Provider", health_Insurance_ProviderTextBox.Text);
                cmdPatient.Parameters.AddWithValue("@Health_Insurance_Contact_Number",health_Insurance_Contact_NumberTextBox.Text);
                cmdPatient.Parameters.AddWithValue("@Medical_History", medical_history.ToString());
                cmdPatient.Parameters.AddWithValue("@Is_Smoker", is_SmokerCheckBox.CheckState.ToString());
                cmdPatient.Parameters.AddWithValue("@Is_Drug_User", is_Drug_UserCheckBox.CheckState.ToString());
                cmdPatient.Parameters.AddWithValue("@Doctor_Name", doctor.ToString());                                
                connection.Open();
                cmdPatient.ExecuteNonQuery();
            }

                // Create a new row with the values from the form
                // Create new row for user data and patient data tables
                // IPIMS_9DataSet.user_dataRow newUserDataRow;
                // IPIMS_9DataSet.patient_dataRow newPatientDataRow;


                /* newUserDataRow = iPIMS_9DataSet.user_data.Newuser_dataRow();
                newPatientDataRow = iPIMS_9DataSet.patient_data.Newpatient_dataRow();

                // Fill the new user data row with the variable data
                newUserDataRow.Classification = classification.ToString();
                newUserDataRow.First_Name = first_name.ToString();
                newUserDataRow.Last_Name = last_name.ToString();
                newUserDataRow.Gender = gender.ToString();
                newUserDataRow.Date_of_Birth = date_of_birth.Date;
                newUserDataRow.Street_Address = street_address.ToString();
                newUserDataRow.City = city.ToString();
                newUserDataRow.State = state.ToString();
                newUserDataRow.Zip_Code = zip_code.ToString();
                newUserDataRow.Phone_Number = phone_number.ToString();
                newUserDataRow.Email = email.ToString();
                newUserDataRow.Username = username.ToString();
                newUserDataRow.Password = password.ToString();
                newUserDataRow.Social_Security_Number = "000-00-0000";

                //Add the row to the user_data table
                this.iPIMS_9DataSet.user_data.Rows.Add(newUserDataRow);
                
                //Save the new rows to the database
                this.user_dataTableAdapter.Update(this.iPIMS_9DataSet.user_data);


                if (classification == "Patient")
                {
                    //newPatientDataRow details
                    newPatientDataRow.Classification = classification.ToString();
                    newPatientDataRow.First_Name = first_name.ToString();
                    newPatientDataRow.Last_Name = last_name.ToString();
                    newPatientDataRow.Date_of_Birth = date_of_birth.Date;
                    newUserDataRow.Social_Security_Number = social_security_number.ToString();
                    newPatientDataRow.Age = age;
                    newPatientDataRow.Medical_History = medical_history.ToString();
                    newPatientDataRow.Country_of_Origin = country_of_origin.ToString();
                    newPatientDataRow.Health_Insurance_Provider = insurance_Provider.ToString(); 
                    newPatientDataRow.Health_Insurance_Contact_Number = insurance_Contact_Number.ToString();
                    newPatientDataRow.Doctor_Name = doctor.ToString();
                    if (smoker == false)
                    {
                        newPatientDataRow.Is_Smoker = false;
                    }
                    else
                    {
                        newPatientDataRow.Is_Smoker = true;
                    }

                    if (drug_user == false)
                    {
                        newPatientDataRow.Is_Drug_User = false;
                    }
                    else
                    {
                        newPatientDataRow.Is_Drug_User = true;
                    }
                    //Add the row to the patient_data table
                    this.iPIMS_9DataSet.patient_data.Rows.Add(newPatientDataRow);
                    this.patient_dataTableAdapter.Update(this.iPIMS_9DataSet.patient_data);
                }
               */

                // this.user_dataTableAdapter.Insert(classification.ToString(), first_name.ToString(), last_name.ToString(), date_of_birth.Date, gender.ToString(), social_security_number.ToString(), street_address.ToString(), city.ToString(), state.ToString(), zip_code.ToString(), phone_number.ToString(), email.ToString(), username.ToString(), password.ToString());
            }
            catch (Exception ex)
            {
                //throw ex;
                this.Close();
                LoggingIn formLog = new LoggingIn();
                formLog.Visible = true;
            }
        }
    }
}