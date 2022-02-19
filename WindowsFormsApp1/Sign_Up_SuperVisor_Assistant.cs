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
    public partial class Sign_Up_SuperVisor_Assistant : Form
    {
        Validation validationObject;
        DB_Controller controller;
        public Sign_Up_SuperVisor_Assistant()
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = new DB_Controller();

            DataTable dt = controller.get_All_IDS_of_supervisors();
            supervisor_id.DataSource = dt;
            supervisor_id.DisplayMember = "id";
        }


        private void submit_SuperVisor_Assistant_Click(object sender, EventArgs e)
        {
            //Validations of Fname of SuperVisor
            string Fname_test = "";
            string empty_error_test_Fname = "";
            string wrong_error_test_Fname = "";
            int counter = 0;

            validationObject.Check_String(firstName_SuperVisor_Assistant.Text, ref empty_error_test_Fname, ref wrong_error_test_Fname);
            if (empty_error_test_Fname == "empty error")
            {
                MessageBox.Show("Please Enter Your First Name");
                counter++;
            }
            else
                Fname_test = firstName_SuperVisor_Assistant.Text;

            if (wrong_error_test_Fname == "wrong error")
            {
                MessageBox.Show("Please Enter Your First Name Correctly");
                counter++;
            }
            else
                Fname_test = firstName_SuperVisor_Assistant.Text;

            //Validations of Minit
            string Minit_test = "";
            string empty_error_test_Minit = "";
            string wrong_error_test_Minit = "";

            validationObject.Check_String(Minit_Supervisor_Assistant.Text, ref empty_error_test_Minit, ref wrong_error_test_Minit);
            if (empty_error_test_Minit == "empty error")
            {
                MessageBox.Show("Please Enter Your Minit");
                counter++;
            }
            else
                Minit_test = Minit_Supervisor_Assistant.Text;

            if (wrong_error_test_Minit == "wrong error")
            {
                MessageBox.Show("Please Enter Your Minit Correctly");
                counter++;
            }
            else
                Minit_test = Minit_Supervisor_Assistant.Text;

            //Validations of Lname of SuperVisor
            string Lname_test = "";
            string empty_error_test_Lname = "";
            string wrong_error_test_Lname = "";

            validationObject.Check_String(lastName_SuperVisor_Assistant.Text, ref empty_error_test_Lname, ref wrong_error_test_Lname);
            if (empty_error_test_Lname == "empty error")
            {
                MessageBox.Show("Please Enter Your Last Name");
                counter++;
            }
            else
                Lname_test = lastName_SuperVisor_Assistant.Text;

            if (wrong_error_test_Lname == "wrong error")
            {
                MessageBox.Show("Please Enter Your Last Name Correctly");
                counter++;
            }
            else
                Lname_test = lastName_SuperVisor_Assistant.Text;

            //Validations for E-mail
            string Email_test = "";
            bool yy = validationObject.validateEmail(email_SuperVisor_Assistant.Text);
            if (!yy)
            {
                MessageBox.Show("Please Enter Your E-mail");
                counter++;
            }
            else
                Email_test = email_SuperVisor_Assistant.Text;

            //Check for password 
            string Password_test = "";
            string error_test_Password = "";

            bool ii = validationObject._validatePassword(password_super_Assistant.Text, ref error_test_Password);
            if (!ii)
            {
                counter++;
            }
            else
            {
                Password_test = password_super_Assistant.Text;
            }
            //Check for Re-password 
            string REPassword_test = "";
            string error_test_REPassword = "";

            bool uu = validationObject._validatePassword(Re_Password_Super_Assistant.Text, ref error_test_REPassword);
            if (!uu)
            {
                counter++;
            }
            else
                REPassword_test = Re_Password_Super_Assistant.Text;

            if (password_super_Assistant.Text.Length == Re_Password_Super_Assistant.Text.Length)
            {
                if (password_super_Assistant.Text != Re_Password_Super_Assistant.Text)
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

            validationObject.Check_Number(Salary_Super_Visor_Assistant.Text, ref empty_error_test_Salary, ref wrong_error_test_Salary);
            if (empty_error_test_Salary == "empty error")
            {
                MessageBox.Show("Please Enter Your Salary");
                counter++;
            }
            else
                Salary_test = Salary_Super_Visor_Assistant.Text;

            if (wrong_error_test_Salary == "wrong error")
            {
                MessageBox.Show("Please Enter Your Salary Correctly");
                counter++;
            }
            else
                Salary_test = Salary_Super_Visor_Assistant.Text;

            //Nationality validations
            //Elemens are added manually
            string Nationality_test = "";
            if (Nationality_Assistant.Text == "" || Nationality_Assistant.Text == null)
            {
                MessageBox.Show("Please Select Your Nationality");
                counter++;
            }
            else
                Nationality_test = Nationality_Assistant.Text;

            //Salary
            string DOF_test = DOF_Super_Visor_Assistant.Text.ToString();

            string supervisor_idd = supervisor_id.Text;

            int test;
            //If all information the user Entered is correct so I will insert the Supervisor, else insertion will fail
            if (counter == 0)
                test = controller.Insert_New_supervisor_assistant(Fname_test,Lname_test,Minit_test, Email_test,Password_test,
                                                                  Nationality_test, DOF_test, Salary_test, supervisor_idd);
            else
                test = 0;

            if (test == 0)
                MessageBox.Show("Your Sign Up is failed");
            else if (test == -1)
                MessageBox.Show("Probably your E-mail exist previously");
            else
                MessageBox.Show("You Signed Up successfully!");

        }
        private void back_SuperVisor_Assistant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();
        }

        private void Sign_Up_SuperVisor_Assistant_Load(object sender, EventArgs e)
        {

        }
    }
}
