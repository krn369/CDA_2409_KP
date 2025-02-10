// Main program to demonstrate the usage of the classes
using ClassLibraryUTB;
using Action = ClassLibraryUTB.Action;


class Program
{
    static void Main(string[] args)
    {


        // Create a new action (stock) with symbol "AAPL" and price 150.75
        Action action = new Action("AAPL", 150.75m);

        // Create a new investor with ID 1 and name "John Doe"
        Investisseur investisseur = new Investisseur(1, "John Doe");

        // Investor buys 10 shares of the action
        investisseur.Acheter(10, action);

        // Investor sells 5 shares of the action
        investisseur.Vendre(5, action);

    }
}

