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
            LePendu pendu = new LePendu(mot);
            #endregion

            #region Déclaration de variables
            char lettre;
            bool ok = false;
            #endregion

            #region Recupération du nombre d'essais par l'utilisateur ( 2nd partie du TP)
            while (!ok)
            {
                Console.Write("Combiens d'essai(s) souhaitez -vous ? ");
                if (int.TryParse(Console.ReadLine(), out int nb))
                {
                    pendu = new LePendu(mot, nb);
                    ok = true;
                    Console.WriteLine("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t Erreur de saisie , merci de saisir un nombre / un chiffre ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            #endregion

            #region Interface jeu pendu
            while (pendu.NbreEssai > 0)
            {
                Console.WriteLine("----- Le Jeu du Pendu -----\n");
                Console.WriteLine($"Le mot à trouver : {pendu.Masque}");
                Console.WriteLine($"Il vous reste {pendu.NbreEssai} essai(s)");
                // Récupération de la lettre proposée par l'utilisateur
                Console.Write($"Veuillez saisir une lettre : ");
                lettre = Convert.ToChar(Console.ReadLine().ToLower());
                // Envoie à la methode testChar, la lettre recupérée
                
                if (pendu.TestChar(lettre))                
                    Console.WriteLine("Bravo vous avez trouvé une lettre");                
                else
                    Console.WriteLine("Et non... essayez une autre lettre");

                
                if (pendu.TestWin())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo vous avez gagné!\n");                                   
                    Console.WriteLine($"Le mot à trouver était {pendu.MotATrouver}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Appuyez sur une touche pour fermer le programme");
                    Console.Read();
                    Environment.Exit(0);    
                }
                else if(pendu.NbreEssai==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous avez perdu!\n");
                    Console.WriteLine($"Le mot à trouver était {pendu.MotATrouver}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Appuyez sur une touche pour fermer le programme");
                    Console.Read();
                    Environment.Exit(0);
                }                
            }
            #endregion

            #region Fermeture du programme
            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
            #endregion


        }
    }
}
