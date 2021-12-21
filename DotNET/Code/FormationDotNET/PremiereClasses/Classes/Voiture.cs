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

        // Constructeur Vide
        public Voiture()
        {
            Demaree = false;
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

        }

        public void Rouler()
        {

        }

        public void Stopper()
        {

        }

        public void Klaxonner()
        {

        }
    }
}
