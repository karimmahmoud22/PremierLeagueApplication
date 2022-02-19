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
    public partial class Sign_Up_Doctor : Form
    {
        Validation validationObject;
        DB_Controller controller;
        public Sign_Up_Doctor()
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = new DB_Controller();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void submit_Coach_Click(object sender, EventArgs e)
        {
            //Validations of Fname of SuperVisor
            string Fname_test = "";
            string empty_error_test_Fname = "";
            string wrong_error_test_Fname = "";
            int counter = 0;

            validationObject.Check_String(firstName_Doctor.Text, ref empty_error_test_Fname, ref wrong_error_test_Fname);
            if (empty_error_test_Fname == "empty error")
            {
                MessageBox.Show("Please Enter Your First Name");
                counter++;
            }
            else
                Fname_test = firstName_Doctor.Text;

            if (wrong_error_test_Fname == "wrong error")
            {
                MessageBox.Show("Please Enter Your First Name Correctly");
                counter++;
            }
            else
                Fname_test = firstName_Doctor.Text;

            //Validations of Minit
            string Minit_test = "";
            string empty_error_test_Minit = "";
            string wrong_error_test_Minit = "";

            validationObject.Check_String(Minit_Doctor.Text, ref empty_error_test_Minit, ref wrong_error_test_Minit);
            if (empty_error_test_Minit == "empty error")
            {
                MessageBox.Show("Please Enter Your Minit");
                counter++;
            }
            else
                Minit_test = Minit_Doctor.Text;

            if (wrong_error_test_Minit == "wrong error")
            {
                MessageBox.Show("Please Enter Your Minit Correctly");
                counter++;
            }
            else
                Minit_test = Minit_Doctor.Text;

            //Validations of Lname of SuperVisor
            string Lname_test = "";
            string empty_error_test_Lname = "";
            string wrong_error_test_Lname = "";

            validationObject.Check_String(lastName_Doctor.Text, ref empty_error_test_Lname, ref wrong_error_test_Lname);
            if (empty_error_test_Lname == "empty error")
            {
                MessageBox.Show("Please Enter Your Last Name");
                counter++;
            }
            else
                Lname_test = lastName_Doctor.Text;

            if (wrong_error_test_Lname == "wrong error")
            {
                MessageBox.Show("Please Enter Your Last Name Correctly");
                counter++;
            }
            else
                Lname_test = lastName_Doctor.Text;

            //Validations for E-mail
            string Email_test = "";
            bool yy = validationObject.validateEmail(email_Doctor.Text);
            if (!yy)
            {
                MessageBox.Show("Please Enter Your E-mail");
                counter++;
            }
            else
                Email_test = email_Doctor.Text;
            //Check for password 
            string Password_test = "";
            string error_test_Password = "";

            bool ii = validationObject._validatePassword(password_Doctor.Text, ref error_test_Password);
            if (!ii)
            {
                counter++;
            }
            else
            {
                Password_test = password_Doctor.Text;
            }
            //Check for Re-password 
            string REPassword_test = "";
            string error_test_REPassword = "";

            bool uu = validationObject._validatePassword(Re_Password_Doctor.Text, ref error_test_REPassword);
            if (!uu)
            {
                counter++;
            }
            else
                REPassword_test = Re_Password_Doctor.Text;

            if (password_Doctor.Text.Length == Re_Password_Doctor.Text.Length)
            {
                if (password_Doctor.Text != Re_Password_Doctor.Text)
                {
                    MessageBox.Show("Please Make sure that you  Entered Your Password and Re passsword correctly");
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Please Make sure that Your Password and Re passsword have the same size");
                counter++;
            }

            //Validations for Salary
            string Salary_test = "";
            string empty_error_test_Salary = "";
            string wrong_error_test_Salary = "";

            validationObject.Check_Number(Salary_Doctor.Text, ref empty_error_test_Salary, ref wrong_error_test_Salary);
            if (empty_error_test_Salary == "empty error")
            {
                MessageBox.Show("Please Enter Your Salary");
                counter++;
            }
            else
                Salary_test = Salary_Doctor.Text;

            if (wrong_error_test_Salary == "wrong error")
            {
                MessageBox.Show("Please Enter Your Salary Correctly");
                counter++;
            }
            else
                Salary_test = Salary_Doctor.Text;

            //Nationality validations
            //Elemens are added manually
            string Nationality_test = "";
            if (Nationality_Doctor.Text == "" || Nationality_Doctor.Text == null)
            {
                MessageBox.Show("Please Select Your Nationality");
                counter++;
            }
            else
                Nationality_test = Nationality_Doctor.Text;

            //date
            string DOF_test = DOF_Doctor.Text.ToString();


            //Certificates
            string s1 = "";
            if ( c1_Doctor.CheckState == CheckState.Checked )
            {
                s1 = c1_Doctor.Text;
            }

            string s2 = "";
            if (c2_Doctor.CheckState == CheckState.Checked)
            {
                s2 = c2_Doctor.Text;
            }

            string s3 = "";
            if (c3_Doctor.CheckState == CheckState.Checked)
            {
                s3 = c3_Doctor.Text;
            }

            string s4 = "";
            if (c4_Doctor.CheckState == CheckState.Checked)
            {
                s4 = c4_Doctor.Text;
            }

            string s5 = "";
            if (c5_Doctor.CheckState == CheckState.Checked)
            {
                s5 = c5_Doctor.Text;
            }

            string s6 = "";
            if (c6_Doctor.CheckState == CheckState.Checked)
            {
                s6 = c6_Doctor.Text;
            }

            //certificatest ready for send to db

            int test;
            //If all information the user Entered is correct so I will insert the Supervisor, else insertion will fail
            if (counter == 0)
                test = controller.Insert_New_Doctor(Fname_test, Minit_test, Lname_test,  Email_test, REPassword_test, Nationality_test,
                                                    DOF_test, Salary_test);
            else
                test = 0;

            if (test == 0)
                MessageBox.Show("Your Sign Up is failed");
            else if (test == -1)
                MessageBox.Show("Probably your E-mail exist previously");
            else
                MessageBox.Show("You Signed Up successfully!");

        }

        private void back_Doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();
        }
    }
}
