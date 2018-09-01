using System;
namespace Code
{
    class BoyOrGirlProblem
    {
        public static void Main(string[] args)
        {
            string message = Console.ReadLine();
            int distinctCharsNumber = 0;
            int Length=message.Length;
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Length--;
                    if (i == j)
                        continue;

                    if (message[i] != message[j])
                        distinctCharsNumber++;
                }
            }

            if (distinctCharsNumber % 2 == 0)
                System.Console.WriteLine("CHAT WITH HER!");
            else
                System.Console.WriteLine("IGNORE HIM!");
        }
    }
}