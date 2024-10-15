/*
 Exercice 2a.2 : Es-tu majeur ?
Lire un nombre A correspondant à un âge (en années).
Afficher “Vous êtes majeur” ou “Vous êtes mineur” selon le cas.
Pour un nombre négatif le message doit être “Vous n’êtes pas encore né”.
La majorité est fixée à 18 ans.
 */

using System;
using System.Text.RegularExpressions;


class EsTuMajeur
{
    static void Main()
    {
        Console.Write("Entrez votre âge: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Vous n’êtes pas encore né");
        }
        else if (age < 18)
        {
            Console.WriteLine("Vous êtes mineur");
        }
        else
        {
            Console.WriteLine("Vous êtes majeur");
        }
    }
}