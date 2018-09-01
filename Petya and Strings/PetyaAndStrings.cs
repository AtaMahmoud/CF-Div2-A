using System;
namespace Code
{
    class PetyaAndStringsProblem
    {
        public static void Main(string[] args)
        {
            var firstString=Console.ReadLine().ToLower();
            var sceondString=Console.ReadLine().ToLower();
            
            Console.WriteLine(firstString.CompareTo(sceondString));
        }
    }
}