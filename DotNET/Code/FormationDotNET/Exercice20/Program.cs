using System;

namespace Exercice20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Je compte jusqu'à 10 ---\n");
            Console.WriteLine("Je commence à compter");
            int i;
            for( i = 1; i <= 10; i++ )
            {
                // Console.WriteLine("\t" + i);
                Console.WriteLine($"\t{i}");
                // Console.WriteLine("\t{0}",i);
            }
            Console.WriteLine($"Super ! Je sais compter jusqu'à {i-1}!");

            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
            Console.WriteLine("--- Menus et sous Menus ---\n");
            Console.WriteLine("Table des matières : \n");

            // Boucle itérativ pour aller de 1 à 3
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("\tChapitre : {0}", i);
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
