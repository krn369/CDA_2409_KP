using System;

class Palindrome
    {
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Veuillez entrer une chaîne de caractères terminée par '.':");
            string input = Console.ReadLine();

            // Check if the input is just a period or empty
            if (string.IsNullOrEmpty(input) || input == ".")
            {
                Console.WriteLine("LA CHAINE EST VIDE. Veuillez réessayer.");
                continue;
            }

            // Remove the period at the end and normalize the string
            string normalizedInput = input.TrimEnd('.').Replace(" ", "").ToLower();

            // Check if the normalized string is a palindrome
            bool isPalindrome = IsPalindrome(normalizedInput);

            if (isPalindrome)
            {
                Console.WriteLine("La chaîne de caractères est un palindrome.");
            }
            else
            {
                Console.WriteLine("La chaîne de caractères n'est pas un palindrome.");
            }

            break;
        }
    }

    static bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
