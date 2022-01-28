using System;

namespace Zadania_petle
{
    class Program
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                for (int i = 0; i < input - 1; i+=2)
                {
                    for (int j = i; j < input - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                    for (int k = i; k >= 0; k-=2)
                    {
                        Console.Write(" ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < input; i+=2)
                {
                    for (int j = i; j < input; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                    for (int k = i; k >= 0; k -= 2)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
