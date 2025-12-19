using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem.PackageDomaine
{
    public class Compte
    {
        public int Num { get; set; }
        public float DecouvertAutorise { get; set; }
        public float Solde { get; set; }

        public ListeDeComptes SonPortefeuille { get; set; }

        public void Sauvegarder()
        {
            Console.WriteLine($"Le compte {Num} a été sauvegardé avec un solde de {Solde}.");
        }

        public void Charger()
        {
            Console.WriteLine($"Le compte {Num} a été chargé avec un solde de {Solde}.");
        }
    }
}
