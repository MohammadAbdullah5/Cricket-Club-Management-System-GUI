using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_App_Final.BL
{
    public class Credentials
    {
        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public Credentials(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Credentials(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public void setUsername(string username)
        {
            this.Username = username;
        }

        public void setPassword(string password)
        {
            this.Password = password;
        }

        public void setRole(string role)
        {
            this.Role = role;
        }

        public string getUsername()
        {
            return Username;
        }

        public string getPassword()
        {
            return Password;
        }

        public string getRole()
        {
            return Role;
        }
    }
}
