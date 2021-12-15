using System;

namespace Exercice24_ForChaineEntier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Metrique
            DateTime StartCounter;
            DateTime EndCounter;
            #endregion

            #region Algo Anthony
            Console.WriteLine("--- Les suites chaînées de nombres --- \n");
            Console.Write("Merci de saisir un nombre : ");
            int nombreAnt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nLes chaînes possible sont : ");
            StartCounter = DateTime.Now;
            for (int i = 1; i <= nombreAnt / 2 + 1; i++)
            {
                int sommeAnt = i;
                string chaine = nombreAnt + " = " + i;
                for (int j = i + 1; j <= nombreAnt / 2 + 1; j++)
                {
                    //somme = somme + j;
                    sommeAnt += j;
                    chaine += "+" + j;
                    if (sommeAnt == nombreAnt)
                    {
                        Console.WriteLine(chaine);
                        break;
                    }
                    else if (sommeAnt > nombreAnt)
                        break;
                }
            }
            EndCounter = DateTime.Now;
            Console.WriteLine($"Temps d'execution de l'algo : {EndCounter-StartCounter}");
            #endregion            

            #region Algo Jamila
            int somme = 0;
            int nombre;
            int valeur_depat_chaine = 1;

            Console.WriteLine("\n\n--- Les suites chaînés de nombre Jamila---");
            Console.Write("Merci de saisir un nombre: ");
            nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Les chaines possibles sont :  ");
            StartCounter = DateTime.Now;
            for (int i = 1; ; i++)
            {
                if (valeur_depat_chaine > (nombre / 2))
                {
                    break;
                }
                valeur_depat_chaine = i;
                somme = valeur_depat_chaine;

                for (int j = valeur_depat_chaine + 1; ; j++)
                {
                    somme = somme + j;
                    if (somme >= nombre)
                    {
                        if (somme == nombre)
                        {
                            Console.Write($" {nombre} = ");
                            for (int k = valeur_depat_chaine; k < j+1; k++)
                            {
                                if (k == j)
                                {
                                    Console.WriteLine($"{k}");
                                }

                                else
                                {
                                    Console.Write($"{k} + ");
                                }
                            }
                        }
                        break;
                    }
                }
            }
            EndCounter = DateTime.Now;
            Console.WriteLine($"Temps d'execution de l'algo : {EndCounter-StartCounter}ms");
            #endregion

            #region Algo Jérome
            print("\n\n--- Les suites chainées de nombres Jérome---\n");
            int toto = lireInt("Merci de saisir un nombre: ");
            int somme1;
            string somCh;
            string prout;
            StartCounter = DateTime.Now;
            for (int j = 1; j<toto; j++)
            {
                somme1 = 0;
                somCh = "";
                for (int i = j; i<toto; i++)
                {
                    somme1 += i;
                    prout = Convert.ToString(i);
                    if (somme1 == toto) { print($"{toto} = {somCh}{prout}\n"); break; }
                    else if (somme1>toto) break;
                    else somCh +=  prout + "+";
                }
            }

            static void print(string message) { Console.Write(message); }
            static int lireInt(string message = "") { Console.Write(message); return Convert.ToInt32(Console.ReadLine()); }

            EndCounter = DateTime.Now;
            Console.WriteLine($"Temps d'execution de l'algo : {EndCounter-StartCounter}ms");
            #endregion

            #region Algo Youness
            Console.WriteLine("\n\n--- Les suites chaînées de nombres Youness---\n");
            int nmbr;
            int sum;
            Console.Write("Merci de saisir un nombre : ");
            nmbr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nLes chaînes possible sont :");
            StartCounter = DateTime.Now;
            for (int j = 1; j < nmbr; j++)
            {
                sum = j;
                for (int i = j+1; i+j<= nmbr; i++)
                {
                    sum = sum + i;
                    if (sum == nmbr)
                    {
                        Console.Write($"\n{nmbr} = {j}");
                        for (int k = 1; k <= i - j; k++)
                        {
                            Console.Write($"+{k + j}");
                        }
                    }
                }
            }
            EndCounter = DateTime.Now;
            Console.WriteLine($"\nTemps d'execution de l'algo : {EndCounter-StartCounter}ms");
            #endregion

            Console.WriteLine("\n\nAppuyez sur Entrer pour fermer le programmme ...");
            Console.Read();
        }
    }
}
