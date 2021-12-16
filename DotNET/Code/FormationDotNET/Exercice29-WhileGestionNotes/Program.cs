using System;

namespace Exercice29_WhileGestionNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            double maxNote = 0;
            double minNote = 20;
            double moyNotes = 0;
            double noteTmp = 0;
            int nbNotes = 0;
            #endregion

            #region While pour les saisie de notes
            Console.WriteLine("--- Gestion des notes ---\n");
            Console.WriteLine("Veuillez saisir les notes : ");
            Console.WriteLine("(999 pour calculer) \n");

            while (noteTmp !=999)
            {
                noteTmp=0;

                Console.Write($"\t-Merci de saisir la note {nbNotes+1} : ");

                if(double.TryParse(Console.ReadLine(), out double nb))
                {
                    noteTmp=nb;
                }
                else
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("\tErreur de saisie, Merci de saisir un chiffre/nombre!");
                    Console.ForegroundColor=ConsoleColor.White;
                    continue;
                }

                if (noteTmp==999)
                {
                    break;
                }
                else if(noteTmp >20 || noteTmp <0)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("\tErreur de saisie, Merci de saisir une note en 0 et 20!");
                    Console.ForegroundColor=ConsoleColor.White;
                    continue;
                }

                moyNotes += noteTmp;

                if(noteTmp < minNote)
                    minNote=noteTmp;

                if(noteTmp > maxNote)
                    maxNote=noteTmp;

                nbNotes++;
            }
            #endregion

            #region Calcul de la moyenne
            moyNotes /= nbNotes;
            #endregion

            #region Affichage des résultats
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"La meilleure note est {maxNote}/20.");
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"La moins bonne note est {minNote}/20.");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine($"La moyenne des {nbNotes} notes est {moyNotes}/20.");
            #endregion

            #region Programme Jamila
            //Console.WriteLine("---Gestion des notes---");
            //double notemin = 20;
            //double notemax = 0;
            //double moyenne = 0;
            //int i = 0;
            //double noteTmp = 0;

            //while (noteTmp != 999)
            //{
            //    Console.Write($"\t-Merci de saisir la note {i+1} (sur/20) : ");
            //    noteTmp = Convert.ToDouble(Console.ReadLine());
            //    //Console.WriteLine(i);
            //    if (noteTmp > 20 || noteTmp < 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"\t\t Erreur de saisie, la note est sur 20!");
            //        Console.ForegroundColor = ConsoleColor.White;
            //        continue;
            //    }
            //    else if (noteTmp != 999)
            //    {
            //        moyenne = moyenne + noteTmp;
            //        i++;

            //        if (noteTmp < notemin)
            //        {
            //            notemin = noteTmp;
            //        }
            //        if (noteTmp > notemax)
            //        {
            //            notemax = noteTmp;
            //        }
            //    }
            //}
            //moyenne = moyenne / i;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"La meilleure note est {notemax}/20");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"La moins bonne note est {notemin}/20");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"La moyenne des notes est {Math.Round(moyenne, 0)}/20");
            #endregion

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme");
            Console.Read();
        }
    }
}
