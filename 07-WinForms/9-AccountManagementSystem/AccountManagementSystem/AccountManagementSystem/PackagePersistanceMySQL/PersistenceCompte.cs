using AccountManagementSystem.PackageDomaine;
using AccountManagementSystem.PackageInterDomainePersistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem.PackagePersistanceMySQL
{
    public class PersistenceCompte : IPersistenceCompte
    {
        public void Update(Compte compte)
        {
            Console.WriteLine($"SQL Server: Mise à jour du compte {compte.Num}.");
        }

        public void Create(Compte compte)
        {
            Console.WriteLine($"SQL Server: Création du compte {compte.Num}.");
        }

        public void Delete(Compte compte)
        {
            Console.WriteLine($"SQL Server: Suppression du compte {compte.Num}.");
        }

        public Compte Select(int num)
        {
            Console.WriteLine($"SQL Server: Sélection du compte {num}.");
            return new Compte { Num = num, Solde = 1000, DecouvertAutorise = 500 };
        }
    }
}


