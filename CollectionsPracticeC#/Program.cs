using System;
using System.Collections.Generic;

namespace collections_practice_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // int[] numArray = new int[10];
            // for (int num = 1; num <= 10; num++){
            //     numArray[num-1] = num;
            // }
            // Console.WriteLine(numArray[9]);

            string[] strNames = {"Tim", "Martin", "Nikki", "Sara"};
            // Console.WriteLine(strNames[1]);

            // bool[] boolArray = new bool[10];
            // for (int i = 0; i < 10; i += 2){
            //     boolArray[i] = true;
            // }
            // Console.WriteLine(boolArray[1]);

            // int [,] multiplicationTable = new int[10,10];
            // for (int x = 1; x <= 10; x++){
            //     for (int y = 1; y <= 10; y++){
            //         multiplicationTable[x-1,y-1] = x*y;
            //     }
            // }
            // for(int x = 0; x < 10; x++){
            //     string display = "[ ";
            //     for(int y = 0; y < 10; y++)
            //     {
            //         display += multiplicationTable[x, y] + ", ";
            //         //Add an extra space for single digit values
            //         if(multiplicationTable[x,y] < 10)
            //         {
            //             display += " ";
            //         }
            //     }
            //     display += "]";
            //     Console.WriteLine(display);
            // }

            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Vanila");
            iceCream.Add("Strawberry");
            iceCream.Add("Mint");
            iceCream.Add("Peanut");
            // Console.WriteLine(iceCream.Count);
            // Console.WriteLine(iceCream[2]);
            // iceCream.RemoveAt(2);
            // Console.WriteLine(iceCream.Count);

            Dictionary<string,string> profile = new Dictionary<string,string>();
            Random rand = new Random();
            foreach (string name in strNames){
                profile.Add(name, iceCream[rand.Next(iceCream.Count)]);
            }
            foreach (var entry in profile){
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
