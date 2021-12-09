using System;

namespace Exercice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom;
            string nom;
            int age;
            Console.Write("Veuillez saisir votre nom : ");
            nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            prenom = Console.ReadLine();
            Console.Write("Veuillez saisir votre age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bonjour {prenom} {nom}, vous avez {age} ans");

            Console.WriteLine("\n\nAppuyez sur une touche pour continuer...");
            Console.Read();
        }
    }
}
