using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesStructures.Classes
{
    internal struct PersonneStruct
    {
        private string nom;
        private string prenom;

        public PersonneStruct(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public void Afficher()
        {
            Console.WriteLine($"Nom = {Nom} - Prénom = {Prenom}");
        }
    }
}
