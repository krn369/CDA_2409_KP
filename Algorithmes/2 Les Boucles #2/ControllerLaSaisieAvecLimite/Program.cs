using System;

class ControllerLaSaisieAvecLimite
{
    static void Main()
    {
        const string correctPassword = "formation";
        int attempts = 0;
        const int maxAttempts = 3;

        while (attempts < maxAttempts)
        {
            Console.Write("Veuillez saisir votre mot de passe : ");
            string password = Console.ReadLine();

            if (password == correctPassword)
            {
                Console.WriteLine("Vous êtes connecté");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine("Mot de passe incorrect. Veuillez réessayer.");
            }
        }

        Console.WriteLine("Votre compte est bloqué");
    }
}
