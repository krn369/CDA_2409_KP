using System;

class LesFruitsEtLegeumes
{
    static void Main(string[] args)
    {
        List<string> fruitsLegumes = new List<string>();
        List<double> prixKilo = new List<double>();

        while (true)
        {
            Console.WriteLine("Saisissez le nom d'un fruit ou légume (ou \"go\" pour terminer) : ");
            string nomFruitsLegumes = Console.ReadLine();

            if (nomFruitsLegumes.Equals("go", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }


            Console.WriteLine("Saisissez le prix au kilo : ");
            double prix = double.Parse(Console.ReadLine());

            fruitsLegumes.Add(nomFruitsLegumes);
            prixKilo.Add(prix);

        }

        Console.WriteLine("\nListe des fruits et légumes :\n");
        for (int i = 0; i < fruitsLegumes.Count; i++)
        {
            Console.WriteLine($"1 kilogramme de {fruitsLegumes[i]} coûte {prixKilo[i]:F2} euros.");
        }

        int indiceFruitsLegumesMoinsCher = 0;
        for (int i = 1; i < prixKilo.Count; i++)
        {
            if (prixKilo[i] < prixKilo[indiceFruitsLegumesMoinsCher])
            {
                indiceFruitsLegumesMoinsCher = i;
            }
        }

        Console.WriteLine("\nLégume le moins cher au kilo : " + fruitsLegumes[indiceFruitsLegumesMoinsCher]);

    }
}