using System;

namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom;
            Console.Write("Veuillez saisir votre prénom : ");
            prenom = Console.ReadLine();
            Console.WriteLine($"Bonjour {prenom}");

            Console.WriteLine("\n\nAppuyez sur une touche pour continuer...");
            Console.Read();
        }
    }
}
