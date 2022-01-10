using System;
using LesTuples.Classes;
namespace LesTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclaration d'un tuple
            (double, int) t1 = (4.5, 10);
            Console.WriteLine($"Tuple avec les élements {t1.Item1} and {t1.Item2}");

            // Avec des variables ayant un nom (type)
            (double Sum, int Count) t2 = (4.7, 5);
            Console.WriteLine($"La Somme de {t2.Count} plus {t2.Sum} est égale à {t2.Count+ t2.Sum}");

            // Affichage avec la méthode toString
            (double, int) t = (4.5, 3);
            Console.WriteLine(t);

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
