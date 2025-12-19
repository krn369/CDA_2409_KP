namespace PackageDomaine
{
    public class Compte
    {
        public int Num { get; set; }
        public float DecouvertAutorise { get; set; }
        public float Solde { get; set; }
        public ListeDeComptes SonPortefeuille { get; internal set; }

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
