using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Buisness_App_Final.DL
{
    class AchievementsDL
    {
        public static List<string> achievements = new List<string>();

        public static void addAchievements(string achievement)
        {
            achievements.Add(achievement);
        }

        public static void removeAchievement(int index)
        {
            achievements.RemoveAt(index);
        }

        public static void loadAchievements(string path)
        {
            StreamReader file = new StreamReader(path);
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                achievements.Add(line);
            }
            file.Close();
        }

        public static void storeAchievements(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int idx = 0; idx < achievements.Count; idx++)
            {
                file.WriteLine(achievements[idx]);
            }

            file.Flush();
            file.Close();
        }

        public static List<string> returnListOfAchievements()
        {
            return achievements;
        }
    }
}
