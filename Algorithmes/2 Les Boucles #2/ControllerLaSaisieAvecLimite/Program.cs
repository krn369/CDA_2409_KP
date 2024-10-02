/*
#Exercice 3a.2 : Contrôler la saisie avec limite

L’utilisateur est invité à saisir un mot de passe.

Si le mot de passe saisi est correct, le programme affiche “Vous êtes connecté”.

Dans le cas contraire, l’utilisateur doit recommencer la saisie.

L’utilisateur dispose de 3 essais maximum.

Au 3ème échec, le programme affiche “Votre compte est bloqué” et se termine.

Note : Le bon mot de passe est formation
 */



using System;

class ControllerLaSaisieAvecLimite
{
    static void Main()
    {
        const string BON_MOT_DE_PASSE = "formation";
        const int ESSAIS_MAX = 3;

        int compteur = 0;
        string motDePasse;

        while (compteur < ESSAIS_MAX)
        {
            Console.Write("Veuillez saisir votre mot de passe : ");
            motDePasse = Console.ReadLine();

            if (motDePasse == BON_MOT_DE_PASSE)
            {
                Console.WriteLine("Vous êtes connecté");
                return;
            }
            else
            {
                compteur++;
                Console.WriteLine("Mot de passe incorrect. Veuillez réessayer.");
            }
        }

        Console.WriteLine("Votre compte est bloqué");
    }
}
