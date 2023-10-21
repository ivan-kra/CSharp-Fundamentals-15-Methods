using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        PrintMiddleCharacters(input);
    }

    static void PrintMiddleCharacters(string input)
    {
        int length = input.Length;
        int middle = length / 2;

        if (length % 2 == 0)
        {
            Console.WriteLine($"{input[middle - 1]}{input[middle]}");
        }
        else
        {
            Console.WriteLine($"{input[middle]}");
        }
    }
}