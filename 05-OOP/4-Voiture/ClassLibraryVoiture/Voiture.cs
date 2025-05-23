using ClassLibraryVoiture;
using System;
namespace ClassLibraryVoiture
{
    // Voiture Car Class
    public class Voiture
    {
        private string marque; // Car brand (e.g., Toyota)
        private string modele; // Car model (e.g., Corolla)
        private Moteur sonMoteur; // The car's engine
        private Roue maRoueAvantGauche; // Front left Wheel
        private Roue maRoueAvantDroite; // Front right Wheel
        private Roue maRoueArriereGauche; // Rear left Wheel
        private Roue maRoueArriereDroite;  // Rear Right Wheel
        private Roue? maRoueDeSecours; // Spare wheel (optional)

        // Default constructor delegates to parameterized constructor : Creates a Toyota Corolla with Diesel engine and Michelin wheels
        public Voiture() : this("Toyota", "Corolla", "Diesel",  "Michelin",  16.5) { }

        // Parameterized constructor: Creates a car with all specified properties
        public Voiture(string marque, string modele, string typeMoteur, string marqueRoue, double tailleEnPouces)
        :this(marque,
             modele, 
             new Moteur(typeMoteur, false), 
             new Roue(tailleEnPouces, false, marqueRoue), 
             new Roue(tailleEnPouces, false, marqueRoue), 
             new Roue(tailleEnPouces, false, marqueRoue), 
             new Roue(tailleEnPouces, false, marqueRoue),
             null)
        {}

        // Full constructor
        private Voiture(string marque, string modele, Moteur moteur, Roue maRoueAvantGauche, Roue maRoueAvantDroite,Roue maRoueArriereGauche,Roue maRoueArriereDroite,Roue? roueDeSecours)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
            this.modele = modele ?? throw new ArgumentNullException(nameof(modele));
            this.sonMoteur = moteur ?? throw new ArgumentNullException(nameof(moteur));
            this.maRoueAvantGauche = maRoueAvantGauche ?? throw new ArgumentNullException(nameof(maRoueAvantGauche));
            this.maRoueAvantDroite = maRoueAvantDroite ?? throw new ArgumentNullException(nameof(maRoueAvantDroite));
            this.maRoueArriereGauche = maRoueArriereGauche ?? throw new ArgumentNullException(nameof(maRoueArriereGauche));
            this.maRoueArriereDroite = maRoueArriereDroite ?? throw new ArgumentNullException(nameof(maRoueArriereDroite));
            this.maRoueDeSecours = roueDeSecours;
        }


        // Copy constructor delegates to parameterized constructor : Creates a copy of another car (creates a new car by coping an existing one)
        public Voiture(Voiture voitureACopier)
            : this(
                voitureACopier.marque,  
                voitureACopier.modele,  
                new Moteur(voitureACopier.sonMoteur),
                new Roue(voitureACopier.maRoueAvantGauche),
                new Roue(voitureACopier.maRoueAvantDroite),
                new Roue(voitureACopier.maRoueArriereGauche),
                new Roue(voitureACopier.maRoueArriereDroite),
                voitureACopier.maRoueDeSecours is Roue roue ? new Roue(roue) : null
            )
        {}


        // Demarrer(): Starts the car's engine
        public bool Demarrer() => sonMoteur.DemarrerMoteur();

        // Arreter(): Stops the engine and all wheels
        public bool Arreter()
        {
            bool moteurArrete = sonMoteur.ArreterMoteur();
            bool r1 = maRoueAvantGauche.ArreterTourner();
            bool r2 = maRoueAvantDroite.ArreterTourner();
            bool r3 = maRoueArriereGauche.ArreterTourner();
            bool r4 = maRoueArriereDroite.ArreterTourner();

            return moteurArrete && r1 && r2 && r3 && r4;
        }

        // Avancer() : Makes the car move forward(starts engine and spins wheels if conditions are met
        public bool Avancer()
        {
            bool rouesAvantTourne = sonMoteur.Entrainer2RouesMotrices(maRoueAvantGauche, maRoueAvantDroite);
            if (rouesAvantTourne)
            {
                bool r1 = maRoueArriereGauche.Tourner();
                bool r2 = maRoueArriereDroite.Tourner();
                return r1&&r2;
            }
            return false;
        }


        // AjouterRoueDeSecours(): Adds a spare wheel if none exists yet
        public bool AjouterRoueDeSecours(Roue roueDeSecoursAAjouter)
        {
            if (roueDeSecoursAAjouter == null)
                throw new ArgumentNullException(nameof(roueDeSecoursAAjouter));

            if (maRoueDeSecours == null)
            {
                maRoueDeSecours = roueDeSecoursAAjouter;
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return $"Voiture [Marque: {marque}, Modele: {modele}]\n" +  // Car Basic Info
                   $"{sonMoteur}\n" +                                   // Engine Info

                   // Wheel Info(Front & Rear Left / Right)
                   $"Roue Avant Gauche: {maRoueAvantGauche}\n" +
                   $"Roue Avant Droite: {maRoueAvantDroite}\n" +
                   $"Roue Arrière Gauche: {maRoueArriereGauche}\n" +
                   $"Roue Arrière Droite: {maRoueArriereDroite}\n" +

                   // Spare Wheel Check
                   $"Roue de Secours: {(maRoueDeSecours != null ? maRoueDeSecours.ToString() : "Aucune")}";
        }
    }
}


