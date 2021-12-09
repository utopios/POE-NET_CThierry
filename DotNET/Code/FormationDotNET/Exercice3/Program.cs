using System;

namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom;
            string nom;
            Console.Write("Veuillez saisir votre nom : ");
            nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            prenom = Console.ReadLine();
            Console.WriteLine($"Bonjour {prenom} {nom}");

            Console.WriteLine("\n\nAppuyez sur une touche pour continuer...");
            Console.Read();
        }
    }
}
