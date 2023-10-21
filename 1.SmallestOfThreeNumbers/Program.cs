using System;

class Program
{
    static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallestNumber = FindSmallestNumber(num1, num2, num3);

        Console.WriteLine($"{smallestNumber}");
    }

    static int FindSmallestNumber(int a, int b, int c)
    {
        return Math.Min(Math.Min(a, b), c);
    }
}