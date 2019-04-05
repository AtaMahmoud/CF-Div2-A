using System;

namespace Code
{
    class BlackSquare
    {
        public static void Main(String[] args)
        {
            int[] claories = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            string squares = Console.ReadLine();
            int claoriesSum = 0;
            for (int i = 0; i < squares.Length; i++)
            {
                int index = int.Parse(squares[i].ToString())-1;
                claoriesSum += claories[index];
            }
            Console.WriteLine(claoriesSum);
        }
    }
}