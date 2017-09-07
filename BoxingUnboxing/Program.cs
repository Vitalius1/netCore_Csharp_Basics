using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            List<object> myBox = new List<object>();
            myBox.Add(7);
            myBox.Add(28);
            myBox.Add(-1);
            myBox.Add(true);
            myBox.Add("chair");
            int sum = 0;
            foreach (var obj in myBox){
                System.Console.WriteLine(obj);
                if(obj is int){
                    sum += (int)obj;
                }
            }
            System.Console.WriteLine("The sum of the integers in the list is {0}", sum);
        }
    }
}
