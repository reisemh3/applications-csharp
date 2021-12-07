using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationManager // Note: actual namespace depends on the project name.
{
    [Serializable()]
    public class Candidats //Formulaire de candidatures
    {
        //------------------------------LastName---------------------------- //
        private String lastName;
        public String LastName { get => lastName; set => lastName = value; }
        //------------------------------FirstName--------------------------- //
        private String firstName;
        public String FirstName { get => firstName; set => firstName = value; }
        //--------------------------------Age------------------------------- //
        private int age;
        public int Age { get => age; set => age = value; }
        //-------------------------------Birthday--------------------------- //
        private String birthday;
        public string Birthday { get => birthday; set => birthday = value; }
        //-------------------------------Address---------------------------- //
        private String address;
        public string Address { get => address; set => address = value; }
        //-----------------------------city--------------------------------- //
        private String city;
        public string City { get => city; set => city = value; }
        //----------------------------Postcode------------------------------ //
        private int postcode;
        public int Postcode { get => postcode; set => postcode = value; }
        //-----------------------------Mail--------------------------------- //
        private String mail;
        public string Mail { get => mail; set => mail = value; } 
        //---------------------------OvrAverage----------------------------- //
        private float ovrAverage;
        public float OvrAverage { get => ovrAverage; set => ovrAverage = value; } 
        //---------------------------PhoneNumber---------------------------- //
        private String phoneNumber;
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        //-----------------------------Status------------------------------- //
        private bool status;
        public bool Status { get => status; set => status = value; } 
        //------------------------------------------------------------------ //
        public Candidats()
        {
        }
        public Candidats(string lastName, string firstName, int age, string birthday,string address,
         string city, int postcode, string mail, float ovrAverage, string phoneNumber, bool status)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.birthday = birthday;
            this.address = address;
            this.city = city;
            this.postcode = postcode;
            this.mail = mail;
            this.ovrAverage = ovrAverage;
            this.phoneNumber = phoneNumber;
            this.status = status;
        }

        //------------------------------------------------------------------ //
        public override string ToString()
        {
            return "Nom: "+this.lastName+" - Prenom: "+this.firstName+" - Age: "+
            this.age+" - Anniversary: "+this.birthday+" - Adresse: "+
            this.address+" - Ville: "+this.city+" - CodePostal: "+
            this.postcode+" - Email: "+this.mail+" - MoyenneScolaire: "+
            this.ovrAverage+" - Telephone: "+this.phoneNumber+" - INSCRIPTION: "+
            this.status;
            // return $"{name : number}";
        }
    }
}