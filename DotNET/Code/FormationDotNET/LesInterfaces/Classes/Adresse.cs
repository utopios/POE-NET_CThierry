using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;

namespace LesInterfaces.Classes
{
    internal class Adresse : IAdresse
    {
        public void AdresseInformation()
        {
            Console.WriteLine("J'affiche l'adresse...");
        }

    }
}
