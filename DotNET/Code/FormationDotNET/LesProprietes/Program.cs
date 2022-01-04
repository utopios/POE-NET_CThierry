using System;
using LesProprietes.Classes;

namespace LesProprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();

            p1.Nom = "Di Persio";
            p1.Prenom = "Anthony";
            //p1.Email = "Anthony@gmail.com";

            Personne p2 = new Personne("Abadi", "Ihab","ihab@gmail.com");
            Personne p3 = new Personne("A", "Ihab","ihab@gmail.com");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme");
            Console.Read();
        }
    }
}
