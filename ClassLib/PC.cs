using System;

namespace ClassLib
{
    public class PC
    {
        public string Stamp { get; set; }
        public string SerialNumber { get; set; }
        public string RAM { get; set; }
        public string CPU { get; set; }
        public bool Overload { get; set; }
        public bool On_Off { get; set; }

        public PC() { }
        public PC(string stamp, string serialnumber, string _RAM, string _CPU, bool overload, bool on_off)
        {
            Stamp = stamp;
            SerialNumber = serialnumber;
            RAM = _RAM;
            CPU = _CPU;
            Overload = false;
            On_Off = false;
        }

        public bool Power_On_Off
        {
            get
            {
                return On_Off;
            }
            set
            {
                if(On_Off==false)
                {
                    On_Off = true;
                }
                else
                {
                    On_Off = false;
                }
            }
        }

        public bool PCOverload
        {
            get
            {
                return Overload;
            }
            set
            {
                if(On_Off == true)
                {
                    Overload = true;
                }
                else
                {
                    Overload = false;
                }
            }
        }

        public void info()
        {
            Console.WriteLine($"Stamp:\t{Stamp}");
            Console.WriteLine($"SerialNumber:\t{SerialNumber}");
            Console.WriteLine($"RAM:\t{RAM}");
            Console.WriteLine($"CPU:\t{CPU}");
            Console.WriteLine($"Overload:\t{Overload}");
            Console.WriteLine($"Power on/off:\t{On_Off}");
        }
    }
}
