using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class Operation
    {
        private int id;
        private decimal montant;
        private DateTime dateOperation;
        private static int compteur=0;

        public Operation()
        {
            Id = ++compteur;
        }
        public Operation(decimal montant):this()
        {            
            Montant = montant;
            DateOperation = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }
        public static int Compteur { get => compteur; }

        public override string ToString()
        {
            return $"ID : {Id}, Date/Heure : {DateOperation}, Montant : {Montant}Euros";
        }
    }
}
