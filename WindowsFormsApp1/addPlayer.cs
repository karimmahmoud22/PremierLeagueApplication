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
    public partial class addPlayer : Form
    {
        Validation validationObject;
        DB_Controller myController;
        string mail_st;
        public addPlayer(string mail_stat)
        {
            InitializeComponent();
            validationObject = new Validation();
            myController = new DB_Controller();
            mail_st = mail_stat;

            DataTable dt222saAa = myController.get_name_team_for_player(mail_st);
            team_id.DataSource = dt222saAa;
            team_id.DisplayMember = "Name";

        }

        private void addPlayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // check minit ------->>>>>>>>>> NOT-COMPLETED
        private void addButton_Click(object sender, EventArgs e)
        {
            // validate names
            string name = firstName.Text;
            if (!validationObject.validateString(name))
            {
                //firstName.Clear();
                //firstName.AppendText("Invalid Name");
                MessageBox.Show("Invalid First Name");
                return;
            }
            name = lastName.Text;
            if (!validationObject.validateString(lastName.Text))
            {
                // lastName.Clear();
                //lastName.AppendText("Invalid Name");
                MessageBox.Show("Invalid Last Name");
                return;
            }

            // Validate nationality
            string nationality = " ";
            if (Nationality.SelectedItem != null)
            {
                nationality = Nationality.SelectedItem.ToString();
            }else
            {
                MessageBox.Show("Invalid Nationality");
                return;
            }

            //Validate age
            System.DateTime dof = DOF.Value;
            int playerYear = dof.Year,
                currentYear = System.DateTime.Now.Year;

            int age = currentYear - playerYear;
            if (age <= 15 || age > 50)
            {
                MessageBox.Show("Invalid Age");
                return;
            }


            // validate position
            if (position.SelectedItem != null)
            {
                string playerPosition = position.SelectedItem.ToString();
                // add to data base
            }
            else
            {
                MessageBox.Show("Invalid Position");
                return;
            }

            // validate t-shirt number
            if (validationObject.validatePositiveNumber(number.Text) &&
                validationObject.validateNumberRange(Int16.Parse(number.Text), 1, 100))
            {
                // check T-shirt NUmber is unique
                if (! myController.check_TshirtNumber(myController.Get_Team_Id_from_manager_stat_mail(mail_st) , number.Text))
                {
                    MessageBox.Show("Duplicate T-shirt Number");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid T-shirt Number");
                return;
            }
            
            // validate injured
            if (injured.SelectedItem != null)
            {
                // add to data base
            }
            else
            {
                MessageBox.Show("Invalid Injured Choice");
                return;
            }

            // validate hegiht

            if (!validationObject.validatePositiveNumber(height.Text, true))
            {
                MessageBox.Show("Invaid Height");
                return;
            }
            // validate weight
            if (!validationObject.validatePositiveNumber(weight.Text, true))
            {
                MessageBox.Show("Invaid weight");
                return;
            }
            // validate price
            if (!validationObject.validatePositiveNumber(price.Text, true))
            {
                MessageBox.Show("Invaid Price");
                return;
            }
            // validate salary
            if (!validationObject.validatePositiveNumber(player_salary.Text, true))
            {
                MessageBox.Show("Invaid Salary");
                return;
            }
            // validate dribbling
            if (!validationObject.validatePositiveNumber(dribbling.Text, true))
            {
                MessageBox.Show("Invaid Dribbling");
                return;
            }
            // validate pass power
            if (!validationObject.validatePositiveNumber(passPower.Text, true))
            {
                MessageBox.Show("Invaid Pass Power");
                return;
            }
            // validate shoot power
            if (!validationObject.validatePositiveNumber(shootPower.Text, true))
            {
                MessageBox.Show("Invaid Shoot Power");
                return;
            }

            //AFTER VALIDATIONS PASS THE PARAMETESRS TO INSERT NEW PLAYER

            string mail = mail_st;
            int team_id = myController.Get_Team_Id_from_manager_stat_mail(mail);
            int coach_id = myController.Get_Coach_Id(team_id);
            int test = myController.Insert_New_Player(firstName.Text, lastName.Text,Minit.Text, Nationality.Text, DOF.Text,Convert.ToInt32( player_salary.Text)
                , Convert.ToInt32(passPower.Text), Convert.ToInt32(shootPower.Text) , Convert.ToInt32(number.Text) , Convert.ToInt32(dribbling.Text) ,
                injured.Text , height.Text , weight.Text , Convert.ToInt32(price.Text), position.Text , team_id , coach_id );
            if (test == 0)
                MessageBox.Show("failed");
            else if (test == -1)
                MessageBox.Show("failed");
            else
                MessageBox.Show("successfully added!");

        }

        private void back_Coach_Click(object sender, EventArgs e)
        {
            string h="";
            DB_Controller f=new DB_Controller();
            this.Hide();
            managerDashboard sign_up = new managerDashboard(h,f );
            sign_up.Show();

        }
    }
}
