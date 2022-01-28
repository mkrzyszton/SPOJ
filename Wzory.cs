using System;

namespace Wzory
{
    class Program
    {
        static void Main(string[] args)
        {
                string parametry = Console.ReadLine();
                string[] t = parametry.Split(' ');

                if (t[0] == "A")
                {
                    int n = Convert.ToInt32(t[1]);
                    int m = Convert.ToInt32(t[2]);

                    if ((3 <= n || n <= 100) && (3 <= m || m <= 100))
                    {
                        if(n % 2 == 0)
                        {
                            n++;
                        }

                        if(m % 2 == 0)
                        {
                            m++;
                        }

                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                if (i == 0 || j == 0 || i == m - 1 || j == n - 1 || i == m / 2 || j == n / 2)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(".");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                { 
                    int n = Convert.ToInt32(t[1]);

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write('*');
                    }

                    Console.Write('\n');

                    for (int j = 1; j < n - 1; j++)
                    {
                        for (int i = n; i > 0; i--)
                        {
                            if (j + i == n)
                            {
                                Console.Write('*');
                            }
                            else
                            {
                                Console.Write('.');
                            }
                        }
                        Console.Write('\n');
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write('*');
                    }
                }
        }
    }
}
