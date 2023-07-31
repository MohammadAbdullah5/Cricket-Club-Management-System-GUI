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
    public partial class PlayerMenu : Form
    {
        public PlayerMenu()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void makePanelVisibilityFalse()
        {
            panelChkSchedule.Visible = false;
            panelChk11.Visible = false;
            panelChkStats.Visible = false;
            panelChkAchievements.Visible = false;
            panelChkTeam.Visible = false;

            dataGridViewMatches.Visible = false;
            dataGridViewChk11.Visible = false;
            dataGridViewChkStats.Visible = false;
            dataGridViewChkAchievements.Visible = false;
            dataGridViewChkTeam.Visible = false;
        }

        private void cmdChkSchedule_Click(object sender, EventArgs e)
        {
            List<MatchSchedule> list = ScheduleDL.returnMatchSchedules();
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;

            dataGridViewMatches.DataSource = null;
            dataGridViewMatches.Visible = true;
            dataGridViewMatches.DataSource = list;
            dataGridViewMatches.Refresh();
        }

        private void cmdChkPlaying11_Click(object sender, EventArgs e)
        {
            dataGridViewChk11.DataSource = null;
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;
            panelChk11.Visible = true;

            dataGridViewChk11.DataSource = PersonDL.returnPlayingXI();
            dataGridViewChk11.Columns["Credentials"].Visible = false;
            dataGridViewChk11.Columns["Stats"].Visible = false;
            dataGridViewChk11.Columns["Role"].Visible = false;
            dataGridViewChk11.Columns["Salary"].Visible = false;
            dataGridViewChk11.Columns["Name"].DisplayIndex = 0;
            dataGridViewChk11.Columns["PlayerRole"].DisplayIndex = 1;

            dataGridViewChk11.Refresh();
            dataGridViewChk11.Visible = true;
        }

        private void cmdChkStats_Click(object sender, EventArgs e)
        {
            dataGridViewChkStats.DataSource = null;
            dataGridViewChkStats.Columns.Clear();
            dataGridViewChkStats.Rows.Clear();
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;
            panelChk11.Visible = true;
            panelChkStats.Visible = true;

            dataGridViewChkStats.Columns.Add("Name", "Name");
            dataGridViewChkStats.Columns.Add("Innings", "Innings");
            dataGridViewChkStats.Columns.Add("Runs", "Runs");
            dataGridViewChkStats.Columns.Add("Wickets", "Wickets");
            dataGridViewChkStats.Columns.Add("HighScore", "HighScore");
            dataGridViewChkStats.Columns.Add("Average", "Average");


            foreach (Player player in PersonDL.returnPlayersList())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewChkStats);

                row.Cells[0].Value = player.Name;
                if (player.Stats != null)
                {
                    row.Cells[1].Value = player.Stats.Innings;
                    row.Cells[2].Value = player.Stats.Runs;
                    row.Cells[3].Value = player.Stats.Wickets;
                    row.Cells[4].Value = player.Stats.HighScore;
                    row.Cells[5].Value = player.Stats.Average;
                }
                dataGridViewChkStats.Rows.Add(row);
            }
            dataGridViewChkStats.AllowUserToAddRows = false;

            dataGridViewChkStats.Visible = true;
            dataGridViewChkStats.Refresh();
        }

        private void cmdChkAchvmnts_Click(object sender, EventArgs e)
        {
            dataGridViewChkAchievements.DataSource = null;
            dataGridViewChkAchievements.Columns.Clear();
            dataGridViewChkAchievements.Rows.Clear();
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;
            panelChk11.Visible = true;
            panelChkStats.Visible = true;
            panelChkAchievements.Visible = true;

            dataGridViewChkAchievements.Visible = true;

            dataGridViewChkAchievements.Columns.Add("Index", "Index");
            dataGridViewChkAchievements.Columns.Add("Achievement", "Achievement");

            for (int i = 0; i < AchievementsDL.returnListOfAchievements().Count; i++)
            {
                dataGridViewChkAchievements.Rows.Add(i, AchievementsDL.returnListOfAchievements()[i]);
            }
            dataGridViewChkAchievements.AllowUserToAddRows = false;
            dataGridViewChkAchievements.Refresh();
        }

        private void cmdChkTeam_Click(object sender, EventArgs e)
        {
            dataGridViewChkTeam.DataSource = null;
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;
            panelChk11.Visible = true;
            panelChkStats.Visible = true;
            panelChkAchievements.Visible = true;
            panelChkTeam.Visible = true;

            dataGridViewChkTeam.Visible = true;
            dataGridViewChkTeam.DataSource = PersonDL.returnPlayersList();
            dataGridViewChkTeam.Columns["Credentials"].Visible = false;
            dataGridViewChkTeam.Columns["Stats"].Visible = false;
            dataGridViewChkTeam.Columns["Name"].DisplayIndex = 0;
            dataGridViewChkTeam.Refresh();
        }

        private void cmdExt_Click(object sender, EventArgs e)
        {
            Opening open = new Opening();
            open.Show();
            this.Hide();
        }
    }
}
