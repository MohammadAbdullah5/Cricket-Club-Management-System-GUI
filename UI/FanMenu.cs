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
    public partial class FanMenu : Form
    {
        public FanMenu()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void makePanelVisibilityFalse()
        {
            panelChkSchedule.Visible = false;
            panelChkStats.Visible = false;
            panelChkAchievements.Visible = false;

            dataGridViewSchedule.Visible = false;
            dataGridViewChkStats.Visible = false;
            dataGridViewAchievements.Visible = false;
        }

        private void cmdChkSchedule_Click(object sender, EventArgs e)
        {
            dataGridViewSchedule.DataSource = null;
            List<MatchSchedule> list = ScheduleDL.returnMatchSchedules();
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;

            dataGridViewSchedule.Visible = true;
            dataGridViewSchedule.DataSource = list;
            dataGridViewSchedule.Refresh();
        }

        private void cmdChkStats_Click(object sender, EventArgs e)
        {
            dataGridViewChkStats.DataSource = null;
            dataGridViewChkStats.Columns.Clear();
            dataGridViewChkStats.Rows.Clear();
            makePanelVisibilityFalse();
            panelChkSchedule.Visible = true;
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
            dataGridViewAchievements.DataSource = null;
            dataGridViewAchievements.Columns.Clear();
            dataGridViewAchievements.Rows.Clear();
            dataGridViewAchievements.Refresh();
            makePanelVisibilityFalse();

            panelChkSchedule.Visible = true;
            panelChkStats.Visible = true;
            panelChkAchievements.Visible = true;

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

        private void cmdExt_Click(object sender, EventArgs e)
        {
            Opening open = new Opening();
            open.Show();
            this.Hide();
        }
    }
}
