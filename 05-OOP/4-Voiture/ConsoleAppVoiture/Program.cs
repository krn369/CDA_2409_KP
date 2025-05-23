using ClassLibraryVoiture;
using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        // ==== Test 1: Default Voiture Constructor ====
        Console.WriteLine("===== Test 1: Default Voiture =====");
        Voiture defaultCar = new Voiture();
        Console.WriteLine(defaultCar);
        Console.WriteLine();

        // ==== Test 2: Parameterized Voiture Constructor ====
        Console.WriteLine("===== Test 2: Parameterized Voiture =====");
        Voiture customCar = new Voiture("BMW", "Serie 3", "Essence", "Pirelli", 16.4);
        Console.WriteLine(customCar);
        Console.WriteLine();

        // ==== Test 3: Voiture Copy Constructor ====
        Console.WriteLine("===== Test 3: Copied Voiture =====");
        Voiture copiedCar = new Voiture(customCar);
        Console.WriteLine(copiedCar);
        Console.WriteLine();

        // ==== Test 4: Testing Moteur Constructors ====
        Console.WriteLine("===== Test 4: Moteur Constructors =====");
        Moteur defaultEngine = new Moteur();
        Moteur customEngine = new Moteur("Electrique", true);
        Moteur copiedEngine = new Moteur(customEngine);
        Console.WriteLine(defaultEngine);
        Console.WriteLine(customEngine);
        Console.WriteLine(copiedEngine);
        Console.WriteLine();

        // ==== Test 5: Testing Roue Constructors ====
        Console.WriteLine("===== Test 5: Roue Constructors =====");
        Roue defaultWheel = new Roue();
        Roue customWheel = new Roue(17.1, true, "Goodyear");
        Roue copiedWheel = new Roue(customWheel);
        Console.WriteLine(defaultWheel);
        Console.WriteLine(customWheel);
        Console.WriteLine(copiedWheel);
        Console.WriteLine();

        // ==== Test 6: Start, Move, Stop the Car ====
        Console.WriteLine("===== Test 6: Start, Move, Stop the Car =====");
        customCar.Demarrer();  // Start engine
        customCar.Avancer();   // Move car
        Console.WriteLine(customCar); // Displays the state of the car after the engine is started and it has moved(i.e., wheels should now be spinning, engine running).

        customCar.Arreter();   // Stop car
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        Console.WriteLine(customCar); // Displays the state of the car after calling Arreter(), which stops the engine and all wheels.
        Console.WriteLine();

        // ==== Test 7: Adding Spare Wheel ====
        Console.WriteLine("===== Test 7: Adding Spare Wheel =====");
        Roue spareWheel = new Roue(17.0, false, "Michelin");
        bool isSpareAdded = customCar.AjouterRoueDeSecours(spareWheel);

        if (isSpareAdded)
        {
            Console.WriteLine("Spare wheel successfully added:");
            Console.WriteLine(spareWheel);
        }
        else
        {
            Console.WriteLine("Spare wheel already exists.");
        }

        // Try adding a second spare wheel to ensure duplication prevention
        Roue secondSpareWheel = new Roue(16.5, false, "Michelin");
        bool isSecondSpareAdded = customCar.AjouterRoueDeSecours(secondSpareWheel);

        Console.WriteLine(isSecondSpareAdded ? "Unexpected second spare added." : "Second spare NOT added (already exists).");
    }
}
