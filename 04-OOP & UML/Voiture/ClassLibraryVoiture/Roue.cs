namespace ClassLibraryVoiture
{
<<<<<<< HEAD
    // Roue  Wheel Class
    public class Roue
    {
        private string marqueRoue;  // Wheel brand (e.g., Michelin)
        private bool tourne;        // Whether the wheel is spinning?
        private int tailleEnMM;     // Wheel size with tyre (diameter) in millimeters 
        public bool Tourne => tourne; // Read-only access

        // Default constructor delegates to parameterized one : Creates a 215mm Michelin Wheel that's not spinning
        public Roue() : this(585, false, "Michelin") { }



        // Parameterized constructor: Creates a wheel with specific size, spin status, and brand
        public Roue(int tailleEnMM, bool tourne, string marqueRoue)
        {
            if (tailleEnMM < 0)
                throw new ArgumentException("La taille de la roue doit être positive.");

            this.tailleEnMM = tailleEnMM;
            this.tourne = tourne;
            this.marqueRoue = marqueRoue;
=======
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
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
        }

        // Parameterized constructor
        public Roue(int tailleEnMM, bool tourne, string marqueRoue)
        {
            if (tailleEnMM < 0)
                throw new ArgumentException("Tire size must be positive");

<<<<<<< HEAD

        // Copy constructor delegates to parameterized constructor : Creates a copy of another wheel
        public Roue(Roue roueACopier) : this(roueACopier.tailleEnMM, roueACopier.tourne, roueACopier.marqueRoue) { }

        // Methods

        // Tourner(): Makes the wheel spin if it's not already spinning
=======
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
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
        public bool Tourner()
        {
            if (!tourne)
            {
                tourne = true;
                return true;
            }
            return false;
        }

<<<<<<< HEAD
        //ArreterTourner(): Stops the wheel if it's spinning
=======
        // Stop rotating
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
        public bool ArreterTourner()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            return false;
        }

<<<<<<< HEAD
        // ToString(): Returns wheel info as text
        public override string ToString() =>
        $"Roue [Marque: {marqueRoue}, Tourne: {tourne}, Taille de pneau: {tailleEnMM}mm]";
=======
        // String representation
        public override string ToString()
        {
            return $"Roue [Marque: {marqueRoue}, Tourne: {tourne}, Taille: {tailleEnMM}mm]";
        }
>>>>>>> 58b75c8a649dd487f52ccbc2a35e0b5fed026305
    }

}

