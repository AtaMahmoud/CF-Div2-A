using System;

namespace Code
{
    class BuyShovel
    {
        public static void Main(string[] args)
        {
            int[] data = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int shovelPrice = data[0];
            int coinDemonation = data[1];
            int shovelNumber = 1;

            while (true)
            {
                int shovelSum = shovelPrice * shovelNumber;
                if (shovelSum % 10 == 0 || (shovelSum - coinDemonation) % 10 == 0)
                {
                    Console.WriteLine(shovelNumber);
                    break;
                }
                shovelNumber++;
            }
        }
    }
}