using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    // Voiture class
    public class Voiture
    {
        private string marque;
        private string modele;
        private Moteur sonMoteur;
        private Roue maRoueAvantGauche;
        private Roue maRoueAvantDroite;
        private Roue maRoueArriereGauche;
        private Roue maRoueArriereDroite;
        private Roue maRoueDeSecour;

        // Default constructor delegates to parameterized constructor
        public Voiture()
            : this("Toyota", "Corolla", "Diesel", false, "Michelin", false, 15) { }

        // Parameterized constructor
        public Voiture(string marque, string modele, string type, bool estDemarre, string marqueRoue, bool tourne, int tailleEnMM)
        {
            this.marque = marque;
            this.modele = modele;
            this.sonMoteur = new Moteur(type, estDemarre);
            this.maRoueAvantGauche = new Roue(tailleEnMM, tourne, marqueRoue);
            this.maRoueAvantDroite = new Roue(tailleEnMM, tourne, marqueRoue);
            this.maRoueArriereGauche = new Roue(tailleEnMM, tourne, marqueRoue);
            this.maRoueArriereDroite = new Roue(tailleEnMM, tourne, marqueRoue);
            this.maRoueDeSecour = null;
        }

        // Copy constructor delegates to parameterized constructor
        public Voiture(Voiture voitureACopier)
            : this(
                voitureACopier.marque,
                voitureACopier.modele,
                voitureACopier.sonMoteur.ToString(), // uses copy constructor internally
                voitureACopier.sonMoteur != null && voitureACopier.sonMoteur.DemarrerMoteur(),
                voitureACopier.maRoueAvantGauche != null ? voitureACopier.maRoueAvantGauche.ToString() : "Michelin",
                voitureACopier.maRoueAvantGauche?.Tourne ?? false,
                voitureACopier.maRoueAvantGauche != null ? 15 : 15
            )
        {
            this.sonMoteur = new Moteur(voitureACopier.sonMoteur);
            this.maRoueAvantGauche = new Roue(voitureACopier.maRoueAvantGauche);
            this.maRoueAvantDroite = new Roue(voitureACopier.maRoueAvantDroite);
            this.maRoueArriereGauche = new Roue(voitureACopier.maRoueArriereGauche);
            this.maRoueArriereDroite = new Roue(voitureACopier.maRoueArriereDroite);
            this.maRoueDeSecour = voitureACopier.maRoueDeSecour != null
                ? new Roue(voitureACopier.maRoueDeSecour)
                : null;
        }

        public void Demarrer() => sonMoteur.DemarrerMoteur();

        public void Arreter()
        {
            sonMoteur.ArreterMoteur();
            maRoueAvantGauche.ArreterTourner();
            maRoueAvantDroite.ArreterTourner();
            maRoueArriereGauche.ArreterTourner();
            maRoueArriereDroite.ArreterTourner();
        }

        public void Avancer()
        {
            if (sonMoteur.Entrainer2RouesMotrices(maRoueAvantGauche, maRoueAvantDroite))
            {
                maRoueArriereGauche.Tourner();
                maRoueArriereDroite.Tourner();
            }
        }

        public override string ToString()
        {
            return $"Voiture [Marque: {marque}, Modele: {modele}]\n" +
                   $"{sonMoteur}\n" +
                   $"Roue Avant Gauche: {maRoueAvantGauche}\n" +
                   $"Roue Avant Droite: {maRoueAvantDroite}\n" +
                   $"Roue Arrière Gauche: {maRoueArriereGauche}\n" +
                   $"Roue Arrière Droite: {maRoueArriereDroite}\n" +
                   $"Roue de Secours: {(maRoueDeSecour != null ? maRoueDeSecour.ToString() : "Aucune")}";
        }
    }
}
