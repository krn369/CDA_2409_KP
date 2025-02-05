namespace BouteilleNamespace
{
    public class Bouteille
    {
        // Attributes
        private float contenanceEnL; // How much liquid it can hold (liters)
        private bool ouvert; // Whether the lid is on or off (true for open, false for closed)
        public float contenuEnL; // How much liquid is in it now (liters)
        public string typeDeContenu; // What kind of drink is in it (water, juice, etc.)

        // Constructor with no arguments: Makes a regular bottle
        public Bouteille()
        {
            this.contenanceEnL = 1;
            this.contenuEnL = 1;
            this.ouvert = false;
            this.typeDeContenu = "H2O";
        }

        // Constructor with arguments: Lets you define specific properties
        public Bouteille(float contenanceEnL, float contenuEnL, bool ouvert, string typeDeContenu)
        {
            this.contenanceEnL = contenanceEnL;
            this.contenuEnL = contenuEnL;
            this.ouvert = ouvert;
            this.typeDeContenu = typeDeContenu;
        }

        // Copy constructor: Makes a new bottle exactly like another
        public Bouteille(Bouteille bouteilleARecopier)
        {
            this.contenanceEnL = bouteilleARecopier.contenanceEnL;
            this.contenuEnL = bouteilleARecopier.contenuEnL;
            this.ouvert = bouteilleARecopier.ouvert;
            this.typeDeContenu = bouteilleARecopier.typeDeContenu;
        }

        // Methods
        public float DonneContenanceEnCL()
        {
            return this.contenanceEnL * 100;
        }

        public bool EstPlein()
        {
            return this.contenuEnL == this.contenanceEnL;
        }

        public bool Fermer()
        {
            if (this.ouvert)
            {
                this.ouvert = false;
            }
            return !this.ouvert;
        }

        public bool Ouvrir()
        {
            if (!this.ouvert)
            {
                this.ouvert = true;
            }
            return this.ouvert;
        }

        public bool Remplir(float quantite)
        {
            if (this.ouvert && this.contenanceEnL - this.contenuEnL >= quantite)
            {
                this.contenuEnL += quantite;
                return true;
            }
            return false;
        }

        public bool Vider(float quantite)
        {
            if (this.ouvert && this.contenuEnL >= quantite)
            {
                this.contenuEnL -= quantite;
                return true;
            }
            return false;
        }

        public bool RemplirComplet()
        {
            if (this.ouvert && this.contenuEnL != this.contenanceEnL)
            {
                this.contenuEnL = this.contenanceEnL;
                return true;
            }
            return false;
        }

        public bool ViderComplet()
        {
            if (this.ouvert && this.contenuEnL != 0)
            {
                this.contenuEnL = 0;
                return true;
            }
            return false;
        }
    }
}
