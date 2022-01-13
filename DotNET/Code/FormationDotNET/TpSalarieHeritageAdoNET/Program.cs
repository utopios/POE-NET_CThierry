using System;
using TpSalarieHeritageAdoNET.Classes;

namespace TpSalarieHeritageAdoNET
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
