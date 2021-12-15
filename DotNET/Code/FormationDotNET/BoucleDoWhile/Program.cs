using System;

namespace BoucleDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Incrémentation d'un compteur
            int compteur = 1;
            do
            {
                Console.WriteLine("Le compteur affiche {0}", compteur);
                compteur++;
            } while (compteur <= 50);
            #endregion

            #region Même condition mais avec un compteur de départ à 51
            Console.WriteLine("La variable compteur {0}", compteur);
            do
            {
                Console.WriteLine("Le compteur affiche {0}", compteur);
                compteur++;
            } while (compteur <= 50);
            Console.WriteLine("La variable compteur {0}", compteur);
            #endregion


            Console.WriteLine("\n\nAppuyez sur Entrer pour fermer le programmme ...");
            Console.Read();
        }
    }
}
