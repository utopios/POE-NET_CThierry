using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LesExceptionRegex.Classes
{
    internal class Tools
    {
        /*
         *  Pattern Regex
         *   ^ = commence
         *   $ = fin
         *   \d = Accpepter toutes les valeurs numeriques (digit)
         *   \w = Lettre , chiffre, underscore (_)
         *   \s = White-space (tabs, spaces)
         *   \D = Accpepter toutes les valeures sauf \d
         *   \W = Accpepter toutes les valeures sauf \w
         *   \S = Accpepter toutes les valeures sauf \s 
         *   \W = Accpepter toutes les valeures sauf \w
         *   | = ou 
         *   * = 0 ou plus
         *   + = Au moins une fois
         *   ? = 0 ou 1 fois
         *   [a-zA-Z] = Range de valeur (a à z mais aussi de A à Z)
         *   {1} = Nombre de répétition
         *   {2,4} = 2 à 4 fois
         *   . = tous les caractères   
         */

        public static bool IsName(string name)
        {
            string pattern = @"^([A-Z]{1})([a-zA-Z\s\-]*)$"; 
            return Regex.IsMatch(name,pattern);
        }

        public static bool IsPhone(string phone)
        {
            //string s ="+33 6 02 03 04 05";
            string pattern = @"^([+33|0]+)(\s|\.|\-)?([1-9]{1})(\.|\s|\-)?([0-9]{2}(\.|\s|\-)?){4}$";
            return Regex.IsMatch(phone, pattern);
        }
        public static bool IsEmail(string email)
        {
            // anthony.d@mail.utopios.net
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,11})$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
 