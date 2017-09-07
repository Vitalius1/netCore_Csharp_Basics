using System;

    class Program
    {
        static void Main(string[] args)
        {
            Human Vitalie = new Human("Vitalie");
            Human Brandon = new Human("Brandon");
            Vitalie.Attack(Brandon);
            System.Console.WriteLine(Brandon.health);
            Wizard Diana = new Wizard("Diana");
            Diana.Fireball(Brandon);
            System.Console.WriteLine(Brandon.health);
        }
    }

