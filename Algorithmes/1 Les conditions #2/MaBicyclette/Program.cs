using System;

namespace MaBicyclette
{
    class App
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            bool beauTemps;
            bool veloOK;
            bool reparationImmediates;
            bool livrePossede;
            bool livreDispoBibliotheque;

            // Lecture de la condition météo
            Console.Write("Fera-t-il beau demain? (Oui/Non): ");
            beauTemps = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);

            // Détermination de l'activité en fonction du beau temps
            if (beauTemps)
            {
                // Le vélo est-il en bon état ?
                Console.Write("Le vélo est-il en bon état ? (Oui/Non): ");
                veloOK = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);

                if (veloOK)
                {
                    // Balade à vélo
                    Console.WriteLine("Vous allez faire une balade à vélo.");
                }
                else
                {
                    // Réparation du vélo
                    Console.WriteLine("Vous allez faire réparer votre vélo.");

                    // Les réparations seront-elles immédiates ?
                    Console.Write("Les réparations seront-elles immédiates ? (Oui/Non): ");
                    reparationImmediates = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);

                    if (reparationImmediates)
                    {
                        // Balade à vélo après réparation immédiate
                        Console.WriteLine("Vous allez faire une balade à vélo après réparation.");
                    }
                    else
                    {
                        // Balade à pied à l'étang
                        Console.WriteLine("Vous irez à pied à l'étang pour cueillir des joncs.");
                    }
                }
            }
            else
            {
                // Journée lecture
                Console.WriteLine("Vous allez passer la journée à lire.");

                // Possédez-vous le premier tome de Game of Thrones ?
                Console.Write("Possédez-vous le premier tome de Game of Thrones ? (Oui/Non): ");
                livrePossede = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);

                if (livrePossede)
                {
                    // Relecture du premier tome de Game of Thrones
                    Console.WriteLine("Vous allez relire le premier tome de Game of Thrones.");
                }
                else
                {
                    // Recherche du livre à la bibliothèque
                    Console.WriteLine("Vous allez chercher le livre à la bibliothèque.");

                    // Le livre est-il disponible à la bibliothèque ?
                    Console.Write("Le livre est-il disponible à la bibliothèque ? (Oui/Non): ");
                    livreDispoBibliotheque = Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase);

                    if (livreDispoBibliotheque)
                    {
                        // Emprunt du premier tome de Game of Thrones
                        Console.WriteLine("Vous allez emprunter le premier tome de Game of Thrones.");
                    }
                    else
                    {
                        // Emprunt d'un roman policier
                        Console.WriteLine("Vous allez emprunter un roman policier.");
                    }
                    Console.WriteLine("Vous allez rentrer chez vous.");
                    Console.WriteLine("Vous allez lire votre livre dans le fauteil.");
                }
            }
        }
    }
}
