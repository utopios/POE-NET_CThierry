using System;

namespace Exercice31
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Déclaration des variables
            double maxNote = 0;
            double minNote = 20;
            double moyNotes = 0;
            double noteTmp = 0;
            int nbNotes = 0;
            string choixMenu;
            #endregion

            #region Interface Utilisateur
            do
            {
                Console.WriteLine("--- Gestion des notes avec menu ---\n");
                Console.WriteLine("1---- Saisir les notes");
                Console.WriteLine("2---- Afficher Meilleure note");
                Console.WriteLine("3---- Afficher la moins bonne note");
                Console.WriteLine("4---- Afficher la moyenne des notes");
                Console.WriteLine("0---- Quitter");
                Console.Write("\nVeuillez faire votre choix : ");
                choixMenu = Console.ReadLine();
                string BonChoix = "01234";
                while (!BonChoix.Contains(choixMenu))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur de saisie...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Veuillez faire votre choix : ");
                    choixMenu = Console.ReadLine();
                }
                Console.Clear();

                switch (choixMenu)
                {
                    case "1":
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("------ Saisir les notes : ------");
                        Console.WriteLine("(999 pour calculer) \n");
                        Console.ForegroundColor=ConsoleColor.White;

                        while (noteTmp !=999)
                        {
                            noteTmp=0;
                            
                            Console.Write($"\t-Merci de saisir la note {nbNotes+1} (sur /20) : ");
                            

                            if (double.TryParse(Console.ReadLine(), out double nb))
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
                            else if (noteTmp >20 || noteTmp <0)
                            {
                                Console.ForegroundColor=ConsoleColor.Red;
                                Console.WriteLine("\tErreur de saisie, Merci de saisir une note en 0 et 20!");
                                Console.ForegroundColor=ConsoleColor.White;
                                continue;
                            }

                            moyNotes += noteTmp;

                            if (noteTmp < minNote)
                                minNote=noteTmp;

                            if (noteTmp > maxNote)
                                maxNote=noteTmp;

                            nbNotes++;
                        }
                        break;
                    case "2":
                        if (moyNotes!=0)
                        {
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("------ La meilleur note ------\n");
                            Console.WriteLine($"La meilleure note est {maxNote}/20.\n");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir des notes avant...");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        break;
                    case "3":
                        if (moyNotes!=0)
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("------ La moins bonne note ------\n");
                            Console.WriteLine($"La moins bonne note est {minNote}/20.\n");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir des notes avant...");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        break;
                    case "4":
                        if (moyNotes!=0)
                        {
                            moyNotes /= nbNotes;
                            Console.ForegroundColor=ConsoleColor.Cyan;
                            Console.WriteLine("------ La moyenne des notes ------\n");
                            Console.WriteLine($"La moyenne des {nbNotes} notes est {moyNotes}/20.\n");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("Veuillez saisir des notes avant...");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Veuillez saisir un choix entre 0 et 4 inclus");
                        break;
                }

            } while (choixMenu != "0");
            #endregion

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme");
            Console.Read();
        }
    }
}
