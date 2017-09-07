using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Animal Bob = new Dog(20.5, "lab");
            System.Console.WriteLine(Bob.weight);
            System.Console.WriteLine(Bob.type);
            System.Console.WriteLine(Bob.diet);
            System.Console.WriteLine(Bob.NumLegs);
            System.Console.WriteLine(Bob.distance);
            Bob.Speak();
            // Dog Rob = (Dog)Bob;
            // Rob.Speak();
        }
    }
}
