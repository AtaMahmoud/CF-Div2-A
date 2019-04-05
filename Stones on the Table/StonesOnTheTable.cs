using System;

namespace Code
{
    class StonesOnTheTable
    {
        public static void Main(String[] args)
        {
            int numberOfStones = int.Parse(Console.ReadLine());
            String stonesColors = Console.ReadLine();
            int numberOfStonesToRemove = 0;
            for (int i = 1; i < numberOfStones; i++)
            {
                if (stonesColors[i] == stonesColors[i - 1])
                    numberOfStonesToRemove++;
            }

            Console.WriteLine(numberOfStonesToRemove);
        }
    }
}