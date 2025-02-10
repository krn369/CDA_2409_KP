using System;
using BibliothequeDeClassBouteille;



namespace BouteilleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Bouteille with specific values
            Bouteille bouteilleDeVin = new Bouteille(0.75f, 0, true);
            Bouteille parfumChanel5 = new Bouteille(0.25f, 0.25f, true);
            Bouteille bouteilleShampoing = new Bouteille(1, 0.5f, false);

            // Display the initial state of the bottles
            Console.WriteLine("Initial State:");
            Console.WriteLine($"Bouteille de Vin: Contenance={bouteilleDeVin.ContenanceEnLitre}L, Contenu={bouteilleDeVin.ContenuEnLitre}L, Ouverte={bouteilleDeVin.EstOuverte}");
            Console.WriteLine($"Parfum Chanel 5: Contenance={parfumChanel5.ContenanceEnLitre}L, Contenu={parfumChanel5.ContenuEnLitre}L, Ouverte={parfumChanel5.EstOuverte}");
            Console.WriteLine($"Bouteille de Shampoing: Contenance={bouteilleShampoing.ContenanceEnLitre}L, Contenu={bouteilleShampoing.ContenuEnLitre}L, Ouverte={bouteilleShampoing.EstOuverte}");

            // Perform some operations on the bottles
            bouteilleDeVin.Remplir(0.5f);
            parfumChanel5.Vider(0.1f);
            bouteilleShampoing.Ouvrir();
            bouteilleShampoing.RemplirComplet();

            // Display the state of the bottles after operations
            Console.WriteLine("\nAfter Operations:");
            Console.WriteLine($"Bouteille de Vin: Contenance={bouteilleDeVin.ContenanceEnLitre}L, Contenu={bouteilleDeVin.ContenuEnLitre}L, Ouverte={bouteilleDeVin.EstOuverte}");
            Console.WriteLine($"Parfum Chanel 5: Contenance={parfumChanel5.ContenanceEnLitre}L, Contenu={parfumChanel5.ContenuEnLitre}L, Ouverte={parfumChanel5.EstOuverte}");
            Console.WriteLine($"Bouteille de Shampoing: Contenance={bouteilleShampoing.ContenanceEnLitre}L, Contenu={bouteilleShampoing.ContenuEnLitre}L, Ouverte={bouteilleShampoing.EstOuverte}");
    
        }
    }
}