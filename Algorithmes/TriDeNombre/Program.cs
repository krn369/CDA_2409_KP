// See https://aka.ms/new-console-template for more information

using System;

namespace _01_TriDeNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lire les trois nombres entiers
            Console.WriteLine("Entrez le premier nombre (A) :");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre (B) :");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le troisième nombre (C) :");
            int C = int.Parse(Console.ReadLine());

            // Mettre les nombres dans un tableau
            int[] nombres = { A, B, C };

            // Trier le tableau
            Array.Sort(nombres);

            // Afficher les nombres dans l'ordre croissant
            Console.WriteLine("Les nombres dans l'ordre croissant sont :");
            foreach (int nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}

