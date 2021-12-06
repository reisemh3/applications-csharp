using System;
using System.Collections.Generic;
using System.Linq;

namespace Annuaire // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static String path =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Contacts.xml";
        public static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            Console.WriteLine("\n\t");
            Console.WriteLine("\t-----------------------CONTACT--------------------------");
            contacts.Add(new Contact("Joe", "0710203040"));
            contacts.Add(new Contact("Aly", "0612233445"));
            contacts.Add(new Contact("Mounira", "0610203040"));
            WriteXML(contacts);
            ReadXML();
            Console.WriteLine("\t--------------------------------------------------------");
            Console.ReadKey(true);
        }
        public static void WriteXML(List<Contact> contacts)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Contact>));

            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, contacts);
            file.Close();
        }
        public static void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Contact>));
            System.IO.StreamReader file = new StreamReader(path);
            List<Contact> listContacts = (List<Contact>)reader.Deserialize(file);
            file.Close();

            foreach(Contact c in listContacts)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}