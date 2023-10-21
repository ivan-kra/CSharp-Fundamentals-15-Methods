using System;

class Program
{
    static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfTwoNumbers(num1, num2);
        int result = SubtractThirdNumber(sum, num3);

        Console.WriteLine($"{result}");
    }

    static int SumOfTwoNumbers(int a, int b)
    {
        return a + b;
    }

    static int SubtractThirdNumber(int sum, int c)
    {
        return sum - c;
    }
}