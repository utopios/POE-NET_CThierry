using System;

namespace MethodeTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemple de tryParse
            string chaine="20";
            //string chaine = "abc";
            int age;
            if(int.TryParse(chaine, out age))
            {
                Console.WriteLine("La conversion est possible, age vaut :" + age);
            }
            else
            {
                Console.WriteLine("Convertion impossible!");
            }
            Console.WriteLine(age);
            #endregion
            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
