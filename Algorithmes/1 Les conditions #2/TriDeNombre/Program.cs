
using KpariyarTools;

namespace TriDeNombre
{
    class Program
    {
        static void Main(string[] args)                 

            {

            int A = ConsoleTools.DemanderNombreEntier("Entrez le premier nombre");
            int B = ConsoleTools.DemanderNombreEntier("\nEntrez le deuxième nombre");
            int C = ConsoleTools.DemanderNombreEntier("\nEntrez le troisième nombre");

            /*
            // Lire les trois nombres entiers
            Console.WriteLine("Entrez le premier nombre (A) :");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre (B) :");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le troisième nombre (C) :");
            int C = int.Parse(Console.ReadLine());
            */

            // Mettre les nombres dans un tableau
            int[] nombres = { A, B, C };

            // Trier le tableau
            Array.Sort(nombres);

            // Afficher les nombres dans l'ordre croissant
            Console.WriteLine("\nLes nombres dans l'ordre croissant sont :");
            foreach (int nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}

