using System;

class TriDunTableau
    {
    static void Main()
    {
        int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };

        // Afficher le tableau initial
        Console.WriteLine("Tableau initial : " + string.Join(", ", tableau));

        // Tri par sélection
        for (int i = 0; i < tableau.Length - 1; i++)
        {
            // Trouver l'indice du plus petit élément à partir de i
            int minIndex = i;
            for (int j = i + 1; j < tableau.Length; j++)
            {
                if (tableau[j] < tableau[minIndex])
                {
                    minIndex = j;
                }
            }

            // Permuter les éléments
            int temp = tableau[i];
            tableau[i] = tableau[minIndex];
            tableau[minIndex] = temp;

            // Afficher le tableau après chaque permutation
            Console.WriteLine("Après permutation " + (i + 1) + " : " + string.Join(", ", tableau));
        }

        // Afficher le tableau trié
        Console.WriteLine("Tableau trié : " + string.Join(", ", tableau));
    }
}
