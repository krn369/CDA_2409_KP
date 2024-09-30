using System;

class RechercherLeNombreD
{
    static void Main(string[] args)
    {


        Console.WriteLine("Saisissez une phrase en terminé par '.': ");
        string phrase = Console.ReadLine();
        Console.WriteLine();

        if (string.IsNullOrEmpty(phrase) || phrase == ".")
        {
            Console.WriteLine("LA CHAINE EST VIDE.");
            return;
        }

        Console.WriteLine("Saisissez la lettre à compter.  ");
        char lettre = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine();

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
            Console.WriteLine($"La lettre '{lettre}' appraît {count} fois dans la chaîne.");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("La lettre n'est pas présente.");
            Console.WriteLine();
        }

    }

}
    