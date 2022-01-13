using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritageAdoNET.Classes
{
    internal class Compte
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;

        public event Action<decimal, int> ADecouvert;

        public Compte()
        {
            this.operations = new List<Operation>();
        }

        public Compte(decimal solde, Client client)
        {            
            this.solde = solde;
            this.client = client;            
        }

        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Operation> Operations { get => operations; set => operations = value; }
               

        public virtual bool AjouterCompte()
        {
            return true;
        }

        public static Compte RechercherCompte(int id)
        {
            Compte c = new Compte();
            return c;
        }

        public virtual bool Depot(Operation operation)
        {
            return false;
        }
        public virtual bool Retrait(Operation operation)
        {
            return false;
        }

        public int MiseAJourCompte()
        {
            int nbLigne=0;
            return nbLigne;
        }
        public static void ActionNotificationADecouvert(decimal solde, int compte)
        {
            Console.WriteLine($"Le compte numéro {compte} est à découvert, voici le nouveau solde {solde} €uros");
        }

        public override string ToString()
        {
            string result = $"Client : {Client}\n";
            result += $"Solde : {Solde} Euros";
            Operations.ForEach(o =>
            {
                result += $"{o}\n";
            }
            );
            return result;
        }
    }
}
