using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    // Roue class
    public class Roue
    {
        private string marqueRoue;
        private bool tourne;
        private int tailleEnMM;

        public bool Tourne => tourne; // Read-only access

        // Default constructor
        public Roue()
        {
            marqueRoue = "Michelin";
            tourne = false;
            tailleEnMM = 15;
        }

        // Parameterized constructor
        public Roue(int tailleEnMM, bool tourne, string marqueRoue)
        {
            if (tailleEnMM < 0)
                throw new ArgumentException("Tire size must be positive");

            this.tailleEnMM = tailleEnMM;
            this.tourne = tourne;
            this.marqueRoue = marqueRoue;
        }

        // Copy constructor
        public Roue(Roue roueACopier)
        {
            this.marqueRoue = roueACopier.marqueRoue;
            this.tourne = roueACopier.tourne;
            this.tailleEnMM = roueACopier.tailleEnMM;
        }

        // Start rotating
        public bool Tourner()
        {
            if (!tourne)
            {
                tourne = true;
                return true;
            }
            return false;
        }

        // Stop rotating
        public bool ArreterTourner()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }

        // String representation
        public override string ToString()
        {
            return $"Roue [Marque: {marqueRoue}, Tourne: {tourne}, Taille: {tailleEnMM}mm]";
        }
    }
}
