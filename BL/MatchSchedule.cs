using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_App_Final.BL
{
    class MatchSchedule : Schedule
    {
        private string opposition;
        private string ground;
        private int ticketPrice;

        public string Opposition { get => opposition; set => opposition = value; }
        public string Ground { get => ground; set => ground = value; }
        public int TicketPrice { get => ticketPrice; set => ticketPrice = value; }

        public MatchSchedule(string date, string time, string opposition, string ground, int ticketPrice) : base(date, time)
        {
            this.Opposition = opposition;
            this.Ground = ground;
            this.TicketPrice = ticketPrice;
        }

        public void setTicketPrice(int price)
        {
            this.TicketPrice = price;
        }

        public int getTicketPrice()
        {
            return ticketPrice;
        }

        public void setOpposition(string opposition)
        {
            this.Opposition = opposition;
        }

        public void setGround(string ground)
        {
            this.Ground = ground;
        }

        public string getOpposition()
        {
            return opposition;
        }

        public string getGround()
        {
            return ground;
        }

        public override string toString()
        {
            return "Match " + base.toString();
        }
    }
}
