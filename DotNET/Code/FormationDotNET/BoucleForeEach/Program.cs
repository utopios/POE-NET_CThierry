using System;

namespace BoucleForeEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach avec une collection de type INT
            Console.WriteLine("Création d'un table T1 : ");
            int[] T1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Affichage de T1 : ");
            foreach (int nombre in T1)
            {
                Console.WriteLine(nombre);
            }
            #endregion

            #region Foreach avec une collection de type string
            Console.WriteLine("Création d'un table T2 : ");
            string[] T2 = { "1", "2", "3", "4", "5" };
            Console.WriteLine("Affichage de T2 : ");
            foreach (string chaine in T2)
            {
                Console.WriteLine(chaine);
            }
            #endregion


            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
