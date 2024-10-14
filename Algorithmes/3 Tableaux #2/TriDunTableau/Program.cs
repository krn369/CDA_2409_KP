
/*
 Exercice 5.4 : Tri d’un tableau
Nous désignerons par a1, a2, …, aN les éléments d’un tableau à trier par ordre croissant.

Exemple: [128, 64, 8, 512, 16, 32, 256]

On commence par chercher l’indice du plus petit des éléments, soit j cet indice.

On permute alors les valeurs de a1 (128) et aj (8).

Le tableau devient [8, 64, 128, 512, 16, 32, 256].

On cherche ensuite l’indice du plus petit des éléments entre a2 et aN et on permute avec a2.

Le tableau devient [8, 16, 128, 512, 64, 32, 256].

On cherche ensuite l’indice du plus petit des éléments a3, a4, …, aN etc…



This program sorts an array of integers using the selection sort algorithm. It repeatedly finds the smallest element in the unsorted part of the array and
swaps it with the first unsorted element, gradually sorting the entire array.

 */

using System;

class TriDunTableau
    {
    static void Main()
    {
        int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };

        // Afficher le tableau initial. Prints the initial array to the console.
        Console.WriteLine("Tableau initial : " + string.Join(", ", tableau));

        // Tri par sélection
        for (int i = 0; i < tableau.Length - 1; i++) // This for loop iterates through the array, except for the last element.
        {
            // Trouver l'indice du plus petit élément à partir de i
            int minIndex = i;  // initially set to i.
            for (int j = i + 1; j < tableau.Length; j++) // The inner for loop finds the smallest element in the unsorted part of the array.
            {
                if (tableau[j] < tableau[minIndex]) // if a smaller element is found, minIndex is updated to the index of  that element.
                {
                    minIndex = j;
                }
            }

            // Permuter les éléments
            // The smallest element found is swapped with the element at index i.
            // temp temporarily holds the value of tableau[i] to facilitate the swap
            int temp = tableau[i];
            tableau[i] = tableau[minIndex];
            tableau[minIndex] = temp;

            // Afficher le tableau après chaque permutation.  This prints the array after each swap to show the progress of the sorting.
            Console.WriteLine("Après permutation " + (i + 1) + " : " + string.Join(", ", tableau));
        }

        // Afficher le tableau trié. Finally, the sorted array is printed to the console.
        Console.WriteLine("Tableau trié : " + string.Join(", ", tableau));
    }

    /*
         internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trier un tableau");

            /*
            Random rnd = new Random();

            int[] monTableau = new int[1_000_000];

            for(int a = 0; a < monTableau.Length; a++)
            {
                monTableau[a] = rnd.Next(1, 1000000);
            }
            //*

    int[] monTableau = [128, 164, 8, 512, 16, -32, 256];
    //int[] monTableau = [-128, -64, -8, -512, -16, -32, -256];


    // 1 - Afficher le tableau d'origine

    Console.WriteLine("Tableau avant le tri :");


            for (int i = 0; i<monTableau.Length; i++)
            {
                Console.Write(monTableau[i] + " ");
            }
Console.WriteLine();


// 2 - Trier le tableau

int stock;
int indice = 0;
int Temporaire = 0;

for (int i = 0; i < monTableau.Length; i++)
{
    stock = int.MaxValue;

    for (int j = i; j < monTableau.Length; j++)
    {
        if (monTableau[j] < stock)
        {
            stock = monTableau[j];
            indice = j;
        }
    }

    Temporaire = monTableau[indice];
    monTableau[indice] = monTableau[i];
    monTableau[i] = Temporaire;
}

// 3 - Afficher le tableau après le tri

Console.WriteLine("Tableau après le tri :");
foreach (int nbr in monTableau)
{

    Console.Write(nbr + " ");
}

Console.WriteLine("\nProgramme terminé, appuyer sur n'importe quelle touche pour quitter.");
Console.ReadLine();
        }
    }
     
     */
    
}
