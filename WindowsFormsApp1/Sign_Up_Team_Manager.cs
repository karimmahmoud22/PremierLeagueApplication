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
    public partial class Sign_Up_Team_Manager : Form
    {
        Validation validationObject;
        DB_Controller controller;

        public Sign_Up_Team_Manager()
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = new DB_Controller();
            
            DataTable dt222saA = controller.get_All_IDS_of_Teams_null_manager();
            team_id.DataSource = dt222saA;
            team_id.DisplayMember = "id";

        }


        private void submit_Team_Manger_Click(object sender, EventArgs e)
        {
            //Validations of Fname of SuperVisor
            string Fname_test = "";
            string empty_error_test_Fname = "";
            string wrong_error_test_Fname = "";
            int counter = 0;

            validationObject.Check_String(firstName_Team_Manger.Text, ref empty_error_test_Fname, ref wrong_error_test_Fname);
            if (empty_error_test_Fname == "empty error")
            {
                MessageBox.Show("Please Enter Your First Name");
                counter++;
            }
            else
                Fname_test = firstName_Team_Manger.Text;

            if (wrong_error_test_Fname == "wrong error")
            {
                MessageBox.Show("Please Enter Your First Name Correctly");
                counter++;
            }
            else
                Fname_test = firstName_Team_Manger.Text;

            //Validations of Minit
            string Minit_test = "";
            string empty_error_test_Minit = "";
            string wrong_error_test_Minit = "";

            validationObject.Check_String(Minit_Team_Manger.Text, ref empty_error_test_Minit, ref wrong_error_test_Minit);
            if (empty_error_test_Minit == "empty error")
            {
                MessageBox.Show("Please Enter Your Minit");
                counter++;
            }
            else
                Minit_test = Minit_Team_Manger.Text;

            if (wrong_error_test_Minit == "wrong error")
            {
                MessageBox.Show("Please Enter Your Minit Correctly");
                counter++;
            }
            else
                Minit_test = Minit_Team_Manger.Text;

            //Validations of Lname of SuperVisor
            string Lname_test = "";
            string empty_error_test_Lname = "";
            string wrong_error_test_Lname = "";

            validationObject.Check_String(lastName_Team_Manger.Text, ref empty_error_test_Lname, ref wrong_error_test_Lname);
            if (empty_error_test_Lname == "empty error")
            {
                MessageBox.Show("Please Enter Your Last Name");
                counter++;
            }
            else
                Lname_test = lastName_Team_Manger.Text;

            if (wrong_error_test_Lname == "wrong error")
            {
                MessageBox.Show("Please Enter Your Last Name Correctly");
                counter++;
            }
            else
                Lname_test = lastName_Team_Manger.Text;

            //Validations for E-mail
            //Validations for E-mail
            string Email_test = "";
            bool yy = validationObject.validateEmail(email_Team_Manger.Text);
            if (!yy)
            {
                MessageBox.Show("Please Enter Your E-mail");
                counter++;
            }
            else
                Email_test = email_Team_Manger.Text;

            //Check for password 
            string Password_test = "";
            string error_test_Password = "";

            bool ii = validationObject._validatePassword(password_Team_Manger.Text, ref error_test_Password);
            if (!ii)
            {
                counter++;
            }
            else
            {
                Password_test = password_Team_Manger.Text;
            }
            //Check for Re-password 
            string REPassword_test = "";
            string error_test_REPassword = "";

            bool uu = validationObject._validatePassword(Re_Password_Team_Manger.Text, ref error_test_REPassword);
            if (!uu)
            {
                counter++;
            }
            else
                REPassword_test = Re_Password_Team_Manger.Text;

            if (password_Team_Manger.Text.Length == Re_Password_Team_Manger.Text.Length)
            {
                if (password_Team_Manger.Text != Re_Password_Team_Manger.Text)
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

            validationObject.Check_Number(Salary_Team_Manger.Text, ref empty_error_test_Salary, ref wrong_error_test_Salary);
            if (empty_error_test_Salary == "empty error")
            {
                MessageBox.Show("Please Enter Your Salary");
                counter++;
            }
            else
                Salary_test = Salary_Team_Manger.Text;

            if (wrong_error_test_Salary == "wrong error")
            {
                MessageBox.Show("Please Enter Your Salary Correctly");
                counter++;
            }
            else
                Salary_test = Salary_Team_Manger.Text;

            //Nationality validations
            //Elemens are added manually
            string Nationality_test = "";
            if (Nationality_Team_Manger.Text == "" || Nationality_Team_Manger.Text == null)
            {
                MessageBox.Show("Please Select Your Nationality");
                counter++;
            }
            else
                Nationality_test = Nationality_Team_Manger.Text;

            //Salary
            string DOF_test = DOF_Team_Manger.Text.ToString();

            //Address  
            int test;
            string test_address = "";
            if (Address_Team_Manger.Text == "")
            {
                MessageBox.Show("Please enter the address");
                counter++;
            }
            else
                test_address = Address_Team_Manger.Text.ToString();

            string team = team_id.Text; 

            if (counter == 0)
                test = controller.Insert_New_Manager(Fname_test, Lname_test, Minit_test, Email_test, Password_test,
                                                     Nationality_test, DOF_test, Salary_test, test_address,team);
            else
                test = 0;

            if (test == 0)
                MessageBox.Show("Your Sign Up is failed");
            else if (test == -1)
                MessageBox.Show("Probably your E-mail exist previously");
            else
                MessageBox.Show("You Signed Up successfully!");

        }
        private void back_Team_Manger_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();
        }

        private void Sign_Up_Team_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
