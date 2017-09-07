using System;
using System.Collections.Generic;
namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {-3,-8,9,19,0,2};
            // range();
            // OddRange();
            // Sum();
            // MyArray();
            // max(myArray);
            // avg(myArray);
            // OddArray();
            // greater(myArray, 3);
            // square(myArray);
            // noNegative(myArray);
            // MinMaxAvg(myArray);
            // Shifter(myArray);
            object[] arr = {-3, -8, 9, 19, 0, 2};
            NumberToString(arr);
        }
        // Print All Numbers of a Range
        public static void range(){
            for (int i = 1; i < 256; i++){
                System.Console.WriteLine(i);
            }
        }
        // Odd Numbers in a Range
        public static void OddRange(){
            for (int i = 1; i < 256; i++){
                if (i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }
        // Print Sum of All Numbers in Range
        public static void Sum(){
            int sum = 0;
            for (int i = 1; i < 256; i++){
                sum += i;
                System.Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }
        // Itterating through an Array
        public static void MyArray(){
            int [] array = {1,3,5,7,9,13};
            for (int idx = 0; idx < array.Length; idx++){
                System.Console.WriteLine(array[idx]);
            }
        }
        // Returning the max Value within a given array
        public static void max(int[] arr){
            int max = arr[0];
            foreach(int val in arr){
                if(val > max){
                    max = val;
                }
            }
            System.Console.WriteLine("The max value is " + max);
        }
        // Get Average of all numbers in a given array
        public static void avg(int[] arr){
            int sum = 0;
            foreach(int val in arr){
                sum += val;
            }
            System.Console.WriteLine("The average of all numbers is " + (double)sum/(double)arr.Length);
        }
        // Return an array with all odd numbers at a given range
        public static int[] OddArray(){
            List<int> myList = new List<int>();
            for (int num = 1; num < 256; num++){
                if (num % 2 != 0){
                    myList.Add(num);
                }
            }
            int[] y = myList.ToArray();
            System.Console.WriteLine(y.Length);
            return y;
        }
        // Greater than Y
        public static void greater(int[] arr, int num){
            int count = 0;
            foreach(int val in arr){
                if (val > num){
                    count += 1;
                }
            }
            System.Console.WriteLine("There are {0} number greater than {1}", count, num);
        }
        //Square the Values
        public static void square(int[] x){
            for (int idx = 0; idx < x.Length; idx++){
                x[idx] = x[idx] * x[idx];
            }
            System.Console.WriteLine(x[2]);
        }
        // Eliminate Negative Numbers
        public static void noNegative(int[] arr){
            for (int idx = 0; idx < arr.Length; idx++){
                if (arr[idx] < 0){
                    arr[idx] = 0;
                }
            }
            System.Console.WriteLine(arr[1]);
        }
        // Min Max and Average
        public static void MinMaxAvg(int[] x){
            int min = x[0];
            int max = x[0];
            int sum = 0;
            for (int idx = 0; idx < x.Length; idx++){
                if (x[idx] >= max){
                    max = x[idx];
                }
                if (x[idx] <= min){
                    min = x[idx];
                }
                sum += x[idx];
            }
            System.Console.WriteLine("The max value is {0}", max);
            System.Console.WriteLine("The min value is {0}", min);
            System.Console.WriteLine("The average value is {0}", (double)sum/(double)x.Length);
        }
        // Shifting the values in an array
        public static void Shifter(int[] x){
            for (int i = 0; i < x.Length - 1; i++){
                x[i] = x[i+1];
            }
            x[x.Length - 1] = 0;
            System.Console.WriteLine(x[0]);
            System.Console.WriteLine(x[x.Length - 1]);
        }
        // Number to string
        public static object[] NumberToString(object[] x){
            for (int i = 0; i < x.Length; i++){
                if((int)x[i] < 0){
                    x[i] = "Dojo";
                }
            }
            System.Console.WriteLine(x[1]);
            return x;
        }
    }
}
