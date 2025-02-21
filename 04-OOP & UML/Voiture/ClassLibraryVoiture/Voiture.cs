using System;

namespace ClassLibraryVoiture
{
    public class Voiture
    {
        private List<Roue> roues;
        private bool avance;
        private bool demarre;
        private string modele;
        private Moteur moteur;


        public Voiture(string _modele, Moteur _moteur, List<Roue> _roues)
        {
            this.modele = _modele;
            this.moteur = _moteur;
            this.roues = _roues;
            this.avance = false;
            this.demarre = false;
        }

     

        public void Demarrer()
        {
            if (!demarre)
            {
                demarre = true;
                Console.WriteLine("La voitrue démarre.");
            }
        }

        public void Arreter()
        {
            if (demarre)
            {
                demarre = false;
                avance = false;
                Console.WriteLine("La voiture s'arrête.");
            }
        }

        public void Avancer()
        {
            if (demarre && !avance)
            {
                avance = true;
                Console.WriteLine("La voiture avance");
            }
        }

        //public void AjouterRoue(Roue roue)
        //{
        //    if (roues.Count < 4)
        //    {
        //        roues.Add(roue);
        //        Console.WriteLine("Roue ajoutée.");
        //    }
        //}


    }


}
