using System;
using System.Linq;

namespace Code
{
    class TeamProblem
    {
        public static void Main(string[] args)
        {
            int numberOfProblems=int.Parse(Console.ReadLine());
            int problemsToImplement=0;
            
            for (int i = 0; i < numberOfProblems; i++)
            {
               var line=Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
                int sum=line.Sum();
                if(sum>=2)
                    problemsToImplement++;
            }

            Console.WriteLine(problemsToImplement);
        }
    }
}