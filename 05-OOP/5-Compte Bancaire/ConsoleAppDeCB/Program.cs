using System;
using ClassLibraryDeCB;

namespace ApplicationConsoleDeCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Fix for € symbol
            Console.WriteLine("Système de Gestion de Comptes Bancaires");
            Console.WriteLine("=======================================\n");

            try
            {
                // Create two sample accounts
                Compte compte1 = new Compte(1001, "Alice Dupont", 1500.00m, -500.00m);
                Compte compte2 = new Compte(1002, "Bernard Martin", 2500.00m, -1000.00m);

                // Display initial account information
                Console.WriteLine("Détails initiaux des comptes:");
                Console.WriteLine(compte1);
                Console.WriteLine(compte2);
                Console.WriteLine();

                // Demonstrate deposit functionality
                Console.WriteLine("Dépôt de 200 € sur le compte d'Alice...");
                compte1.Crediter(200.00m);
                Console.WriteLine($"Nouveau solde d'Alice: {compte1.Solde:C}");

                // Demonstrate withdrawal functionality
                Console.WriteLine("\nRetrait de 100 € du compte de Bernard...");
                if (compte2.Debiter(100.00m))
                {
                    Console.WriteLine($"Retrait réussi. Nouveau solde de Bernard: {compte2.Solde:C}");
                }

                // Demonstrate transfer functionality
                Console.WriteLine("\nTransfert de 300 € de Bernard vers Alice...");
                if (compte2.Transferer(300.00m, compte1))
                {
                    Console.WriteLine("Transfert réussi.");
                    Console.WriteLine($"Solde d'Alice: {compte1.Solde:C}");
                    Console.WriteLine($"Solde de Bernard: {compte2.Solde:C}");
                }

                // Demonstrate comparison functionality
                Console.WriteLine("\nComparaison des comptes:");
                if (compte1.Superieur(compte2))
                {
                    Console.WriteLine("Alice a plus d'argent que Bernard");
                }
                else
                {
                    Console.WriteLine("Bernard a plus d'argent qu'Alice");
                }

                // Try an invalid operation (withdrawal exceeding overdraft limit)
                try
                {
                    Console.WriteLine("\nTentative de retrait de 3000 € du compte d'Alice...");
                    compte1.Debiter(3000.00m);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Erreur: {ex.Message}");
                }

                // Display final account information
                Console.WriteLine("\nDétails finaux des comptes:");
                Console.WriteLine(compte1);
                Console.WriteLine(compte2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur inattendue est survenue: {ex.Message}");
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}