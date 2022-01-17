using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageAdoNET.Data;

namespace TpCompteBancaireHeritageAdoNET.Classes
{
    internal class IHM
    {
        public IHM()
        {
            DataBDD.Injecter();
        }

        public void Start()
        {
            string choix;

            do
            {
                Menu();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        ActionDepot();
                        break;
                    case "3":
                        ActionRetrait();
                        break;
                    case "4":
                        ActionAffichageCompte();
                        break;
                    case "5":
                        ActionCalculInterets();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (choix != "0");
        }

        private void Menu()
        {
            Console.WriteLine("------------- Banque Peu Populaire -------------");
            Console.WriteLine("1-  Créer un compte");
            Console.WriteLine("2-  Effectuer un dépot");
            Console.WriteLine("3-  Effectuer un retrait");
            Console.WriteLine("4-  Opérations et soldes");
            Console.WriteLine("5-  Calcul des intérêts\n");
            Console.WriteLine("0--  Quitter\n");
            Console.Write("Veuillez faire votre choix : ");
        }

        private void MenuCreationCompte()
        {
            Console.WriteLine("----- Type de Compte -----\n");
            Console.WriteLine("1-  Compte normal");
            Console.WriteLine("2-  Compte Epargne");
            Console.WriteLine("3-  Compte Payant\n");
            Console.Write("Veuillez faire votre choix : ");

        }

        private void TryRead(string message, Action ReadElement)
        {
            bool OK = false;
            do
            {
                Console.Write(message);
                try
                {
                    ReadElement();
                    OK = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!OK);
        }

        private void ActionCreationCompte()
        {
            Console.WriteLine("----- Création Client -----");
            Client client = new Client();
            TryRead("Merci de saisir votre nom : ", () => client.Nom = Console.ReadLine());
            TryRead("Merci de saisir votre prenom : ", () => client.Prenom = Console.ReadLine());
            TryRead("Merci de saisir votre téléphone : ", () => client.Telephone = Console.ReadLine());
            client.Id = client.Add();
            decimal solde = 0;
            Console.WriteLine("----- Création Compte -----");
            TryRead("Merci de saisir le solde initial : ", () => solde = Convert.ToDecimal(Console.ReadLine()));
            MenuCreationCompte();
            string choix = Console.ReadLine();
            Compte compte = null;
            switch (choix)
            {
                case "1":
                    compte = new Compte(solde, client);
                    break;
                case "2":
                    Console.Write("Saisir le taux : ");
                    decimal taux = Convert.ToDecimal(Console.ReadLine());
                    compte = new CompteEpargne(solde, client, taux);
                    break;
                case "3":
                    Console.Write("Saisir le coût par opération : ");
                    decimal coutOperation = Convert.ToDecimal(Console.ReadLine());
                    compte = new ComptePayant(solde, client, coutOperation);
                    break;
                default:
                    Console.WriteLine("Erreur de de choix");
                    break;
            }
            if (compte !=null)
            {
                compte.ADecouvert += Compte.ActionNotificationADecouvert;
                if (compte.AjouterCompte())
                    Console.WriteLine($"Compte ajouté avec le numero {compte.Id}");
                else
                    Console.WriteLine("Erreur lors de l'ajout du compte...");
            }
        }

        private void ActionDepot()
        {
            Compte compte = ActionRechercheCompte();

            if (compte !=null)
            {
                decimal montant = 0;
                TryRead("Merci de saisir montant du dépôt : ", () => montant = Convert.ToDecimal(Console.ReadLine()));
                Operation operation = new Operation(montant);
                if (compte.Depot(operation))
                    Console.WriteLine("Dépôt effectué");
                else
                    Console.WriteLine("Erreur lors du dépôt!");
            }
        }

        private void ActionRetrait()
        {
            Compte compte = ActionRechercheCompte();

            if (compte != null)
            {
                decimal montant = 0;
                TryRead("Merci de saisir montant du retrait : ", () => montant = Convert.ToDecimal(Console.ReadLine()));
                Operation operation = new Operation(montant * -1);
                if (compte.Retrait(operation))
                    Console.WriteLine("Retrait effectué");
                else
                    Console.WriteLine("Erreur lors du retrait!");
            }

        }
        private void ActionAffichageCompte()
        {
            Compte compte = ActionRechercheCompte();
            if (compte != null)
            {
                Console.WriteLine(compte);
            }
        }
        private void ActionCalculInterets()
        {
            Compte compte = ActionRechercheCompte();
            if (compte != null && compte is CompteEpargne compteEpargne)
            {
                if (compteEpargne.CalculInteret())                
                    Console.WriteLine("Les intérêts ont été ajoutés");                
                else
                    Console.WriteLine("Problème lors du calcul des intérêts...");
            }
        }

        private Compte ActionRechercheCompte()
        {
            Console.WriteLine("------ Rechercher un compte ------");
            int numeroCompte=0;
            TryRead("Merci de saisir le numéro de compte", () => numeroCompte = Convert.ToInt32(Console.ReadLine()));
            Compte compte = Compte.RechercherCompte(numeroCompte);
            if (compte == null)
            {
                Console.WriteLine("Aucun compte avec ce numero");
            }
            return compte;
        }
    }
}
