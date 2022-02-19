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
    public partial class firstAdminSpecialGUI : Form
    {
        Validation validationObject;
        DB_Controller myController;
        public firstAdminSpecialGUI(DB_Controller cont)
        {
            InitializeComponent();
            validationObject = new Validation();
            myController = cont;
        }

        private void adminChoose_Click(object sender, EventArgs e)
        {

        }

        private void employButton_Click(object sender, EventArgs e)
        {
            employButton.BackColor = Color.Lime;
            delete.BackColor = SystemColors.ButtonFace;
            addButton.BackColor = SystemColors.ButtonFace;

            emailEmployed.Visible   = !emailEmployed.Visible;
            adminEmail.Visible      = !adminEmail.Visible;
            supervisor_id.Visible = !supervisor_id.Visible;
            label1.Visible = !label1.Visible;

            confirmEmploy.Visible = !confirmEmploy.Visible;

            // hide controllers of remove if shown
            removedAdminEmail.Visible   = 
            removedEmail.Visible        = 
            confirmRemove.Visible       = false;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Lime;
            delete.BackColor = SystemColors.ButtonFace;
            employButton.BackColor = SystemColors.ButtonFace;

            // hide any controllers if were shown
            emailEmployed.Visible     =
            adminEmail.Visible        =
            removedEmail.Visible      =
            confirmRemove.Visible     =
            label1.Visible            =
            supervisor_id.Visible     =
            removedAdminEmail.Visible = false;

            Sign_Up_SuperVisor_Assistant newAss = new Sign_Up_SuperVisor_Assistant();
            newAss.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete.BackColor = Color.Lime;
            addButton.BackColor = SystemColors.ButtonFace;
            employButton.BackColor = SystemColors.ButtonFace;

            removedAdminEmail.Visible   = !removedAdminEmail.Visible;
            removedEmail.Visible        = !removedEmail.Visible;
            confirmRemove.Visible       = !confirmRemove.Visible;

            // hide controllers of employ if shown
            emailEmployed.Visible       =
            confirmEmploy.Visible       =
            label1.Visible              =
            supervisor_id.Visible       =
            adminEmail.Visible          = false;

        }

        private void firstAdminSpecialGUI_Load(object sender, EventArgs e)
        {
            DataTable data = myController.getSuperVisorAssistantsData();
            Assistants_data.DataSource = data;
            Assistants_data.Refresh();

            DataTable dt = myController.get_All_IDS_of_supervisors();
            supervisor_id.DataSource = dt;
            supervisor_id.DisplayMember = "id";
            supervisor_id.DataSource = dt;
            supervisor_id.Refresh();
        }

        private void refresh()
        {
            DataTable data = myController.getSuperVisorAssistantsData();
            Assistants_data.DataSource = data;
            Assistants_data.Refresh();

            DataTable dt = myController.get_All_IDS_of_supervisors();
            supervisor_id.DataSource = dt;
            supervisor_id.DisplayMember = "id";
            supervisor_id.DataSource = dt;
            supervisor_id.Refresh();
        }

        private void confirmRemove_Click(object sender, EventArgs e)
        {


            string email = removedEmail.Text;
            if (myController.checkEmail(email, "supervisor_assistant"))
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int result = myController.removeFromAnyTableByUniqueAttribute("email", email, "supervisor_assistant");
                    if (result == 1)
                    {
                        MessageBox.Show("Removed Successfully");
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }


            }
            else
            {
               // removedEmail.Clear();
                //email_box.ForeColor = Color.Red;
                MessageBox.Show("Email is Wrong");
                return;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string email = emailEmployed.Text;
            if (myController.checkAssistant(email))
            {
                int result = myController.employAssistant(email, supervisor_id.Text);
                if (result == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                emailEmployed.Clear();
                //email_box.ForeColor = Color.Red;
                emailEmployed.AppendText("Email is Wrong (or may be already employed)");
            }
        }

        private void removedEmail_TextChanged(object sender, EventArgs e)
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
