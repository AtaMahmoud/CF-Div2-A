using System;
using System.Text;
namespace Code
{
    class WordCapWithStBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder(Console.ReadLine());
            if (name[0] >= 'a')
                name[0] = Convert.ToChar(name[0] - 32);
            Console.WriteLine(name);
        }
    }

}