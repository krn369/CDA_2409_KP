using System;

class RechercheDesDiviseurs
{
    static void Main(string[] args)
    {
        int nombre;
        int diviseur;


        Console.WriteLine("Saisissez un nombre entier : ");
        nombre =  int.Parse(Console.ReadLine());

        if (nombre <= 1)
        {
            Console.WriteLine("Le nombre n'a pas de diviseurs autres que 1 et lui-memê.");
        }

        else
        {
            Console.WriteLine("Divisores : ");
            for (diviseur = 2; diviseur <= nombre; diviseur++)
            {

                if (nombre % diviseur == 0)
                {
                    Console.WriteLine(diviseur + " ");
                }
            }
        }

    }

}

