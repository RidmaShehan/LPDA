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
    public partial class contact_details : Form
    {
        public contact_details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close the current form
            this.Close();
            //Show the older form
            peronal_detail_form f2 = new peronal_detail_form();
            f2.ShowDialog();
            
        }
    }
}
