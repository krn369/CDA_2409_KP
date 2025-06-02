namespace ClassLibraryFraction
{
    public class Fraction
    {
        // Fields
        private int numerateur;
        private int denominateur;



        // Constructors - All constructors ultimately call the main constructor

        public Fraction() : this(0, 1) { } // Default uses main constructor

        public Fraction(int numerateur) : this(numerateur, 1) { } // Single param uses main constructor

        public Fraction(int numeratuer, int denominateur)
        {
            // Main constructor handles all initialization
            if (denominateur == 0)
                throw new ArgumentException("Le dénominateur ne peut pas être zéro. ");

            this.numerateur = numerateur;
            this.denominateur = denominateur;
            Reduire(); // All fractions get reduced on creation
        }

        public Fraction(Fraction f) : this(f.numerateur, f.denominateur) { } // Copy constructor uses main constructor

        // Methods
        

        
        public void Oppose() // Negates the fraction (-n/d)
        {
            numerateur = -numerateur;
            // No need to reduce as sign change doesn't affect simplification
        }

        public void Inverse()  // Swap numerator by denominator (d/n)
        {
            if (numerateur == 0)
                throw new InvalidOperationException("Impossible d'inverser zéro");
            (numerateur, denominateur) = (denominateur, numerateur); // Swap values
            
            Reduire();  // Re-simplify after swap
        }

        // Checks if this > other by cross-multiplying
        public bool Superieur(Fraction f) => (numerateur * f.denominateur) > (f.numerateur * f.denominateur);

        // Checks if this == other by cross-multiplying
        public bool EgalA(Fraction f) => (numerateur * f.denominateur) == (f.numerateur * denominateur);


        // Arthemetic operations : Each operation returns a new Fraction, which gets simplified automatically via the constructor.

        // Addition: (a/b) + (c/d) = (ad + bc)/bd
        public Fraction Plus(Fraction f) => new Fraction(
            numerateur * f.denominateur + f.numerateur *denominateur,
            denominateur * f.denominateur);

        public Fraction Moins(Fraction f) => new Fraction(
            numerateur * f.denominateur - f.numerateur * denominateur,
            denominateur * f.denominateur);

        public Fraction Multiplie(Fraction f) => new Fraction(
            numerateur * f.numerateur,
            denominateur * f.denominateur);


        // Division: (a/b) ÷ (c/d) = (a/b) × (d/c)
        public Fraction Divise(Fraction f)
        {
            if (f.numerateur == 0)
                throw new DivideByZeroException("Division par zéro impossible.");
            return Multiplie(new Fraction(f.denominateur, f.numerateur));  // Reuses Multiplie with inverse
        }

        public override string ToString()
        {
            if (denominateur == 1) return numerateur.ToString();
            if (numerateur == 0) return "0";
            return $"{numerateur}/{denominateur}";
        }


        // Private Methods
        private void Reduire()
        {
            int pgcd = GetPgcd();
            numerateur /= pgcd;
            denominateur /= pgcd;   

            //Ensure denominator is positive
            if (denominateur < 0)
            {
                numerateur = -numerateur;
                denominateur = -denominateur;
            }
        }

        // Euclidean algorithm for GCD
        private int GetPgcd()
        {
            int a = Math.Abs(numerateur);
            int b = Math.Abs(denominateur);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a == 0 ? 1 : a;
        }

        // Operator Overloading (all reuse existing methods)
        public static Fraction operator + (Fraction f1, Fraction f2) => f1.Plus(f2);
        public static Fraction operator - (Fraction f1, Fraction f2) => f1.Moins(f2);
        public static Fraction operator * (Fraction f1, Fraction f2) => f1.Multiplie(f2);
        public static Fraction operator / (Fraction f1, Fraction f2) => f1.Divise(f2);

    }
}
