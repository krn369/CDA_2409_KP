using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibraryDeCB
{
    // The 'Compte' class represents a bank account.
    // It implements IComparable to allow comparing two accounts based on their balance.
    public class Compte : IComparable
    {
        // Private fields (attributes)  to store account details
        private int numero;                                        // Account number (e.g., 12345)
        private string nom;                                        // Account holder's name (e.g., "John Cena")
        private decimal solde;                                     // Account balance (e.g., 1000.50)
        private decimal decouvertAutorise;                         // Overdraft limit (e.g., -200.00)

        // Public property to access solde (balance) : This is a read-only property that returns the balance(solde) of the account. The arrow ( => ) is a shorthand for a property that only has a getter. 
        public decimal Solde => solde;





        // ----------------- Constructor -----------------
        // The constructor is called when a new instance of the 'Compte' class is created.
        // It assigns values to the fields (attributes) of the object.
        public Compte(int numero, string nom, decimal solde, decimal decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom ?? throw new ArgumentException("Le nom du titulaire du compte est requis.", nameof(nom));   // // Ensure the account holder's name is not null
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
        }




        // ----------------- Methods -----------------




        // ToString() - Converts account details into a string representation. It is useful to print or display account information.
        public override string ToString()
        {
            return $"Numéro : {numero} | Nom : {nom} | Solde : {solde:C} | Découvert autorisé : {decouvertAutorise:C}";
            // The :C formats the solde (balance) and decouvertAutorise (overdraft) as currency (e.g., 1,000.50 €)
        }




        // Crediter() - Deposits money into the account. It allows depositing money into the account.
        public void Crediter(decimal montant)
        {
            // Ensure the deposit amount is positive
            if (montant <= 0) 
                throw new ArgumentException("Le montant du dépôt doit être positif.", nameof(montant));

            solde += montant;  // Increase the account balance by the deposit amount.
        }




        // Debiter() - Withdraws money from the account. It allows withdrawing money if the account has enough funds (including overdraft).
        public bool Debiter(decimal montant)
        {
            // Ensure the withdrawal amount is positive, If it is zero or negative, throw an error
            if (montant <= 0)       
                throw new ArgumentException("Le montant doit être positif", nameof(montant));

            // Check if the withdrawal will exceed the overdraft limit
            if (solde - montant < decouvertAutorise)
                throw new InvalidOperationException("Opération refusée : découvert insuffisant");

            solde -= montant;  // Decrease the account balance by the withdrawal amount
            return true;       // Return true if withdrawal was successful
        }




        // Transferer() - Transfers money from this account to another account
        public bool Transferer(decimal montant, Compte compteDestinataire)
        {
            // Ensure the transfer amount is positive
            if (montant <= 0) 
                throw new ArgumentException("Le montant doit être positif", nameof(montant));

            // Ensure the transfer amount is positive
            if (compteDestinataire == null)  
                throw new ArgumentNullException(nameof(compteDestinataire));

            try
            {
                // Attempt to withdraw money from the current account and credit it to the destination account
                if (Debiter(montant)) // Try to withdraw  from the current account
                {
                    compteDestinataire.Crediter(montant); // If the withdrawal is successful, it credits the amount to the recipient account
                    return true;  // Return true if the transfer was successful
                }
                return false;  // Return false if withdrawal failed
            }


            // If any error occurs(e.g., insufficient funds), it catches the exception and rethrows it with a specific message.
            catch (InvalidOperationException ex) 
            {
                throw new InvalidOperationException("Transfert échoué : solde insuffisant !", ex);
            }
        }



        // Superieur() - Compares this account's balance to another account's balance
        public bool Superieur(Compte autreCompte)
        {
            // Ensure the other account exists
            if (autreCompte == null) 
                throw new ArgumentNullException(nameof(autreCompte));

            return solde > autreCompte.solde;  // Return true if this account has more money
        }



        // CompareTo() -  This method is part of the IComparable interface and is used to compare two accounts for sorting purposes.

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;  // If the object is null, this account is considered greater


            // Ensure the object is of type 'Compte' (bank account) for comparison
            if (obj is Compte other)  
                return solde.CompareTo(other.solde);  // Compare the balances and returns a number: 
            // A negative value if the current account balance is less than the other account.
            // A positive value if the current account balance is greater than the other account.
            // Zero if both accounts have the same balance.

            throw new ArgumentException("L'objet n'est pas un Compte");  // If the object is not a 'Compte', throw an exception
        }
    }
}
