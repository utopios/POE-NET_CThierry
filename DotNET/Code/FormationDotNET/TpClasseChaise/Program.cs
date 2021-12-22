using System;
using TpClasseChaise.Classes;

namespace TpClasseChaise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chaise 1
            Chaise chaise1 = new Chaise();
            chaise1.NbPieds = 4;
            chaise1.Couleur = "Bleu";
            chaise1.Materiaux= "Bois";

            chaise1.Afficher();
            #endregion

            #region Chaise 2
            Chaise chaise2 = new Chaise(4, "Blanche", "Métal");
            chaise2.Afficher();
            #endregion


            #region Chaise 3
            Chaise chaise3 = new Chaise(1, "Transparente", "Pléxiglass");
            chaise3.Afficher();
            #endregion

            Console.WriteLine(chaise3);

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme");
            Console.Read();

        }

    }
}
