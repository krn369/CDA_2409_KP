using System;

class JeuDu02
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int joueurScore = 0;
        int ordiScore = 0;

        while (joueurScore < 10 && ordiScore < 10)
        {
            Console.Write("\nChoisissez un nombre (0, 1, 2) ou ( -1 ) pour arrêter : ");
            int joueurChoix;

            // This means the condition is true if the input is not a valid integer.
            if (!int.TryParse(Console.ReadLine(), out joueurChoix) || joueurChoix < -1 || joueurChoix > 2)
            {
                Console.WriteLine("Entrée invalide. Veuillez résessayer.");
                continue;
            }

            else if (joueurChoix < 0)
            {
                break;
            }

            int ordiChoix = random.Next(0, 3);
            Console.WriteLine($"L'ordinateur a choisi : {ordiChoix}");

            int difference = Math.Abs(joueurChoix - ordiChoix);

            if (difference == 2)
            {

                if (joueurChoix > ordiChoix)
                {
                    joueurScore++;
                }

                else
                {
                    ordiScore++;
                }
            }

            else if (difference == 1)
            {
                if (joueurChoix < ordiChoix)
                {
                    joueurScore++;
                }

                else
                {

                    ordiScore++;
                }
            }

            Console.WriteLine($"Score du joueur : {joueurScore}, Score de l'ordinateur : {ordiScore}");

        }

        Console.WriteLine("\nJeu terminé!");
        Console.WriteLine($"Score final - Joueur : {joueurScore}, Ordinateur : {ordiScore}");
    }
}