using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereClasses.Classes
{
    internal class Voiture
    {
        // Les attributs (Toujours en privé)
        private string model;
        private string couleur;
        private int reservoir;
        private int autonomie;
        private bool demaree;
        private bool roule;

        // Constructeur Vide
        public Voiture()
        {
            Demaree = false;
            roule = false;
        }

        public Voiture(string Model) : this()
        {
            this.Model = Model;
        }

        // Constructeur avec 4 paramètres 
        public Voiture(string Model, string Couleur, int Reservoir, int Autonomie) : this()
        {
            this.Model=Model;
            this.Couleur=Couleur;
            this.Reservoir=Reservoir;
            this.Autonomie=Autonomie;
        }

        // Propriétés
        public string Model { get => model; set => model=value; }
        public string Couleur { get => couleur; set => couleur=value; }
        public int Reservoir { get => reservoir; set => reservoir=value; }
        public int Autonomie { get => autonomie; set => autonomie=value; }
        public bool Demaree { get => demaree; set => demaree=value; }
        public bool Roule { get => roule; set => roule=value; }


        // Méthode de la classe Voiture
        public void Demarrer()
        {
            if (!Demaree)
            {
                Demaree=true;
                Console.WriteLine("La voiture est démarée, le moteur tourne!");
            }
            else
            {
                Console.WriteLine("Le moteur est déja démarré ! ! !");
            }
        }

        public void Arreter()
        {
            if (!Roule)
            {
                if (demaree)
                {
                    Console.WriteLine("Extinction du moteur, le moteur est éteint...");
                    Demaree = false;
                }
                else
                {
                    Console.WriteLine("Le moteur ne tourne pas !!! Impossible de l'arreter...");
                }
            }
            else
            {
                Console.WriteLine("Veuillez stopper le véhicule avant d'arrêter le moteur");
            }
        }

        public void Rouler()
        {
            if (Demaree)
            {
                if (Reservoir >=5)
                {
                    Roule=true;
                    Console.WriteLine("Je roule 100km");
                    Reservoir -=5;
                    Console.WriteLine($"Il vous reste {Reservoir} litres de carburant");
                }
                else
                {
                    Console.WriteLine("Veuillez faire le plein avant de rouler!");
                }
            }
            else
            {
                Console.WriteLine("Veuillez démarrer le véhicule avant!");
            }

        }

        public void Stopper()
        {
            if (roule)
            {
                Console.WriteLine("Arrêt du véhicule... la voiture est arrétée");
                roule=false;
            }
            else
            {
                Console.WriteLine("Le véhicule n'est pas en train de rouler, impossible de l'arrêter");
            }

        }

        public void Klaxonner()
        {
            Console.WriteLine("Tut! tut...");
        }
    }
}
