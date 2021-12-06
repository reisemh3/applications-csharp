using System;
using System.Collections.Generic;
using System.Linq;

namespace Annuaire // Note: actual namespace depends on the project name.
{
    public class Candidats
    {
        private String name;
        private String prenom;
        private int age;
        private DateTime date;
        private String number;
        private String adresse;
        private String mail;
        private String dossier;
        private String note;
        private String status;
        public Candidats()
        {
        }
        public Candidats(string name, string prenom, int age, DateTime date, string number, string adresse, string mail, string dossier, string note, string status)
        {
            this.name = name;
            this.prenom = prenom;
            this.age = age;
            this.date = date;
            this.number = number;
            this.adresse = adresse;
            this.mail = mail;
            this.dossier = dossier;
            this.note = note;
            this.status = status;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override string? ToString()
        {
            return base.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        // public override string? ToString()
        // {
        //     return base.ToString();
        // }
    }
}