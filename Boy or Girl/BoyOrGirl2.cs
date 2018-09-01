using System;
using System.Linq;
namespace Code
{
    class BoyOrGirl2
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int distinctChars = name.Distinct().Count();

            if (distinctChars % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");

        }
    }
}