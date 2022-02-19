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
    public partial class teamControl : Form
    {
        DB_Controller myController;
        Validation validationObject;
        DataTable allTeams;
        public teamControl(DB_Controller cont)
        {
            myController = cont;
            InitializeComponent();
            validationObject = new Validation();
            teamsData.ReadOnly = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teamControl_Load(object sender, EventArgs e)
        {
           // myController = new DB_Controller();
            allTeams = myController.getAllTeams();
            teamsData.DataSource = allTeams;
            teamsData.Refresh();

            chooseTeam.DataSource    = allTeams;
            chooseTeam.DisplayMember = "Name";
            chooseTeam.ValueMember   = "Name";

        }

        private void refreshData()
        {
            myController = new DB_Controller();
            allTeams = myController.getAllTeams();
            teamsData.DataSource = allTeams;
            teamsData.Refresh();

            chooseTeam.DataSource = allTeams;
            chooseTeam.DisplayMember = "Name";
            chooseTeam.ValueMember = "Name";


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            addTeam.ForeColor = Color.Green;
            removeTeam.ForeColor = Color.Black;

            //teamName.Visible = !teamName.Visible;
            //teamNameLabel.Visible = !teamNameLabel.Visible;
            //budget.Visible = !budget.Visible;
            //budgetLabel.Visible = !budgetLabel.Visible;
            //playersCount.Visible = !playersCount.Visible;
            //playersCountLabel.Visible = !playersCountLabel.Visible;

            //choosePlayer.Hide();
            //teamPlayers.Hide();
            //delete.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void removeTeam_CheckedChanged(object sender, EventArgs e)
        {
            addTeam.ForeColor = Color.Black;
            removeTeam.ForeColor = Color.Green;

            // if remove is checked, show remove controllers
            // if add is checked, show add controllers
            choosePlayer.Visible        = !choosePlayer.Visible;
            chooseTeam.Visible         = !chooseTeam.Visible;
            delete.Visible              = !delete.Visible;
            
            teamName.Visible            = !teamName.Visible;
            teamNameLabel.Visible       = !teamNameLabel.Visible;
            budget.Visible              = !budget.Visible;
            budgetLabel.Visible         = !budgetLabel.Visible;
            playersCount.Visible        = !playersCount.Visible;
            playersCountLabel.Visible   = !playersCountLabel.Visible;
            submit.Visible              = !submit.Visible;

            nameError.Visible = budgetError.Visible = countError.Visible = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // validatiton of team name
            string name = teamName.Text;
            int playersCounter;
            if (validationObject.validateString(name))
            {
                nameError.Visible = false;

                if (!myController.checkTeamNameUniqueness(name))
                {
                    MessageBox.Show("This Name is taken, Write antoher name");
                    return;
                }

            }
            else
            {
                //teamName.Clear();
                //email_box.ForeColor = Color.Red;
                nameError.Visible = true;
                return;
            }
            
            // validation of numbers
            if (! validationObject.validatePositiveNumber(budget.Text, true))
            {
                budgetError.Visible = true;
                return;
            } else
            {
                budgetError.Visible = false;

            }

            if ( validationObject.validatePositiveNumber(playersCount.Text) && validationObject.validateNumberRange(Int16.Parse(playersCount.Text), 15, 40))
            {
                playersCounter = Int16.Parse(playersCount.Text);        // if the user enter 13.5 we will take 13
                countError.Visible = false;
            }
            else
            {
                countError.Visible = true;
                return;
            }

            myController.InsertTeam(name, 0, decimal.Parse(budget.Text), 0, 0);
            refreshData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (chooseTeam.SelectedItem == null)
            {
                MessageBox.Show("Wrong Choice");
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string chosenTeamToDelete = chooseTeam.SelectedValue.ToString();
                int result = myController.removeFromAnyTableByUniqueAttribute("Name", chosenTeamToDelete, "team");

                if (result == 1)
                {
                    MessageBox.Show("Deleted");
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
