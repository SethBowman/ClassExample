using System;
using System.Collections.Generic;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "Lab";
            dog.Age = 2;
            dog.HasFur = true;
            dog.LegCount = 4;

            Console.WriteLine($"This dog is a {dog.Age} year old {dog.Name}. It is {dog.HasFur} that this dog has fur. It has {dog.LegCount} legs.");
            dog.Bark();

            Console.WriteLine("========");

            Dog beagle = new Dog();

            beagle.Name = "Buster";
            Console.WriteLine(beagle.Name);
            beagle.Bark();

            Console.WriteLine("========");

            // Explicit typing = Vehicle car = new Vehicle();
            // Implicit typing: 
            var car = new Vehicle();

            car.WheelCount = 4;
            car.HasIgnition = true;
            car.Type = "sedan";

            Console.WriteLine($"This {car.Type} has {car.WheelCount} wheels and it is {car.HasIgnition} that this car has an ignition.");
            car.Honk();            

        }
    }
}
