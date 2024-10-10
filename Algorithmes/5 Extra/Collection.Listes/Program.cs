
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

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enregistrement de nouveaux utilisateurs");

        string[] utilisateurs;

        string saisieNomPrenom;

        char saisieOuiNon;

        string[] tabTempo;

        utilisateurs = new string[1] { "Karan Pariyar" };

        do
        {
            Console.WriteLine("Saisissez votre prénom et nom :");

            saisieNomPrenom = Console.ReadLine()?? " ";

            tabTempo = utilisateurs;

            utilisateurs = new string[utilisateurs.Length + 1];

            tabTempo.CopyTo(utilisateurs, 0);

            utilisateurs[utilisateurs.Length - 1] = saisieNomPrenom;

            Console.WriteLine("Souhaitez vous ajouter un autre utilisateur ? (N/0)");

            saisieOuiNon = Console.ReadKey().KeyChar;

        }
        while (saisieOuiNon == 'o'  || saisieOuiNon == 'O');
    }
}