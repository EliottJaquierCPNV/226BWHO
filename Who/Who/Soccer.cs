using System;
using System.Collections.Generic;
using System.Text;

namespace Who
{
    public class Soccer : Person
    {
        private int number;
        private string haircut;

        public Soccer(string firstname,string name,DateTime birthdate,int number,string haircut):base(firstname,name,birthdate)
        {
            this.number = number;
            this.haircut = haircut;
        }

        public int Number
        {
            get
            {
                return number;
            }
        }
        public string Haircut
        {
            get
            {
                return haircut;
            }
        }

        public override string ToString()
        {
            return base.ToString()+" "+number+" "+haircut;
        }
    }
}
