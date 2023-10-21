using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        ValidatePassword(password);
    }
    static void ValidatePassword(string password)
    {
        bool isValid = true;

        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }

        if (!password.All(char.IsLetterOrDigit))
        {
            Console.WriteLine("Password must consist only of letters and digits");
            isValid = false;
        }

        int digitCount = password.Count(char.IsDigit);
        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        if (isValid)
        {
            Console.WriteLine("Password is valid");
        }
    }
}