using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;

namespace LesInterfaces.Classes
{
    internal class TransportColis
    {
        private IVolant volant;

        public TransportColis(IVolant v)
        {
            volant = v;
        }

        public void Transporter()
        {
            volant.Voler();
            Console.WriteLine("Je livre des colis...");
        }

        public void Livrer()
        {
            volant.Atterrir();
            Console.WriteLine("le colis est livré...");
        }
    }
}
