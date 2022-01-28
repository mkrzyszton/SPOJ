using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Wpisz liczbe od 1 do 120: ");

        int input = int.Parse(Console.ReadLine());

        List<int> space = new List<int>();

        if (input < 1 || input > 120)
            Console.WriteLine("Złe dane");
        
        else if (input % 2 == 0)
        {
            --input;

            for (int i = -input; i < input; i++)
            {
                Console.WriteLine();

                space.Add(i);
                space.ForEach(e => Console.Write(" "));

                for (int j = 0; j < input; j++)
                {
                    Console.Write("*");
                }

                input -= 2;
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = -input; i < input; i++)
            {
                Console.WriteLine();

                space.Add(i);
                space.ForEach(e => Console.Write(" "));

                for (int j = 0; j < input; j++)
                {
                    Console.Write("*");
                }

                input -= 2;                
            }
            Console.WriteLine();
        }
    }
}
