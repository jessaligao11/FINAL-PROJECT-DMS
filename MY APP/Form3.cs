using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROD_ACTIVITYY
{
    public partial class Form3 : Form
    {
       
       

        private void exitbtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform logout or any other necessary actions before exiting
                // ...

                // Exit the application
                Environment.Exit(0);
            }
            // If the user clicks "No", do nothing and continue with the application

        }

        private void daydiary_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthdiary_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeardiary_TextChanged(object sender, EventArgs e)
        {

        }

        private void richtextboxdiary_TextChanged(object sender, EventArgs e)
        {

        }

      
       
    }
}