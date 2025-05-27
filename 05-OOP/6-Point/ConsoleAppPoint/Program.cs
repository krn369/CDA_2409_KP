using ClassLibraryPoint;
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(" #####   Testing the Point Class.   ##### \n");

        // 1. Test Constructors
        Console.WriteLine("----- Constructors -----");
        Point origin = new Point();
        Point customPoint = new Point(3.5f, 2.7f);
        Point copiedPoint = new Point(customPoint);

        Console.WriteLine($"Default constructor: {origin}");
        Console.WriteLine($"Custom constructor: {customPoint}");
        Console.WriteLine($"Copy constructor: {copiedPoint}");

        // 2. Test Movement
        Console.WriteLine("\n----- Movement -----");
        origin.Deplacer(1, 1);
        Console.WriteLine($"Moved origin to (1,1): {origin}");

        // 3. Test Coordinate Swap
        Console.WriteLine("\n----- Coordinate Swap -----");
        Console.WriteLine($"Before swap: {customPoint}");
        customPoint.Permuter();
        Console.WriteLine($"After swap: {customPoint}");

        // 4. Test Symmetry Operations
        Console.WriteLine("\n----- Symmetry Operations -----");
        Point original = new Point(2, 3);

        Point xFlipped = original.SymetrieAxeAbscisse();
        Console.WriteLine($"X-axis symmetry: {xFlipped}"); // (2, -3)

        Point yFlipped = original.SymetrieAxeOrdonnee();
        Console.WriteLine($"Y-axis symmetry: {yFlipped}"); // (-2, 3)

        Point originFlipped = original.SymetrieOrigine();
        Console.WriteLine($"Origin symmetry: {originFlipped}"); // (-2, -3)

        // 5. Verify Original Unchanged (Immutability)
        Console.WriteLine($"\nOriginal point remains: {original}"); // (2, 3)
    }
}