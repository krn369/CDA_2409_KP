using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using PackageDomaine;

namespace PackageInterDomainePersistance
{
    public interface IPersistenceCompte
    {
        void Update(Compte compte);
        void Create(Compte compte);
        void Delete(Compte compte);
        structCompte  Select(int num);
    }
}

