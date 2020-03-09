using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Cwiczenia2
{
    public class Program
    {
        static void Main(string[] args)
        {
            String file = @"Data\dane.csv";

            FileInfo f = new FileInfo(file);
            try
            {
                StreamReader stream = new StreamReader(f.OpenRead());
                string line = "";
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //XML
            FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("uczelnia"));
            var list = new List<Student>();
            var s=new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "kowalski@wp.pl"
            };
            list.Add(s);
            serializer.Serialize(writer, list);
            Console.WriteLine("koniec");

        }
    }
}
