using System;

class BarnabeFaitSesCourses
{
    static void Main(string[] args)
    {

        int argentDepart;
        int nombreMagasins = 0;
        int depenseParMagasin;

        Console.Write("Saisissez l'argent initial de Barnabé (en euros) : ");
        argentDepart = int.Parse(Console.ReadLine());

        if (argentDepart <= 1)
        {
            Console.WriteLine("Barnabé n'a pas pu faire d'achats.");
        }

        else
        {
            while (argentDepart > 0)
            {
                nombreMagasins++;

                depenseParMagasin = (argentDepart / 2) + 1;

                argentDepart = argentDepart - depenseParMagasin;
            }
            Console.WriteLine("Barnabé à acheté dans " + nombreMagasins + " magasins.");
        }
    }
}