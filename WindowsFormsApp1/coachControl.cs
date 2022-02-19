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
    public partial class coachControl : Form
    {
        DB_Controller myController;
        public coachControl(DB_Controller cont)
        {
            InitializeComponent();
            myController = cont;
            coachesData.ReadOnly = true;

        }

        // mustafa --> this button for add a new coach
        private void button1_Click(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Lime;
            employButton.BackColor = SystemColors.ButtonFace;

            chooseCoach.Visible =
            coachChoose.Visible =

            teamChoose.Visible =
            chooseTeam.Visible =

            confirm.Visible = false;


            // mustafa --> after changing name of login to register, change it here too
            //this.Hide();
            Sign_Up_Coach coach = new Sign_Up_Coach();
            coach.Show();
            refreshData();


        }

        private void coachControl_Load(object sender, EventArgs e)
        {

            DataTable coaches = myController.getNotEmplyedCoaches();
            chooseCoach.DataSource = coaches;
            chooseCoach.DisplayMember = "name";
            chooseCoach.ValueMember = "id";

            DataTable teams = myController.getTeamsWithoutCoaches();
            chooseTeam.DataSource = teams;
            chooseTeam.DisplayMember = "Name";
            chooseTeam.ValueMember = "id";

            DataTable coachesTable = myController.getAllCoaches();
            coachesData.DataSource = coachesTable;
            coachesData.Refresh();
        }

        private void refreshData()
        {

            DataTable coaches = myController.getNotEmplyedCoaches();
            chooseCoach.DataSource = coaches;
            chooseCoach.DisplayMember = "name";
            chooseCoach.ValueMember = "id";

            DataTable teams = myController.getTeamsWithoutCoaches();
            chooseTeam.DataSource = teams;
            chooseTeam.DisplayMember = "Name";
            chooseTeam.ValueMember = "id";

            DataTable coachesTable = myController.getAllCoaches();
            coachesData.DataSource = coachesTable;
            coachesData.Refresh();
        }

        private void employButton_Click(object sender, EventArgs e)
        {
            employButton.BackColor = Color.Lime;
            addButton.BackColor = SystemColors.ButtonFace;

            // NOTE : change color of button when clicked

            chooseCoach.Visible = !chooseCoach.Visible;
            coachChoose.Visible = !coachChoose.Visible;

            teamChoose.Visible  = !teamChoose.Visible;
            chooseTeam.Visible  = !chooseTeam.Visible;

            confirm.Visible     = !confirm.Visible;




            refreshData();
        }

        private void chooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (chooseCoach.SelectedItem == null || chooseTeam.SelectedItem == null)
            {
                MessageBox.Show("Wrong Choice");
                return;
            }
            else
            {
                //DateTime now = DateTime.Now;    // start date will be from today

                int teamId  = (int)chooseTeam.SelectedValue;
                int coachId = (int)chooseCoach.SelectedValue;

                // update start date of the coach
                // update coachId in team table
                myController.updateTeamCoach(coachId, teamId);
                MessageBox.Show("Emplyed Successfully");
                refreshData();

            }
        }

        private void chooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Coach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();

        }
    }
}
