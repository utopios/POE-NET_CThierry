using System;

namespace Exercice22_TableMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Tables de multiplication ---\n");

            // Boucle itérative pour aller de 1 à 3 pour les chapitres
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Table de {0} :", i);
                // Boucle itérative imbriquée allant de 1 à 3 pour les sous parties
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"\t- {i} x {j} = {i*j}");
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine("\nAppuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
