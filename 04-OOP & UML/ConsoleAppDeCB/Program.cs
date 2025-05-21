using System;
using System.Runtime.CompilerServices;
using ClassLibraryDeCB;

class Program
{
    static void Main(string[] args)
    {
        Compte c1 = new Compte();
        Compte c2 = new Compte(12345, "Toto", 1000, -500);
        Compte c3 = new Compte(67890, "Titi", 2000, -1000);

        Console.WriteLine("----- Initial State || État initial -----");
        Console.WriteLine(c1.ToString());
        Console.WriteLine(c2.ToString());
        Console.WriteLine(c3.ToString());

        Console.WriteLine("\n----- After Deposit  || Après le dépôt  -----");
        c2.Crediter(100);
        Console.WriteLine(c2.ToString());

        Console.WriteLine("\n----- After Withdraw Attempt ||  Après une tentative de retrait -----");
        bool ok = c2.Debiter(1600);
        Console.WriteLine(ok ? "Débit réussi !" : "Débit échoué !");

        Console.WriteLine("\n----- After Transfer  ||  Après le transfert  -----");
        c2.Transferer(300, c3);
        Console.WriteLine(c2.ToString());
        Console.WriteLine(c3.ToString());

        Console.WriteLine("\n----- Balance Comparison  ||  Comparaison du solde  -----  ");
        Console.WriteLine(c2.Superieur(c3) ? "Supérieur !" : "Inférieur !");

    }
}