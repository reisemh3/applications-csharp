using System;
using System.Collections.Generic;
using System.Linq;

namespace Annuaire // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static String path =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Candidats.xml";
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

            List<Candidats> candidats = new List<Candidats>();
            Console.WriteLine("\n\t");
            Console.WriteLine("\t-----------------------CANDIDATS------------------------");
            candidats.Add(new Candidats("Joe", "0710203040"));
            candidats.Add(new Candidats("Aly", "0612233445"));
            candidats.Add(new Candidats("Mounira", "0610203040"));
            WriteXML(candidats);
            ReadXML();
            Console.WriteLine("\t--------------------------------------------------------");
            Console.ReadKey(true);
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