using System;

namespace BoucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boucle While Simple
            int compteur = 1;
            while (compteur <=50)
            {
                Console.WriteLine($"Le compteur affiche : {compteur}");
                compteur++;
            }
            #endregion

            #region La boucle while avec un booleen
            int compteur2 = 1;
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine($"Le compteur affiche : {compteur2}");                
                if (compteur2 == 50)
                    valid = true;
                compteur2++;
            } 

            #endregion



            Console.WriteLine("\n\nAppuyez sur Entrer pour fermer le programmme ...");
            Console.Read();
        }
    }
}
