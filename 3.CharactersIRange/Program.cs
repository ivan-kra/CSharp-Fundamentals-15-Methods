using System;

class Program
{
    static void Main()
    {
       char firstChar = Convert.ToChar(Console.ReadLine());
        char secondChar = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();

        PrintCharactersBetween(firstChar, secondChar);
    }

    static void PrintCharactersBetween(char char1, char char2)
    {
        if (char2 < char1)
        {
            char temp = char1;
            char1 = char2;
            char2 = temp;
        }

        for (char i = (char)(char1 + 1); i < char2; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}