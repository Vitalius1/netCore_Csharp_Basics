using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist from_MountVernon = Artists.Where(str => str.Hometown == "Mount Vernon").Single();
            System.Console.WriteLine(from_MountVernon.RealName + "'s age is " + from_MountVernon.Age + " years.");
            System.Console.WriteLine("============================================");

            //Who is the youngest artist in our collection of artists?
            Artist Youngest = Artists.OrderBy(age => age.Age).First();
            System.Console.WriteLine("The youngest artist is " + Youngest.ArtistName + " and his age is " + Youngest.Age);
            System.Console.WriteLine("============================================");

            //Display all artists with 'William' somewhere in their real name
            string x = "William";
            List<Artist> William = Artists.Where(name => name.RealName.Contains(x)).ToList();
            foreach(Artist person in William){
                System.Console.WriteLine(person.RealName);
            }
            System.Console.WriteLine("============================================");
            
            // Display all groups with names less than 8 characters in length.
            List<Group> shortname = Groups.Where(length => length.GroupName.Length < 8).ToList();
            foreach(Group gr in shortname){
                System.Console.WriteLine(gr.GroupName);
            }
            System.Console.WriteLine("============================================");

            //Display the 3 oldest artist from Atlanta
            List<Artist> OldGuys = Artists.Where(town => town.Hometown == "Atlanta").OrderByDescending(age => age.Age).Take(3).ToList();
            foreach(Artist old in OldGuys){
                System.Console.WriteLine(old.RealName);
            }
            System.Console.WriteLine("============================================");
            //(Optional) Display the Group Name of all groups that have at least one member not from New York City
            List<Artist> NotFromNewYork = Artists.Where(town => town.Hometown != "New York City").ToList();
            // System.Console.WriteLine(NotFromNewYork.Count());
            // System.Console.WriteLine(Artists.Count());
            List<Group> NotNewYork = NotFromNewYork.Join(Groups, artist => artist.GroupId, group => group.Id, (artist, group) => {
                artist.Group = group;
                return artist.Group;})
                .Distinct()
                .ToList();
            System.Console.WriteLine("The groups having at least one member from NewYork are:");
            foreach(Group group in NotNewYork){
                System.Console.WriteLine(group.GroupName);
            }
            System.Console.WriteLine("============================================");

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            Group Wu_Tang = Groups.Where(name => name.GroupName == "Wu-Tang Clan").GroupJoin(
                Artists,
                group => group.Id, artist => artist.GroupId, (group, artists) =>{
                group.Members = artists.ToList();
                return group;
                }).Single();
            foreach(Artist person in Wu_Tang.Members){
                System.Console.WriteLine(person.ArtistName + " " + person.RealName);
            }
        }
    }
}
