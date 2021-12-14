using System;

namespace BoucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration d'une variable d'itération et utilisation dans la boucle [Slide 65]
            int compteur;

            for (compteur =1; compteur <=10; compteur++)
            {
                Console.WriteLine("L'instruction a été exécutée {0} fois", compteur);
            }

            Console.WriteLine(compteur);
            #endregion

            #region Déclaration d'une variable d'itération à la volée
            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine($"La valeur de i est {i}");
            }

            // Console.WriteLine(i);
            #endregion

            #region Variable décrémentée
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"La valeur de i est {i}");
            }
            #endregion

            #region Itération de caractères
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }
            #endregion

            #region Boucles Imbriquées
            for (int i = 0; i <=3; i++)
            {
                Console.WriteLine("i = "+i);
                for (int j = 0; j <5; j++)
                {
                    Console.WriteLine("j = "+j);
                }
            }
            #endregion



            Console.WriteLine("Appuyez sur ENTER pour fermer le programme");
            Console.Read();
        }
    }
}
