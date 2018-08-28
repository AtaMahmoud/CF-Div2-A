using System;
namespace Code
{
    class Petya
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine().ToLower();
            string secondName = Console.ReadLine().ToLower();

            Console.WriteLine(firstName.CompareTo(secondName));
        }
    }
}
