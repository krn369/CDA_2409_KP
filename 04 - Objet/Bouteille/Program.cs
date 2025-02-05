
using System;
using BouteilleNamespace;

namespace BouteilleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Coca bottle
            Bouteille coca = new Bouteille(1.5f, 1.0f, false, "Coca");
            Console.WriteLine($"Bouteille de Coca créée avec {coca.contenuEnL}L de {coca.typeDeContenu}");

            // Open the Coca bottle and fill it completely
            coca.Ouvrir();
            coca.RemplirComplet();
            Console.WriteLine($"La bouteille de Coca est maintenant remplie à {coca.contenuEnL}L");

            // Create a H2O bottle
            Bouteille h2o = new Bouteille();
            Console.WriteLine($"Bouteille H2O créée avec {h2o.contenuEnL}L de {h2o.typeDeContenu}");

            // Open the H2O bottle and empty it completely
            h2o.Ouvrir();
            h2o.ViderComplet();
            Console.WriteLine($"La bouteille H2O est maintenant vidée {h2o.contenuEnL}L");

            // Create a wine bottle
            Bouteille wine = new Bouteille(0.75f, 0.75f, true, "Wine");
            Console.WriteLine($"Bouteille de vin créée avec {wine.contenuEnL}L de {wine.typeDeContenu}");

            // Empty some wine from the bottle
            wine.Vider(0.25f);
            Console.WriteLine($"La bouteille de vin contient désormais {wine.DonneContenanceEnCL()}CL après avoir versé 25 CL");
        }
    }
}
