using System;

namespace BibliothequeDeClassBouteille
{
    // Define the Bouteille (Bottle) class
    public class Bouteille
    {
        // Fields (attributes) of the Bouteille class
        private float contenanceEnLitre; // Total capacity of the bottle in liters
        private float contenuEnLitre;    // Current content in the bottle in liters
        private bool estOuverte;         // Whether the bottle is open or not


        // **** CONSTRUCTORS ****


        // Default constructor : Call the Parameterized constructor & Creates a bottle with default values.
        // Useful to create a bottle without specifying any parameters.
        public Bouteille()
            : this(1f, 1f, false)
        {
            
        }

        // Parameterized constructor : Creates a bottle with specific values provided by the caller.
        // Useful to create a bottle with custom values for capacity, content and state.
        public Bouteille(float contenanceEnLitre, float contenuEnLitre, bool estOuverte)
        {
            // Initialize the bottle with specific values
            this.contenanceEnLitre = contenanceEnLitre;
            this.contenuEnLitre = contenuEnLitre;
            this.estOuverte = estOuverte;
        }

        // Hybrid constructor (default state: full and closed)
        // Useful to create a bottle with a specific capacity, but you don't care about the initial content or state.
        public Bouteille(float contenanceEnLitre)
            : this(contenanceEnLitre, contenanceEnLitre, false)
        {
            // This constructor calls the parameterized constructor with default values for content and state
        }

        // Copy constructor : Create a copy of an existing Bouteille object. 
        // Useful to create a new bottle that is an exact copy of an existing bottle. 
        public Bouteille(Bouteille bouteilleACopier)
            : this (bouteilleACopier.contenanceEnLitre, bouteilleACopier.contenuEnLitre, bouteilleACopier.estOuverte)
        {
       
        }

        // **** METHODS ****

        // Method to open the bottle
        public bool Ouvrir()
        {
            if (!estOuverte)
            {
                estOuverte = true;
                return true; // Successfully opened
            }
            return false; // Already open
        }

        // Method to close the bottle
        public bool Fermer()
        {
            if (estOuverte)
            {
                estOuverte = false;
                return true; // Successfully closed
            }
            return false; // Already closed
        }

        // Method to empty the bottle completely
        public bool Vider()
        {
            //if (estOuverte)
            //{
            //    contenuEnLitre = 0;
            //    return true; // Successfully emptied
            //}
            //return false; // Bottle is closed
            return Vider(contenuEnLitre);
        }

        // Method to empty a specific quantity from the bottle
        public bool Vider(float quantiteEnLitre)
        {
            // Check if the is open, the quantity is non-negative, and there's enough content.
            if (estOuverte && quantiteEnLitre >= 0 && quantiteEnLitre <= contenuEnLitre)
            {
                contenuEnLitre -= quantiteEnLitre;
                return true; // Successfully emptied the specified quantity
            }
            return false; // Bottle is closed, invalid quantity, or not enough content
        }

        // Method to fill the bottle completely
        public bool Remplir()
        {
            //if (estOuverte)
            //{
            //    contenuEnLitre = contenanceEnLitre;
            //    return true; // Successfully filled
            //}
            //return false; // Bottle is closed

            return Remplir(contenanceEnLitre - contenuEnLitre);
        }

        // Method to fill a specific quantity into the bottle
        public bool Remplir(float quantiteEnLitre)
        {
            // Check if the bottle is open, the quantity is non-negative  and there is enough capacity.
            if (estOuverte && quantiteEnLitre >= 0 && quantiteEnLitre + contenuEnLitre <= contenanceEnLitre)
            {
                contenuEnLitre += quantiteEnLitre;
                return true; // Successfully filled the specified quantity
            }
            return false; // Bottle is closed, invalid quantity, or not enough capacity
        }

        // Method to display the state of the bottle (for debugging)
        public void AfficherEtat()
        {
            Console.WriteLine($"Contenance: {contenanceEnLitre}L, Contenu: {contenuEnLitre}L, Ouverte: {estOuverte}");
        }
    }
}
