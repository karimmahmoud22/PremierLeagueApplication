using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Password : Form
    {
        DB_Controller myController;
        Validation validation;
        public Password(DB_Controller cont)
        {
            InitializeComponent();
            myController = cont;
            validation = new Validation();
        }

        private void Password_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jobs.SelectedItem == null)
            {
                MessageBox.Show("Choose your Job");
                return;
            }
            // check email
            if (myController.checkEmail(emailBox.Text, jobs.SelectedItem.ToString()))
            {
                newLabel.Visible    = true;
                newPassword.Visible = true;

                // validate new password
                string ErrMsg = " ";
                if (validation._validatePassword(newPassword.Text, ref ErrMsg))
                {

                    // Update it
                   int result = myController.updatePassword(emailBox.Text, jobs.SelectedItem.ToString(),newPassword.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Changed Successfully!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show(ErrMsg);
                }

                

            }
            else
            {
                MessageBox.Show("Invalid Email");
            }

            
        }
    }
}
