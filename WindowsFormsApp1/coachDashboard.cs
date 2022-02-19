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
    public partial class coachDashboard : Form
    {
        
        Validation validationObject;
        DB_Controller controller;
        login login1;
        string mail_coach;
        public coachDashboard(string mail, DB_Controller cont)
        {
            InitializeComponent();
            validationObject = new Validation();
            controller = cont;
            login1 = new login(controller); 
            //DataTable dt = controller.get_All_mails_of_Doctors();
            //allDoctors.DataSource = dt;
            //allDoctors.DisplayMember = "email";
            mail_coach = mail;

            DataTable dt22 = controller.get_All_mails_of_Statistician_to_delete(mail_coach);
            allManagers.DataSource = dt22;
            allManagers.DisplayMember = "email";

            DataTable dt22q = controller.get_All_mails_of_Statistician();
            employe_statistian.DataSource = dt22q;
            employe_statistian.DisplayMember = "email";

            
            //DataTable dt222 = controller.get_All_mails_of_Doctors_who_donnot_work();
            //employe_doctor.DataSource = dt222;
            //employe_doctor.DisplayMember = "email";
        }

        

        private void addDoctor_Click(object sender, EventArgs e)
        {
            // show sign up as a doctor
            this.Hide();
            Sign_Up_Doctor doc = new Sign_Up_Doctor();
            doc.Show();
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            Sign_Up_Team_Manager form = new Sign_Up_Team_Manager();
            form.Show();
        }

        private void employDoctor_Click(object sender, EventArgs e)
        {
            //////////////////////////////////NOT COMPLETTTTTTTED YEEEEEEEEEEEEEET
            //string doc = employe_doctor.Text;
            //int doc_id = controller.Get_Doctor_Id_from_docotr_email(doc);
            //int iddddd = controller.Get_Team_Id_from_manager_mail(mail_coach);
            //int test = controller.Update_Doctor_ID_IN_TEAMTABLE(doc_id);
            //int test_2 = controller.Update_TEAM_ID_IN_DOCTORTABLE(iddddd);

        }

        private void employManager_Click(object sender, EventArgs e)
        {
            string man = employe_statistian.Text;
            int iddddd = controller.Get_Team_Id_from_manager_mail(mail_coach);
            int test = controller.Update_TEAM_ID_IN_Stat(iddddd, employe_statistian.Text);
            if ( test == 1 )
                MessageBox.Show("Successfully!");
        }

        private void allDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeDoctor_Click(object sender, EventArgs e)
        {
            //string mail_doctor = allDoctors.Text;

            //int test= controller.DeleteDoctor(mail_doctor);
            //MessageBox.Show("Doctor is deleted successfully!");
            //allDoctors.Refresh();
        }

        private void removeManager_Click(object sender, EventArgs e)
        {
            string mail_manager = allManagers.Text;

            int test = controller.DeleteStatistician(mail_manager);
            MessageBox.Show("Statistician is deleted successfully!");
            allManagers.Refresh();
        }

        private void back_Doctor_Click(object sender, EventArgs e)
        {

        }

        private void employe_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Coach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sign_up = new Form1();
            sign_up.Show();

        }

        private void coachDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
