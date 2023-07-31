
namespace Buisness_App_Final.UI
{
    partial class FanMenu
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
            this.tableLayoutPanelFan = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdExt = new System.Windows.Forms.Button();
            this.cmdChkAchvmnts = new System.Windows.Forms.Button();
            this.cmdChkStats = new System.Windows.Forms.Button();
            this.cmdChkSchedule = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChkSchedule = new System.Windows.Forms.Panel();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.panelChkStats = new System.Windows.Forms.Panel();
            this.dataGridViewChkStats = new System.Windows.Forms.DataGridView();
            this.panelChkAchievements = new System.Windows.Forms.Panel();
            this.dataGridViewAchievements = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelFan.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelChkSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.panelChkStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkStats)).BeginInit();
            this.panelChkAchievements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchievements)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFan
            // 
            this.tableLayoutPanelFan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelFan.ColumnCount = 2;
            this.tableLayoutPanelFan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelFan.Controls.Add(this.lblHeader, 1, 0);
            this.tableLayoutPanelFan.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanelFan.Controls.Add(this.picLogo, 0, 0);
            this.tableLayoutPanelFan.Controls.Add(this.panelChkSchedule, 1, 1);
            this.tableLayoutPanelFan.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanelFan.Name = "tableLayoutPanelFan";
            this.tableLayoutPanelFan.RowCount = 2;
            this.tableLayoutPanelFan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64802F));
            this.tableLayoutPanelFan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35198F));
            this.tableLayoutPanelFan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFan.Size = new System.Drawing.Size(934, 625);
            this.tableLayoutPanelFan.TabIndex = 3;
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
            this.panel2.Controls.Add(this.cmdChkSchedule);
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
            this.cmdChkAchvmnts.Location = new System.Drawing.Point(3, 109);
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
            this.cmdChkStats.Location = new System.Drawing.Point(3, 60);
            this.cmdChkStats.Name = "cmdChkStats";
            this.cmdChkStats.Size = new System.Drawing.Size(174, 43);
            this.cmdChkStats.TabIndex = 4;
            this.cmdChkStats.Text = "Statistics ";
            this.cmdChkStats.UseVisualStyleBackColor = false;
            this.cmdChkStats.Click += new System.EventHandler(this.cmdChkStats_Click);
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
            this.panelChkSchedule.Controls.Add(this.panelChkStats);
            this.panelChkSchedule.Controls.Add(this.dataGridViewSchedule);
            this.panelChkSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChkSchedule.Location = new System.Drawing.Point(189, 119);
            this.panelChkSchedule.Name = "panelChkSchedule";
            this.panelChkSchedule.Size = new System.Drawing.Size(742, 503);
            this.panelChkSchedule.TabIndex = 8;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(79, 100);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.Size = new System.Drawing.Size(574, 303);
            this.dataGridViewSchedule.TabIndex = 0;
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
            this.dataGridViewChkStats.Location = new System.Drawing.Point(79, 100);
            this.dataGridViewChkStats.Name = "dataGridViewChkStats";
            this.dataGridViewChkStats.Size = new System.Drawing.Size(605, 318);
            this.dataGridViewChkStats.TabIndex = 0;
            // 
            // panelChkAchievements
            // 
            this.panelChkAchievements.Controls.Add(this.dataGridViewAchievements);
            this.panelChkAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChkAchievements.Location = new System.Drawing.Point(0, 0);
            this.panelChkAchievements.Name = "panelChkAchievements";
            this.panelChkAchievements.Size = new System.Drawing.Size(742, 503);
            this.panelChkAchievements.TabIndex = 1;
            // 
            // dataGridViewAchievements
            // 
            this.dataGridViewAchievements.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewAchievements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAchievements.Location = new System.Drawing.Point(117, 109);
            this.dataGridViewAchievements.Name = "dataGridViewAchievements";
            this.dataGridViewAchievements.Size = new System.Drawing.Size(495, 233);
            this.dataGridViewAchievements.TabIndex = 0;
            // 
            // FanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 627);
            this.Controls.Add(this.tableLayoutPanelFan);
            this.Name = "FanMenu";
            this.Text = "FanMenu";
            this.tableLayoutPanelFan.ResumeLayout(false);
            this.tableLayoutPanelFan.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelChkSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.panelChkStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChkStats)).EndInit();
            this.panelChkAchievements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchievements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFan;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdExt;
        private System.Windows.Forms.Button cmdChkAchvmnts;
        private System.Windows.Forms.Button cmdChkStats;
        private System.Windows.Forms.Button cmdChkSchedule;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelChkSchedule;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Panel panelChkStats;
        private System.Windows.Forms.DataGridView dataGridViewChkStats;
        private System.Windows.Forms.Panel panelChkAchievements;
        private System.Windows.Forms.DataGridView dataGridViewAchievements;
    }
}