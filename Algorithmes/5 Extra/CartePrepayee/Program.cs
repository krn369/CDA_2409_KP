/*
 Résolvez le problème suivant dans une application en mode "Console" dans l'un des langages suivants :
C#.

Au CRM, chaque stagiaire et chaque membre du personnel possède une carte à son nom.
Pour payer une boisson avec la carte, il faut la charger en €. (Principe de la "carte prépayée").
Pour payer un repas au restaurant du CRM, la carte est vérifiée :
- Les données de la carte correspondent-elles à une personne inscrite ?
- Y a-t-il suffisamment de fonds disponibles ?

Si les contrôles sont validés, le prix du repas est soustrait du montant disponible sur la carte.

Votre travail consiste à développer l'algorithme de validation de la carte.

Pour simuler le fonctionnement, l'algorithme sera programmé dans une application en mode "Console".
- La table "utilisateurs" contiendra 5 utilisateurs.
- Le prix du repas sera fixé à 4 €
- Il n'est pas possible d'être "à découvert"
 */

using System;
using System.Diagnostics;


class CartePrepayee
{
    // Class to represent a user with a name and balance.
    class Utilisateur
    {
        public string Nom;
        public double Solde;

        public Utilisateur(string nom, double solde)  // The constructor initializes these fields.
        {
            Nom = nom;
            Solde = solde;
        }
    }

 
    private static void Main(string[] args)
    {
        // Initialize users
        // An array of 5 users is created and initialized with the names and balances.

        Utilisateur[] utilisateurs = new Utilisateur[5];
        utilisateurs[0] = new Utilisateur("Raymond", 50.50);
        utilisateurs[1] = new Utilisateur("Remi", 10.90);
        utilisateurs[2] = new Utilisateur("Allan", 15.04);
        utilisateurs[3] = new Utilisateur("Marie", 49.99);
        utilisateurs[4] = new Utilisateur("Julien", 25.0);

     

        // Meal price is set to 4 euros.
        double prixDuRepas = 4.0;

        // Ask for the user name
        Console.WriteLine("Entrez le nom de l’utilisateur : ");
        string nomUtilisateur  = Console.ReadLine();


        // Find the user
        // It search through the array of users to find a match with the entered name. If a match is found, found user (utilisateurTrouver) is set to that user (utilisateur).
        Utilisateur utilisateurTrouver = null;
        foreach (var utilisateur in utilisateurs)
        {
            if(utilisateur.Nom.Equals(nomUtilisateur, StringComparison.OrdinalIgnoreCase))
            {
                utilisateurTrouver = utilisateur;
                break;
            }
        }

        /*
                     
         If the user is found, the program checks if the balance is sufficient to pay for the meal.
         If the balance is sufficient, it deducts the meal price from the balance and displays the new balance.
         If the balance is insufficient, it displays a message indicating insufficient funds.
         If the user is not found, it displays a message indicating the user was not found.

         */
        if (utilisateurTrouver != null)
        {
            Console.WriteLine($"\nUtilisateur Trouvé : {utilisateurTrouver.Nom}, Balance : {utilisateurTrouver.Solde} euros ");

            if (utilisateurTrouver.Solde >= prixDuRepas)
            {
                utilisateurTrouver.Solde -= prixDuRepas;
                Console.WriteLine($"\nRepas payé. Nouveau solde : {utilisateurTrouver.Solde} euros ");
            }

            else
            {
                Console.WriteLine("\nFonds insuffisants pour payer le repas.");
            }
        }

        else
        {
            Console.WriteLine("Utilisateur non trouvé.");
        }


    }
}