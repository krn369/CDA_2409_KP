/*
 Implémenter le programme suivant : 

Au démarrage, il n'y a aucun utilisateur enregistré.

## Déroulement du programme

1. Le programme demande à l'utilisateur de saisir un nom et un prénom.
      - L’utilisateur saisit un nom et un prénom.

2. Le programme demande à l'utilisateur de saisir la date de naissance.
      - L'utilisateur saisit la date de naissance.

3. Le programme calcule l'âge de la personne en cours d'ajout.
      - Si l’âge est supérieur ou égal à 18 (majeur)
            - Le programme demande à l'utilisateur de saisir son métier.
      - Si l’âge est inférieur à 18 (mineur)
            - Le programme demande à l'utilisateur de saisir sa couleur préférée.

4. Lorsque toutes les informations sont saisies
      - Le programme enregistre l'utilisateur

5. Le programme demande à l'utilisateur s'il souhaite ajouter une autre personne.
      - Si oui
            - Retour à l'étape 1 (saisir nom et prénom)
      - Si non
            - Afficher tous les utilisateurs enregistrés en respectant ce format :
            - Nom Prénom - Date de naissance (âge) - Métier/Couleur préférée

6. Le programme remercie l'utilisateur et se termine



 This program allows users to enter their personal information, including their name, date of birth and either their profession or favourite color,
 depending on their age. It then stores this information and displays it at the end.
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


// The USER class is a blueprint for creating user objects. Each user has a fname, lname, birthdate and additional information (profession or favourite color)
class User
{
    // { get; set; } This is shorthand for creating a property with a getter and setter. A getter allows to read the value of the property
    // a setter allows to assign a value to the property
    public string Prenom { get; set; }
    public string Nom { get; set; }
    public DateTime DateDeNaissance { get; set; }
    public string InfoAdditional { get; set; }
    public int Age => Calculer_Age(DateDeNaissance);


    // This method is used within the USER class to ensure the age is calculated correctly.
    private int Calculer_Age(DateTime dateDeNaissance)
    {
        int age = DateTime.Now.Year - dateDeNaissance.Year;

 // Checks If the current day of the year is before the birthday, it means the person hasn’t had their birthday yet this year, so subtract 1 from the age.
       
        if (DateTime.Now.DayOfYear < dateDeNaissance.DayOfYear)
            age--;
        return age;
    }

}

// This class contains the Main method, which is the entry point of the program.
class Program
{
    static void Main()
    {
        List<User> users = new List<User>();  // To keep track of all the users which will be added.
        bool addMoreUsers = true;

        while (addMoreUsers) // It continues to run as long as addMoreUsers is true.
        {
            // Demander le nom et le prénom de l'utilisateur || Ask the user to enter their fname and lname.
            Console.Write("Entrez le nom: ");
            string nom = Console.ReadLine().ToUpper();
            Console.Write("Entrez le prénom: ");
            string prenom = Console.ReadLine().ToUpper();

            // Ask the user to enter their date of birth.
            Console.Write("Entrez la date de naissance (yyyy-mm-dd) : ");
            DateTime dateDeNaissance = DateTime.Parse(Console.ReadLine());

            // Enregistrer l'utilisateur  || Create an new user object with the entered information and add it to the list.
            string infoAdditional;
            User user = new User { Prenom = prenom, Nom = nom, DateDeNaissance = dateDeNaissance };

            if (user.Age >= 18)
            {
                // Ask for the user's profession if they are an adult.
                Console.Write("Entrez votre métier : ");
                infoAdditional = Console.ReadLine().ToUpper();
            }
            else
            {
                // Ask fo the user's favourite color if ther are a minor.
                Console.Write("Entrez votre couleur préférée : ");
                infoAdditional = Console.ReadLine().ToUpper();
            }

            user.InfoAdditional = infoAdditional;
            users.Add(user);


            // Demander si l'utilisateur souhaite ajouter une autre personne  || check if more users should be added, if type "oui" the loop continues, otherwise it stops
            Console.Write("\nVoulez-vous ajouter une autre personne? (oui/non): ");
            string response = Console.ReadLine().ToLower();
            addMoreUsers = response == "oui";
            Console.WriteLine();
        }

        // Afficher tous les utilisateurs enregistrés || Displaying all registered users after the loop ends
        Console.WriteLine("\nUtilisateurs enregistrés: ");
        foreach (var user in users)
        {
            String infoType = user.Age >= 18 ? "Métier" : "Couleur préférée";
            Console.WriteLine($"\n{user.Prenom} {user.Nom} - {user.DateDeNaissance.ToShortDateString()} ({user.Age} ans) - {infoType} :  {user.InfoAdditional}");
        }

        // Thank the user and end the program.
        Console.WriteLine("\nMerci d'avoir utilisé le programme!");
    }
}


