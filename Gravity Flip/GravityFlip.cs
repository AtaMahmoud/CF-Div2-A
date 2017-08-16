using System;
class program
{
    static void Main(string[]args)
    {
        int n = int.Parse(Console.ReadLine());
            int[] cubes = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            Array.Sort(cubes);
           
            for (int i = 0; i < cubes.Length; i++)
            {
                Console.Write(cubes[i] + " ");
            }
    }
}
