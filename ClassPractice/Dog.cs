using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    public class Dog : Animal
    {       
        public int LegCount { get; set; }
        public bool HasFur { get; set; }
      


        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
}
