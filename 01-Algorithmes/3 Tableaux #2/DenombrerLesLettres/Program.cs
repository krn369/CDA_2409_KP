using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Veuillez entrer un texte d'au moins 120 caractères :");
        string texte = Console.ReadLine();

        // Vérifier que le texte contient au moins 120 caractères
        if (texte.Length < 120)
        {
            Console.WriteLine("Le texte doit contenir au moins 120 caractères.");
            return;
        }

        // Initialiser un tableau pour compter les occurrences des lettres
        int[] occurrences = new int[26];

        // Convertir le texte en minuscules pour simplifier le comptage
        texte = texte.ToLower();

        // Compter les occurrences de chaque lettre
        foreach (char c in texte)
        {
            if (c >= 'a' && c <= 'z')
            {
                occurrences[c - 'a']++;
            }
        }

        // Afficher les résultats
        for (int i = 0; i < 26; i++)
        {
            char lettre = (char)(i + 'a');
            Console.WriteLine($"La lettre '{lettre}' apparaît {occurrences[i]} fois.");
        }
    }
}
