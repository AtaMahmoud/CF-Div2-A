using System;
using System.Linq;
namespace Code
{
    class WordProblem
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int upperChars = word.Count(char.IsUpper);
            int lowerChars = word.Count(char.IsLower);

            if (upperChars > lowerChars)
                Console.WriteLine(word.ToUpper());
            else if (lowerChars > upperChars)
                Console.WriteLine(word.ToLower());
            else
                Console.WriteLine(word.ToLower());
        }
    }
}