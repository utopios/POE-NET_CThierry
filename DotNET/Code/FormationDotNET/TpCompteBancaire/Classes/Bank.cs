using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaire.Classes
{
    internal class Bank
    {
        private List<Compte> comptes;

        public List<Compte> Comptes { get => comptes; set => comptes = value; }

        public Bank()
        {
            comptes = new List<Compte>();
        }

        public bool AjouterCompte()
        {
            return true;
        }

        public Compte RechercherCompte()
        {
            Compte compte = new Compte();
            return compte;
        } 
    }
}
