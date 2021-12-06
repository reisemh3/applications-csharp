using System;
using System.Collections.Generic;
using System.Linq;

namespace Annuaire // Note: actual namespace depends on the project name.
{
    [Serializable()]
    public class Contact
    {
        private String name;
        public String Name { get => name; set => name = value; }
        private String number;
        public string Number { get => number; set => number = value; }
        public Contact()
        {
        }
        public Contact(string name, string number)
        {
            this.name = name;
            this.number = number;
        }
        public override string ToString()
        {
            return this.name+" : "+this.number;
            // return $"{name : number}";
        }
    }
}