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
    public partial class login : Form         //THIS IS IN CASE OF LOG IN
    {
        Validation validationObject;
        DB_Controller myController;
        public string tt;
        public login(DB_Controller cont)
        {
            InitializeComponent();
            validationObject = new Validation();
            myController = cont;
            Log_in_button.MouseEnter += OnMouseEnterButton1;
            Log_in_button.MouseLeave += OnMouseLeaveButton1;
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
 
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            Log_in_button.BackColor = Color.Lime;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            Log_in_button.BackColor = SystemColors.ButtonFace;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            error.Visible = false;
            string job = " ";
            if (jobs.SelectedItem != null)
            {
                job = jobs.SelectedItem.ToString();
            }

            switch (job)
            {
                case "Supervisor":
                    if (myController.checkEmail_passowrd(email_box.Text, password_box.Text, job.ToLower()))
                    {
                        adminHome admin = new adminHome(myController);
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        error.Visible = true;
                    }
                    break;
                case "Supervisoer Assistant":
                    if (myController.checkEmail_passowrd(email_box.Text, password_box.Text, "supervisor_assistant"    ))
                        
                    {
                        if (myController.check_user_is_already_employed("supervisor_assistant", "supervisor_id", email_box.Text))
                        {

                            teamControl assistant = new teamControl(myController);
                            assistant.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You has no access, you are not emplyed yet");
                            return;
                        }
                    }
                    else
                    {
                        error.Visible = true;
                    }

                    break;
                case "Doctor":
                    if (myController.checkEmail_passowrd(email_box.Text, password_box.Text, job.ToLower()))
                        
                    {
                        if (myController.check_user_is_already_employed("doctor", "team_id", email_box.Text)
                        )
                        {

                            DoctorDashboard doc = new DoctorDashboard(myController);
                            doc.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("You has no access, you are not emplyed yet");
                            return;
                        }
                    }
                    else
                    {
                        error.Visible = true;
                    }

                    break;
                case "Coach":
                    if (myController.checkEmail_passowrd(email_box.Text, password_box.Text, job.ToLower()))
                        
                    {
                        //if (myController.check_user_is_already_employed("coach", "team_id", email_box.Text))
                      //  {

                            tt = email_box.Text;
                            coachDashboard coach = new coachDashboard(tt, myController);
                            coach.Show();
                            this.Hide();
                        //}
                        //else
                        //{
                            //MessageBox.Show("You has no access, you are not emplyed yet");
                          //  return;
                        //}
                    }
                    else
                    {
                        error.Visible = true;
                    }

                    break;
                case "Statistician":
                    if (myController.checkEmail_passowrd(email_box.Text, password_box.Text, "Manager"))
                    {
                        tt = email_box.Text;
                        managerDashboard mgr = new managerDashboard(tt,myController);
                        mgr.Show();
                        this.Hide();
                    }
                    else
                    {
                        error.Visible = true;
                    }

                    break;
                case "Fitness Trainer":
                    if (myController.checkEmail_passowrd(email_box.Text, password_box.Text, "fitness_trainer"))
                    {
                        FitnessDashboard fit = new FitnessDashboard(myController);
                        fit.Show();
                        this.Hide();
                    }
                    else
                    {
                        error.Visible = true;
                    }
                    break;
                default:
                    MessageBox.Show("Wrong Choice");
                    break;
            }

            /*if (this._validation())
            {
                

                
            }
            else
            {
                error.Visible = true;
            }*/
            
        }

        private bool _validation()
        {
            bool emailValid = true,
                 passValid  = true;
            // Validate the email
            string enteredEmail = email_box.Text;
            if (!validationObject.validateEmail(enteredEmail))
            {
                //email_box.Clear();
                //email_box.ForeColor = Color.Red;
                //email_box.AppendText("Email is Wrong");
                emailValid = false;
            }

            // Validate the password
            string enteredpassword = password_box.Text;
            string Error = " ";
            if (!validationObject._validatePassword(enteredpassword,ref Error))
            {
                //MessageBox.Show("Password is Wrong");
                passValid = false;
            }
            return emailValid && passValid;
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void resetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Password resetForm = new Password(myController);
            resetForm.Show();

        }
    }
}
