using System;

namespace Exercice28_WhileNbMystere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            Random aleatoire = new Random();
            int nbMystere = aleatoire.Next(1, 51);
            int nbCoups = 0;
            bool trouve = false;
            //Console.WriteLine(nbMystere);
            #endregion

            #region Boucle While : Tant que le nombre mystere n'est pas trouvé
            Console.WriteLine("--- Trouver le nombre mystere ---\n");
            while (!trouve)
            {
                Console.Write("\tVeuillez saisir un nombre : ");
                int nbTmp= Convert.ToInt32(Console.ReadLine());
                nbCoups++;
                Comparer(nbTmp);               
            }
            #endregion

            #region Affichage des résultats
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nBravo vous avez trouve le nombre {nbMystere}");
            Console.WriteLine($"Vous avez trouvé en {nbCoups} coups");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion
            Console.Read();

            void PlusGrand()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tLe nombre mystere est plus grand");
                Console.ForegroundColor = ConsoleColor.White;
            }
            void PlusPetit()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tLe nombre mystere est plus petit");
                Console.ForegroundColor = ConsoleColor.White;
            }
            void Comparer(int nbUser)
            {
                if (nbUser == nbMystere)                
                    trouve = true;                
                else if (nbUser < nbMystere)                
                    PlusGrand();                
                else                
                    PlusPetit();                
            }
        }
    }
}
