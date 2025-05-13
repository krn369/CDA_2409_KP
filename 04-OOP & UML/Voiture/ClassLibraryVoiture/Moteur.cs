using System;
namespace ClassLibraryVoiture
{
    // Moteur Engine Class
    public class Moteur
    {
        private string type;        // What kind of engine (e.g., Diesel)
        private bool estDemarre;    // Whether the engine is running (true/false) 

        // Default constructor calls parameterized constructor : Creates a Diesel engine that's not running
        public Moteur() : this("Diesel", false) { }

        // Parameterized constructor : Creates an engine with specific type and running status
        public Moteur(string type, bool estDemarre)
        {
            this.type = type;
            this.estDemarre = estDemarre;
        }

        // Copy constructor calls parameterized constructor : Creates a copy of another engine
        public Moteur(Moteur moteurACopier) : this(moteurACopier.type, moteurACopier.estDemarre) { }

        // DemarrerMoteur(): Starts the engine if it's not already running
        public bool DemarrerMoteur()
        {
            if (!estDemarre)
            {
                estDemarre = true;
                return true;
            }
            return false;
        }

        // ArreterMoteur() : Stops the engine if it's running
        public bool ArreterMoteur()
        {
            if (estDemarre)
            {
                estDemarre = false;
                return true;
            }
            return false;
        }

        // Entrainer2RouesMotrices(): Makes two wheels spin if the engine is running and the wheels aren't already spinning
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

        // ToString(): Returns engine info as text
        public override string ToString() =>
        $"Moteur [Type: {type}, EstDemarre: {estDemarre}]";
    }
}
