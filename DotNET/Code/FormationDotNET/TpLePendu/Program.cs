using System;
using TpLePendu.Classes;

namespace TpLePendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Démarrage du jeu
            GenerateurDeMots mot = new GenerateurDeMots();
            LePendu lePendu = new LePendu(mot);
            #endregion

            #region Déclaration de variables

            #endregion

            #region Recupération du nombre d'essais par l'utilisateur ( 2nd partie du TP)

            #endregion

            #region Interface jeu pendu

            #endregion

            #region Fermeture du programme
            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
            #endregion


        }
    }
}
