using System;

class JeuDeLaFourchette
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int nombreMystere = rnd.Next(0, 101);
        int nombreEssais = 0;
        Boolean trouve = false;
        int nombreChoisi;

        while (!trouve)
        {
            nombreEssais++;

            Console.Write( "Saisissez un nombre entre 0 et 100 : ");
            nombreChoisi = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (nombreChoisi == nombreMystere)
            {
                trouve = true;
            }

            else
            {
                if (nombreChoisi > 100 || nombreChoisi < 0)
                {
                    Console.WriteLine("Invalide. Le nombre doit etre comprise entre 0 et 100");
                }

                else if (nombreChoisi < nombreMystere)
                {
                    Console.WriteLine("Le nombre mystère est supérieur à " + nombreChoisi);
                }
                else
                {
                    Console.WriteLine( "Le nombre mystère est inférieur à " + nombreChoisi);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Bravo !!! Vous avez trouvé le nombre mystère en " + nombreEssais + " essais.");
    }
}