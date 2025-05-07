using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    // Moteur (Engine) class represents a car engine
    public class Moteur
    {
        // Fields
        private string type; // Type of the engine
        private bool estDemarre; // Whether the engine is started or not

        // Constructors
        public Moteur()
        {
            // Default constructor
            this.type = "";
            this.estDemarre = false;
        }

        public Moteur(string type, bool estDemarre)
        {
            // Constructor with parameters
            this.type = type;
            this.estDemarre = estDemarre;
        }

        public Moteur(Moteur moteurACopier)
        {
            // Copy constructor
            this.type = moteurACopier.type;
            this.estDemarre = moteurACopier.estDemarre;
        }

        // Methods
        public bool DemarreMoteur()
        {
            // Starts the engine
            this.estDemarre = false;
            return this.estDemarre;
        }

        public bool ArreteMoteur()
        {
            // Stops the engine
            this.estDemarre = false;
            return this.estDemarre;
        }

        public bool EntrainerRouesMotrices(Roue r1, Roue r2)
        {
            //Makes the motor turn the driving wheels
            if (this.estDemarre)
            {
                r1.Tourne(true);
                r2.Tourne(true);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            // Returns a string representation of the engine
            return $"Type de Moteur : {type}, Démarré : {estDemarre}";
        
        }


    }
}