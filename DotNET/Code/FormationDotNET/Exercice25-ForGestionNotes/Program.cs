using System;

namespace Exercice25_ForGestionNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            int nbNotes;
            double maxNote =0;
            double minNote = 20;
            double moyenne =0;
            #endregion

            #region Récupération des saisies de l'utilisateur
            Console.WriteLine("\n--- Gestion des notes ---");
            Console.Write("\nCombien de notes voulez-vous saisir ? ");
            nbNotes=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 1; i <= nbNotes; i++)
            {
                Console.Write($"\t-Veuillez saisir la note {i} : ");
                double noteTMP = Convert.ToDouble(Console.ReadLine());

                moyenne += noteTMP;

                if (noteTMP > maxNote)
                {
                    maxNote = noteTMP;
                }
                if (noteTMP < minNote)
                {
                    minNote = noteTMP;
                }
            }
            #endregion

            #region Calcul de la moyenne
            moyenne /= nbNotes;
            #endregion

            #region Affichage des résultats
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nLa meilleur note est {maxNote}/20");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La moins bonne note est {minNote}/20");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"La moyenne des notes est de {moyenne}/20");
            #endregion



            Console.WriteLine("\n\nAppuyez sur Entrer pour fermer le programmme ...");
            Console.Read();
        }
    }
}
