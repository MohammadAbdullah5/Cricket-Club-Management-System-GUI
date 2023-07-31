using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisness_App_Final.DL;

namespace Buisness_App_Final.BL
{
    public class Person
    {
        protected string name;
        protected string role;
        protected int age;
        protected int salary;
        private Credentials credentials;

        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public int Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }
        public Credentials Credentials { get => credentials; set => credentials = value; }

        public Person(string name, string role, int age, int salary, Credentials credentials)
        {
            this.Name = name;
            this.Age = age;
            this.Role = role;
            this.Salary = salary;
            this.Credentials = credentials;
        }

        public Person(string name, Credentials credentials)
        {
            this.Name = name;
            this.Age = 0;
            this.Credentials = credentials;
            Role = null;
            Salary = 0;
        }

        public Person(string name, int age, Credentials credentials)
        {
            this.Name = name;
            this.Age = age;
            this.Credentials = credentials;
            Role = null;
            Salary = 0;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string getName()
        {
            return Name;
        }

        public int getAge()
        {
            return Age;
        }

        public string getRole()
        {
            return Role;
        }

        public int getSalary()
        {
            return Salary;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public void setAge(int age)
        {
            this.Age = age;
        }

        public void setRole(string role)
        {
            this.Role = role;
        }

        public void setSalary(int salary)
        {
            this.Salary = salary;
        }

        public Credentials getCredentials()
        {
            return Credentials;
        }

        public virtual string toString()
        {
            return Role;
        }
    }
}
