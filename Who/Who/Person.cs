using System;

namespace Who
{
    public class Person
    {
        private string name;
        private string firstname;
        private DateTime birthdate;

        public Person(string firstname,string name, DateTime birthdate)
        {
            this.firstname = firstname;
            this.name = name;
            this.birthdate = birthdate;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
        }
    }
}
