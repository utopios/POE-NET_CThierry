using System;
using TpCompteBancaireHeritageAdoNET.Classes;

namespace TpCompteBancaireHeritageAdoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHM ihm = new IHM();
            ihm.Start();
        }
    }
}
