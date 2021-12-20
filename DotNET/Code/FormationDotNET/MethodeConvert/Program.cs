using System;

namespace MethodeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convertion d'une string en int avec Convert()
            string nombre = "20";
            int @int = Convert.ToInt32(nombre);
            Console.WriteLine(@int);
            //Cette méthode ne permet de convertir que des chaines numérique
            #endregion

            #region Limite de la méthode convert
            ////Caster une variable String non numerique avec une variable int !!! Provoque une erreur !!!
            //string chaine = "ABC";
            //int @int2 = Convert.ToInt32(chaine);
            //Console.WriteLine(@int2);
            #endregion

            Console.Read();
        }
    }
}
