using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;
namespace LesInterfaces.Classes
{
    internal class Drone : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris à la verticale, ou sur les gens...");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle à la verticale");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole tout seul ! ! !");
        }
    }
}
