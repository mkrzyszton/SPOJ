using System;

namespace Petle2
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            //Twój kod

            int a = dane[0];
            int b = dane[1];
            int c = dane[2];

            if (a == b)
            {
                Console.WriteLine("empty");
            }            
            else
            {
                if (c > 0)
                {
                    if (a < b)
                    {
                        if (c >= b - a)
                        {
                            Console.WriteLine("empty");
                        }                       
                        else
                        {
                            if ((b - a) - c > 10)
                            {
                                a++;
                                Console.Write($"{a}, ");

                                for (int j = 0; j < 2; j++)
                                {
                                    a = a + c;
                                    Console.Write(a);
                                    
                                    if (j < 2)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.Write("..., ");

                                for (int j = b - c - 1; j < b; j += c)
                                {
                                    Console.Write(j);

                                    if (b - c > j)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                            }                            
                            else
                            {
                                for (int i = a + 1; i < b; i++)
                                {
                                    if (i % c == 0)
                                    {
                                        Console.Write(i);
                                    }

                                    if (i % c == 0 && i < b - c)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                            }
                        }
                    }                    
                    else if (a > b)
                    {
                        if (c >= a - b || a == b)
                        {
                            Console.WriteLine("empty");
                        }                        
                        else
                        {
                            if ((a - b) - c > 10)
                            {
                                b++;
                                Console.Write($"{b}, ");

                                for (int j = 0; j < 2; j++)
                                {
                                    b = b + c;
                                    Console.Write(b);
                                    if (j < 2)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                                Console.Write("..., ");

                                for (int j = a - c - 1; j < a; j += c)
                                {
                                    Console.Write(j);

                                    if (a - c > j)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                            }                            
                            else
                            {

                                for (int i = b + 1; i < a; i++)
                                {
                                    if (i % c == 0)
                                    {
                                        Console.Write(i);
                                    }

                                    if (i % c == 0 && i < a - c)
                                    {
                                        Console.Write(", ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
