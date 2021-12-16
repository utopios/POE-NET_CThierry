using System;

namespace Exercice30_DoWhileChoixMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            string poursuivre = "OUI";
            string choix = "";
            #endregion

            #region Affichage de la question
            Console.WriteLine("--- Question à choix multiple ---");
            Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C#?");
            Console.WriteLine("\ta) quit\n\tb)continue\n\tc)break\n\td)exit\n");
            #endregion

            #region Demande et traitement de la réponse de l'utilsateur 
            do
            {
                // récupérer la saisie utilisateur (son choix)
                bool ok = false;
                while (!ok)
                {
                    string chaine = "ABCD";
                    Console.Write("Veuillez saisir votre réponse : ");
                    choix = Console.ReadLine().ToUpper();
                    ok = chaine.Contains(choix) ? true : false;
                    //if (chaine.Contains(choix))
                    //{
                    //    ok = true;
                    //}
                    //else
                    //{
                    //    ok = false;
                    //}
                }

                // Comparer le choix

                if (choix =="C")
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.Write("\nBravo !!! C'est la bonne réponse");
                    Console.ForegroundColor= ConsoleColor.White;
                    break;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.Write("Incorrecte!\n");
                    Console.ForegroundColor= ConsoleColor.White;
                }
                ok = false;
                while (!ok)
                {
                    Console.Write("Un nouvel essai ? Oui / Non : ");
                    poursuivre = Console.ReadLine().ToUpper();
                    ok = poursuivre == "OUI" || poursuivre == "NON" ? true : false;

                }


            } while (poursuivre=="OUI");
            #endregion

            Console.WriteLine("\nAppuyez sur ENTER pour fermer le programme");
            Console.Read();
        }
    }
}
