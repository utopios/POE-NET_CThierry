using System;
using TpClasseSalarieHeritage.Classes;
namespace TpClasseSalarieHeritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHM ihm=new IHM();
            ihm.Start();

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
