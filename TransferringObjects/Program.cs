using ClassLib;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializConsolApp
{
    public class Program
    {
        static void Main()
        {
            List<PC> computers = new List<PC>(3);

            computers.Add(new PC("Samsung", "S5DC12CEDSF", "8GB", "Core I-3 5400", false, false));
            computers.Add(new PC("Lenovo", "E1VS65DFFD1", "16GB", "AMD-A5", false, false));
            computers.Add(new PC("Asus", "VD5VCDV15D2D", "24GB", "Core I-7 7300", false, false));
            computers.Add(new PC("HP", "C51VFB1N5H", "12GB", "AMD-A4", false, false));
            computers.Add(new PC("Aser", "U5IKM51J3HJ1", "64GB", "Core I-5 5200", false, false));

            SerializAllPC("D:\\listSerial.txt", ref computers);

            foreach (PC computer in computers)
            {
                SerializPC("D:\\" + computer.Stamp + "_" + computer.SerialNumber + ".txt", computer);
            }

            Console.WriteLine("Programm complite");
            Console.ReadKey();
        }

        public static void SerializAllPC(string path, ref List<PC> computers)
        {
            if (File.Exists(path))
            {
                Console.WriteLine($"Файл с именем {path} уже существует.\nОн будет перезаписан.");
            }
            XmlSerializer xml = new XmlSerializer(typeof(List<PC>));
            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(file_xml, computers);
            }
            Console.WriteLine("SerializAllPC is done");
        }
        public static void SerializPC(string path, PC computer)
        {
            if (File.Exists(path))
            {
                Console.WriteLine($"Файл с именем {path} уже существует.\nОн будет перезаписан.");
            }
            XmlSerializer xml = new XmlSerializer(typeof(PC));
            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(file_xml, computer);
            }
            Console.WriteLine($"SerializPC {path} is done.");
        }
    }
}
