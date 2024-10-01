using System;

class Program
{
    static void Main()
    {
        int countYoung = 0;
        int countEqual20 = 0;
        int countOlder = 0;
        int[] ages = new int[20];

        Console.WriteLine("Veuillez saisir les âges de 20 personnes \n:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Âge de la personne {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());

            if (ages[i] < 20)
            {
                countYoung++;
            }
            else if (ages[i] == 20)
            {
                countEqual20++;
            }
            else
            {
                countOlder++;
            }
        }

        if (countYoung == 20)
        {
            Console.WriteLine("\nTOUTES LES PERSONNES ONT MOINS DE 20 ANS");
        }
        else if (countYoung == 0)
        {
            Console.WriteLine("\nTOUTES LES PERSONNES ONT PLUS DE 20 ANS");
        }
        else
        {
            Console.WriteLine($"\nNombre de personnes moins de 20 ans : {countYoung}");
            Console.WriteLine($"Nombre de personnes égales à 20 ans : {countEqual20}");
            Console.WriteLine($"Nombre de personnes plus de 20 ans : {countOlder}");
        }
    }
}
