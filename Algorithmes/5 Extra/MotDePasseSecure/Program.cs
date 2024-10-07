
/*
L'utilisateur entre un mot de passe
Le programme contrôle si le mot de passe respecte les règles en vigueur
- 12 caractères minimum
    ET Au moins 1 minuscule
    ET Au moins 1 majuscule
    ET Au moins 1 chiffre
    ET Au moins 1 caractère spécial
OU
- 20 caractères minimum
    ET Au moins 1 minuscule
    ET Au moins 1 majuscule
    ET Au moins 1 chiffre
*/

using System;
using System.Text.RegularExpressions;  // This line imports the REGEX library, which allows us to use regular expressions for pattern matching.

//Déclaration des Variables.
// These lines declare variables to store the password and the regular expression for different character types.

string motDePasse;
string regexMinuscules;
string regexMajuscules;
string regexChiffres;
string regexCaracteresSpeciaux;


// Display a message asking the user to enter a password and then reads the input. If the input is null, it assigns an empty string to motDePasse.

Console.WriteLine("Saisissez un mot de passe : ");
motDePasse = Console.ReadLine() ?? "";


// These lines define the regular expressions to match : Lowercase letters, Uppercase letters, Digits and Special Characters respectively.

regexMinuscules = "[a-z]{1,}";  // {1,} = 1 ou plusieurs

regexMajuscules = "[A-Z]+"; // + = 1 ou plusieurs 

regexChiffres = "[0-9]+";

regexCaracteresSpeciaux = "[^a-zA-Z0-9]+";


/*
 Checking Password Validity
This "if" statement checks if the password meets the following criteria:
- Contains at least one lowercase letter AND
- Contains at least one uppercase letter AND
- Contains at least one digit AND
- [Contains at least one special character OR Is at least 20 characters long] AND
- Contains at least 12 characters long

If all these conditions are met, it prints "Password OK" otherwise it prints "Password too weak!"
 */

if (
    Regex.IsMatch(motDePasse, regexMinuscules) &&
    Regex.IsMatch(motDePasse, regexMajuscules) &&
    Regex.IsMatch(motDePasse, regexChiffres) &&
    (Regex.IsMatch(motDePasse, regexCaracteresSpeciaux) || motDePasse.Length >= 20) &&
    motDePasse.Length >= 12

    )
{
    Console.WriteLine("Mot de passe OK");
}

else
{
    Console.WriteLine("Mot de passe trop faible !");
}



/*
 #SUMMARY 
  This program ensures that the password entered by the user is strong by checking for a mix of character types and minimum length. if the password meets all the criteria
    it is considered strong; otherwise, it is deemed to weak.
 */