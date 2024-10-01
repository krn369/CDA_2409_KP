using System;

class CalculDuNombreDJ
    {
    static void Main(string[] args)
    {
        int countJeune = 0;
        int[] ages = new int[20];

        Console.WriteLine("Veuillez saisir les âges de 20 personnes : ");

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Age de la personne {i + 1} : ");
            ages[i] = int.Parse(Console.ReadLine());

            if (ages[i] < 20)
            {
                countJeune++;            
            }
        }

        Console.WriteLine($"Nombre de jeunes (moins de 20 ans) : {countJeune}");
    }
}