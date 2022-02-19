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
    public partial class FitnessDashboard : Form
    {
        DB_Controller controller;
        public FitnessDashboard(DB_Controller cont)
        {
            controller = cont;
            InitializeComponent();
        }

        //KARIM ====> NOT COMPLETED VALIDATIONS YET
        private void update_fitness_Click(object sender, EventArgs e)
        {
            // validate salary
            /*
             * check if float number
             * 
             */
            // validate dribbling
            /*
             * check if float number
             * 
             */
            // validate pass power
            /*
             * check if float number
             * 
             */
            // validate shoot power
            /*
             * check if float number
             * 
             */
        }
    }
}
