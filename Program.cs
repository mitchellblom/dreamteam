using System;

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
            Madeline madeline = new Madeline();
            Chaz chaz = new Chaz();
            Matt matt = new Matt();
            Andy andy = new Andy();
            Jordan jordan = new Jordan();

        }
    }

    public class Ben : IDreamTeam
    {
        public string Specialty { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string FullName { get; set; }

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

        public void Work()
        {
            Console.WriteLine("Harmonizes conflict and also harmonizes when someone begins singing.");
        }
    }

    public class Chaz
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public void Work()
        {
            Console.WriteLine("Doesn't like the available libraries; writes his own.");
        }
    }

    public class Matt
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public void Work()
        {
            Console.WriteLine("Masters concepts effortlessly by tatooing them into memory and onto sleeve.");
        }
    }

    public class Andy
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public void Work()
        {
            Console.WriteLine("Networking guru. Once got a contract from approaching the right person. It's doable!");
        }
    }

    public class Jordan
    {
        public string Specialty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public void Work()
        {
            Console.WriteLine("Cooks healthy and delicious meals for the team. Knows all the bus routes of Davidson County.");
        }
    }


}