using System;

namespace Exercice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int nbre1;
            //int nbre2;
            //Console.Write("Veuillez saisir un nombre : ");
            //nbre1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Veuillez saisir un deuxieme nombre : ");
            //nbre2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"La somme de ces deux nombre est {nbre1+nbre2}");

            //double nbre3;
            //double nbre4;
            //Console.Write("Veuillez saisir un nombre : ");
            //nbre3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Veuillez saisir un deuxieme nombre : ");
            //nbre4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"La somme de ces deux nombre est {nbre3+nbre4}");

            Console.Write("Veuillez saisir un nombre: ");

            decimal nombre1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Veuillez saisir un nombre: ");

            decimal nombre2 = Convert.ToDecimal(Console.ReadLine());

            decimal resultat = nombre1 + nombre2;

            Console.Write("La somme des deux nombres est: " + resultat);

            Console.WriteLine("\n\nAppuyez sur une touche pour continuer...");
            Console.Read();
        }
    }
}
