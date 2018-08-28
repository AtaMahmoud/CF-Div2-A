using System;

namespace Code
{
    class word
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int upperCaseCounter = 0;
            int lowerCaseCounter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a')
                    lowerCaseCounter++;
                else if (word[i] >= 'A')
                    upperCaseCounter++;
            }
            if (lowerCaseCounter > upperCaseCounter)
                Console.WriteLine(word.ToLower());
            else if (lowerCaseCounter < upperCaseCounter)
                Console.WriteLine(word.ToUpper());
            else
                Console.WriteLine(word.ToLower());
        }
    }

}