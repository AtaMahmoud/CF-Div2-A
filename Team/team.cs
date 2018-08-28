using System;
namespace Code
{
    class Team
    {
        static void Main(string[] args)
        {
            int numberOfProblem;
            numberOfProblem = int.Parse(Console.ReadLine());
            int[,] problems = new int[numberOfProblem, 3];
            int numberOfSolutions = 0;
            //Read the Matrix
            for (int i = 0; i < numberOfProblem; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    problems[i, j] = Convert.ToInt32(inputs[j]);
                }
            }
            //Calculations
            for (int i = 0; i < numberOfProblem; i++)
            {
                int sumOfSures = 0;
                for (int j = 0; j < 3; j++)
                {
                    sumOfSures += problems[i, j];
                }
                if (sumOfSures >= 2)
                    numberOfSolutions++;

            }
            Console.WriteLine(numberOfSolutions);
        }
    }

}