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
        public string Specialty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Work()
        {
            Console.WriteLine("Ben works by casting spells on his machine. Known for producing thousands of lines without ever touching his keyboard.")
        }
    }

    public class Madeline : IDreamTeam
    {
        public string Specialty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Work()
        {
            Console.WriteLine("Finds funniest videos to lighten the mood and keep the team positive.")
        }
    }

    public class Mitchell
    {

    }

    public class Chaz
    {

    }

    public class Matt
    {

    }

    public class Andy
    {

    }

    public class Jordan
    {

    }


}