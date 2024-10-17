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
    // { get; set; } This is shorthand for creating a property with a getter and setter.
    // A getter allows to read the value of the property
    // A setter allows to assign a value to the property
    public string Prenom { get; set; }
    public string Nom { get; set; }
    public DateTime DateDeNaissance { get; set; }
    public string InfoAdditional { get; set; }

    // This property calculates the age based on the birthdate.
    // The age property uses the method to calculate the user's age based on their birthdate.
    // Whenever we access the age property, it will call the "calculer_age" method and return the calculated age.
    // => This is known as the “expression-bodied member” syntax. It is similar to writing a method with a single return statement.
    public int Age => Calculer_Age(DateDeNaissance);


    // This method calculates the age based on the birthdate.
    private int Calculer_Age(DateTime dateDeNaissance)
    {
        // Calculate the initial age bye subtracting the birth year form the current year.
        int age = DateTime.Now.Year - dateDeNaissance.Year;

        // Checks If the current day of the year is before the birthday.
        // If it is, subtract 1 from the age because the person hasn't had their birthday yet this year.

        if (DateTime.Now.DayOfYear < dateDeNaissance.DayOfYear)
            age--;

        // Return the calculated age.
        return age;
    }

}

// This class contains the Main method, which is the entry point of the program.
class Program
{
    static void Main()
    {
        //Create a list to keep track of all the users that will be added.
        List<User> users = new List<User>();
        bool addMoreUsers = true; // This variable controls whether more users should be added.

        // Continue to run the loop as long as addMoreUsers is true.
        while (addMoreUsers)
        {
            // Ask the user to enter their lname and fname.
            Console.Write("Entrez le nom: ");
            string nom = Console.ReadLine().ToUpper();

            Console.Write("Entrez le prénom: ");
            string prenom = Console.ReadLine().ToUpper();

            // Ask the user to enter their date of birth.
            Console.Write("Entrez la date de naissance (yyyy-mm-dd) : ");
            DateTime dateDeNaissance = DateTime.Parse(Console.ReadLine());

            // Create a new user object with the entered information.            
            User user = new User { Prenom = prenom, Nom = nom, DateDeNaissance = dateDeNaissance };

            // Declare a variable to store additional information.
            string infoAdditional;

            // If the user's age is below 0, it is invalid.
            if (user.Age < 0)
            {
                Console.Write("Saisie non valide !");
                break;                
            }
            // Ask fo the user's favourite color if ther are a minor.
            else if(user.Age < 18)
            {
                Console.Write("Entrez votre couleur préférée : ");
                infoAdditional = Console.ReadLine().ToUpper();
            }
            // If the user is an adult, ask for their profession.
            else
            {
                Console.Write("Entrez votre métier : ");
                infoAdditional = Console.ReadLine().ToUpper();
            }

            // Assign the additional information to the user object.
            user.InfoAdditional = infoAdditional;

            // Add the user object to the list of users.
            users.Add(user);

            // Ask if the user wants to add another person.
            Console.Write("\nVoulez-vous ajouter une autre personne? (oui/non): ");
            string response = Console.ReadLine().ToLower();

            // If the reponse is "oui", continue the loop. Otherwise, stop the loop.
            addMoreUsers = response == "oui";
            Console.WriteLine();
        }

        // Display all registered users after the loop ends
        Console.WriteLine("\nUtilisateurs enregistrés: ");
        foreach (var user in users)
        {
            // Determine the type of additional information based on the user's age.
            String infoType = user.Age >= 18 ? "Métier" : "Couleur préférée";
            Console.WriteLine($"\n{user.Prenom} {user.Nom} - {user.DateDeNaissance.ToShortDateString()} ({user.Age} ans) - {infoType} :  {user.InfoAdditional}");
        }

        // Thank the user and end the program.
        Console.WriteLine("\nMerci d'avoir utilisé le programme!");
    }
}


