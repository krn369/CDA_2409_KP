using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string ending with '.':");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input == ".")
        {
            Console.WriteLine("LA CHAINE EST VIDE");
            return;
        }

        Console.WriteLine("Enter the letter to count:");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = 0;
        foreach (char c in input)
        {
            if (c == letter)
            {
                count++;
            }
        }

        Console.WriteLine($"The letter '{letter}' appears {count} times in the string.");
    }
}
