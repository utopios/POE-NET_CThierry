using System;

namespace Exercice21_MenuEtSousMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menus et sous Menus ---\n");
            Console.WriteLine("Table des matières : \n");

            // Boucle itérative pour aller de 1 à 3 pour les chapitres
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("\tChapitre : {0}", i);
                // Boucle itérative imbriquée allant de 1 à 3 pour les sous parties
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine($"\t\t-Partie : {i}.{j}");
                }
            }
            Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
