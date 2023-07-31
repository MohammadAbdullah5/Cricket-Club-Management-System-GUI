using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Buisness_App_Final.BL;

namespace Buisness_App_Final.DL
{
    class ScheduleDL
    {
        public static List<Schedule> schedules = new List<Schedule>();

        public static void addTrainingSchedule(TrainingSchedule trainingSchedule)
        {
            schedules.Add(trainingSchedule);
        }

        public static void addMatchSchedule(MatchSchedule matchSchedule)
        {
            schedules.Add(matchSchedule);
        }

        public static void removeTrainingSchedule(TrainingSchedule trainingSchedule)
        {
            schedules.Remove(trainingSchedule);
        }

        public static void removeMatchSchedule(MatchSchedule matchSchedule)
        {
            schedules.Remove(matchSchedule);
        }

        public static List<TrainingSchedule> returnTrainingSchedules()
        {
            List<TrainingSchedule> trainingSchedules = new List<TrainingSchedule>();
            foreach (Schedule schedule in schedules)
            {
                if (schedule.toString() == "Training Schedule")
                {
                    trainingSchedules.Add((TrainingSchedule)schedule);
                }
            }
            return trainingSchedules;
        }

        public static List<MatchSchedule> returnMatchSchedules()
        {
            List<MatchSchedule> matchSchedules = new List<MatchSchedule>();
            foreach (Schedule schedule in schedules)
            {
                if (schedule.toString() == "Match Schedule")
                {
                    matchSchedules.Add((MatchSchedule)schedule);
                }
            }
            return matchSchedules;
        }

        public static void storeMatchSchedule(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int idx = 0; idx < schedules.Count; idx++)
            {
                if (schedules[idx].toString() == "Match Schedule")
                {
                    MatchSchedule schedule = (MatchSchedule)schedules[idx];
                    if (idx == (schedules.Count - 1) && idx != 0)
                    {
                        file.WriteLine(schedule.getOpposition() + "," + schedules[idx].getDate() + "," + schedules[idx].getTime() + "," + schedule.getGround() + "," +schedule.getTicketPrice());
                    }
                    else
                    {
                        file.WriteLine(schedule.getOpposition() + "," + schedules[idx].getDate() + "," + schedules[idx].getTime() + "," + schedule.getGround() + "," + schedule.getTicketPrice());
                    }
                }
            }
            file.Flush();
            file.Close();
        }

        public static void storeTraining(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int idx = 0; idx < schedules.Count; idx++)
            {
                if (schedules[idx].toString() == "Training Schedule")
                {
                    TrainingSchedule schedule = (TrainingSchedule)schedules[idx];
                    if (idx == (schedules.Count - 1) && idx != 0)
                    {
                        file.WriteLine(schedules[idx].getDate() + "," + schedules[idx].getTime() + "," + schedule.getEndTime() + "," + schedule.getDescription());
                    }
                    else
                    {
                        file.WriteLine(schedules[idx].getDate() + "," + schedules[idx].getTime() + "," + schedule.getEndTime() + "," + schedule.getDescription());
                    }
                }
            }
            file.Flush();
            file.Close();
        }

        public static void loadSchedule(string path)
        {
            string line = "";
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] splittedRecord = line.Split(',');
                string opposition = splittedRecord[0];
                string date = splittedRecord[1];
                string time = splittedRecord[2];
                string ground = splittedRecord[3];
                int ticketPrice = int.Parse(splittedRecord[4]);
                MatchSchedule matchSchedule = new MatchSchedule(opposition, date, time, ground, ticketPrice);
                schedules.Add(matchSchedule);
            }
            file.Close();
        }


        public static void loadTraining(string path)
        {
            string line = "";
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] splittedRecord = line.Split(',');
                string date = splittedRecord[0];
                string time = splittedRecord[1];
                string endTime = splittedRecord[2];
                string description = splittedRecord[3];
                TrainingSchedule trainingSchedule = new TrainingSchedule(date, time, endTime, description);
                schedules.Add(trainingSchedule);
            }
            file.Close();
        }
    }
}
