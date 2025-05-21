namespace ClassLibraryDeCB
{
    public class Compte
    {
        // Fields (--------------  Attributes  ------------------------) for storing account details
        private int numero;
        private string nom;
        private int solde;
        private int decouvertAutorise;

        // ----------------  Constructors --------------------------------

        // (Initialization) using Constructor Chaining i.e. One constructor calls another to avoid code duplication, We use [ this() ] for constructor chaining.
        // Default constructor -> Calls parameterized constructor with defaults
        public Compte () : this(0,"", 0, 0) 
        {
            // No need for extra code; Everything is handled by the parameterized constructor
        }

        // Main parameterized constructor (does all the work) : Takes inputs and assigns them to the fields
        public Compte(int _numero, string _nom, int _solde, int _decouvertAutorise)
        {
            this.numero = _numero;
            this.nom = _nom;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        // ---------------------------------  Methods  -----------------------------
        
        // ______  ToString()  _________ : Display Account Info
        // This method returns a formatted string with all account details
        public override string ToString()
        {
            return $"Numéro : {numero} | Nom : {nom} | Solde : {solde} | Découvert autorisé : {decouvertAutorise}";
        }

        // ______  Crediter()  ___________   
        // Deposit Money: Adds money to the account balance
        public void Crediter(int montant)
        {
            if (montant > 0)
            {
                solde += montant;
            }
            else
            {
                Console.WriteLine("Montant invalide !");
            }
        }

        // ______  Debiter()  ___________
        // Withdraw Money: Subtracts money form the balance if allowed (checks overdraft limit). Returns true if successful, false if failed
        public bool Debiter(int montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide !");
                return false;
            }

            else if (solde - montant >= decouvertAutorise)
            {
                solde -= montant;
                return true;
            }

            else
            {
                Console.WriteLine( "Débit refusé : solde insuffisant !");
                return false;
            }
        }

        // _____ Transferer() _______
        // Transfers money if the sender has enough funds.

        public bool Transferer(int montant, Compte compteDestinataire)
        {
            if (montant <= 0)
            { 
                Console.WriteLine( "Montant invalide !");
                return false;
            }
            else if (Debiter(montant)) // If withdrawal succeeds
            {
                compteDestinataire.Crediter(montant);  // Deposit into recipient
                return true;
            }
            else
            {
                Console.WriteLine( "Transfert échoué : solde insuffisant !");
                return false;
            }
        }


        // __________  Superieur() _____________
        // Checks if the current account has a higher balance than another.

        public bool Superieur (Compte autreCompte)
        {
            return solde > autreCompte.solde;
        }


    }
}
