using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDelegues.Classes
{
    internal class Calculatrice
    {
        /*
         * Il existe deux type de délégate : Func / Action 
         *  Action => Délégué sans retour (Void)
         *  Func => Délégué avec un retour
         */


        /*
         *  Avec retour
         */

        //public delegate double DelegateMethodeCalcul(double a, double b);

        //public void Calcule(double a, double b, DelegateMethodeCalcul Methode)
        //{
        //    Console.WriteLine(Methode(a, b));
        //}       


        public void Calcule(double a, double b, Func<double, double, double> methode)
        {
            Console.WriteLine(methode(a, b));
        }

        /*
         * VOID
         */

        //public delegate void DelegateVoid(string s);

        //public void HowToDisplay(string message, DelegateVoid methode)
        //{
        //    methode(message);
        //}

        public void HowToDisplay(string message, Action<string> methode)
        {
            methode(message);
        }
    }
}
