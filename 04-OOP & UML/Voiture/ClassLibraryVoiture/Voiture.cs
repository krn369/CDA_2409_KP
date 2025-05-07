using System;

namespace ClassLibraryVoiture
{
    // Voiture class represents a car
    public class Voiture
    {
        // Fields
        private string marque; // Brand of the car
        private string modele; // Model of the car
        private Moteur moteur; // The car's engine
        private Roue maRoueAvantGauche; // Front left wheel
        private Roue maRoueAvantDroite; // Front right wheel
        private Roue maRoueArriereGauche; // Rear left wheel
        private Roue maRoueArriereDroite; // Rear right wheel
        private Roue maRoueDeSecours; // Spare wheel
    }

    // Constructors
    public Voiture()
    {
        // Default constructor
        this.marque = "";
        this.modele = "";
        this.moteur = new Moteur();
        this.maRoueAvantGauche = new Roue();
        this.maRoueAvantDroite = new Roue();
        this.maRoueArriereGauche = new Roue();
        this.maRoueArriereDroite = new Roue();
        this.maRoueDeSecours = new Roue();

    }


}
