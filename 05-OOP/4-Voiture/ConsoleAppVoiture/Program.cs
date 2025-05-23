using ClassLibraryVoiture;
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==== Test 1: Default Constructor ====
        Console.WriteLine("===== Test 1: Default Voiture =====");
        Voiture defaultCar = new Voiture();
        Console.WriteLine(defaultCar);
        Console.WriteLine();

        // ==== Test 2: Parameterized Constructor ====
        Console.WriteLine("===== Test 2: Parameterized Voiture =====");
        Voiture customCar = new Voiture("BMW", "Serie 3", "Essence", true, "Pirelli", false, 16.4);
        Console.WriteLine(customCar);
        Console.WriteLine();

        // ==== Test 3: Copy Constructor ====
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

        // ==== Test 6: Car Actions ====
        Console.WriteLine("===== Test 6: Start, Move, Stop =====");
        customCar.Demarrer();       // Start engine
        customCar.Avancer();        // Move car
        Console.WriteLine(customCar);
        customCar.Arreter();        // Stop car
        Console.WriteLine(customCar);
        Console.WriteLine();

        // ==== Test 7: Spare Wheel (maRoueDeSecour) ====
        Console.WriteLine("===== Test 7: Adding Spare Wheel =====");
        Roue spare = customCar.AjouterRoueDeSecours();

        if (spare != null)
        {
            Console.WriteLine("Spare wheel added:");
            Console.WriteLine(spare);
        }
        else
        {
            Console.WriteLine("Spare wheel already exists.");
        }

        // Try adding it again to test duplication prevention
        Roue spare2 = customCar.AjouterRoueDeSecours();
        Console.WriteLine(spare2 == null ? "Second spare NOT added (already exists)." : "Unexpected second spare added.");
    }
}
