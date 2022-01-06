using System;
using System.Collections.Generic;
using LesInterfaces.Classes;
using LesInterfaces.Interfaces;
namespace LesInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Personne
            //Personne p = new Personne(new Adresse2()) { Nom="Di Persio", Prenom="Anthony"};
            //Console.WriteLine(p);
            #endregion

            #region Ivolant
            List<IVolant> volants = new List<IVolant>();
            volants.Add(new Oiseau());
            volants.Add(new Avion());
            volants.Add(new Drone());

            foreach (IVolant v in volants)
            {
                v.Voler();
            }

            IVolant avion = new Avion();
            IVolant oiseau = new Oiseau();
            IVolant drone = new Drone();

            TransportColis t = new TransportColis(oiseau);
            t.Transporter();
            t.Livrer();


            #endregion

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
