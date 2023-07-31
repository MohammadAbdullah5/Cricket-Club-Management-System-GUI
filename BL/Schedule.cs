using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_App_Final.BL
{
    class Schedule
    {
        protected string date;
        protected string time;

        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }

        public Schedule(string date, string time)
        {
            this.Date = date;
            this.Time = time;
        }

        public void setDate(string date)
        {
            this.Date = date;
        }

        public void setTime(string time)
        {
            this.Time = time;
        }

        public string getDate()
        {
            return Date;
        }

        public string getTime()
        {
            return Time;
        }

        public virtual string toString()
        {
            return "Schedule";
        }
    }
}
