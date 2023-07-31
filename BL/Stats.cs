using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_App_Final.BL
{
    public class Stats
    {
        private int innings;
        private int runs;
        private int wickets;
        private int highScore;
        private float average;

        public int Innings { get => innings; set => innings = value; }
        public int Runs { get => runs; set => runs = value; }
        public int Wickets { get => wickets; set => wickets = value; }
        public int HighScore { get => highScore; set => highScore = value; }
        public float Average { get => average; set => average = value; }

        public Stats(int innings, int runs, int wickets, int highScore, float average)
        {
            this.Innings = innings;
            this.Runs = runs;
            this.Wickets = wickets;
            this.HighScore = highScore;
            this.Average = average;
        }

        public int getInnings()
        {
            return Innings;
        }

        public int getRuns()
        {
            return Runs;
        }

        public int getWickets()
        {
            return Wickets;
        }

        public int getHighScore()
        {
            return HighScore;
        }

        public float getAverage()
        {
            return Average;
        }

        public void setInnings(int innings)
        {
            this.Innings = innings;
        }

        public void setRuns(int runs)
        {
            this.Runs = runs;
        }

        public void setWickets(int wickets)
        {
            this.Wickets = wickets;
        }

        public void setHighScore(int highScore)
        {
            this.HighScore = highScore;
        }

        public void setAverage(float average)
        {
            this.Average = average;
        }
    }
}
