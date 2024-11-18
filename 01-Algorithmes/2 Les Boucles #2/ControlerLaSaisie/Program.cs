using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

class ControlerLaSaisie
{
    static void Main()
    {
        try 
        {
            string? prenom;
            Console.WriteLine("Bonjour, Entrer votre prénom : ");
            prenom = Console.ReadLine();

            String formatPrenom = @"^[a-zA-Z]{2,32}$";

            while(!Regex.IsMatch(prenom, formatPrenom /* , RegexOptions.IgnoreCase*/))
            {
                Console.WriteLine("Saissez un vrai prénom!");
                prenom = Console.ReadLine();
            }

            Console.WriteLine("Bonjour " + prenom + " !");
        }

        catch (Exception ex) 
        {
            Console.WriteLine("Contactez le service informatique !");
        }

        


      /*  
            while (true)
        {
            Console.Write("Saisissez votre prénom : ");
            prenom = Console.ReadLine();

            if (prenom.Length >= 2)
            {
                Console.WriteLine($"Bonjour {prenom} !");
                break;
            }
            else
            {
                Console.WriteLine("Le prénom doit contenir au moins 2 caractères. Veuillez réessayer.");
            }
        }
      */
    }
}
