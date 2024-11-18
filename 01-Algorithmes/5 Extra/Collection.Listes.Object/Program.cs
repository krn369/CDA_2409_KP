using Collection.Listes.Object;
using System;

internal class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enregistrement d'utilisateurs (gestion avec Objet Métier).");

        //Variable
        string saisieNomPrenom;
        string saisieDate;
        string? metierCouleur = null;
        ConsoleKey continuerO_N;
        List<Utilisateur> utilisateurs = new();

        //Traitement
        do
        {

            try
            {
                Console.WriteLine("\nSaisissez le nom et Prénom.");
                saisieNomPrenom = Console.ReadLine().ToUpper();

                Console.WriteLine("\nSaisissez la date de naissane, jour/mois/année.");
                saisieDate = Console.ReadLine();

                Utilisateur unUtilisateur = new Utilisateur(saisieNomPrenom, saisieDate);

                if (unUtilisateur.IsMajeur())
                {
                    Console.WriteLine("\nVotre metier ?");
                    metierCouleur = Console.ReadLine();
                    unUtilisateur.SetMetier(metierCouleur);
                }
                else
                {
                    Console.WriteLine("\ncouleur préféré ?");
                    metierCouleur = Console.ReadLine();
                    unUtilisateur.SetCouleurPreferee(metierCouleur);
                }


                utilisateurs.Add(unUtilisateur);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nVoulez vous saisir un autre utilisateur : N/O ?");

            continuerO_N = Console.ReadKey(true).Key;
        }
        while (continuerO_N == ConsoleKey.O);


        // Affichage de la liste des utilisateurs

        // List<Utilisateur]> utilisateurs = new();
        foreach (Utilisateur utilisateur in utilisateurs)
        {
            Console.Write("\nNom et Prénom : " + utilisateur.GetNomComplet() + " - ");

            Console.Write(
                "Date de naissance (âge): " +
                utilisateur.GetDateDeNaissance() +
                " (" + utilisateur.GetAge() + ") - "
                );

            Console.WriteLine(utilisateur.GetCouleurOuMetier());


        }




        /*List<Utilisateur> resultat = utilisateurs.FindAll(u => u.IsMajeur() && u.GetDateDeNaissance() == DateTime.Now.ToShortDateString());

        foreach (Utilisateur u in utilisateurs)
        {
            if(u.IsMajeur() && u.GetDateDeNaissance() == DateTime.Now.ToShortDateString())
            {
                resultat.Add(u);
            }
        }*/

    }
}
