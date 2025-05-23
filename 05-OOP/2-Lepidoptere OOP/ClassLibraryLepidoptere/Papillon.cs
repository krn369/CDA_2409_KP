using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Papillon : StadeDEvolution
    {
        public Papillon()
        {
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole car je suis un Papillon");
        }

        public override StadeDEvolution SeMetamorphoser()
        {
            return this;
        }

    }
}
