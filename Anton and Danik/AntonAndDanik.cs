using System;

namespace Code
{
    class AntoneProblem
    {
        public static void Main(String[] args)
        {
            int gamesNumber = int.Parse(Console.ReadLine());
            string gameScore = Console.ReadLine();

            int antonScore = 0;
            int danikScore = 0;
            foreach (var character in gameScore)
            {
                if (character == 'A')
                    antonScore++;
                else
                    danikScore++;
            }

            if (antonScore > danikScore)
                Console.WriteLine("Anton");
            else if (antonScore < danikScore)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");

        }
    }
}