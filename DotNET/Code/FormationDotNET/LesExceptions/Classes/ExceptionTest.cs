using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptions.Classes
{
    internal class ExceptionTest
    {
        public static double SafeDivision(double nombre, double diviseur)
        {
            if (diviseur == 0)
            {
                throw new DivideByZeroException("Attention, vous tentez de diviser par 0, c'est impossible!");
            }
            return nombre / diviseur;
        }
    }
}
