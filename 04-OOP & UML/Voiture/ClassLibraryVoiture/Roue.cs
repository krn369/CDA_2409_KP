using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    // Roue (Wheel) class represents a car wheel
    public class Roue
    {
        // Fields
        private string marqueRoue; // Brand of the wheel
        private bool tourne;  // Whether the wheel is turning
        private int tailleEnMM; // Size of the wheel in millimeters

        // Constructors
        public Roue()
        {
            // Default constructor
            this.marqueRoue = "";
            this.tourne = false;
            this.tailleEnMM = 0;
        }

        public Roue(int tailleEnMM, bool tourne, string marqueRoue)
        {
            // Constructor with parameters
            this.tailleEnMM = tailleEnMM;
            this.tourne = tourne;
            this.marqueRoue = marqueRoue;
        }

        public Roue(Roue roueACopier)
        {
            // Copy constructor
            this.tailleEnMM = roueACopier.tailleEnMM;
            this.tourne = roueACopier.tourne;
            this.marqueRoue = roueACopier.marqueRoue;
        }

        // Methods
        public bool Tourne(bool tourne)
        {
            // Sets the wheel to turn or stop
            this.tourne = tourne;
            return this.tourne;
        }

        public override string ToString()
        {
            // Returns a string representation of the wheel
            return $"Marque de roue : {marqueRoue}, Taille : {tailleEnMM}mm, Tourne: {tourne}";

        }
    }
}
