using System;


class NombrePremier
{
    static void Main(string[] args)
    {
        Console.Write("Saisissez un nombre positif supérieur à 1: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Les nombres premiers compris entre 1 et {N} sont:");
        for (int i = 2; i <= N; i++)
        {
            if (estPremier(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        // Check if the entered number itself is prime
        if (estPremier(N))
        {
            Console.WriteLine($"\n{N} est un nombre premier.");
        }
        else
        {
            Console.WriteLine($"\n{N} n'est pas un nombre premier.");
        }
    }

    static bool estPremier(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }


}

