using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDEvolution
    {
        public Oeuf()
        {
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas deplacer car je suis un oeuf");
        }

        public override StadeDEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
