using System;

class IntervalleEntre2Nombres
{
    static void Main()
    {
        Console.WriteLine("Veuillez saisir le nombre A : ");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Veuillez saisir le nombre B : ");
        int B = int.Parse(Console.ReadLine());

        if (A < B)
        {

            for (int i = A + 1; i < B; i++)
            {
                Console.WriteLine(i + " ");
            }
        }

        else if (A > B)
        {

            for (int i = A - 1; i > B; i--)
            {
                Console.WriteLine(i + " ");
            }

        }

        else
        {
            Console.WriteLine("A et B sont égaux, il n'y a pas de nombres entre eux.");
        }
    }
}