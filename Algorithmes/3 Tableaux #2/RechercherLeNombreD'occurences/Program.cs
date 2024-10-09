using System;
using System.Text.RegularExpressions;

class RechercherLeNombreD
{
    static void Main(string[] args)
    {
        string regexPoint = @"\.$";

        Console.WriteLine("Saisissez une phrase en terminé par '.': ");
        string phrase = Console.ReadLine();


        if (string.IsNullOrEmpty(phrase) || phrase == ".")
        {
            Console.WriteLine("\nLA CHAINE EST VIDE.");
            return;
        }

        else if (!Regex.IsMatch(phrase, regexPoint))
        {
            Console.WriteLine("\nLa phrase doit se terminer par un point.");
            return;
        }

        Console.WriteLine("\nSaisissez la lettre à compter.  ");
        char lettre = Console.ReadKey().KeyChar;
        

        char[] charTableau = phrase.ToCharArray();

        int count = 0;

        foreach (char c in charTableau)
        {
            if (c == lettre)
            {
                count++;

            }
        }

        if (count > 0)
        {
            Console.WriteLine($"\nLa lettre '{lettre}' appraît {count} fois dans la chaîne.");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("\nLa lettre n'est pas présente.");
            Console.WriteLine();
        }

    }

}
    