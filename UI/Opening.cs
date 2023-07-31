using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buisness_App_Final.UI;
using Buisness_App_Final.BL;
using Buisness_App_Final.DL;


namespace Buisness_App_Final
{
    public partial class Opening : Form
    {
        public Opening()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void lnkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp i = new SignUp();
            i.Show();
            this.Hide();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            PersonDL.storePeoplesData("data.txt");
            PersonDL.storeCricketersData("CricketersData.txt");
            PersonDL.storeCoachesData("CoachesData.txt");
            ScheduleDL.storeMatchSchedule("Schedule.txt");
            ScheduleDL.storeTraining("Training.txt");
            AchievementsDL.storeAchievements("Achievements.txt");
            this.Close();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Credentials credentials = new Credentials(txtUsername.Text, txtPassword.Text);
            Person user = PersonDL.login(credentials);
            if (user != null)
            {
                if (user.getCredentials().getRole() == "Admin")
                {
                    AdminMenu menu = new AdminMenu();
                    menu.Show();
                    this.Hide();
                }

                else if (user.getCredentials().getRole() == "Coach")
                {
                    CoachMenu menu = new CoachMenu();
                    menu.Show();
                    this.Hide();
                }

                else if (user.getCredentials().getRole() == "Player")
                {
                    PlayerMenu menu = new PlayerMenu();
                    menu.Show();
                    this.Hide();
                }

                else if (user.getCredentials().getRole() == "Fan")
                {
                    FanMenu menu = new FanMenu();
                    menu.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }
    }
}
