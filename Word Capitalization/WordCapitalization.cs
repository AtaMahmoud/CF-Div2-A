using System;
namespace Code
{
    class WordCapitalizationProblem
    {
        public static void Main(string[] args)
        {
            var word=Console.ReadLine().ToCharArray();
            word[0]=Char.ToUpper(word[0]);
           foreach (var c in word)
           {
               Console.Write(c);
           }
        }
    }
}