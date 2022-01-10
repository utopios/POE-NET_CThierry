using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class Compte
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;
        private static int compteur = 0;

        public Compte()
        {
            Id = ++compteur;
        }
        public Compte(Client client):this()
        {           
            Solde = 0;
            Client = client;
            Operations = new List<Operation>();
        }

        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Operation> Operations { get => operations; set => operations = value; }

        public virtual bool Depot()
        {
            return true;
        }

        public virtual bool Retrait()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
