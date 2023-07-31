
namespace Buisness_App_Final.UI
{
    partial class PlayerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdExt = new System.Windows.Forms.Button();
            this.cmdChkAchvmnts = new System.Windows.Forms.Button();
            this.cmdChkStats = new System.Windows.Forms.Button();
            this.cmdChkTeam = new System.Windows.Forms.Button();
            this.cmdChkSchedule = new System.Windows.Forms.Button();
            this.cmdChkPlaying11 = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChkSchedule = new System.Windows.Forms.Panel();
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.panelChk11 = new System.Windows.Forms.Panel();
            this.dataGridViewChk11 = new System.Windows.Forms.DataGridView();
            this.panelChkStats = new System.Windows.Forms.Panel();
            this.dataGridViewChkStats = new System.Windows.Forms.DataGridView();
            this.panelChkAchievements = new System.Windows.Forms.Panel();
            this.dataGridViewChkAchievements = new System.Windows.Forms.DataGridView();
            this.panelChkTeam = new System.Windows.Forms.Panel();
            this.dataGridViewChkTeam = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelPlayer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelChkSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            this.panelChk11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChk11)).BeginInit();
            this.panelChkStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkStats)).BeginInit();
            this.panelChkAchievements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkAchievements)).BeginInit();
            this.panelChkTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPlayer
            // 
            this.tableLayoutPanelPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelPlayer.ColumnCount = 2;
            this.tableLayoutPanelPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelPlayer.Controls.Add(this.lblHeader, 1, 0);
            this.tableLayoutPanelPlayer.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanelPlayer.Controls.Add(this.picLogo, 0, 0);
            this.tableLayoutPanelPlayer.Controls.Add(this.panelChkSchedule, 1, 1);
            this.tableLayoutPanelPlayer.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanelPlayer.Name = "tableLayoutPanelPlayer";
            this.tableLayoutPanelPlayer.RowCount = 2;
            this.tableLayoutPanelPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64802F));
            this.tableLayoutPanelPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35198F));
            this.tableLayoutPanelPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPlayer.Size = new System.Drawing.Size(934, 625);
            this.tableLayoutPanelPlayer.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(189, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(742, 116);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Cricket Club Management System";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdExt);
            this.panel2.Controls.Add(this.cmdChkAchvmnts);
            this.panel2.Controls.Add(this.cmdChkStats);
            this.panel2.Controls.Add(this.cmdChkTeam);
            this.panel2.Controls.Add(this.cmdChkSchedule);
            this.panel2.Controls.Add(this.cmdChkPlaying11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 503);
            this.panel2.TabIndex = 7;
            // 
            // cmdExt
            // 
            this.cmdExt.BackColor = System.Drawing.Color.SteelBlue;
            this.cmdExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExt.Location = new System.Drawing.Point(3, 437);
            this.cmdExt.Name = "cmdExt";
            this.cmdExt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdExt.Size = new System.Drawing.Size(174, 60);
            this.cmdExt.TabIndex = 11;
            this.cmdExt.Text = "Exit";
            this.cmdExt.UseVisualStyleBackColor = false;
            this.cmdExt.Click += new System.EventHandler(this.cmdExt_Click);
            // 
            // cmdChkAchvmnts
            // 
            this.cmdChkAchvmnts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdChkAchvmnts.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChkAchvmnts.Location = new System.Drawing.Point(3, 158);
            this.cmdChkAchvmnts.Name = "cmdChkAchvmnts";
            this.cmdChkAchvmnts.Size = new System.Drawing.Size(174, 43);
            this.cmdChkAchvmnts.TabIndex = 5;
            this.cmdChkAchvmnts.Text = "Achievements";
            this.cmdChkAchvmnts.UseVisualStyleBackColor = false;
            this.cmdChkAchvmnts.Click += new System.EventHandler(this.cmdChkAchvmnts_Click);
            // 
            // cmdChkStats
            // 
            this.cmdChkStats.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdChkStats.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChkStats.Location = new System.Drawing.Point(3, 109);
            this.cmdChkStats.Name = "cmdChkStats";
            this.cmdChkStats.Size = new System.Drawing.Size(174, 43);
            this.cmdChkStats.TabIndex = 4;
            this.cmdChkStats.Text = "Statistics ";
            this.cmdChkStats.UseVisualStyleBackColor = false;
            this.cmdChkStats.Click += new System.EventHandler(this.cmdChkStats_Click);
            // 
            // cmdChkTeam
            // 
            this.cmdChkTeam.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdChkTeam.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChkTeam.Location = new System.Drawing.Point(3, 207);
            this.cmdChkTeam.Name = "cmdChkTeam";
            this.cmdChkTeam.Size = new System.Drawing.Size(174, 43);
            this.cmdChkTeam.TabIndex = 2;
            this.cmdChkTeam.Text = "Team";
            this.cmdChkTeam.UseVisualStyleBackColor = false;
            this.cmdChkTeam.Click += new System.EventHandler(this.cmdChkTeam_Click);
            // 
            // cmdChkSchedule
            // 
            this.cmdChkSchedule.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdChkSchedule.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChkSchedule.Location = new System.Drawing.Point(3, 11);
            this.cmdChkSchedule.Name = "cmdChkSchedule";
            this.cmdChkSchedule.Size = new System.Drawing.Size(174, 43);
            this.cmdChkSchedule.TabIndex = 1;
            this.cmdChkSchedule.Text = "Schedule";
            this.cmdChkSchedule.UseVisualStyleBackColor = false;
            this.cmdChkSchedule.Click += new System.EventHandler(this.cmdChkSchedule_Click);
            // 
            // cmdChkPlaying11
            // 
            this.cmdChkPlaying11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdChkPlaying11.FlatAppearance.BorderSize = 3;
            this.cmdChkPlaying11.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Bold);
            this.cmdChkPlaying11.Location = new System.Drawing.Point(3, 60);
            this.cmdChkPlaying11.Name = "cmdChkPlaying11";
            this.cmdChkPlaying11.Size = new System.Drawing.Size(174, 43);
            this.cmdChkPlaying11.TabIndex = 0;
            this.cmdChkPlaying11.Text = "Check Playing XI";
            this.cmdChkPlaying11.UseVisualStyleBackColor = false;
            this.cmdChkPlaying11.Click += new System.EventHandler(this.cmdChkPlaying11_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Buisness_App_Final.Properties.Resources.logo2;
            this.picLogo.Location = new System.Drawing.Point(60, 25);
            this.picLogo.Margin = new System.Windows.Forms.Padding(60, 25, 3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(63, 66);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // panelChkSchedule
            // 
            this.panelChkSchedule.Controls.Add(this.panelChk11);
            this.panelChkSchedule.Controls.Add(this.dataGridViewMatches);
            this.panelChkSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChkSchedule.Location = new System.Drawing.Point(189, 119);
            this.panelChkSchedule.Name = "panelChkSchedule";
            this.panelChkSchedule.Size = new System.Drawing.Size(742, 503);
            this.panelChkSchedule.TabIndex = 8;
            this.panelChkSchedule.Visible = false;
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatches.Location = new System.Drawing.Point(43, 44);
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.Size = new System.Drawing.Size(666, 258);
            this.dataGridViewMatches.TabIndex = 1;
            this.dataGridViewMatches.Visible = false;
            // 
            // panelChk11
            // 
            this.panelChk11.Controls.Add(this.panelChkStats);
            this.panelChk11.Controls.Add(this.dataGridViewChk11);
            this.panelChk11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChk11.Location = new System.Drawing.Point(0, 0);
            this.panelChk11.Name = "panelChk11";
            this.panelChk11.Size = new System.Drawing.Size(742, 503);
            this.panelChk11.TabIndex = 2;
            // 
            // dataGridViewChk11
            // 
            this.dataGridViewChk11.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewChk11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChk11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChk11.Location = new System.Drawing.Point(23, 60);
            this.dataGridViewChk11.Name = "dataGridViewChk11";
            this.dataGridViewChk11.Size = new System.Drawing.Size(686, 324);
            this.dataGridViewChk11.TabIndex = 0;
            // 
            // panelChkStats
            // 
            this.panelChkStats.Controls.Add(this.panelChkAchievements);
            this.panelChkStats.Controls.Add(this.dataGridViewChkStats);
            this.panelChkStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChkStats.Location = new System.Drawing.Point(0, 0);
            this.panelChkStats.Name = "panelChkStats";
            this.panelChkStats.Size = new System.Drawing.Size(742, 503);
            this.panelChkStats.TabIndex = 1;
            // 
            // dataGridViewChkStats
            // 
            this.dataGridViewChkStats.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewChkStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChkStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChkStats.Location = new System.Drawing.Point(23, 82);
            this.dataGridViewChkStats.Name = "dataGridViewChkStats";
            this.dataGridViewChkStats.Size = new System.Drawing.Size(686, 340);
            this.dataGridViewChkStats.TabIndex = 0;
            // 
            // panelChkAchievements
            // 
            this.panelChkAchievements.Controls.Add(this.panelChkTeam);
            this.panelChkAchievements.Controls.Add(this.dataGridViewChkAchievements);
            this.panelChkAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChkAchievements.Location = new System.Drawing.Point(0, 0);
            this.panelChkAchievements.Name = "panelChkAchievements";
            this.panelChkAchievements.Size = new System.Drawing.Size(742, 503);
            this.panelChkAchievements.TabIndex = 1;
            // 
            // dataGridViewChkAchievements
            // 
            this.dataGridViewChkAchievements.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewChkAchievements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChkAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChkAchievements.Location = new System.Drawing.Point(111, 82);
            this.dataGridViewChkAchievements.Name = "dataGridViewChkAchievements";
            this.dataGridViewChkAchievements.Size = new System.Drawing.Size(539, 227);
            this.dataGridViewChkAchievements.TabIndex = 0;
            // 
            // panelChkTeam
            // 
            this.panelChkTeam.Controls.Add(this.dataGridViewChkTeam);
            this.panelChkTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChkTeam.Location = new System.Drawing.Point(0, 0);
            this.panelChkTeam.Name = "panelChkTeam";
            this.panelChkTeam.Size = new System.Drawing.Size(742, 503);
            this.panelChkTeam.TabIndex = 1;
            // 
            // dataGridViewChkTeam
            // 
            this.dataGridViewChkTeam.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewChkTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChkTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChkTeam.Location = new System.Drawing.Point(52, 60);
            this.dataGridViewChkTeam.Name = "dataGridViewChkTeam";
            this.dataGridViewChkTeam.Size = new System.Drawing.Size(640, 383);
            this.dataGridViewChkTeam.TabIndex = 0;
            // 
            // PlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 627);
            this.Controls.Add(this.tableLayoutPanelPlayer);
            this.Name = "PlayerMenu";
            this.Text = "PlayerMenu";
            this.tableLayoutPanelPlayer.ResumeLayout(false);
            this.tableLayoutPanelPlayer.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelChkSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            this.panelChk11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChk11)).EndInit();
            this.panelChkStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkStats)).EndInit();
            this.panelChkAchievements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkAchievements)).EndInit();
            this.panelChkTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdExt;
        private System.Windows.Forms.Button cmdChkAchvmnts;
        private System.Windows.Forms.Button cmdChkStats;
        private System.Windows.Forms.Button cmdChkTeam;
        private System.Windows.Forms.Button cmdChkSchedule;
        private System.Windows.Forms.Button cmdChkPlaying11;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelChkSchedule;
        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.Panel panelChk11;
        private System.Windows.Forms.DataGridView dataGridViewChk11;
        private System.Windows.Forms.Panel panelChkStats;
        private System.Windows.Forms.DataGridView dataGridViewChkStats;
        private System.Windows.Forms.Panel panelChkAchievements;
        private System.Windows.Forms.DataGridView dataGridViewChkAchievements;
        private System.Windows.Forms.Panel panelChkTeam;
        private System.Windows.Forms.DataGridView dataGridViewChkTeam;
    }
}