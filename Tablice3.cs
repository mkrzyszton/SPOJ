using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] S = new int[n];

            string input = Console.ReadLine();
            S = Array.ConvertAll<string, int>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

            int m = int.Parse(Console.ReadLine());
            int[] Q = new int[m];

            string input2 = Console.ReadLine();
            Q = Array.ConvertAll<string, int>(input2.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (n < m)
            {
                for (int i = 0; i < n; i++)
                {
                    if (S[i] == Q[i] && i < m)
                    {
                        Console.Write($"{i + 1} ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    if (S[i] == Q[i] && i < n)
                    {
                        Console.Write($"{i + 1} ");
                    }
                }
            }
        }
    }
}
