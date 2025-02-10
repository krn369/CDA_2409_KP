using System;

namespace BibliothequeDeClassBouteille
{
    // Define the Bouteille (Bottle) class
    public class Bouteille
    {
        // Fields (attributes) of the Bouteille class
        public float ContenanceEnLitre; // Total capacity of the bottle in liters
        public float ContenuEnLitre;    // Current content in the bottle in liters
        public bool EstOuverte;         // Whether the bottle is open or not

        // Default constructor
        public Bouteille()
        {
            // Initialize the bottle with default values
            ContenanceEnLitre = 0;
            ContenuEnLitre = 0;
            EstOuverte = false;
        }

        // Parameterized constructor
        public Bouteille(float contenanceEnLitre, float contenuEnLitre, bool ouverte)
        {
            // Initialize the bottle with specific values
            ContenanceEnLitre = contenanceEnLitre;
            ContenuEnLitre = contenuEnLitre;
            EstOuverte = ouverte;
        }

        // Copy constructor
        public Bouteille(Bouteille bouteilleAReCopier)
        {
            // Copy the values from another Bouteille object
            ContenanceEnLitre = bouteilleAReCopier.ContenanceEnLitre;
            ContenuEnLitre = bouteilleAReCopier.ContenuEnLitre;
            EstOuverte = bouteilleAReCopier.EstOuverte;
        }

        // Method to open the bottle
        public bool Ouvrir()
        {
            if (!EstOuverte)
            {
                EstOuverte = true;
                return true; // Successfully opened
            }
            return false; // Already open
        }

        // Method to close the bottle
        public bool Fermer()
        {
            if (EstOuverte)
            {
                EstOuverte = false;
                return true; // Successfully closed
            }
            return false; // Already closed
        }

        // Method to empty the bottle completely
        public bool ViderComplet()
        {
            if (EstOuverte)
            {
                ContenuEnLitre = 0;
                return true; // Successfully emptied
            }
            return false; // Bottle is closed
        }

        // Method to empty a specific quantity from the bottle
        public bool Vider(float quantiteEnLitre)
        {
            if (EstOuverte && quantiteEnLitre <= ContenuEnLitre)
            {
                ContenuEnLitre -= quantiteEnLitre;
                return true; // Successfully emptied the specified quantity
            }
            return false; // Bottle is closed or not enough content
        }

        // Method to fill the bottle completely
        public bool RemplirComplet()
        {
            if (EstOuverte)
            {
                ContenuEnLitre = ContenanceEnLitre;
                return true; // Successfully filled
            }
            return false; // Bottle is closed
        }

        // Method to fill a specific quantity into the bottle
        public bool Remplir(float quantiteEnLitre)
        {
            if (EstOuverte && quantiteEnLitre + ContenuEnLitre <= ContenanceEnLitre)
            {
                ContenuEnLitre += quantiteEnLitre;
                return true; // Successfully filled the specified quantity
            }
            return false; // Bottle is closed or not enough capacity
        }
    }

}