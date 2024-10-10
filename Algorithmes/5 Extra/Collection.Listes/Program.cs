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