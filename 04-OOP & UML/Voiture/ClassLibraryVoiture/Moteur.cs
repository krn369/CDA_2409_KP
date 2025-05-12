using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    // Moteur class
    public class Moteur
    {
        private string type; // What kind of engine?
        private bool estDemarre; // Whether the engine is running ?

        // Default constructor calls parameterized constructor  // Creates a Diesel engine that's not running
        public Moteur() : this("Diesel", false) { }

        // Parameterized constructor
        public Moteur(string type, bool estDemarre)
        {
            this.type = type;
            this.estDemarre = estDemarre;
        }

        // Copy constructor calls parameterized constructor
        public Moteur(Moteur moteurACopier) : this(moteurACopier.type, moteurACopier.estDemarre) { }

        public bool DemarrerMoteur()
        {
            if (!estDemarre)
            {
                estDemarre = true;
                return true;
            }
            return false;
        }

        public bool ArreterMoteur()
        {
            if (estDemarre)
            {
                estDemarre = false;
                return true;
            }
            return false;
        }

        public bool Entrainer2RouesMotrices(Roue r1, Roue r2)
        {
            if (estDemarre && !r1.Tourne && !r2.Tourne)
            {
                r1.Tourner();
                r2.Tourner();
                return true;
            }
            return false;
        }

        public override string ToString() =>
            $"Moteur [Type: {type}, EstDemarre: {estDemarre}]";
    }

}