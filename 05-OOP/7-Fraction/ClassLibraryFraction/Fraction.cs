namespace ClassLibraryFraction
{
    public class Fraction
    {
        // Fields
        private int numerateur;  // Top part of the fraction
        private int denominateur;  // Bottom part of the fraction

        //  =========================================================================================================================================

        // Constructors - All constructors ultimately call the main constructor

        public Fraction() : this(0, 1) { } // Default uses main constructor :  0/1

        public Fraction(int numerateur) : this(numerateur, 1) { } // Single parameter uses main constructor : 3/1

        public Fraction(int numerateur, int denominateur)
        {
            // Main constructor handles all initialization i.e  sets the num & deno for a fraction
            if (denominateur == 0)
                throw new ArgumentException("Le dénominateur ne peut pas être zéro. ");

            this.numerateur = numerateur;
            this.denominateur = denominateur;
            Reduire(); // All fractions get reduced (simplified)  on creation
        }

        // Copy Constructor : Creates a copy of another Fraction. 
        public Fraction(Fraction f) : this(f.numerateur, f.denominateur) { } // Copy constructor uses main constructor


        //  =========================================================================================================================================

        // Methods
        

        
        public void Oppose() // Negates the fraction (-n/d)
        {
            numerateur = -numerateur;
            // No need to reduce as sign change doesn't affect simplification
        }



        public void Inverse()  // Swap the numerator by denominator (d/n)
        {
            if (numerateur == 0)
                throw new InvalidOperationException("Impossible d'inverser zéro");
            (numerateur, denominateur) = (denominateur, numerateur); // Swap values
            
            Reduire();  // Re-simplify after swap
        }



        // This method checks if this fraction is greater than another fraction f by cross-multiplying.
        public bool Superieur(Fraction f) => (numerateur * f.denominateur) > (f.numerateur * f.denominateur);



        // This method checks if two fractions are equal by cross-multiplying and comparing.
        public bool EgalA(Fraction f) => (numerateur * f.denominateur) == (f.numerateur * denominateur);


        // Arthemetic operations : Each operation returns a new Fraction, which gets simplified automatically via the constructor.

        // Addition: (a/b) + (c/d) = (ad + bc)/bd
        public Fraction Plus(Fraction f) => new Fraction(
            numerateur * f.denominateur + f.numerateur *denominateur,
            denominateur * f.denominateur);


        // Moins (Subtraction of two fractions) 
        public Fraction Moins(Fraction f) => new Fraction(
            numerateur * f.denominateur - f.numerateur * denominateur,
            denominateur * f.denominateur);

        //  Multiplie (Multiplication of two fractions)
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


        // This method converts the fraction to a string for display.
        public override string ToString()
        {
            if (denominateur == 1) return numerateur.ToString();
            if (numerateur == 0) return "0";
            return $"{numerateur}/{denominateur}";
        }


        // Private Methods 
        // simplifying Fractions (Reducing)
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
