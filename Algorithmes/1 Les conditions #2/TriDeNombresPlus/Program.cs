using System;

namespace TriDeNombrePlus
{

    class App
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le premier nombre (A) : ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre (B) :");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le troisième nombre (C) :");
            int C = int.Parse(Console.ReadLine());

            int[] nombres = { A, B, C };

            Array.Sort(nombres);
            Array.Reverse(nombres);

            Console.WriteLine("Les nombres dans l'ordre decroissant sont :");
            foreach(int nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

        }

    }

}