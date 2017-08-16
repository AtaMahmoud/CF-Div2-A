using System;

class Program
{
   static void Main(string[]args)
    {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int limakWeight = a[0];
            int bearWeight = a[1];
            int i = 0;
            while (limakWeight <= bearWeight)
            {
                i++;
                limakWeight = limakWeight * 3;
                bearWeight = bearWeight * 2;
            }

            for (i = 0; limakWeight <= bearWeight; i++)
            {
                if (limakWeight == bearWeight)
                {
                    i++;
                    break;
                }
                else
                {
                    limakWeight = limakWeight * 3;
                    bearWeight = bearWeight * 2;
                }

            }
            Console.WriteLine(i);
    }
    
}
