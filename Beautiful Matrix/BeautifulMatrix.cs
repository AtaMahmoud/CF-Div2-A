using System;
namespace Code
{
    class MatrixProblem
    {
        public static void Main(string[] args)
        {
            int [,] matrix=new int[5,5];
            int movesNumber=0;
            for (int i = 0; i < 5; i++)
            {
                var inputs=Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
                for (int j = 0; j < 5; j++)
                {
                    matrix[i,j]=inputs[j];
                    if(matrix[i,j]==1)
                    {
                        movesNumber=Math.Abs(2-i)+Math.Abs(2-j);
                    }
                }
            }
            Console.WriteLine(movesNumber);
        }
    }
}