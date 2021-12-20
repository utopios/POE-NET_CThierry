using System;

namespace Exercice32
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            int[] tab = new int[10];
            string chaine = "";
            Random rnd = new Random();
            #endregion

            #region Insertion des valeurs par L'utilisateur
            //Console.WriteLine("Insertion des valeurs du tableau : ");
            //for (int i = 0; i < tab.Length; i++)
            //{
            //    Console.Write("Saisir la valeur " + (i + 1) + " : ");
            //    if (int.TryParse(Console.ReadLine(), out int nombre))
            //    {
            //        tab[i] = nombre;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }
            //}
            #endregion

            #region Affectation de valeurs entières, pris au hasard entre 1 et 10, au tableau
            Console.WriteLine("Affectation automatique des valeurs...\n");
            for (int i = 0; i < 10; i++)
            {
                tab[i] = rnd.Next(1, 11);
            }
            #endregion

            #region  affichage des valeurs du tableau
            Console.WriteLine("Affichage des valeurs du tableau : ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(chaine + tab[i]);
                chaine += "\t";
            }
            #endregion

            Console.WriteLine("Appuyez sur Enter pour fermer le programme");
            Console.ReadLine();
        }
    }
}
