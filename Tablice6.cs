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

            string input1 = Console.ReadLine();
            Q = Array.ConvertAll<string, int>(input1.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

            double nsum = 0;
            double msum = 0;

            for (int i = 0; i < m; i++)
            {
                msum += Q[i];
            }

            for (int i = 0; i < n; i++)
            {
                nsum += S[i];
            }

            if (msum < nsum)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{S[i] } ");
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write($"{Q[i] } ");
                }
            }
        }
    }
}
