using System;
using BibliothequeDeClassBouteille;


namespace BouteilleApp
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Create instances of Bouteille using different constructors
            Bouteille bouteille1 = new Bouteille(); // Default constructor (1L, full, closed)
            Bouteille bouteille2 = new Bouteille(0.75f, 0.5f, true); // Parameterized constructor (0.75L, half-full, open)
            Bouteille bouteille3 = new Bouteille(2f); // Hybrid constructor (2L, full, closed)
            Bouteille bouteille4 = new Bouteille(bouteille2); // Copy constructor (copy of bouteille2)

            // Display initial state of the bottles
            Console.WriteLine("Initial State:");
            bouteille1.AfficherEtat(); // 1L, full, closed
            bouteille2.AfficherEtat(); // 0.75L, half-full, open
            bouteille3.AfficherEtat(); // 2L, full, closed
            bouteille4.AfficherEtat(); // 0.75L, half-full, open (copy of bouteille2)

            // Test operations on bouteille1
            Console.WriteLine("\nTesting Operations on bouteille1:");
            bouteille1.Ouvrir(); // Open the bottle
            bouteille1.Vider(0.5f); // Empty 0.5L
            bouteille1.AfficherEtat(); // 1L, 0.5L, open

            // Test operations on bouteille2
            Console.WriteLine("\nTesting Operations on bouteille2:");
            bouteille2.Fermer(); // Close the bottle
            bouteille2.Remplir(0.25f); // Try to fill 0.25L (should fail because it's closed)
            bouteille2.AfficherEtat(); // 0.75L, 0.5L, closed

            // Test operations on bouteille3
            Console.WriteLine("\nTesting Operations on bouteille3:");
            bouteille3.Ouvrir(); // Open the bottle
            bouteille3.Vider(); // Empty the bottle completely
            bouteille3.AfficherEtat(); // 2L, 0L, open

            // Test operations on bouteille4
            Console.WriteLine("\nTesting Operations on bouteille4:");
            bouteille4.Remplir(0.25f); // Fill 0.25L
            bouteille4.AfficherEtat(); // 0.75L, 0.75L, open (now full)
        }
    }
}