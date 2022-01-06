using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;
namespace LesInterfaces.Classes
{
    internal class Oiseau : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris... comme je peux!");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis une branche d'un arbre..");

        }

        public void Voler()
        {
            Console.WriteLine("Je vole grace au battement de mes ailes");

        }
    }
}
