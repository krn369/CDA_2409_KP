using ClassLibraryVoiture;
using System;

class MyApp
{
    static void Main(string[] args)
    {
     
        Moteur moteur = new Moteur("Essence");

        List<Roue> roues = new List<Roue>();
        roues.Add(new Roue("18 pouces", "Michelin"));
        roues.Add(new Roue("18 pouces", "Continental"));
        roues.Add(new Roue("18 pouces", "Hancock"));
        roues.Add(new Roue("18 pouces", "Dunlop"));

        Voiture krn = new Voiture("Tesla E", moteur, roues);

        krn.Demarrer();
        krn.Avancer();
        krn.Arreter();

    }
}
