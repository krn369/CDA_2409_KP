
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

/*
   Console.WriteLine("Enregistrement d'utilisateurs (gestion avec Listes).");

        //Variable
        DateTime ajd = DateTime.Now;
        int age = 0;
        string saisieNomPrenom;
        string saisieDate;
        string? metierCouleur = null;
        ConsoleKey continuerO_N;
        List<string[]> utilisateurs = new();

        //Traitement
        do
        {
            Console.WriteLine("Saisissez le nom et Prénom.");
            saisieNomPrenom = Console.ReadLine();

            Console.WriteLine("Saisissez la date de naissane, jour/mois/année.");
            saisieDate = Console.ReadLine();

            if (DateTime.TryParse(saisieDate, out DateTime formaDate))
            {
                TimeSpan intervalle = ajd - formaDate;
                age = (int)(intervalle.Days / 365.25);
            }

            if (age < 0)
            {
                Console.WriteLine("Saisie non valide.");
            }
            else if (age < 18)
            {
                Console.WriteLine("couleur préférée ?");
                metierCouleur = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Votre metier ?");
                metierCouleur = Console.ReadLine();
            }

            string[] unUtilisateur = [saisieNomPrenom, saisieDate, age.ToString(), metierCouleur];

            utilisateurs.Add(unUtilisateur);

            Console.WriteLine("Voulez vous saisir un autre utilisateur : N/O ?");
            continuerO_N = Console.ReadKey(true).Key;
        }
        while (continuerO_N == ConsoleKey.O);

        // Affichage de la liste des utilisateurs

        // List<string[]> utilisateurs = new();
        foreach (string[] utilisateur in utilisateurs)
        {
            Console.Write("Nom et Prénom: " + utilisateur[0] + " - ");
            Console.Write("Date de naissance (âge) : " + utilisateur[1] + "(" + utilisateur[2] + ")");

            if (int.Parse(utilisateur[2]) < 18)
            {
                Console.WriteLine(" Couleur: " + utilisateur[3]);
            }
            else
            {
                Console.WriteLine(" Métier: " + utilisateur[3]);
            }

        }

 */




