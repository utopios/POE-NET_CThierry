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

        }
    }
}
