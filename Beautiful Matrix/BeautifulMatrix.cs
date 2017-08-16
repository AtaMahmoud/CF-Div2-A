using System;

class program
{
    static void Main(string[]args)
    {
        int[,] Matrix = new int[5, 5];
            int rowNumber = 0;
            int columnNumber = 0;
            int rowSwaps = 0;
            int columnSwaps = 0;
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    Matrix[i, j] = Convert.ToInt32(inputs[j]);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Matrix[i, j] == 1)
                    {
                        rowNumber = i;
                        columnNumber = j;
                    }
                }
            }
            

            if (rowNumber == 2)
                rowSwaps = 0;
            else
            {
                while (rowNumber > 2)
                {
                    rowNumber--;
                    rowSwaps++;
                }
                    
                while (rowNumber < 2)
                {
                    rowNumber++;
                    rowSwaps++;
                }
            }

            if (columnNumber == 2)
                columnSwaps = 0;
            else
            {
                while (columnNumber > 2)
                {
                    columnNumber--;
                    columnSwaps++;
                }
                   
                while (columnNumber < 2)
                {
                    columnNumber++;
                    rowSwaps++;
                }
            }
           
         

            Console.WriteLine(rowSwaps+columnSwaps);
    }
}
