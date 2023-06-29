using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LPDA
{
    public partial class create_account_form_02 : Form
    {
        public string Email;
        public string PhoneNumber;
        public string UserName;
        public string Password;
        public string ZipCode;
        public string TempPassword;

        public create_account_form_02()
        {
            InitializeComponent();
        }

        private void next_butten_form_02_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "reg(*.txt)|*.txt";
            saveFileDialog.Title = "save Registration Data";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the registration data to the file
                    /*
                    writer.WriteLine($"Surname: {Surname}");
                    writer.WriteLine($"First Name: {FirstName}");
                    writer.WriteLine($"Second Name: {SecondName}");
                    writer.WriteLine($"ID Number: {IDNumber}");
                    writer.WriteLine($"Date Of Birth : {DateOfBirth}");
                    writer.WriteLine($"Gender : {Gender}");*/

                    writer.WriteLine($"Email: {Email}");
                    writer.WriteLine($"Phone Number: {PhoneNumber}");
                    writer.WriteLine($"ZipCode: {ZipCode}");
                    writer.WriteLine($"UserName: {UserName}");
                    writer.WriteLine($"Password: {Password}");

                    writer.WriteLine();
                }

                // Display a success message
                string message = "Registration data saved successfully.";
                MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void email_text_KeyDown(object sender, KeyEventArgs e)
        {
            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as "EmailIsCorrect" , for controlling the while loop.
                Boolean EmailIsCorrect = false;

                // The value of "email_text" is assigned to the variable  "Email".
                Email = email_text.Text;
                
                while (EmailIsCorrect!=true)
                {
                   
                        if (Email.Contains("@"))
                        {
                            //If text content has '@'. It is correct.
                            //Focusing on phone_number_tex.
                            email_error_picture.Visible = false;
                            phone_number_text.Focus();
                            EmailIsCorrect = true;
                        break;
                        }
                        else
                        {
                            //If text content hasn't '@'. It is incorrect.
                            EmailIsCorrect = false;
                            //To receive user input again, the focus is placed on that cell and the contents of the cell are cleared.
                            email_error_picture.Visible=true;
                            email_text.Clear();
                            email_text.Focus();
                        break;
                        }
                    
                }
                
            }
        }

        private void phone_number_text_KeyDown(object sender, KeyEventArgs e)
        {

            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " PhoneNumberIsCorrect" , for controlling the while loop.
                Boolean PhoneNumberIsCorrect = false;

                // The value of "phone_number_text" is assigned to the variable  "PhoneNumber".
                PhoneNumber = phone_number_text.Text;


                while (PhoneNumberIsCorrect != true)
                {

                }
            }
        }

        private void user_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " UserNameIsCorrect " , for controlling the while loop.
                Boolean UserNameIsCorrect = false;

                // The value of "user_name_text" is assigned to the variable  "UserName".
                UserName = user_name_text.Text;

                // while loop.
                while (UserNameIsCorrect != true)
                {
                    if (UserName == "")
                    {
                        user_name_error_picture.Visible = true;
                        user_name_text.Focus();
                        UserNameIsCorrect = false; 
                        break;
                    }
                    else
                    {
                        user_name_error_picture.Visible = false;
                        zip_code_text.Focus();
                        UserNameIsCorrect=false;
                        break;
                    }
                }
            }
                
        }

        private void zip_code_text_TextChanged(object sender, EventArgs e)
        {
            ZipCode = zip_code_text.Text;
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {
            Password = password_text.Text;
        }

        private void confirm_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_password_KeyDown(object sender, KeyEventArgs e)
        {

            TempPassword = confirm_password.Text;

        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
