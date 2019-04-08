using System;
using System.Collections.Generic;
namespace Code
{
    class IsYourHorseshoe
    {
        public static void Main(string[] args)
        {
            int[] shoesColors = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            List<int> distincColors = new List<int>();
            for (int i = 0; i < shoesColors.Length; i++)
            {
                bool isDistinict = false;
                for (int j = 0; j < i; j++)
                {
                    if (shoesColors[i] == shoesColors[j])
                    {
                        isDistinict = true;
                        break;
                    }
                }
                if (!isDistinict)
                    distincColors.Add(shoesColors[i]);
            }
            Console.WriteLine(shoesColors.Length - distincColors.Count);
        }
    }
}