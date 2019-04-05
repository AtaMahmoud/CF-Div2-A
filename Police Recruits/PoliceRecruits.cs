using System;

namespace Code
{
    class PoliceRecruits
    {
        public static void Main(String[] args)
        {
            int numberOfEvents = int.Parse(Console.ReadLine());
            int[] events = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int untreated = 0;
            int availablePoliceMen = 0;
            for (int i = 0; i < numberOfEvents; i++)
            {
                if (events[i] < 0 && availablePoliceMen == 0)
                    untreated++;
                else if (events[i] < 0 && availablePoliceMen != 0)
                    availablePoliceMen += events[i];
                else if (events[i] > 0)
                    availablePoliceMen += events[i];
            }
            Console.WriteLine(untreated);
        }
    }
}