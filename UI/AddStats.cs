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
    public partial class AddStats : Form
    {
        Player player;
        public AddStats(Player playerNew)
        {
            InitializeComponent();
            player = playerNew;

        }

        private void cmdAddStats_Click(object sender, EventArgs e)
        {
            if (txtHighScore.Text != "" && txtInnings.Text != "" && txtRuns.Text != "" && txtWickets.Text != "")
            {
                float avg = float.Parse(txtRuns.Text) / float.Parse(txtInnings.Text);
                Stats stats = new Stats(int.Parse(txtInnings.Text), int.Parse(txtRuns.Text), int.Parse(txtWickets.Text), int.Parse(txtHighScore.Text), avg);
                player.addStats(stats);
                MessageBox.Show("Stats have been added.");
                this.Hide();
            }

            else if (txtHighScore.Text == "" || txtInnings.Text == "" || txtRuns.Text == "" || txtWickets.Text == "")
            {
                lblOutputAddStats.Text = "Enter all the fields.";
                lblOutputAddStats.ForeColor = Color.Red;
                lblOutputAddStats.Visible = true;
            }
        }
    }
}
