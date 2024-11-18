/*
#Exercice 6.4 : DENOMBRER LES LETTRES DE L’ALPHABET
Lire une chaine de caractères d’au moins 100 caractères (à contrôler).

Compter et afficher:

le nombre de consonnes.
le nombre de voyelles
le nombre de chiffres
la moyenne des chiffres, 0 si aucun chiffre.
 */

using System;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Veuillez entrer une chaîne de caractères d'au moins 100 charactères : ");
        string input = Console.ReadLine();

        // Ensure the input is at least 100 characters long
        while (input.Length < 100)
        {
            Console.WriteLine("\nLa chaine doit contenir au moins 100 charactères. Veuillez réessayer :");
            input = Console.ReadLine();
        }

        // Variables
        int nombreDeConsonnes = 0;
        int nombreDeVoyelles = 0;
        int nombreDeChiffres = 0;
        int sommeDesChiffres = 0;

        // This foreach loop iterates over each character in the input string:

        foreach (char c in input)
        {
            // - If the character is a letter, it checks if it's a vowel in both uppercase and lowercase. If it is, it increments the (nombreDeVoyelles)
            // Otherwise, it increments the nombreDeConsonnes.

            if (char.IsLetter(c))
            {
                if ("aeiouyAEIOUY".Contains(c))
                {
                    nombreDeVoyelles++;
                }
                else
                {
                    nombreDeConsonnes++;
                }
            }

            // - If the charracter is a digit, it increments the nomreDeChiffres and adds the digits value to sommeDesChifres.
            // this code snippet checks if a character is a digit, counts it, and adds its numeric value to a running total.

            else if (char.IsDigit(c))
            {
                nombreDeChiffres++;
                // The expression (c - '0') converts the character c to its corresponding integer value. For example, if c is ‘5’, then '5' - '0' results in the integer 5.
                sommeDesChiffres += (c - '0');
            }
        }

        // This line calculates the average of the digits. If there are no digits, it sets the average to 0, Otherwise, it divides the sum of the digits by the count of digits.

        double chiffreMoyenne = nombreDeChiffres > 0 ? (double)sommeDesChiffres / nombreDeChiffres : 0;
        
        // Résultat

        Console.WriteLine($"\nNombre de consonnes : {nombreDeConsonnes}");
        Console.WriteLine($"Nombre de voyelles :  {nombreDeVoyelles}");
        Console.WriteLine($"Nombre de chiffres : {nombreDeChiffres}");
        Console.WriteLine($"Moyenne des chiffres : {chiffreMoyenne}");

    }
}