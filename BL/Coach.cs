using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_App_Final.DL;

namespace Buisness_App_Final.BL
{
    class Coach : Person
    {
        private string coachRole;

        public Coach(string name, string coachRole, int age, int salary, Credentials credentials) : base(name, credentials.getRole(), age, salary, credentials)
        {
            this.coachRole = coachRole;
        }

        public void setCoachRole(string coachRole)
        {
            this.coachRole = coachRole;
        }

        public string getCoachRole()
        {
            return coachRole;
        }

        public override string toString()
        {
            return "Coach";
        }
    }
}
