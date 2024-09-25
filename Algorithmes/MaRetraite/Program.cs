using System;

class MaRetraite
{
    static void Main()
    {
        Console.Write("Entrez votre âge: ");
        int age;
        bool isValid = int.TryParse(Console.ReadLine(), out age);

        if (!isValid || age < 0)
        {
            Console.WriteLine("La valeur fournie n’est pas un âge valide.");
        }
        else if (age < 60)
        {
            int anneesRestantes = 60 - age;
            Console.WriteLine($"Il vous reste {anneesRestantes} années avant la retraite.");
        }
        else if (age == 60)
        {
            Console.WriteLine("C’est le moment de prendre sa retraite.");
        }
        else
        {
            int anneesDeRetraite = age - 60;
            Console.WriteLine($"Vous êtes à la retraite depuis {anneesDeRetraite} années.");
        }
    }
}

