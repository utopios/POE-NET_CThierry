using System;

namespace Affichage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Les commentaires

            //// Commentaire sur la ligne

            ///*
            //        Commentaire 
            //        multiligne
            // */

            ///// Commentaire pour la generation automatique de la documentation

            //#endregion

            //#region Affichage console
            ////Afficher un chaine de caractere dans la console sans retour à la ligne

            //Console.Write("Bonjour,");
            //Console.Write("je m'appelle ");
            //Console.Write("Anthony\n");

            ////Afficher un chaine de caractere dans la console sans retour à la ligne

            //Console.WriteLine("Je retourne à la ligne");
            //Console.WriteLine("La preuve !!!!");



            //#endregion

            //#region Lecture Console
            //// Lit un caracter ou une chaine depuis le flux clavier ( cast obligatoire)
            ////Console.Read();

            ////char @char = (char)Console.Read();
            ////Console.WriteLine(@char);

            //// Utiliser le concole.readline() qui lit et retourne une chaine de caractere
            ////string maChaine = Console.ReadLine();
            ////maChaine = maChaine + maChaine;
            ////Console.WriteLine(maChaine);


            //// Utilisation de la methode readLine() pour retourner une valeur numérique
            //// Convertion de la chaine en entier (int)
            //int nbre = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(nbre);


            //#endregion

            //#region Changement de couleur dans la console
            //Console.BackgroundColor = ConsoleColor.Blue;



            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Je suis en vert");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Je suis en rouge");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Je suis en blanc");

            //Console.BackgroundColor = ConsoleColor.Black;
            //#endregion

            #region Les caractères spéciaux
            /*
             * Le caractere \ echappe le caractere suivant de sa fonction principale
             */


            // Afficher un chemin d'accès aux dossiers 
            Console.WriteLine("c:\\repertoire\\MonFichier.ext");
            Console.WriteLine(@"c:\repertoire\MonFichier.ext");

            // Le \ avant les "
            Console.WriteLine("Bonjour, je m'appelle \"Anthony\" ");

            // Le \t pour afficher une tabulation
            Console.WriteLine("Ma liste de choses à faire : ");
            Console.WriteLine("\t-Apprendre le C#");
            Console.WriteLine("\t-Faire des exercices");
            Console.WriteLine("\t\t-What else...?");

            // Les caracteres spéciaux du charset UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Vous me devez 30€");
            #endregion

            #region Affichage de la date et de l'heure
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString());
            Console.WriteLine("La date est {0:d}, et l'heures est {0:t}",date);

            string nom = "Di Persio";
            string prenom = "Anthony";
            int age = 25;
            // Concatenation par le surcharge de la méthode WriteLine
            Console.WriteLine("Bonjour, je m'appelle {1} {0} et j'ai {2}ans",nom,prenom,age);
            // Concaténation par l'opérateur +
            Console.WriteLine("Bonjour, je m'appelle "+prenom+" "+nom+" et j'ai "+age+" ans");
            #endregion 

            Console.WriteLine("Hello World!");
        }
    }
}
