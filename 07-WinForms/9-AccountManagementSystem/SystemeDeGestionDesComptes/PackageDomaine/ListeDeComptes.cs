using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDomaine
{
    public class ListeDeComptes : IDisposable
    {
        public List<Compte> SesComptes { get; private set; }

        public ListeDeComptes()
        {
            SesComptes = new List<Compte>();
        }

        public void AjouterCompte(Compte compte)
        {
            SesComptes.Add(compte);
            compte.SonPortefeuille = this;
        }

        public void Dispose()
        {
            foreach (var compte in SesComptes)
            {
                compte.SonPortefeuille = null;
            }
            SesComptes.Clear();
        }
    }
}
