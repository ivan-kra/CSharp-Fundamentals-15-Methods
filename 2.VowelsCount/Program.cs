using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int numberOfVowels = CountVowels(input);
        Console.WriteLine($"{numberOfVowels}");
    }

    // Method to count the number of vowels in a string
    static int CountVowels(string input)
    {
        int vowelCount = 0;
        string lowercaseInput = input.ToLower();

        foreach (char character in lowercaseInput)
        {

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}