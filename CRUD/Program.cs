using System;
using System.Collections.Generic;
using DbConnection;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Back();
        }

        static void Back(){
            Console.Clear();
            System.Console.WriteLine("Here is the list of all users in the database");
            System.Console.WriteLine("---------------------------------------------------------");
            Read();
            System.Console.WriteLine("---------------------------------------------------------");
            Choice();
        }

        static void Choice(){
            System.Console.WriteLine("What do you want to do with the data? Type create, update or delete.");
            string request = System.Console.ReadLine();
            if (request == "create"){
                Create();
            }
            else if (request == "update"){
                Update();
            }
            else if (request == "delete"){
                Delete();
            }
            else{
                Console.Clear();
                System.Console.WriteLine("The only choices you can choose are 1)create or 2)update");
                Choice();
            }
        }

        static void Read(){
            Console.Clear();
            List<Dictionary<string, object>> users = DbConnector.Query("SELECT * FROM table1");
            foreach(var user in users){
                System.Console.WriteLine(user["id"] + " " + user["first_name"] + " " + user["last_name"] + " " + user["favorite_number"]);
            }
        }

        static void Create(){
            Console.Clear();
            System.Console.WriteLine("Give First Name:");
            string first = System.Console.ReadLine();
            System.Console.WriteLine("Give Last Name:");
            string last = System.Console.ReadLine();
            System.Console.WriteLine("Give his Favorite number:");
            int favorite = Int32.Parse(System.Console.ReadLine());
            string x = "INSERT INTO table1 (first_name, last_name, favorite_number) VALUES ('" + first + "','" + last + "','" + favorite+ "')";
            // System.Console.WriteLine(x);
            DbConnector.Execute(x);
            Back();
        }
        static void Update(){
            Console.Clear();
            Read();
            System.Console.WriteLine("Please input the id number of the user you want to update...");
            int id = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Give First Name:");
            string first = System.Console.ReadLine();
            System.Console.WriteLine("Give Last Name:");
            string last = System.Console.ReadLine();
            System.Console.WriteLine("Give his Favorite number:");
            int favorite = Int32.Parse(System.Console.ReadLine());
            string x = "UPDATE table1 SET first_name = '" + first + "', last_name = '" + last + "', favorite_number = '" + favorite + "' WHERE id = " + id;
            DbConnector.Execute(x);
            Back();
        }
        
        static void Delete(){
            Console.Clear();
            Read();
            System.Console.WriteLine("Please input the id number of the user you want to delete...");
            int id = Int32.Parse(System.Console.ReadLine());
            string x = "DELETE FROM table1 WHERE id = " + id;
            DbConnector.Execute(x);
            Back();
        }
    }
}
