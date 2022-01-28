using System;

namespace Petle1
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod
            int a = dane[0];
            int b = dane[1];
            int counter = 0;

            if (a == b || a == b + 1 || b == a + 1)
            {
                Console.Write("empty");
            }
            
            else if (a < b)
            {
                if ((b - a) - 1 <= 10)
                {
                    for (int i = a + 1; i < b; i++)
                    {
                        counter++;
                        Console.Write(i);

                        if (i < b - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }

                else if ((b - a) - 1 > 10)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        a++;
                        Console.Write(a);
                        if (j < 3)
                        {
                            Console.Write(", ");
                        }
                    }
                    
                    Console.Write("..., ");
                    for (int j = b - 2; j < b; j++)
                    {
                        Console.Write(j);
                        
                        if (b - 1 > j)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
            else if (a > b)
            {
                if ((a - b) - 1 <= 10)
                {
                    for (int i = b + 1; i < a; i++)
                    {
                        Console.Write(i);
                        counter++;

                        if (i < a - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
                else if ((a - b) - 1 > 10)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        b++;
                        Console.Write(b);
                        
                        if (j < 3)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.Write("..., ");
                    
                    for (int j = a - 2; j < a; j++)
                    {
                        Console.Write(j);

                        if (a - 1 > j)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
        }
    }
}
