using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_App_Final.BL
{
    class TrainingSchedule : Schedule
    {
        private string endTime;
        private string description;

        public TrainingSchedule(string date, string time, string endTime, string description) : base(date, time)
        {
            this.endTime = endTime;
            this.description = description;
        }

        public void setEndTime(string endTime)
        {
            this.endTime = endTime;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return description;
        }

        public string getEndTime()
        {
            return endTime;
        }

        public override string toString()
        {
            return "Training " + base.toString();
        }
    }
}
