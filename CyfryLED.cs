using System;

public class Test2
{
    static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        char[] charArray = nums.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            switch (charArray[i])
            {
                case '0':
                    Console.Write(" _ ");
                    break;
                case '1':
                    Console.Write("   ");
                    break;
                case '2':
                    Console.Write(" _ ");
                    break;
                case '3':
                    Console.Write(" _ ");
                    break;
                case '4':
                    Console.Write("   ");
                    break;
                case '5':
                    Console.Write(" _ ");
                    break;
                case '6':
                    Console.Write(" _ ");
                    break;
                case '7':
                    Console.Write(" _ ");
                    break;
                case '8':
                    Console.Write(" _ ");
                    break;
                case '9':
                    Console.Write(" _ ");
                    break;
            }
        }

        Console.WriteLine();

        for (int i = 0; i < charArray.Length; i++)
        {
            switch (charArray[i])
            {
                case '0':
                    Console.Write("| |");
                    break;
                case '1':
                    Console.Write("  |");
                    break;
                case '2':
                    Console.Write(" _|");
                    break;
                case '3':
                    Console.Write(" _|");
                    break;
                case '4':
                    Console.Write("|_|");
                    break;
                case '5':
                    Console.Write("|_ ");
                    break;
                case '6':
                    Console.Write("|_ ");
                    break;
                case '7':
                    Console.Write("  |");
                    break;
                case '8':
                    Console.Write("|_|");
                    break;
                case '9':
                    Console.Write("|_|");
                    break;
            }
        }

        Console.WriteLine();

        for (int i = 0; i < charArray.Length; i++)
        {
            switch (charArray[i])
            {
                case '0':
                    Console.Write("|_|");
                    break;
                case '1':
                    Console.Write("  |");
                    break;
                case '2':
                    Console.Write("|_ ");
                    break;
                case '3':
                    Console.Write(" _|");
                    break;
                case '4':
                    Console.Write("  |");
                    break;
                case '5':
                    Console.Write(" _|");
                    break;
                case '6':
                    Console.Write("|_|");
                    break;
                case '7':
                    Console.Write("  |");
                    break;
                case '8':
                    Console.Write("|_|");
                    break;
                case '9':
                    Console.Write("  |");
                    break;
            }
        }
    }
}
