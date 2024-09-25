using System;

class ControlerLaSaisie
{
    static void Main()
    {
        string prenom = string.Empty;

        while (true)
        {
            Console.Write("Veuillez saisir votre prénom : ");
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
    }
}
