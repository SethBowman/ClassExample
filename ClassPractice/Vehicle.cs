using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    public class Vehicle
    {
        public string Type { get; set; }
        public int WheelCount { get; set; }
        public bool HasIgnition { get; set; }

        public  void Honk() 
        {
            Console.WriteLine("Honk");
        }
    }
}
