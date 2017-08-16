using System;

class Program
{
   static void Main(string[]args)
    {
            int n;
            string resultOfGames;
            int Anton = 0;
            int Danik = 0;
            n = int.Parse(Console.ReadLine());
            resultOfGames = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (resultOfGames[i] == 'A')
                    Anton++;
                else if (resultOfGames[i] == 'D')
                    Danik++;
            }
            if (Anton > Danik)
                Console.WriteLine("Anton");
            else if (Anton < Danik)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");
    }
    
}
