using System;
using System.Linq;
class Program
{
   static void Main(string[]args)
    {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int n = a[0];
            int h = a[1];
            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] width = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (height[i] > h)
                    width[i] = 2;
                else
                    width[i] = 1;
            }

            Console.WriteLine(width.Sum());
    }
    
}
