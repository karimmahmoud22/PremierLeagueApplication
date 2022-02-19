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
    public partial class adminHome : Form
    {
        DB_Controller myController;
        public adminHome(DB_Controller cont)
        {
            myController = cont;
            InitializeComponent();
        }

        private void adminControl_Click(object sender, EventArgs e)
        {
            //this.Hide();
            firstAdminSpecialGUI dashboard = new firstAdminSpecialGUI(myController);
            dashboard.Show();

        }

        private void coachControl_Click(object sender, EventArgs e)
        {
            //this.Hide();
            coachControl coachForm = new coachControl(myController);
            coachForm.Show();
        }

        private void teamControl_Click(object sender, EventArgs e)
        {
            //this.Hide();
            teamControl teamForm = new teamControl(myController);
            teamForm.Show();
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
