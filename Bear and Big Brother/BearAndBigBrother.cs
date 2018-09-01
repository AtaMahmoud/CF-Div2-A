using System;
namespace Code
{
    class BearProblem
    {
        public static void Main(string[] args)
        {
            var weights = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int limarkWeight = weights[0];
            int bobWeight = weights[1];
            int years = 0;
            while (limarkWeight <= bobWeight)
            {
                years++;
                limarkWeight *= 3;
                bobWeight *= 2;
            }

            Console.WriteLine(years);
        }
    }
}