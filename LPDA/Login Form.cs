using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void user_name_text_box_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void user_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                bool UserNameIsCorrect = false;

                while (UserNameIsCorrect!= true)
                {
                    string user_name_login = user_name_text_box.Text;

                    if (user_name_login != "ridma")
                    {
                       

                        user_name_error_massege.Visible = true;
                        user_name_error_picture.Visible = true;
                        user_name_correct_picture.Visible = false;

                        // Optionally, you can clear the username and password fields
                        user_name_text_box.Clear();

                        // Set focus back to the username field
                        user_name_text_box.Focus();

                        //---------------------------------

                        UserNameIsCorrect = true;
                        break;
                    }
                    else{
                        user_name_error_massege.Visible = false;
                        user_name_error_picture.Visible = false;

                        // user name is correct 
                        
                        user_name_correct_picture.Visible = true;
                        password_txet_box.Focus();
                        UserNameIsCorrect = false;
                        break;
                    }
                }
            }
        }

        private void user_name_error_massege_Click(object sender, EventArgs e)
        {

        }

        private void password_txet_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if()
            }
        }
    }
}
