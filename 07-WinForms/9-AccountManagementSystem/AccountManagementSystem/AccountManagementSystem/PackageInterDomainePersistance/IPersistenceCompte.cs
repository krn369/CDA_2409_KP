using AccountManagementSystem.PackageDomaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem.PackageInterDomainePersistance
{
    public interface IPersistenceCompte
    {
        void Update(Compte compte);
        void Create(Compte compte);
        void Delete(Compte compte);
        Compte Select(int num);
    }
}
