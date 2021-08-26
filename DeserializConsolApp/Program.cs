using ClassLib;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DeserializConsolApp
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(":: Deserializ All PC ::");
            List<PC> computers = new List<PC>(3);
            DeserializAllPC("D:\\listSerial.txt", ref computers);
            foreach (PC computer in computers)
            {
                computer.info();
            }

            PC compDes = new PC();

            DeserializPC("D:\\Samsung.txt", ref compDes);
            compDes.info();

            Console.WriteLine("Programm complite");
            Console.ReadKey();
        }
        public static void DeserializAllPC(string path, ref List<PC> computers)
        {
            XmlSerializer xml_formatter = new XmlSerializer(typeof(List<PC>));
            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                computers = (List<PC>)xml_formatter.Deserialize(file_xml);
            }
            Console.WriteLine("DeserializAllPC is DONE");
        }
        public static void DeserializPC(string path, ref PC computer)
        {
            XmlSerializer xml_formatter = new XmlSerializer(typeof(PC));
            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                computer = (PC)xml_formatter.Deserialize(file_xml);
            }
            Console.WriteLine("DeserializAllPC is DONE");
        }
    }
}