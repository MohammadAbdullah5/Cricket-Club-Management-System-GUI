using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_App_Final.BL;
using System.IO;

namespace Buisness_App_Final.DL
{
    class PersonDL
    {
        public static List<Person> people = new List<Person>();

        public static void addPlayerToList(Player player)
        {
            people.Add(player);
        }

        public static void removePlayer(Player player)
        {
            people.Remove(player);
        }

        public static void removePlayer(int index)
        {
            people.RemoveAt(index);
        }

        public static void addCoachToList(Coach coach)
        {
            people.Add(coach);
        }

        public static void removeCoach(int index)
        {
            people.RemoveAt(index);
        }

        public static void removeCoach(Coach coach)
        {
            people.Remove(coach);
        }

        public static void addPeopleToList(Person fan)
        {
            people.Add(fan);
        }

        public static void addUser(string name, Credentials user)
        {
            user.setRole("Fan");

            Person person = new Person(name, user);
            PersonDL.addPeopleToList(person);
        }

        public static Person login(Credentials user)
        {
            foreach (Person person in people)
            {
                if ((user.getUsername() == person.getCredentials().getUsername()) && (user.getPassword() == person.getCredentials().getPassword()))
                {
                    return person;
                }
            }
            return null;
        }

        public static Person isValidCoach(string name)
        {
            foreach (Person person in people)
            {
                if (person.toString() == "Coach")
                {
                    if (person.getName() == name)
                    {
                        return person;
                    }
                }
            }
            return null;
        }

        public static int isValidCoachAndReturnIndex(string name, string role)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].toString() == "Coach")
                {
                    Coach coach = (Coach)people[i];
                    if (people[i].getName() == name && coach.getCoachRole() == role)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static Player isValidPlayer(string name)
        {
            foreach (Person person in people)
            {
                if (person.toString() == "Player")
                {
                    if (person.getName() == name)
                    {
                        return (Player)person;
                    }
                }
            }
            return null;
        }

        public static Player isValidPlayer(string name, string role)
        {
            foreach (Person person in people)
            {
                if (person.toString() == "Player")
                {
                    Player player = (Player)person;
                    if (person.getName() == name && player.getPlayerRole() == role)
                    {
                        return (Player)person;
                    }
                }
            }
            return null;
        }

        public static List<Player> returnPlayingXI()
        {
            List <Player> players = returnPlayersList();
            List<Player> returningList = new List<Player>();
            if (players.Count > 10)
            {
                for (int i = 0; i < 11; i++)
                {
                    returningList.Add(players[i]);
                }
            }

            else
            {
                for(int i = 0; i < players.Count; i++)
                {
                    returningList.Add(players[i]);
                }
            }
            return returningList;
        }

        public static int isValidPlayerAndReturnIndex(string name, string role)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].toString() == "Player")
                {
                    Player player = (Player)people[i];
                    if (people[i].getName() == name && player.getPlayerRole() == role)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static bool changePlayerName(string currentName, string newName)
        {
            foreach (Person person in people)
            {
                if (person.toString() == "Player")
                {
                    if (person.getName() == currentName)
                    {
                        person.setName(newName);
                        return true;
                    }
                }
            }
            return false;
        }

        public static int sumPlayerSalary()
        {
            int sum = 0;
            foreach (Person person in people)
            {
                if (person.toString() == "Player")
                {
                    sum += person.getSalary();
                }
            }
            return sum;
        }

        public static List<Player> returnPlayersList()
        {
            List<Player> players = new List<Player>();

            foreach (Person person in people)
            {
                if (person.toString() == "Player")
                {
                    players.Add((Player)person);
                }
            }
            return players;
        }

        public static List<Coach> returnCoachList()
        {
            List<Coach> coaches = new List<Coach>();

            foreach (Person person in people)
            {
                if (person.toString() == "Coach")
                {
                    coaches.Add((Coach)person);
                }
            }
            return coaches;
        }

        public static int sumCoachSalary()
        {
            int sum = 0;
            foreach (Person person in people)
            {
                if (person.toString() == "Coach")
                {
                    sum += person.getSalary();
                }
            }
            return sum;
        }

        public static Player searchPlayer(string search)
        {
            for (int idx = 0; idx < people.Count; idx++)
            {
                if (search == people[idx].getName() && people[idx].toString() == "Player")
                {
                    return (Player)people[idx];
                }
            }
            return null;

        }

        public static void LoadCricketersData(string path)
        {
            string line = "";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');
                    string name = splittedRecord[0];
                    string playerRole = splittedRecord[1];
                    string battingStyle = splittedRecord[2];
                    string bowlingStyle = splittedRecord[3];
                    int age = int.Parse(splittedRecord[4]);
                    int salary = int.Parse(splittedRecord[5]);

                    string[] splittedRecordForCredentials = splittedRecord[7].Split(';');
                    string username = splittedRecordForCredentials[0];
                    string password = splittedRecordForCredentials[1];
                    string role = splittedRecordForCredentials[2];
                    Credentials credentials = new Credentials(username, password, role);

                    if (splittedRecord[6] != "null")
                    {
                        string[] splittedRecordForStats = splittedRecord[6].Split(';');
                        int innings = int.Parse(splittedRecordForStats[0]);
                        int runs = int.Parse(splittedRecordForStats[1]);
                        int wickets = int.Parse(splittedRecordForStats[2]);
                        int highScore = int.Parse(splittedRecordForStats[3]);
                        float average = float.Parse(splittedRecordForStats[4]);
                        Stats stats = new Stats(innings, runs, wickets, highScore, average);
                        Player player = new Player(name, age, playerRole, battingStyle, bowlingStyle, salary, stats, credentials);
                        people.Add(player);
                    }

                    else
                    {
                        Player player = new Player(name, age, playerRole, battingStyle, bowlingStyle, salary, credentials);
                        people.Add(player);
                    }


                }
                file.Close();
            }

            else
            {
                return;
            }
        }

        public static void changeplayingXI(int currentPlayer, int substitutedPlayer)
        {
            currentPlayer = returnGeneralListIndex(currentPlayer);
            substitutedPlayer = returnGeneralListIndex(substitutedPlayer);
            Person temp = people[currentPlayer];
            people[currentPlayer] = people[substitutedPlayer];
            people[substitutedPlayer] = temp;
        }

        public static List<Stats> returnStatsList()
        {
            List<Stats> stats = new List<Stats>();
            foreach (Person person in people)
            {
                if (person.toString() == "Player")
                {
                    Player player = (Player)person;
                    stats.Add(player.getStats());
                }
            }
            return stats;
        }

        public static int returnGeneralListIndex(int number)
        {
            int newIndex = 0;
            int check = 0;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].toString() == "Player")
                {
                    if (check == number)
                    {
                        return newIndex;
                    }
                    check++;
                }
                newIndex++;
            }
            return newIndex;
        }

        public static void LoadCoachesData(string path)
        {
            string line = "";
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] splittedRecord = line.Split(',');
                string name = splittedRecord[0];
                string coachRole = splittedRecord[1];
                int age = int.Parse(splittedRecord[2]);
                int salary = int.Parse(splittedRecord[3]);

                string[] splittedRecordForCredentials = splittedRecord[4].Split(';');
                string username = splittedRecordForCredentials[0];
                string password = splittedRecordForCredentials[1];
                string role = splittedRecordForCredentials[2];
                Credentials credentials = new Credentials(username, password, role);
                Coach coach = new Coach(name, coachRole, age, salary, credentials);
                people.Add(coach);
            }
            file.Close();
        }

        public static void storeCricketersData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);

            for (int idx = 0; idx < people.Count(); idx++)
            {
                string record = "null";
                string recordUser;
                if (people[idx].toString() == "Player")
                {
                    Player player = (Player)people[idx];
                    if (player.getStats() != null)
                    {
                        Stats stats = player.getStats();
                        record = stats.getInnings() + ";" + stats.getRuns() + ";" + stats.getWickets() + ";" + stats.getHighScore() + ";" + stats.getAverage();
                    }

                    Credentials user = people[idx].getCredentials();
                    recordUser = user.getUsername() + ";" + user.getPassword() + ";" + user.getRole();

                    file.WriteLine(people[idx].getName() + "," + player.getPlayerRole() + "," + player.getBattingStyle() + "," + player.getBowlingStyle() + "," + people[idx].getAge() + "," + people[idx].getSalary() + "," + record + "," + recordUser);
                }
            }
            file.Flush();
            file.Close();
        }

        public static void storeCoachesData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int idx = 0; idx < people.Count(); idx++)
            {
                string record = "";
                if (people[idx].toString() == "Coach")
                {
                    Coach coach = (Coach)people[idx];
                    Credentials user = people[idx].getCredentials();
                    record = user.getUsername() + ";" + user.getPassword() + ";" + user.getRole();

                    file.WriteLine(people[idx].getName() + "," + coach.getCoachRole() + "," + people[idx].getAge() + "," + people[idx].getSalary() + "," + record);
                }
            }

            file.Flush();
            file.Close();
        }

        public static void storePeoplesData(string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int idx = 0; idx < people.Count(); idx++)
            {
                string record = "";
                if (people[idx].getCredentials().getRole() == "Fan" || people[idx].getCredentials().getRole() == "Admin")
                {
                    Credentials user = people[idx].getCredentials();
                    record = user.getUsername() + ";" + user.getPassword() + ";" + user.getRole();

                    file.WriteLine(people[idx].getName() + "," + people[idx].getAge() + "," + record);
                }
            }

            file.Flush();
            file.Close();
        }

        public static void loadPeoplesData(string path)
        {
            string line = "";
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] splittedRecord = line.Split(',');
                string name = splittedRecord[0];
                int age = int.Parse(splittedRecord[1]);

                string[] splittedRecordForCredentials = splittedRecord[2].Split(';');
                string username = splittedRecordForCredentials[0];
                string password = splittedRecordForCredentials[1];
                string role = splittedRecordForCredentials[2];
                Credentials credentials = new Credentials(username, password, role);
                Person person = new Person(name, age, credentials);
                people.Add(person);
            }
            file.Close();
        }
    }
}
