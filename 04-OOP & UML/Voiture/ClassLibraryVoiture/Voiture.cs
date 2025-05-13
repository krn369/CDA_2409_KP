using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        private Roue maRoueDeSecour; // Spare wheel (optional)


        // Default constructor delegates to parameterized constructor : Creates a Toyota Corolla with Diesel engine and Michelin wheels
        public Voiture() : this("Toyota", "Corolla", "Diesel", false, "Michelin", false, 585) { }

        // Parameterized constructor: Creates a car with all specified properties
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

        // Copy constructor delegates to parameterized constructor : Creates a copy of another car (creates a new car by coping an existing one)
        public Voiture(Voiture voitureACopier)
            // First call the parameterized constructor with values from the car we're copying
            : this(
                voitureACopier.marque,
                voitureACopier.modele,
                voitureACopier.sonMoteur.ToString(), // Get engine type as string
                voitureACopier.sonMoteur != null && voitureACopier.sonMoteur.DemarrerMoteur(),  // Check if engine exists and get its running status
                voitureACopier.maRoueAvantGauche != null ? voitureACopier.maRoueAvantGauche.ToString() : "Michelin", // // Get front left wheel brand (or "Michelin" if wheel is null)
                voitureACopier.maRoueAvantGauche?.Tourne ?? false, // Get front left wheel spin status (default to false if wheel is null)
                voitureACopier.maRoueAvantGauche != null ? 585 : 585 // Get wheel size (default to 585mm if wheel is null)
            )
        {
            // Now make DEEP COPIES of all components (so changes to the copy don't affect original)

            // Copy the engine (creates a brand new Moteur object)
            this.sonMoteur = new Moteur(voitureACopier.sonMoteur);

            // Copy all four wheels (create new Roue objects for each)
            this.maRoueAvantGauche = new Roue(voitureACopier.maRoueAvantGauche);
            this.maRoueAvantDroite = new Roue(voitureACopier.maRoueAvantDroite);
            this.maRoueArriereGauche = new Roue(voitureACopier.maRoueArriereGauche);
            this.maRoueArriereDroite = new Roue(voitureACopier.maRoueArriereDroite);

            // Copy spare wheel if it exists (otherwise set to null)
            this.maRoueDeSecour = voitureACopier.maRoueDeSecour != null
                ? new Roue(voitureACopier.maRoueDeSecour)
                : null;
        }

        // Demarrer(): Starts the car's engine
        public void Demarrer() => sonMoteur.DemarrerMoteur();

        // Arreter(): Stops the engine and all wheels
        public void Arreter()
        {
            sonMoteur.ArreterMoteur();
            maRoueAvantGauche.ArreterTourner();
            maRoueAvantDroite.ArreterTourner();
            maRoueArriereGauche.ArreterTourner();
            maRoueArriereDroite.ArreterTourner();
        }

        // Avancer() : Makes the car move forward(starts engine and spins wheels if conditions are met)
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
            return $"Voiture [Marque: {marque}, Modele: {modele}]\n" +  // Car Basic Info
                   $"{sonMoteur}\n" +                                   // Engine Info

                   // Wheel Info(Front / Rear Left / Right)
                   $"Roue Avant Gauche: {maRoueAvantGauche}\n" +        
                   $"Roue Avant Droite: {maRoueAvantDroite}\n" +
                   $"Roue Arrière Gauche: {maRoueArriereGauche}\n" +
                   $"Roue Arrière Droite: {maRoueArriereDroite}\n" +

                   // Spare Wheel Check
                   $"Roue de Secours: {(maRoueDeSecour != null ? maRoueDeSecour.ToString() : "Aucune")}";  
        }
    }
}
