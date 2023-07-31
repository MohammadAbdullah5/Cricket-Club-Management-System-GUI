using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buisness_App_Final.DL;
using Buisness_App_Final.BL;

namespace Buisness_App_Final.UI
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void cmdCallAdd_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
        }

        private void cmdCallRemove_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            dataGridViewDeletePlayer.DataSource = PersonDL.returnPlayersList();
            dataGridViewDeletePlayer.Refresh();
            dataGridViewDeletePlayer.Visible = true;
        }

        private void cmdChkFinances_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            dataGridSalariesPlayer.DataSource = null;
            dataGridSalariesPlayer.DataSource = PersonDL.returnPlayersList();
            dataGridSalariesPlayer.Columns["Stats"].Visible = false;
            dataGridSalariesPlayer.Columns["BattingStyle"].Visible = false;
            dataGridSalariesPlayer.Columns["BowlingStyle"].Visible = false;
            dataGridSalariesPlayer.Columns["Credentials"].Visible = false;
            dataGridSalariesCoach.DataSource = PersonDL.returnCoachList();
            dataGridSalariesCoach.Columns["Credentials"].Visible = false;

            dataGridSalariesPlayer.Refresh();
            dataGridSalariesCoach.Refresh();
            dataGridSalariesCoach.Visible = true;
            dataGridSalariesPlayer.Visible = true;

            PlayerSalary.Text = string.Concat(PersonDL.sumPlayerSalary());
            CoachesSalary.Text = string.Concat(PersonDL.sumCoachSalary());
        }

        private void makePanelsVisibilityFalse()
        {
            panelAddPlayer.Visible = false;
            panelRemovePlayer.Visible = false;
            panelChkFinance.Visible = false;
            panelSearchPlayer.Visible = false;
            panelAddCoach.Visible = false;
            panelRemoveCoach.Visible = false;
            panelAddAchievements.Visible = false;
            panelChkTeam.Visible = false;
            panelChkMgmt.Visible = false;
            panelCallChngName.Visible = false;
            panelAddSchedule.Visible = false;

            lblOutputAddPlayer.Visible = false;
            lblOutputRemovePlayer.Visible = false;
            lblOutputSearch.Visible = false;
            lblOutputAddCoach.Visible = false;
            lblOutputRemoveCoach.Visible = false;
            lblOutputAchievement.Visible = false;
            lblOutputChangeName.Visible = false;
            lblOutputMatchSchedule.Visible = false;
            
            dataGridSalariesCoach.Visible = false;
            dataGridSalariesPlayer.Visible = false;
            dataGridViewChkMgmt.Visible = false;
            dataGridViewChkTeam.Visible = false;
            dataGridViewDelCoach.Visible = false;
            dataGridViewDeletePlayer.Visible = false;
            dataGridViewSearchPlayer.Visible = false;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(txtAge.Text != "" && txtBatStyle.Text != "" && txtBowlStyle.Text != "" && txtName.Text != "" && txtRole.Text != "" && txtSalary.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                Player player = new Player(txtName.Text, int.Parse(txtAge.Text), txtRole.Text, txtBatStyle.Text, txtBowlStyle.Text, int.Parse(txtSalary.Text), new Credentials(txtUsername.Text, txtPassword.Text, "Player"));
                PersonDL.people.Add(player);
                lblOutputAddPlayer.ForeColor = Color.Green;
                lblOutputAddPlayer.Text = "The player has been added.";
                lblOutputAddPlayer.Visible = true;
            }

            else if(txtAge.Text == "" || txtBatStyle.Text == "" || txtBowlStyle.Text == "" || txtName.Text == "" || txtRole.Text == "" || txtSalary.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblOutputAddPlayer.Text = "Enter all the fields.";
                lblOutputAddPlayer.ForeColor = Color.Red;
                lblOutputAddPlayer.Visible = true;
            }
        }

        private void dataBind(DataGridView dataGridViewDelete)
        {
            dataGridViewDelete.DataSource = null;
            dataGridViewDelete.DataSource = PersonDL.returnPlayersList();
            dataGridViewDelete.Refresh();
        }

        private void dataGridViewDeletePlayer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Player user = (Player)dataGridViewDeletePlayer.CurrentRow.DataBoundItem;
            PersonDL.removePlayer(user);
            dataBind(dataGridViewDeletePlayer);
            lblOutputRemovePlayer.Visible = true;
            dataGridViewDeletePlayer.Refresh();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            List <Player> players = new List<Player>();
            Player player;
            if (txtSearchPlayerName.Text != "")
            {
                player = PersonDL.isValidPlayer(txtSearchPlayerName.Text);
                players.Add(player);
                if (player != null)
                {
                    dataGridViewSearchPlayer.DataSource = players;
                    dataGridViewSearchPlayer.Columns["Credentials"].Visible = false;
                    dataGridViewSearchPlayer.Columns["Stats"].Visible = false;
                    dataGridViewSearchPlayer.Refresh();
                    dataGridViewSearchPlayer.Visible = true;
                    lblOutputSearch.Visible = false;
                }

                else
                {
                    lblOutputSearch.Text = "There is no such player in the team.";
                    lblOutputSearch.Visible = true;
                    dataGridViewSearchPlayer.Visible = false;
                }
            }

            if(txtSearchPlayerName.Text == null)
            {
                lblOutputSearch.Text = "Fill the fields first.";
                lblOutputSearch.Visible = true;
                dataGridViewSearchPlayer.Visible = false;
            }            
        }

        private void cmdAddCoach_Click(object sender, EventArgs e)
        {
            if (txtAgeAddCoach.Text != "" && txtNameAddCoach.Text != "" && txtRoleAddCoach.Text != "" && txtSalaryAddCoach.Text != "" && txtPasswordAddCoach.Text != "" && txtUsernameAddCoach.Text != "")
            {
                Coach player = new Coach(txtNameAddCoach.Text, txtRoleAddCoach.Text, int.Parse(txtAgeAddCoach.Text), int.Parse(txtSalary.Text), new Credentials(txtUsername.Text, txtPassword.Text, "Coach"));
                PersonDL.people.Add(player);
                lblOutputAddCoach.ForeColor = Color.Green;
                lblOutputAddCoach.Text = "The coach has been added.";
                lblOutputAddCoach.Visible = true;
            }

            else if (txtAgeAddCoach.Text == "" || txtNameAddCoach.Text == "" || txtRoleAddCoach.Text == "" || txtSalaryAddCoach.Text == "" || txtPasswordAddCoach.Text == "" || txtUsernameAddCoach.Text == "")
            {
                lblOutputAddCoach.Text = "Enter all the fields.";
                lblOutputAddCoach.ForeColor = Color.Red;
                lblOutputAddCoach.Visible = true;
            }
        }

        private void cmdCallRemoveCoach_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
            panelRemoveCoach.Visible = true;
            dataGridViewDelCoach.DataSource = PersonDL.returnCoachList();
            dataGridViewDelCoach.Refresh();
            dataGridViewDelCoach.Visible = true;
        }

        private void dataGridViewDelCoach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Coach user = (Coach)dataGridViewDelCoach.CurrentRow.DataBoundItem;
            PersonDL.removeCoach(user);
            dataBind(dataGridViewDelCoach);
            lblOutputRemoveCoach.Visible = true;
            dataGridViewDelCoach.Refresh();
            dataGridViewDelCoach.Visible = true;
        }

        private void cmdSearchPlayer_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
        }

        private void cmdCallAddCoach_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
        }

        private void cmdAddAchievements_Click(object sender, EventArgs e)
        {
            if(txtAchievement.Text != "")
            {
                AchievementsDL.addAchievements(txtAchievement.Text);
                lblOutputAchievement.Visible = true;
            }

            else
            {
                lblOutputAchievement.Text = "Fill the field correctly.";
                lblOutputAchievement.Visible = true;
            }
        }

        private void cmdCallAddAchievements_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
            panelRemoveCoach.Visible = true;
            panelAddAchievements.Visible = true;
        }

        private void cmdChkTeam_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
            panelRemoveCoach.Visible = true;
            panelAddAchievements.Visible = true;
            panelChkTeam.Visible = true;
            dataGridViewChkTeam.DataSource = PersonDL.returnPlayersList();
            dataGridViewChkTeam.Columns["Stats"].Visible = false;
            dataGridViewChkTeam.Columns["Credentials"].Visible = false;
            dataGridViewChkTeam.Refresh();
            dataGridViewChkTeam.Visible = true;
        }

        private void cmdCallChkMgmt_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
            panelRemoveCoach.Visible = true;
            panelAddAchievements.Visible = true;
            panelChkTeam.Visible = true;
            panelChkMgmt.Visible = true;
            dataGridViewChkMgmt.DataSource = PersonDL.returnCoachList();
            dataGridViewChkMgmt.Columns["Credentials"].Visible = false;
            dataGridViewChkMgmt.Refresh();
            dataGridViewChkMgmt.Visible = true;
        }

        private void cmdCallChangeName_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
            panelRemoveCoach.Visible = true;
            panelAddAchievements.Visible = true;
            panelChkTeam.Visible = true;
            panelChkMgmt.Visible = true;
            panelCallChngName.Visible = true;
        }

        private void cmdChangeName_Click(object sender, EventArgs e)
        {
            if(txtCurrentNameChangeName.Text != "" && txtNewNameChangeName.Text != "")
            {
                bool flag = PersonDL.changePlayerName(txtCurrentNameChangeName.Text, txtNewNameChangeName.Text);
                if(flag == true)
                {
                    lblOutputChangeName.Text = "The name of the player has been changed.";
                    lblOutputChangeName.ForeColor = Color.Green;
                    lblOutputChangeName.Visible = true;
                }

                else
                {
                    lblOutputChangeName.Text = "No such player is found in the team.";
                    lblOutputChangeName.ForeColor = Color.Red;
                    lblOutputChangeName.Visible = true;
                }
            }

            else if (txtCurrentNameChangeName.Text == "" || txtNewNameChangeName.Text == "")
            {
                lblOutputChangeName.Text = "Fill the fields correctly.";
                lblOutputChangeName.ForeColor = Color.Red;
                lblOutputChangeName.Visible = true;
            }
        }

        private void cmdCallScheduleMatch_Click(object sender, EventArgs e)
        {
            makePanelsVisibilityFalse();
            panelAddPlayer.Visible = true;
            panelRemovePlayer.Visible = true;
            panelChkFinance.Visible = true;
            panelSearchPlayer.Visible = true;
            panelAddCoach.Visible = true;
            panelRemoveCoach.Visible = true;
            panelAddAchievements.Visible = true;
            panelChkTeam.Visible = true;
            panelChkMgmt.Visible = true;
            panelCallChngName.Visible = true;
            panelAddSchedule.Visible = true;
            timePickerMatchSchedule.Format = DateTimePickerFormat.Time;
            timePickerMatchSchedule.Format = DateTimePickerFormat.Custom;
            timePickerMatchSchedule.CustomFormat = "HH:mm tt";
        }

        private void cmdAddMatchSchedule_Click(object sender, EventArgs e)
        {
            DateTime currentDate = datePickerMatchSchedule.Value.Date;
            string Date = currentDate.ToString("dd-MM-yyyy");

            DateTime currentTime = timePickerMatchSchedule.Value;
            string Time = currentTime.ToString("HH:mm");

            if(txtGroundMatchSchedule.Text != "" && txtOppositionMatchSchedule.Text != "" && txtPriceMatchSchedule.Text != "")
            {
                MatchSchedule schedule = new MatchSchedule(Date, Time, txtOppositionMatchSchedule.Text, txtGroundMatchSchedule.Text, int.Parse(txtPriceMatchSchedule.Text));
                ScheduleDL.schedules.Add(schedule);
                lblOutputMatchSchedule.Text = "Schedule Added !";
                lblOutputMatchSchedule.ForeColor = Color.Green;
                lblOutputMatchSchedule.Visible = true;
            }

            else if(txtGroundMatchSchedule.Text == "" || txtOppositionMatchSchedule.Text == "" || txtPriceMatchSchedule.Text == "")
            {
                lblOutputMatchSchedule.Text = "Fill all the fields correctly";
                lblOutputMatchSchedule.ForeColor = Color.Red;
                lblOutputMatchSchedule.Visible = true;
            }
        }

        private void cmdExt_Click(object sender, EventArgs e)
        {
            Opening open = new Opening();
            open.Show();
            this.Hide();
        }
    }
}
