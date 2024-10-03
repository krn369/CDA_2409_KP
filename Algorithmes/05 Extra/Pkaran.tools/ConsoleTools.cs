
//  Namespace is a way to organise your code and avoid naming conflicts.
using System.Threading.Channels;

namespace KpariyarTools 

{   // This means it can be accessed from other parts of the program.
    public class ConsoleTools
    {       
        public static int DemanderNombreEntier(string _question) // This declares a public static method DME that returns an integer. It takes a single parameter Q of typ sting
        // This method prompts the user with a question, reads the input and keep asking until a valid int is entered. it then returns that integer

        
        {
            string saisieUtilisateur; // Declared string to store the user's input.

            int valeurRetour; // Declared an interger to store the parsed integer value.

            bool saisieOK;  // Declared boolean to indicate whether the input was successfully parsed  as an integer.


            // This is a do-while loop that repeatedly asks the user for input until a valid integer is entered.
            do
            {
                Console.WriteLine(_question); // Displays the question to the user.

                saisieUtilisateur = Console.ReadLine() ?? "";   //Reads the user’s input from the console. If the input is null, it assigns an empty string to saisieUtilisateur.

                saisieOK = int.TryParse(saisieUtilisateur, out valeurRetour); // Attempts to parse the input string to an integer. If successful, saisieOK is set to true and valeurRetour contains the parsed integer. If not, saisieOK is set to false.

                if (!saisieOK)
                {
                    Console.WriteLine("Saisie invalide, Recommencez !\n"); // If the input is not a valid integer, it displays an error message and prompts the user to try again.
                }
            }
            while (!saisieOK);
            return valeurRetour; // Returns the parsed integer value to the caller.

            /*
            
            do
            {

                Console.WriteLine(_question); // Displays the question to the user.
                saisieUtilisateur = Console.ReadLine() ?? "";   // Reads the user input from the console. If the input is NULL, it assigns an empty string.


                // Attempts to parse the input string to an integer. if the input is not a valid integer, this line will throw an exception.
                valeurRetour = int.TryParse(saisieUtilisateur); 

               
            }
            // This condition checks if the input can be parsed to an interger, if it can't, the loop continues.
            while (!int.TryParse(saisieUtilisateur, out valeurRetour)); 

            return valeurRetour;  // Returns the parsed integer value to the caller.

            */
        }






        public static float DemanderFloatPositif(string _question)
        {
            string saisieUtilisateur;
            float valeurRetour;
            bool saisieOK;

            do
            {
                Console.WriteLine(_question);

                saisieUtilisateur = Console.ReadLine() ?? "";

                saisieOK = float.TryParse(saisieUtilisateur, out valeurRetour) && valeurRetour >= 0;

                if (!saisieOK)
                {
                    Console.WriteLine("Saisie invalide, veuillez entrer un nombre float positif !");
                }
            }
            while (!saisieOK);
            return valeurRetour;


        }
    }
}
