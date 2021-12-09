using System;

namespace Exercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calcul pour un carré
            Console.WriteLine("--- Calcul du périmetre d'un carré ---"+ Environment.NewLine);
            Console.Write("Entrez la longueur d'un des côté du carré : ");
            double longeurCote = Convert.ToDouble(Console.ReadLine());
            double perimetre = 4*longeurCote;
            double aire = longeurCote*longeurCote;
            Console.WriteLine($"Le périmetre du carré est de {perimetre} cm");
            Console.WriteLine($"L'aire du carré est de {aire} cm²");
            #endregion

            #region Calcul pour un rectangle
            Console.WriteLine("--- Calcul du périmetre d'un carré ---"+ Environment.NewLine);
            Console.Write("Entrez la longueur du rectangle : ");
            double longeur = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez la largeur du rectangle : ");
            double largeur = Convert.ToDouble(Console.ReadLine());
            double perimetreRectangle = 2*(longeur+largeur);
            double aireRectangle = longeur*largeur;
            Console.WriteLine($"Le périmetre du carré est de {perimetreRectangle} cm");
            Console.WriteLine($"L'aire du carré est de {aireRectangle} cm²");
            #endregion

            Console.WriteLine("Appuyez sur Enter pour ferme le programme...");
            Console.Read();
        }
    }
}
