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
    public partial class client_registration_form : Form
    {
        public client_registration_form()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //create the  peronal_detail_form f1
            peronal_detail_form f1 = new peronal_detail_form();
            //Hide the current form
            this.Hide();
            //Show the create  peronal_detail_form f1
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
