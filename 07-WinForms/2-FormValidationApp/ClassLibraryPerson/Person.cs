

using System;

namespace ClassLibraryPerson
{
    public class Person
    {
        // Properties
        public string Nom { get; set; }
        public DateTime DateRDV { get; set; }
        public decimal Montant { get; set; }
        public string CodePostal { get; set; }

        // Constructor
        public Person(string nom, DateTime dateRDV, decimal montant, string codePostal )
        {
            Nom = nom;
            DateRDV = dateRDV;
            Montant = montant;
            CodePostal = codePostal;
        }


     

        // Return a formatted string summary of the person's details. 
        public string Resume()
        {
            return $"Nom : {Nom}\n" +
                   $"Date du rendez-vous :{DateRDV:dd/MM/yyyy}\n" +
                   $"Montant : {Montant:C}\n" +
                   $"Code Postal : {CodePostal}";
        }


        // Method to check if the appointment is in the future and within the next 7 days
        public bool EstRDVImminent()
        {
            return (DateRDV - DateTime.Today).Days <= 7 && DateRDV > DateTime.Today;
        }
    }
}
