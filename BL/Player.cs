using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_App_Final.DL;

namespace Buisness_App_Final.BL
{
    public class Player : Person
    { 
        private string battingStyle;
        private string bowlingStyle;
        private string playerRole;
        private Stats stats;

        public string BattingStyle { get => battingStyle; set => battingStyle = value; }
        public string BowlingStyle { get => bowlingStyle; set => bowlingStyle = value; }
        public string PlayerRole { get => playerRole; set => playerRole = value; }
        public Stats Stats { get => stats; set => stats = value; }

        public Player(string name, int age, string playerRole, string battingStyle, string bowlingStyle, int salary, Credentials credentials) : base(name, credentials.getRole(), age, salary, credentials)
        {
            this.BattingStyle = battingStyle;
            this.BowlingStyle = bowlingStyle;
            this.PlayerRole = playerRole;
        }

        public Player(string name, int age, string playerRole, string battingStyle, string bowlingStyle, int salary, Stats stats, Credentials credentials) : base(name, "Player", age, salary, credentials)
        {
            this.BattingStyle = battingStyle;
            this.BowlingStyle = bowlingStyle;
            this.Stats = stats;
            this.PlayerRole = playerRole;
            
        }

        public void addStats(Stats stats)
        {
            this.Stats = stats;
        }

        public string getBattingStyle()
        {
            return BattingStyle;
        }

        public string getBowlingStyle()
        {
            return BowlingStyle;
        }

        public string getPlayerRole()
        {
            return PlayerRole;
        }

        public void setBattingStyle(string battingStyle)
        {
            this.BattingStyle = battingStyle;
        }

        public void setPlayerRole(string playerRole)
        {
            this.PlayerRole = playerRole;
        }

        public void setBowlingStyle(string bowlingStyle)
        {
            this.BowlingStyle = bowlingStyle;
        }

        public Stats getStats()
        {
            return Stats;
        }

        public override string toString()
        {
            return "Player";
        }
    }

}

