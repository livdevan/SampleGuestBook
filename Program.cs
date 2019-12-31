using System;
using System.Collections.Generic;

namespace SampleMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool finished = false;
            Dictionary<string,int> guests = new Dictionary<string, int>();
            while (finished == false)
            {
                string name = GetUserName();
                int number = PartyNumber();
                guests.Add(name,number);
                count += number;
                System.Console.WriteLine("Still place for guests? yes/no");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "yes") finished = true;
            }

            System.Console.WriteLine("guest list:");
            PrintGuestList(guests);
            Console.WriteLine($"Number of total guests is {count}");
            Console.ReadLine();
        }
        private static string GetUserName()
        {
            System.Console.WriteLine("What's your name ?");
            string output = Console.ReadLine();
            return output;
        }
        private static int PartyNumber()
        {

            System.Console.WriteLine("How many in your party ? ");
            string answer = Console.ReadLine();
            bool goodNumber = int.TryParse(answer, out int output);
            if (goodNumber)
            {
                return output;
            }
            else
            {
                System.Console.WriteLine("Not a good number, we count only you");
                return 1;
            }
        }

        private static void PrintGuestList(Dictionary<string, int> guests)
        {
            foreach (var guest in guests)
            {
                System.Console.WriteLine($"{guest.Key} is party of {guest.Value}");
            }
        }
    }
}
