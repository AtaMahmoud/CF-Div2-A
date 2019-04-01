using System;

namespace Code
{
    class MagnetsProblem
    {
        public static void Main(String[] args)
        {
            int numberOfMagnets = int.Parse(Console.ReadLine());
            int[] magnets = new int[numberOfMagnets];
            for (int i = 0; i < numberOfMagnets; i++)
            {
                magnets[i] = int.Parse(Console.ReadLine());
            }

            int numberOfGroups = 1;
            for (int i = 1; i < numberOfMagnets; i++)
            {
                if (magnets[i] != magnets[i - 1])
                    numberOfGroups++;
            }

            Console.WriteLine(numberOfGroups);
        }
    }
}