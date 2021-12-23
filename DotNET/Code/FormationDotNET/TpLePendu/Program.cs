using System;
using TpLePendu.Classes;

namespace TpLePendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateurDeMots mot = new GenerateurDeMots();
            LePendu lePendu = new LePendu();
            lePendu.GenerateurMasque(mot);


            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
