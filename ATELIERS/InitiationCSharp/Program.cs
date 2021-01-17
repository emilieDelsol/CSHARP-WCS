using System;

namespace MoreOrLessInitiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 computerChoice = new Random().Next(0, 100); // Get a random integer value
            /* Si le booléen finished passe à true, l'exécution du code s'arrête */
            bool finished = false; // Comme le jeu vient de commencer, il n'est pas terminé

            while (!finished) // Tant que finished est différent de true
            {

                finished = PlayTurn(computerChoice);
            }
        }

        /* Cette fonction "joue" un tour de jeu. Ainsi, elle doit contenir toutes les opérations nécessaires à la réalisation d'un tour de jeu:
         * 1. Demander à l'utilisateur de choisir un nombre entre 1 et 100
         * 2. Afficher "moins", "plus" ou "égal" en fonction de la corrélation entre le nombre rentré par l'utilisateur et celui choisi par l'ordinateur
         * 3. Retourner un booléen à "true" si le joueur a deviné le bon nombre. Retourner faux si le nombre entré par l'utilisateur n'est pas égal au nombre choisi par l'ordinateur. */


        private static bool PlayTurn(Int32 computerChoice)
        {
            Console.Write("Choose a number: ");
            string userGuessAsString = Console.ReadLine();
            int userGuess = Convert.ToInt32(userGuessAsString);/* Convertit en entier la chaîne de caractères récupérée en console */

            PrintComputerHint(computerChoice, userGuess);
            /* Ici PlayTurn doit retourner "vrai" si computerChoice est égal à userGuess, et faux autrement. Ceci va permettre de savoir si le jeu doit continuer ou non */
            if (userGuess != computerChoice)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        /* Cette fonction affiche une aide à l'utilisateur. Ainsi:
         * 1. Si userGuess est strictement supérieur à computerChoice il faut afficher "moins"
         * 2. Si userGuess est strictement inférieur à computerChoice il faut afficher "plus"
         * 3. Si userGuess est égal à computerChoice il faut afficher "Les nombres sont égaux" */
        private static void PrintComputerHint(Int32 computerChoice, Int32 userGuess)
        {
            if (userGuess < computerChoice)
            {
                Console.WriteLine("It's more!");
            }
            else if (userGuess > computerChoice)
            {
                Console.WriteLine("Its less!");
            }
            else
            {
                Console.WriteLine("well done!");
            }
        }
    }
}
