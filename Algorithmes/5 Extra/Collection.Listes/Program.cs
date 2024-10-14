
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
            Console.Write("Saisissez votre prénom et nom : ");

            saisieNomPrenom = Console.ReadLine().ToUpper() ?? " ";

            utilisateurs.Add(saisieNomPrenom);

            Console.WriteLine("\nSouhaitez vous ajouter un autre utilisateur ? (N/O)");

            saisieOuiNon = Console.ReadKey(true).KeyChar;

        }
        while (saisieOuiNon == 'o' || saisieOuiNon == 'O');

        for (int i = 0; i < utilisateurs.Count; i++)
        {
            Console.WriteLine("\n" + utilisateurs[i]);
        }

        /*
        foreach (string personne in utilisateurs)
        {
            Console.WriteLine(personne);
        }
        */

    }
}





