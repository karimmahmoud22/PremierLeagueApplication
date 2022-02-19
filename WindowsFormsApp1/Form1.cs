using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DB_Controller controller_Obj;

        public Form1()
        {
            InitializeComponent();
            controller_Obj = new DB_Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_SuperVisor new_super = new Sign_Up_SuperVisor();
            new_super.Show();
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login register = new login(controller_Obj);
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Coach coach = new Sign_Up_Coach();
            coach.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Assistant_Supervisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_SuperVisor_Assistant new_super_ass = new Sign_Up_SuperVisor_Assistant();
            new_super_ass.Show();
        }

        private void Sign_Up_Team_Manager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Team_Manager new_team_manager = new Sign_Up_Team_Manager();
            new_team_manager.Show();
        }

        private void Sign_Up_Fitness_Trainer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Fitness fit = new Sign_Up_Fitness();
            fit.Show();
        }

        private void Sign_Up_Doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up_Doctor doc = new Sign_Up_Doctor();
            doc.Show();
        }

        private void players_goals_Click(object sender, EventArgs e)
        {
            statistics st = new statistics();
            st.Show();
            this.Hide();
        }
    }
}
