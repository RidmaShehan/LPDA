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
    public partial class peronal_detail_form : Form
    {
        public peronal_detail_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the contact_details f2
            contact_details f2 = new contact_details();
            //Hide the create form
            this.Hide();
            //Show the create contact_details f2
            f2.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the current form
            this.Close();  
            //go to ealier form
            client_registration_form f3 = new client_registration_form();
            //show the create form
            f3.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIC_NO_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
