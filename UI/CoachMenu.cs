using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buisness_App_Final.BL;
using Buisness_App_Final.DL;

namespace Buisness_App_Final.UI
{
    public partial class CoachMenu : Form
    {
        public CoachMenu()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void cmdCallSearch_Click(object sender, EventArgs e)
        {
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            dataGridViewSearchPlayer.DataSource = null;
        }

        private void makePanelVisibilityFalse()
        {
            panelSearchPlayer.Visible = false;
            panelChkSchedule.Visible = false;
            panelChkTeam.Visible = false;
            panelChangePlayingXI.Visible = false;
            panelChkStats.Visible = false;
            panelChkAchvmnts.Visible = false;
            panelAddStats.Visible = false;
            panelAddTraining.Visible = false;

            lblOutputSearch.Visible = false;
            lblOutputChangeXI.Visible = false;
            lblOutputTrainingSchedule.Visible = false;

            dataGridViewSearchPlayer.Visible = false;
            dataGridViewMatches.Visible = false;
            dataGridViewChkTeam.Visible = false;
            dataGridViewChngPlaying11.Visible = false;
            dataGridViewStats.Visible = false;
            dataGridViewAchievements.Visible = false;
            dataGridViewAddStats.Visible = false;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            List<Player> players = new List<Player>();
            Player player;
            if (txtSearchPlayerName.Text != "")
            {
                player = PersonDL.isValidPlayer(txtSearchPlayerName.Text);
                players.Add(player);
                if (player != null)
                {
                    dataGridViewSearchPlayer.DataSource = players;
                    dataGridViewSearchPlayer.Refresh();
                    dataGridViewSearchPlayer.Visible = true;
                    lblOutputSearch.Visible = false;
                    dataGridViewSearchPlayer.Columns["Credentials"].Visible = false;
                    dataGridViewSearchPlayer.Columns["Stats"].Visible = false;
                }

                else
                {
                    lblOutputSearch.Text = "There is no such player in the team.";
                    lblOutputSearch.Visible = true;
                    dataGridViewSearchPlayer.Visible = false;
                }
            }

            if (txtSearchPlayerName.Text == null)
            {
                lblOutputSearch.Text = "Fill the fields first.";
                lblOutputSearch.Visible = true;
                dataGridViewSearchPlayer.Visible = false;

            }
        }

        private void cmdChkSchedule_Click(object sender, EventArgs e)
        {
            List<MatchSchedule> list = ScheduleDL.returnMatchSchedules();
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;

            dataGridViewMatches.DataSource = null;
            dataGridViewMatches.Visible = true;
            dataGridViewMatches.DataSource = list;
            dataGridViewMatches.Refresh();
        }

        private void cmdChkTeam_Click(object sender, EventArgs e)
        {
            dataGridViewChkTeam.DataSource = null;
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;
            panelChkTeam.Visible = true;

            dataGridViewChkTeam.Visible = true;
            dataGridViewChkTeam.DataSource = PersonDL.returnPlayersList();
            dataGridViewChkTeam.Columns["Credentials"].Visible = false;
            dataGridViewChkTeam.Columns["Stats"].Visible = false;
            dataGridViewChkTeam.Columns["Name"].DisplayIndex = 0;
            dataGridViewChkTeam.Refresh();
        }

        private void cmdCallChangePlaying11_Click(object sender, EventArgs e)
        {
            dataGridViewChngPlaying11.DataSource = null;
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;
            panelChkTeam.Visible = true;
            panelChangePlayingXI.Visible = true;

            dataGridViewChngPlaying11.Visible = true;
            dataGridViewChngPlaying11.DataSource = PersonDL.returnPlayersList();
        }

        private void cmdChangeXI_Click(object sender, EventArgs e)
        {
            if (cBCurrentPlayer.SelectedItem != null && cBSubstitution.SelectedItem != null)
            {
                int currentIndex = int.Parse(cBCurrentPlayer.SelectedItem.ToString()) - 1;
                int substitutedIndex = int.Parse(cBSubstitution.SelectedItem.ToString()) - 1;
                if (substitutedIndex < PersonDL.returnPlayersList().Count)
                {
                    PersonDL.changeplayingXI(currentIndex, substitutedIndex);
                    lblOutputChangeXI.Visible = true;
                }

                else
                {
                    lblOutputChangeXI.Text = "Fill the forms correctly.";
                    lblOutputChangeXI.ForeColor = Color.Red;
                    lblOutputChangeXI.Visible = true;
                }
            }

            if (cBCurrentPlayer.SelectedItem == null || cBSubstitution.SelectedItem == null)
            {
                lblOutputChangeXI.Text = "Fill the forms correctly.";
                lblOutputChangeXI.ForeColor = Color.Red;
                lblOutputChangeXI.Visible = true;
            }

        }

        private void cmdChkStats_Click(object sender, EventArgs e)
        {
            dataGridViewStats.DataSource = null;
            dataGridViewStats.Columns.Clear();
            dataGridViewStats.Rows.Clear();
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;
            panelChkTeam.Visible = true;
            panelChangePlayingXI.Visible = true;
            panelChkStats.Visible = true;

            dataGridViewStats.Columns.Add("Name", "Name");
            dataGridViewStats.Columns.Add("Innings", "Innings");
            dataGridViewStats.Columns.Add("Runs", "Runs");
            dataGridViewStats.Columns.Add("Wickets", "Wickets");
            dataGridViewStats.Columns.Add("HighScore", "HighScore");
            dataGridViewStats.Columns.Add("Average", "Average");


            foreach (Player player in PersonDL.returnPlayersList())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewStats);

                row.Cells[0].Value = player.Name;
                if (player.Stats != null)
                {
                    row.Cells[1].Value = player.Stats.Innings;
                    row.Cells[2].Value = player.Stats.Runs;
                    row.Cells[3].Value = player.Stats.Wickets;
                    row.Cells[4].Value = player.Stats.HighScore;
                    row.Cells[5].Value = player.Stats.Average;
                }
                dataGridViewStats.Rows.Add(row);
            }
            dataGridViewStats.AllowUserToAddRows = false;

            dataGridViewStats.Visible = true;
            dataGridViewStats.Refresh();
        }

        private void cmdChkAchvmnts_Click(object sender, EventArgs e)
        {
            dataGridViewAchievements.DataSource = null;
            dataGridViewAchievements.Columns.Clear();
            dataGridViewAchievements.Rows.Clear();
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;
            panelChkTeam.Visible = true;
            panelChangePlayingXI.Visible = true;
            panelChkStats.Visible = true;
            panelChkAchvmnts.Visible = true;

            dataGridViewAchievements.Visible = true;

            dataGridViewAchievements.Columns.Add("Index", "Index");
            dataGridViewAchievements.Columns.Add("Achievement", "Achievement");

            for (int i = 0; i < AchievementsDL.returnListOfAchievements().Count; i++)
            {
                dataGridViewAchievements.Rows.Add(i, AchievementsDL.returnListOfAchievements()[i]);
            }
            dataGridViewAchievements.AllowUserToAddRows = false;
            dataGridViewAchievements.Refresh();
        }

        private void cmdCallAddStats_Click(object sender, EventArgs e)
        {
            dataGridViewAddStats.DataSource = null;
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;
            panelChkTeam.Visible = true;
            panelChangePlayingXI.Visible = true;
            panelChkStats.Visible = true;
            panelChkAchvmnts.Visible = true;
            panelAddStats.Visible = true;
            dataGridViewAddStats.Visible = true;

            dataGridViewAddStats.DataSource = PersonDL.returnPlayersList();
            dataGridViewAddStats.Columns["Credentials"].Visible = false;
            dataGridViewAddStats.Columns["Role"].Visible = false;
            dataGridViewAddStats.Columns["Stats"].Visible = false;
            dataGridViewAddStats.Columns["Salary"].Visible = false;
            dataGridViewAddStats.Columns["Name"].DisplayIndex = 1;
            dataGridViewAddStats.Columns["Age"].DisplayIndex = 2;
            dataGridViewAddStats.Columns["PlayerRole"].DisplayIndex = 3;

        }

        private void dataGridViewAddStats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Player user = (Player)dataGridViewAddStats.CurrentRow.DataBoundItem;
            AddStats form = new AddStats(user);
            form.Show();
        }

        private void cmdAddTrainingSchedule_Click(object sender, EventArgs e)
        {
            DateTime currentDate = datePickerTrainingSchedule.Value.Date;
            string Date = currentDate.ToString("dd-MM-yyyy");

            DateTime startTime = timePickerStartTrainingSchedule.Value;
            string Time = startTime.ToString("HH:mm");

            DateTime endTime = timePickerEndSchedule.Value;
            string eTime = endTime.ToString("HH:mm");

            if (txtDescTrainingSchedule.Text != "")
            {
                TrainingSchedule schedule = new TrainingSchedule(Date, Time, eTime, txtDescTrainingSchedule.Text);
                ScheduleDL.schedules.Add(schedule);
                lblOutputTrainingSchedule.Text = "Schedule Added !";
                lblOutputTrainingSchedule.ForeColor = Color.Green;
                lblOutputTrainingSchedule.Visible = true;
            }

            else if (txtDescTrainingSchedule.Text == "")
            {
                lblOutputTrainingSchedule.Text = "Fill all the fields correctly";
                lblOutputTrainingSchedule.ForeColor = Color.Red;
                lblOutputTrainingSchedule.Visible = true;
            }
        }

        private void cmdCallAddTraining_Click(object sender, EventArgs e)
        {
            makePanelVisibilityFalse();
            panelSearchPlayer.Visible = true;
            panelChkSchedule.Visible = true;
            panelChkTeam.Visible = true;
            panelChangePlayingXI.Visible = true;
            panelChkStats.Visible = true;
            panelChkAchvmnts.Visible = true;
            panelAddStats.Visible = true;
            panelAddTraining.Visible = true;

            timePickerStartTrainingSchedule.Format = DateTimePickerFormat.Custom;
            timePickerStartTrainingSchedule.CustomFormat = "HH:mm tt";

            timePickerEndSchedule.Format = DateTimePickerFormat.Custom;
            timePickerEndSchedule.CustomFormat = "HH:mm tt";
        }

        private void cmdExt_Click(object sender, EventArgs e)
        {
            Opening open = new Opening();
            open.Show();
            this.Hide();
        }
    }
}
