using System;

namespace Code
{
    class SerejaAndDimaProblem
    {
        public static void Main(String[] args)
        {
            int numberOfCards = int.Parse(Console.ReadLine());
            int[] cards = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int serjaPoints = 0;
            int dimaPoints = 0;
            int leftIndex = 0;
            int rightIndex = numberOfCards - 1;
            for (int i = 0; i < numberOfCards; i++)
            {
                int points = 0;
                if (cards[leftIndex] > cards[rightIndex])
                {
                    points = cards[leftIndex];
                    leftIndex++;
                }
                else
                {
                    points = cards[rightIndex];
                    rightIndex--;
                }

                if (i % 2 == 0)
                    serjaPoints += points;
                else
                    dimaPoints += points;

            }

            Console.WriteLine($"{serjaPoints} {dimaPoints}");
        }
    }
}