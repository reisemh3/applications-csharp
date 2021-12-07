using System;
using System.Collections.Generic;
using System.Linq;

namespace Annuaire // Note: actual namespace depends on the project name.
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
        private DateTime birthday;
        public DateTime Birthday { get => birthday; set => birthday = value; }
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
        private int phoneNumber;
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        //-----------------------------Status------------------------------- //
        private bool status;
        public bool Status { get => status; set => status = value; } 
        //------------------------------------------------------------------ //
        public Candidats()
        {
        }
        public Candidats(string lastName, string firstName, int age, DateTime birthday,string address,
         string city, int postcode, string mail, float ovrAverage, int phoneNumber, bool status)
        {
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
            return this.lastName+" : "+this.phoneNumber;
            // return $"{name : number}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Candidats candidats &&
                   lastName == candidats.lastName &&
                   LastName == candidats.LastName &&
                   firstName == candidats.firstName &&
                   FirstName == candidats.FirstName &&
                   age == candidats.age &&
                   Age == candidats.Age &&
                   birthday == candidats.birthday &&
                   Birthday == candidats.Birthday &&
                   address == candidats.address &&
                   Address == candidats.Address &&
                   city == candidats.city &&
                   City == candidats.City &&
                   postcode == candidats.postcode &&
                   Postcode == candidats.Postcode &&
                   mail == candidats.mail &&
                   Mail == candidats.Mail &&
                   ovrAverage == candidats.ovrAverage &&
                   OvrAverage == candidats.OvrAverage &&
                   phoneNumber == candidats.phoneNumber &&
                   PhoneNumber == candidats.PhoneNumber &&
                   status == candidats.status &&
                   Status == candidats.Status;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}