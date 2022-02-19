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
    public partial class Sign_Up_SuperVisor : Form
    {
        Validation validationObject;
        DB_Controller controller;
        public Sign_Up_SuperVisor()
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = new DB_Controller();
        }

        private void Sign_Up_SuperVisor_Load(object sender, EventArgs e)
        {

        }

        private void firstName_SuperVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_SuperVisor_Click(object sender, EventArgs e)
        {
            //Validations of Fname of SuperVisor
            string Fname_test = "";
            string empty_error_test_Fname = "";
            string wrong_error_test_Fname = "";
            int counter = 0;

            validationObject.Check_String(firstName_SuperVisor.Text, ref empty_error_test_Fname, ref wrong_error_test_Fname);
            if (empty_error_test_Fname == "empty error")
            {
                MessageBox.Show("Please Enter Your First Name");
                counter++;
            }
            else
                Fname_test = firstName_SuperVisor.Text;

            if (wrong_error_test_Fname == "wrong error")
            {
                MessageBox.Show("Please Enter Your First Name Correctly");
                counter++;
            }
            else
                Fname_test = firstName_SuperVisor.Text;

            //Validations of Minit
            string Minit_test="";
            string empty_error_test_Minit = "";
            string wrong_error_test_Minit = "";

            validationObject.Check_String(Minit_SuperVisor.Text , ref empty_error_test_Minit , ref wrong_error_test_Minit);
            if (empty_error_test_Minit == "empty error")
            {
                MessageBox.Show("Please Enter Your Minit");
                counter++;
            }
            else
                Minit_test = Minit_SuperVisor.Text;

            if (wrong_error_test_Minit == "wrong error")
            {
                MessageBox.Show("Please Enter Your Minit Correctly");
                counter++;
            }
            else
                Minit_test = Minit_SuperVisor.Text;

            //Validations of Lname of SuperVisor
            string Lname_test = "";
            string empty_error_test_Lname = "";
            string wrong_error_test_Lname = "";

            validationObject.Check_String(lastName_SuperVisor.Text, ref empty_error_test_Lname, ref wrong_error_test_Lname);
            if (empty_error_test_Lname == "empty error")
            {
                MessageBox.Show("Please Enter Your Last Name");
                counter++;
            }
            else
                Lname_test = lastName_SuperVisor.Text;

            if (wrong_error_test_Lname == "wrong error")
            {
                MessageBox.Show("Please Enter Your Last Name Correctly");
                counter++;
            }
            else
                Lname_test = lastName_SuperVisor.Text;

            //Validations for E-mail
            string Email_test = "";

            bool tt = false;
            
            tt= validationObject.validateEmail(email_SuperVisor.Text);
            if (tt)
            {
                Email_test= email_SuperVisor.Text;
            }
            else
            {
                MessageBox.Show("Your E-mail is not Correct");
            }

            //Check for password 
            string Password_test = "";
            string error_test_Password = "";

            bool ii = validationObject._validatePassword(password_SuperVisor.Text, ref error_test_Password);
            if (!ii)
            {
                counter++;
            }
            else
            {
                Password_test = password_SuperVisor.Text;
            }
            //Check for Re-password 
            string REPassword_test = "";
            string error_test_REPassword = "";

            bool uu = validationObject._validatePassword(Re_Password_SuperVisor.Text, ref error_test_REPassword);
            if (!uu)
            {
                counter++;
            }
            else
                REPassword_test = Re_Password_SuperVisor.Text;

            if (password_SuperVisor.Text.Length == Re_Password_SuperVisor.Text.Length)
            {
                if (password_SuperVisor.Text != Re_Password_SuperVisor.Text)
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

            validationObject.Check_Number(Salary_SuperVisor.Text, ref empty_error_test_Salary, ref wrong_error_test_Salary);
            if (empty_error_test_Salary == "empty error")
            {
                MessageBox.Show("Please Enter Your Salary");
                counter++;
            }
            else
                Salary_test = Salary_SuperVisor.Text;

            if (wrong_error_test_Salary == "wrong error")
            {
                MessageBox.Show("Please Enter Your Salary Correctly");
                counter++;
            }
            else
                Salary_test = Salary_SuperVisor.Text;

            //Nationality validations
            //Elemens are added manually
            string Nationality_test="";
            if (Nationality_SuperVisor.Text == "" || Nationality_SuperVisor.Text == null)
            {
                MessageBox.Show("Please Select Your Nationality");
                counter++;
            }
            else
                Nationality_test = Nationality_SuperVisor.Text;

            //Salary
            string DOF_test = DOF_SuperVisor.Text.ToString();

            //phone number
            string phone_test = "";
            string empty_error_test_phone = "";
            string wrong_error_test_phone = "";

            validationObject.Check_Phone_Number(Phone_SuperVisor.Text, ref empty_error_test_phone, ref wrong_error_test_phone);
            if (empty_error_test_phone == "empty error")
            {
                MessageBox.Show("Please Enter Your Phone Number");
                counter++;
            }
            else
                phone_test = Phone_SuperVisor.Text;

            if (wrong_error_test_phone == "wrong error")
            {
                MessageBox.Show("Please Enter Your Phone Number Correctly");
                counter++;
            }
            else
                phone_test = Phone_SuperVisor.Text;

            int test;
            //If all information the user Entered is correct so I will insert the Supervisor, else insertion will fail
            if (counter == 0)
                test = controller.Insert_New_supervisor(Fname_test, Lname_test, Minit_test, Email_test, REPassword_test, Nationality_test,
                    DOF_test, Salary_test , phone_test);
            else
                test = 0;

            if (test == 0)
                MessageBox.Show("Your Sign Up is failed");
            else if(test == -1)
                MessageBox.Show("Probably your E-mail or Phone Number exist previously");
            else
                MessageBox.Show("You Signed Up successfully!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_SuperVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_super_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_SuperVisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();
        }

        private void Phone_Number_supervisor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
