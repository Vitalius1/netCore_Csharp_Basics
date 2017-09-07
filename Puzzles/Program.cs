using System;
using System.Linq;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            RandomArray();
            // TossCoin(Random RandObj);
            TossMultipleCoins(10);
            Names();
        }
        static void RandomArray(){
            int[] myArray = new int[10];
            Random randObj = new Random();
            for (int i = 0; i < myArray.Length; i++){
                myArray[i] = randObj.Next(5, 26);
            }
            System.Console.WriteLine(myArray.Min());
            System.Console.WriteLine(myArray.Max());
            System.Console.WriteLine(myArray.Sum());
        }

        static string TossCoin(Random RandObj){
            System.Console.WriteLine("Tossing a coin...");
            // Random RandObj = new Random();
            int CoinToss = RandObj.Next(0,2);
            string res = "Tails";
            if (CoinToss == 0){
                System.Console.WriteLine("Heads");
                res = "Heads";
            } else {
                System.Console.WriteLine("Tails");
            }
            return res;
        }

        static Double TossMultipleCoins(int Num){
            Random r = new Random();
            int CountHeads = 0;
            for (int i = 0; i < Num; i++){
                if(TossCoin(r) == "Heads"){
                    CountHeads ++;
                }
            }
            Console.WriteLine((Double)CountHeads/Num);
            return (Double)CountHeads/Num;
        }

        public static string[] Names(){
            string[] myNames = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for (int i = 0; i < myNames.Length - 1; i++){
                int r = rand.Next(i + 1, myNames.Length - 1);
                System.Console.WriteLine(r);
                string my_temp = myNames[i];
                myNames[i] = myNames[r];
                myNames[r] = my_temp;
            }
            foreach(string val in myNames){
                System.Console.WriteLine(val);
            }
            List<string> my_list = new List<string>();
            foreach(string val in myNames){
                if (val.Length > 5){
                    my_list.Add(val);
                }
            }
            string[] final_list = my_list.ToArray();
            foreach(string val in final_list){
                System.Console.WriteLine(val);
            }
            return final_list;
        }

    }
}
