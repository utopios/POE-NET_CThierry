using System;
using TpCompteBancaire.Classes;

namespace TpCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHM ihm = new IHM();
            ihm.Start();
            


            #region Fermeture du programme
            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
            #endregion
        }
    }
}
