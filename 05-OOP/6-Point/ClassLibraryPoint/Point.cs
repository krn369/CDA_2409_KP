using System;
using System.Runtime.InteropServices;
namespace ClassLibraryPoint
{
    public class Point
    {
        private float x;
        private float y;

        // Constructors (Interdependent)

        // Key Idea : Point() and Point(Point p) rely on Point(x, y) to set coordinates.
        public Point() : this(0,0) { }  // Creates a point at (0, 0) by calling Point(0, 0)
        public Point(float x, float y) // Set custom (x,y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p) : this(p.x, p.y) { } // Copies another point's x and y



        // Symmetry Methods (Interdependent)
        // These methods return a new Point (original remains unchanged).

        /*
                public Point SymetrieAxeAbscisse()
                {
                    return new Point(x, -y);
                }
        */

        public Point SymetrieAxeAbscisse() => new Point(x, -y); // Flips over X-axis (negates y)
        public Point SymetrieAxeOrdonnee() => new Point(-x, -y); // Flips over Y-axis (negates x)


        // public Point SymetrieOrigine() => new Point(-x, -y);    // Flips over origin (negates both)	(-x, -y)
        public Point SymetrieOrigine() => this.SymetrieAxeAbscisse().SymetrieAxeOrdonnee(); // Flip X and Y

        // Other Methods
        public void Deplacer(float newX, float newY)  // Moves the point to new coordinates
        {
            x = newX;
            y = newY;
        }

        public void Permuter () // Swap X & Y
        {
            float temp = x;
            x = y;
            y = temp;
        }

        public override string ToString()  // Returns a readable string
        {
            return $"Point ( X :{x}, Y : {y} )";
        }
    }
}
