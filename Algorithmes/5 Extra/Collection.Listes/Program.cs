
/*
 
Au démarrage, il n'y a aucun utilisateur enregistré.
 
1. Le programme demande à l'utilisateur de saisir un nom et un prénom.
	- L’utilisateur saisit un nom et un prénom.
 
2. Lorsque toutes les informations sont saisies
	- Le programme enregistre l'utilisateur
 
3. Le programme demande à l'utilisateur s'il souhaite ajouter une autre personne.
	- Si oui
		- Retour à l'étape 1 (saisir nom et prénom)
	- Si non
		- Afficher tous les utilisateurs enregistrés
 
4. Le programme se termine

*/


/*
    using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enregistrement de nouveaux utilisateurs");

        List<string> utilisateurs = new List<string>();  // Liste fortement typée

        string saisieNomPrenom;

        char saisieOuiNon;

        do
        {
            Console.WriteLine("Saisissez votre prénom et nom :");

            saisieNomPrenom = Console.ReadLine() ?? " ";

            utilisateurs.Add(saisieNomPrenom);

            Console.WriteLine("Souhaitez vous ajouter un autre utilisateur ? (N/O)");

            saisieOuiNon = Console.ReadKey(true).KeyChar;

        }
        while (saisieOuiNon == 'o' || saisieOuiNon == 'O');

        for (int i = 0; i < utilisateurs.Count; i++)
        {
            Console.WriteLine(utilisateurs[i]);
        }

        /*
        foreach (string personne in utilisateurs)
        {
            Console.WriteLine(personne);
        }
        *

    }
}

*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();  // to keep track of all the users we will add.
        bool addMoreUsers = true;

        while (addMoreUsers) // It continues to run as long as addMoreUsers is true.
        {
            // Demander le nom et le prénom de l'utilisateur // Ask the user to enter their fname and lname.
            Console.Write("Entrez le nom: ");
            string lastName = Console.ReadLine().ToUpper();
            Console.Write("Entrez le prénom: ");
            string firstName = Console.ReadLine().ToUpper();

            // Enregistrer l'utilisateur  || Create an new user object with the entered fname and lname and add it to the list.
            users.Add(new User { FirstName = firstName, LastName = lastName });

            // Demander si l'utilisateur souhaite ajouter une autre personne  || check if more users should be added, if type "oui" the loop continues, otherwise it stops
            Console.Write("Voulez-vous ajouter une autre personne? (oui/non): ");
            string response = Console.ReadLine().ToLower();
            addMoreUsers = response == "oui";
        }

        // Afficher tous les utilisateurs enregistrés || Displaying all users after the loop ends
        Console.WriteLine("\nUtilisateurs enregistrés:");
        foreach (var user in users)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName}");
        }
    }
}

class User  // user class defination; it has two properties, fname and lname to store the user's information.
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
