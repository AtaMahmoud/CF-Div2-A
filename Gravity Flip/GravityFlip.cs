using System;

namespace Code
{
    class GravityFlipProblem
    {
        public static void Main(string[] args)
        {
            int cubesNumber=int.Parse(Console.ReadLine());
            var cubes=Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
            Array.Sort(cubes);
            foreach (var cud in cubes)
            {
                Console.Write($"{cud} ");
            }
        }
    }
}