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
    public partial class DoctorDashboard : Form
    {
        DB_Controller myController;
        public DoctorDashboard(DB_Controller cont)
        {
            myController = cont;
            InitializeComponent();
        }

        //KARIM ====> NOT COMPLETED VALIDATIONS YET

        private void doctorConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
