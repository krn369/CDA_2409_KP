using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Chrysalide : StadeDEvolution
    {
        public Chrysalide()
        {
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas car je suis un Chrysalide");
        }

        public override StadeDEvolution SeMetamorphoser()
        {
            return new Papillon();
        }

    }
}
