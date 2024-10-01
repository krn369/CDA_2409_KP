using System;

class AfficherParChaqueCategorie
{
    static void Main(string[] args)
    {
        int countJeune = 0;
        int countEgal20Ans = 0;
        int countPlus20Ans = 0;
        int[] ages = new int[20];

        Console.WriteLine("Veuillez saisir les âges de 20 personnes : \n");

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Age de la personne {i + 1} : ");
            ages[i] = int.Parse(Console.ReadLine());

            if (ages[i] < 20)
            {
                countJeune++;
            }

            else if (ages[i] == 20)
            {
                countEgal20Ans++;
            }

            else
            {
                countPlus20Ans++;
            }
        }

        if (countJeune == 20)
        {
            Console.WriteLine("\nTOUTES LES PERSONNES ONT MOINS DE 20 ANS.");
        }

        else if (countJeune == 0)
        {
            Console.WriteLine("\nTOUTES LES PERSONNES ONT PLUS DE 20 ANS.");
        }

        else
        {
            Console.WriteLine($"\nNombre de personnes moins de 20 ans : {countJeune}");
            Console.WriteLine($"Nombre de personnes égales à 20 ans : {countEgal20Ans}");
            Console.WriteLine($"Nombre de personnes plus de 20 ans : {countPlus20Ans}");
        }
    }
}