using System;
namespace ClassLibraryVoiture
{
    // Roue  Wheel Class
    public class Roue
    {
        private string marqueRoue;  // Wheel brand (e.g., Michelin)
        private bool tourne;        // Whether the wheel is spinning?
        private double tailleEnPouces;     // Wheel size with tyre (diameter) in inches
        public bool Tourne => tourne; // Read-only access

        // Default constructor delegates to parameterized one : Creates a 18.5" Michelin Wheel that's not spinning
        public Roue() : this(18.5, false, "Michelin") { }


        // Parameterized constructor: Creates a wheel with specific size, spin status, and brand
        public Roue(double tailleEnPouces, bool tourne, string marqueRoue)
        {
            if (tailleEnPouces < 0)
                throw new ArgumentException("La taille de la roue doit être positive.", nameof(tailleEnPouces));

            this.tailleEnPouces = tailleEnPouces;
            this.tourne = tourne;
            this.marqueRoue = marqueRoue ?? throw new ArgumentNullException(nameof(marqueRoue));
        }


        // Copy constructor delegates to parameterized constructor : Creates a copy of another wheel
        public Roue(Roue roueACopier) : this(
            roueACopier.tailleEnPouces, 
            roueACopier.tourne, 
            roueACopier.marqueRoue) 
        { }

        // Methods

        // Tourner(): Makes the wheel spin if it's not already spinning
        public bool Tourner()
        {
            if (!tourne)
            {
                tourne = true;
                return true;
            }
            return false;
        }

        //ArreterTourner(): Stops the wheel if it's spinning
        public bool ArreterTourner()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }

        // ToString(): Returns wheel info as text
        public override string ToString() =>
        $"Roue [Marque: {marqueRoue}, Tourne: {tourne}, Taille de pneu: {tailleEnPouces}\"]";
    }

}
