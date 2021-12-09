using System;

namespace Exercice7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calcul de la longueur de l'Hypothénuse ---"+ Environment.NewLine);
            Console.Write("Entrez la longueur du premier coté (en cm) : ");
            double premierCote = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez la longueur du deuxieme coté (en cm) : ");
            double deuxiemeCote = Convert.ToDouble(Console.ReadLine());

            double hypothenuse = Math.Round(Math.Sqrt(Math.Pow(premierCote, 2)+Math.Pow(deuxiemeCote, 2)),2);
            Console.WriteLine($"La longeur de l'hypothénuse est de {hypothenuse} cm ");



            Console.WriteLine("\n\nAppuyez sur Enter pour ferme le programme...");
            Console.Read();
        }
    }
}
