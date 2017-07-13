using System;
using System.Linq;
using System.Collections.Generic;

namespace dreamteam
{

    public interface IDreamTeam
    {
        string Specialty { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        void Work();
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Ben ben = new Ben();
            Chaz chaz = new Chaz();
            Jordan jordan = new Jordan();
            Madeline madeline = new Madeline();
            Matt matt = new Matt();
            Mitchell mitchell = new Mitchell();

            List<IDreamTeam> clientSide = new List<IDreamTeam>() {};
            clientSide.Add(ben);
            clientSide.Add(chaz);
            clientSide.Add(jordan);

            List<IDreamTeam> serverSide = new List<IDreamTeam>() {};
            serverSide.Add(madeline);
            serverSide.Add(matt);
            serverSide.Add(mitchell);

            Console.WriteLine("Client Side teammates: ");
            foreach (IDreamTeam teammate in clientSide){
                Console.WriteLine(teammate.FullName);
            }

            Console.WriteLine("Server Side teammates: ");
            foreach (IDreamTeam teammate in serverSide){
                Console.WriteLine(teammate.FullName);
            }

        }
    }

    public class Ben : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Ben() {
            FirstName = "Ben";
            LastName = "Greaves";
            FullName = $"{FirstName} {LastName}";
        }

        public void Work()
        {
            Console.WriteLine("Ben works by casting D&D spells on his machine. Known for producing thousands of lines without ever touching his keyboard.");
        }

    }

    public class Madeline : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Madeline() {
            FirstName = "Madeline";
            LastName = "Power";
            FullName = $"{FirstName} {LastName}";
        }

        public void Work()
        {
            Console.WriteLine("Finds funny YouTube videos to lighten the mood and keep the team positive.");
        }

    }

    public class Mitchell : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Mitchell() {
            FirstName = "Mitchell";
            LastName = "Blom";
            FullName = $"{FirstName} {LastName}";
        }

        public void Work()
        {
            Console.WriteLine("Harmonizes conflict and also harmonizes when someone begins singing.");
        }

    }

    public class Chaz : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Chaz() {
            FirstName = "Chaz";
            LastName = "Henricks";
            FullName = $"{FirstName} {LastName}";
        }
        public void Work()
        {
            Console.WriteLine("Doesn't like the available libraries; writes his own.");
        }
    }

    public class Matt : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Matt() {
            FirstName = "Matt";
            LastName = "Augsburger";
            FullName = $"{FirstName} {LastName}";
        }

        public void Work()
        {
            Console.WriteLine("Masters concepts effortlessly by tatooing them into memory and onto sleeve.");
        }
    }

    public class Jordan : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Jordan() {
            FirstName = "Jordan";
            LastName = "Dhaenens";
            FullName = $"{FirstName} {LastName}";
        }

        public void Work()
        {
            Console.WriteLine("Cooks healthy and delicious meals for the team. Knows all the bus routes of Davidson County.");
        }
    }

}