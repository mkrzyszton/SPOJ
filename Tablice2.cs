using System;

public class Test2
{
    static void Main(string[] args)
    {
        int s = int.Parse(Console.ReadLine());
        int[] tab = new int[s];

        if (s >= 2 && s <= 100)
        {
            string input = Console.ReadLine();
            tab = Array.ConvertAll<string, int>(input.Split(), int.Parse);
        }

        int q = int.Parse(Console.ReadLine());
        int[] tab2 = new int[q];

        if (q >= 2 && q <= 100)
        {
            string input = Console.ReadLine();
            tab2 = Array.ConvertAll<string, int>(input.Split(), int.Parse);
        }

        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = 0; j < tab2.Length; j++)
            {
                if (tab[i] == tab2[j])
                {
                    Console.Write($"{tab[i]} ");
                }
            }
        }
    }
}
