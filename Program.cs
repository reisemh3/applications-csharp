using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationManager // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static String path =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Candidats.xml";
        public static void Main(string[] args)
        {
            List<Candidats> candidats = new List<Candidats>();
            Console.WriteLine("\n\t");
            Console.WriteLine("\t-----------------------CANDIDATS------------------------");
            candidats.Add(new Candidats("lastName", "firstName", 30, "1990-12-12", "address", "city", 93260, "mail", 15, "0610203040", false));
            // candidats.Add(new Candidats($"{lastName, firstName, age,birthday, address, city, postcode, mail, ovrAverage, phoneNumber}"));
            // Console.WriteLine($"{Environment.NewLine}Hello, {lastName, firstName, age, birthday, mail}, from {address, city, postcode}, {mail}!");
            Console.Write($"{Environment.NewLine}");
            WriteXML(candidats);
            ReadXML();
            Console.WriteLine("\t--------------------------------------------------------");
            Console.ReadKey(true);
        }
        private void AddCandidate(string CandidatsCollections)
        {

        }
        public static void WriteXML(List<Candidats> candidats)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Candidats>));

            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, candidats);
            file.Close();
        }
        public static void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Candidats>));
            System.IO.StreamReader file = new StreamReader(path);
            List<Candidats> listCandidats = (List<Candidats>)reader.Deserialize(file);
            file.Close();

            foreach(Candidats c in listCandidats)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}