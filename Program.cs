using System;
using System.Windows.Forms;
using Buisness_App_Final.DL;
using Buisness_App_Final.UI;

namespace Buisness_App_Final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PersonDL.loadPeoplesData("data.txt");
            PersonDL.LoadCricketersData("CricketersData.txt");
            PersonDL.LoadCoachesData("CoachesData.txt");
            ScheduleDL.loadSchedule("Schedule.txt");
            ScheduleDL.loadTraining("Training.txt");
            AchievementsDL.loadAchievements("Achievements.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Opening());
        }
    }
}
