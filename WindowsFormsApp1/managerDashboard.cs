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
    public partial class managerDashboard : Form
    {
        Validation validationObject;
        DB_Controller controller;
        string mail_stattt;
        public managerDashboard(string mail_stat , DB_Controller cont)
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = cont;

            mail_stattt = mail_stat;

            int iddd=controller.get_team_id_for_player(mail_stat);

            DataTable dt222 = controller.Get_Plyers_of_a_team(iddd);
            allPlayers.DataSource = dt222;
            allPlayers.DisplayMember = "Tshirt_number";

            DataTable dt22a2 = controller.Get_Plyers_of_a_team(iddd);
            allPlayers_update.DataSource = dt22a2;
            allPlayers_update.DisplayMember = "Tshirt_number";

            DataTable dt222a = controller.Get_Plyers_of_a_team(iddd);
            teamPlayers.DataSource = dt222a;
            teamPlayers.DisplayMember = "Tshirt_number";


            DataTable dt222saA = controller.get_team_id_for_playerr(mail_stat);
            team_from.DataSource = dt222saA;
            team_from.DisplayMember = "team_id";

            DataTable dt222saAa = controller.get_team_ids_for_transfer(iddd);
            Transfer_to.DataSource = dt222saAa;
            Transfer_to.DisplayMember = "id";


        }

        public void refreshData()
        {
            int iddd = controller.get_team_id_for_player(mail_stattt);

            DataTable dt222 = controller.Get_Plyers_of_a_team(iddd);
            allPlayers.DataSource = dt222;
            allPlayers.DisplayMember = "Tshirt_number";

            DataTable dt22a2 = controller.Get_Plyers_of_a_team(iddd);
            allPlayers_update.DataSource = dt22a2;
            allPlayers_update.DisplayMember = "Tshirt_number";

            DataTable dt222a = controller.Get_Plyers_of_a_team(iddd);
            teamPlayers.DataSource = dt222a;
            teamPlayers.DisplayMember = "Tshirt_number";


            DataTable dt222saA = controller.get_team_id_for_playerr(mail_stattt);
            team_from.DataSource = dt222saA;
            team_from.DisplayMember = "team_id";

            DataTable dt222saAa = controller.get_team_ids_for_transfer(iddd);
            Transfer_to.DataSource = dt222saAa;
            Transfer_to.DisplayMember = "id";
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            addPlayer form = new addPlayer(mail_stattt);
            form.Show();
        }

        private void transferConfirm_Click(object sender, EventArgs e)
        {

            string player_tshirt_number = teamPlayers.Text;
            string team_transfer_from = team_from.Text;
            string team_transfer_to = Transfer_to.Text;

            // controller.Update_TEAM_ID_IN_TRANSFER(Convert.ToInt32(team_transfer_to));

            /*// Validate the email
            string enteredEmail = email.Text;
            if (!validationObject.validateEmail(enteredEmail))
            {
                //email.Clear();
                //email_box.ForeColor = Color.Red;
                //email.AppendText("Email is Wrong");
                MessageBox.Show("Email is wrong");
                return;
            }

            // Validate the password
            string enteredpassword = password.Text;
            string Error = " ";
            if (!validationObject._validatePassword(enteredpassword, ref Error))
            {
                MessageBox.Show("Password is Wrong");
            }else
            {
                // check from dataBase that it is correct
                // search in database with this email (enteredEmail) and get the password
            }*/
            int rr = controller.Get_Team_Id_from_manager_stat_mail(mail_stattt);
            int coach_id = controller.Get_Coach_Id(Convert.ToInt32(Transfer_to.Text));
            int result = controller.transferPlayer(teamPlayers.Text, coach_id, Transfer_to.Text);

            MessageBox.Show("Successfully Transfered");
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check the choice
            //if (goalsCount.Text == "" || assistsCount.Text == "" || yCards.Text == "" || rcards.Text == "")
            //{
            //   MessageBox.Show("Invalid value");
            //  return;
            //}

            if (! validationObject.validatePositiveNumber(goalsCount.Text))
            {
                MessageBox.Show("Invalid Value for Goals");
                return;
            }

            if (!validationObject.validatePositiveNumber(assistsCount.Text))
            {
                MessageBox.Show("Invalid Value for Assists");
                return;
            }

            if (!validationObject.validatePositiveNumber(yCards.Text))
            {
                MessageBox.Show("Invalid Value for Yellow Cards");
                return;
            }

            if (!validationObject.validatePositiveNumber(rcards.Text))
            {
                MessageBox.Show("Invalid Value for Red Cards");
                return;
            }

            if (allPlayers_update.SelectedItem == null)
            {
                MessageBox.Show("Invalid Choice");
                return;
            }
            else
            {
                int team_id = controller.Get_Team_Id_from_manager_stat_mail(mail_stattt);
                int result = controller.updatePlayer(team_id, goalsCount.Text, assistsCount.Text, yCards.Text, rcards.Text, allPlayers_update.Text);
                // update goals in the team
                int goals = controller.getGoals(team_id);
                goals += Int16.Parse(goalsCount.Text);
                controller.updateGoals(team_id, goals);

                if (result == 1)
                {
                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Falied");
                }

            }
        }

        private void removePlayer_Click(object sender, EventArgs e)
        {
            if (allPlayers.SelectedItem == null)
            {
                MessageBox.Show("Invalid Choice");
                return;
            }
            else
            {
                // code here
                string tshirt_number= allPlayers.Text;
                controller.DeletePlayer(tshirt_number);
                MessageBox.Show("Successfully Deleted");
                refreshData();
            }
        }

        private void allPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void managerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void back_Coach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
