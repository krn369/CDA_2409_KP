using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ClassLibraryVoiture
{
<<<<<<< HEAD
    // Moteur Engine Class
    public class Moteur
    {
        private string type;        // What kind of engine (e.g., Diesel)
        private bool estDemarre;    // Whether the engine is running (true/false) 

        // Default constructor calls parameterized constructor : Creates a Diesel engine that's not running
        public Moteur() : this("Diesel", false) { }

        // Parameterized constructor : Creates an engine with specific type and running status
=======
    // Moteur class
    public class Moteur
    {
        private string type; // What kind of engine?
        private bool estDemarre; // Whether the engine is running ?

        // Default constructor calls parameterized constructor  // Creates a Diesel engine that's not running
        public Moteur() : this("Diesel", false) { }

        // Parameterized constructor
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
        public Moteur(string type, bool estDemarre)
        {
            this.type = type;
            this.estDemarre = estDemarre;
        }

<<<<<<< HEAD
        // Copy constructor calls parameterized constructor : Creates a copy of another engine
        public Moteur(Moteur moteurACopier) : this(moteurACopier.type, moteurACopier.estDemarre) { }

        // DemarrerMoteur(): Starts the engine if it's not already running
=======
        // Copy constructor calls parameterized constructor
        public Moteur(Moteur moteurACopier) : this(moteurACopier.type, moteurACopier.estDemarre) { }

>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
        public bool DemarrerMoteur()
        {
            if (!estDemarre)
            {
                estDemarre = true;
                return true;
            }
            return false;
        }

<<<<<<< HEAD
        // ArreterMoteur() : Stops the engine if it's running
=======
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
        public bool ArreterMoteur()
        {
            if (estDemarre)
            {
                estDemarre = false;
                return true;
            }
            return false;
        }

<<<<<<< HEAD
        // Entrainer2RouesMotrices(): Makes two wheels spin if the engine is running and the wheels aren't already spinning
=======
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
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

<<<<<<< HEAD
        // ToString(): Returns engine info as text
        public override string ToString() =>
        $"Moteur [Type: {type}, EstDemarre: {estDemarre}]";
    }
}
=======
        public override string ToString() =>
            $"Moteur [Type: {type}, EstDemarre: {estDemarre}]";
    }

}
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
