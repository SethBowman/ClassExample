using System;

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
        }
    }
}
