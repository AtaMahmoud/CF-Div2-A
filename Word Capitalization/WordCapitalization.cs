using System;
class program
{
    static void Main(string[]args)
    {
            string name = Console.ReadLine();
            char [] arr = name.ToCharArray();
            var c =arr[0].ToString().ToUpper();
            Console.Write(c);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
    }
}
