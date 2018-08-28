using System;
using System.Linq;

namespace Code
{
    class BoyOrGirl
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var unique = name.Distinct();
            int distinctCharacters = unique.Count();


            if (distinctCharacters % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");
        }
    }
}

