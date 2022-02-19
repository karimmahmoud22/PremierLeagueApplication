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
    public partial class statistics : Form
    {
        DB_Controller mycontroller;
        DataTable temp;
        public statistics()
        {
            InitializeComponent();
            mycontroller = new DB_Controller();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            DataTable temp2 = mycontroller.getAllTeams();
            teams.DataSource = temp2;
            teams.DisplayMember = "Name";
            teams.ValueMember   = "id";

            /*temp = mycontroller.statistics(teams.SelectedValue.ToString());
            data.DataSource = temp;
            data.Refresh();

            chart.Series["goals"].XValueMember = "name";

            chart.Series["goals"].YValueMembers = "goals";

            chart.DataSource = temp;
           // chart.DataBind();*/

        }

        private void back_Coach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();
        }

        private void teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void draw_Click(object sender, EventArgs e)
        {
            temp = mycontroller.statistics(teams.SelectedValue.ToString());
            data.DataSource = temp;
            data.Refresh();

            chart.Series["goals"].XValueMember = "name";

            chart.Series["goals"].YValueMembers = "goals";

            chart.DataSource = temp;
            chart.DataBind();
            
        }
    }
}
