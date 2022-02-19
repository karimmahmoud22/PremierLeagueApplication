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
    public partial class Sign_Up_Fitness : Form
    {
        Validation validationObject;
        DB_Controller controller;
        public Sign_Up_Fitness()
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = new DB_Controller();

            //DataTable dt = controller.get_All_IDS_of_Teams();
            //team_id.DataSource = dt;
            //team_id.DisplayMember = "id";
        }


        private void submit_Fitness_Click(object sender, EventArgs e)
        {
            //Validations of Fname of SuperVisor
            string Fname_test = "";
            string empty_error_test_Fname = "";
            string wrong_error_test_Fname = "";
            int counter = 0;

            validationObject.Check_String(firstName_Fitness.Text, ref empty_error_test_Fname, ref wrong_error_test_Fname);
            if (empty_error_test_Fname == "empty error")
            {
                MessageBox.Show("Please Enter Your First Name");
                counter++;
            }
            else
                Fname_test = firstName_Fitness.Text;

            if (wrong_error_test_Fname == "wrong error")
            {
                MessageBox.Show("Please Enter Your First Name Correctly");
                counter++;
            }
            else
                Fname_test = firstName_Fitness.Text;

            //Validations of Minit
            string Minit_test = "";
            string empty_error_test_Minit = "";
            string wrong_error_test_Minit = "";

            validationObject.Check_String(Minit_Fitness.Text, ref empty_error_test_Minit, ref wrong_error_test_Minit);
            if (empty_error_test_Minit == "empty error")
            {
                MessageBox.Show("Please Enter Your Minit");
                counter++;
            }
            else
                Minit_test = Minit_Fitness.Text;

            if (wrong_error_test_Minit == "wrong error")
            {
                MessageBox.Show("Please Enter Your Minit Correctly");
                counter++;
            }
            else
                Minit_test = Minit_Fitness.Text;

            //Validations of Lname of SuperVisor
            string Lname_test = "";
            string empty_error_test_Lname = "";
            string wrong_error_test_Lname = "";

            validationObject.Check_String(lastName_Fitness.Text, ref empty_error_test_Lname, ref wrong_error_test_Lname);
            if (empty_error_test_Lname == "empty error")
            {
                MessageBox.Show("Please Enter Your Last Name");
                counter++;
            }
            else
                Lname_test = lastName_Fitness.Text;

            if (wrong_error_test_Lname == "wrong error")
            {
                MessageBox.Show("Please Enter Your Last Name Correctly");
                counter++;
            }
            else
                Lname_test = lastName_Fitness.Text;

            //Validations for E-mail
            //Validations for E-mail
            string Email_test = "";
            bool yy = validationObject.validateEmail(email_Fitness.Text);
            if (!yy)
            {
                MessageBox.Show("Please Enter Your E-mail");
                counter++;
            }
            else
                Email_test = email_Fitness.Text;

            //Check for password 
            string Password_test = "";
            string error_test_Password = "";

            bool ii = validationObject._validatePassword(password_Fitness.Text, ref error_test_Password);
            if (!ii)
            {
                counter++;
            }
            else
            {
                Password_test = password_Fitness.Text;
            }
            //Check for Re-password 
            string REPassword_test = "";
            string error_test_REPassword = "";

            bool uu = validationObject._validatePassword(Re_Password_Fitness.Text, ref error_test_REPassword);
            if (!uu)
            {
                counter++;
            }
            else
                REPassword_test = Re_Password_Fitness.Text;

            if (password_Fitness.Text.Length == Re_Password_Fitness.Text.Length)
            {
                if (password_Fitness.Text != Re_Password_Fitness.Text)
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

            validationObject.Check_Number(Salary_Fitness.Text, ref empty_error_test_Salary, ref wrong_error_test_Salary);
            if (empty_error_test_Salary == "empty error")
            {
                MessageBox.Show("Please Enter Your Salary");
                counter++;
            }
            else
                Salary_test = Salary_Fitness.Text;

            if (wrong_error_test_Salary == "wrong error")
            {
                MessageBox.Show("Please Enter Your Salary Correctly");
                counter++;
            }
            else
                Salary_test = Salary_Fitness.Text;

            //Nationality validations
            //Elemens are added manually
            string Nationality_test = "";
            if (Nationality_Fitness.Text == "" || Nationality_Fitness.Text == null)
            {
                MessageBox.Show("Please Select Your Nationality");
                counter++;
            }
            else
                Nationality_test = Nationality_Fitness.Text;

            //Salary
            string DOF_test = DOF_Fitness.Text.ToString();


            //Certificates
            string s1 = "";
            if (c1_Fitness.CheckState == CheckState.Checked)
            {
                s1 = c1_Fitness.Text;
            }

            string s2 = "";
            if (c2_Fitness.CheckState == CheckState.Checked)
            {
                s2 = c2_Fitness.Text;
            }

            string s3 = "";
            if (c3_Fitness.CheckState == CheckState.Checked)
            {
                s3 = c3_Fitness.Text;
            }

            string s4 = "";
            if (c4_Fitness.CheckState == CheckState.Checked)
            {
                s4 = c4_Fitness.Text;
            }

            string s5 = "";
            if (c5_Fitness.CheckState == CheckState.Checked)
            {
                s5 = c5_Fitness.Text;
            }

            string s6 = "";
            if (c6_Fitness.CheckState == CheckState.Checked)
            {
                s6 = c6_Fitness.Text;
            }

            //certificatest ready for send to db

            string team_idd = team_id.Text;

            int test;
            //If all information the user Entered is correct so I will insert the Supervisor, else insertion will fail
            if (counter == 0)
                test = controller.Insert_New_fitness_trainer(Fname_test, Lname_test, Minit_test, Email_test, REPassword_test, Nationality_test,
                                                    DOF_test, Salary_test, team_idd);
            else
                test = 0;

            if (test == 0)
                MessageBox.Show("Your Sign Up is failed");
            else if (test == -1)
                MessageBox.Show("Probably your E-mail exist previously");
            else
                MessageBox.Show("You Signed Up successfully!");

        }

        private void back_Fitness_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();
        }

    }
}
