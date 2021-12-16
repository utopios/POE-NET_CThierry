using System;

namespace LesTableaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Création d'un tableau et assignation de valeurs (En string)
            string[] prenoms;// Déclaration d'une variable de type tableau
            prenoms = new string[6];// Allocation de la mémoire
            for (int i = 0; i < prenoms.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}",i,prenoms[i]);
            }
            // Affectation des valeurs
            prenoms[0] = "Anthony";
            prenoms[1] = "Fabien";
            prenoms[2] = "Meriem";
            prenoms[3] = "Tarik";
            prenoms[4] = "Olive";
            prenoms[5] = "Patrick";

            // Boucle pour itérer le contenu du tableau
            for (int i = 0; i < prenoms.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, prenoms[i]);
            }

            #endregion

            #region Création d'un tableau et assignation de valeurs (En int)
            int[] nombre;// Déclaration d'une variable de type tableau
            nombre = new int[6];// Allocation de la mémoire
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, nombre[i]);
            }
            // Affectation des valeurs
            nombre[0] = 5;
            nombre[1] = 3;
            nombre[2] = 4;
            nombre[3] = 2;
            nombre[4] = 6;
            nombre[5] = 1;

            // Boucle pour itérer le contenu du tableau
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, nombre[i]);
            }

            #endregion

            #region Création d'un tableau d'objets
            Console.WriteLine("Création du tableau d'objets 'tabs'");
            object[] tabs = new object[3];
            Console.WriteLine("Contenu de tabs");
            for (int i = 0; i < tabs.Length; i++)
            {
                Console.WriteLine(tabs[i]);
            }
            Console.WriteLine("Affectation de valeurs à tabs");
            tabs[0] = 12;
            tabs[1] = 1.2;
            tabs[2] = "Message";

            Console.WriteLine("Affichage du nouveau contenu de tabs");

            for (int i = 0; i < tabs.Length; i++)
            {
                Console.WriteLine(tabs[i]);
            }
            #endregion

            #region Création et assignation de valeurs à la volée
            double[] nombre2 = new double[] { 2.2, 3.3, 4.4, 5.5 };
            // double[] nombre2 = { 2.2, 3.3, 4.4, 5.5 };

            for (int i = 0; i < nombre2.Length; i++)
            {
                Console.WriteLine(nombre2[i]);
            }
            #endregion

            #region IndexOf()
            Console.WriteLine("L'index de Olive est {0}",Array.IndexOf(prenoms, "Olive"));
            #endregion

            #region Sort() (pour trier)
            Console.WriteLine("Avant le tri :");

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, nombre[i]);
            }
            Array.Sort(nombre);

            Console.WriteLine("Après le tri :");

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, nombre[i]);
            }

            #endregion


            #region Reverse()
            Array.Reverse(nombre);
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, nombre[i]);
            }
            #endregion

            Array.Sort(prenoms);
            for (int i = 0; i < prenoms.Length; i++)
            {
                Console.WriteLine("A l'index {0} : {1}", i, prenoms[i]);
            }
            Console.WriteLine("\nAppuyez sur ENTER pour fermer le programme");
            Console.Read();
        }
    }
}
