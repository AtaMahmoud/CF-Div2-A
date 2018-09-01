using System;
using System.Linq;
namespace Code
{
    class VanyaProblem  
    {
        public static void Main(String []args)
        {
            var line=Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
            int friendsNumber=line[0];
            int fenceHeight=line[1];
            

            var heights=Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
            int roadWidth=0;
            for (int i = 0; i < friendsNumber; i++)
            {
                if(heights[i]>fenceHeight)
                    roadWidth+=2;
                else
                    roadWidth+=1;
            }

            Console.WriteLine(roadWidth);
        }
    }
}