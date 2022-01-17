using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageAdoNET.Data;

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
            SqlConnection connection = DataBase.Connection;
            string request = "INSERT INTO compte (solde,taux,coutOperation) OUTPUT INSERTED.id VALUES (@Solde,@Taux,@CoutOperation)";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Solde", Solde));
            command.Parameters.Add(new SqlParameter("@Taux", SqlDbType.Decimal) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@CoutOperation", SqlDbType.Decimal) { Value = 0 });

            connection.Open();
            int IdCompte = (int)command.ExecuteScalar();
            command.Dispose();
            request = "INSERT INTO clientCompte (idClient,idCompte) VALUES (@IdClient,@IdCompte)";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@IdClient", Client.Id));
            command.Parameters.Add(new SqlParameter("@IdCompte", IdCompte));
            int nbLigne = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

            //if (nbLigne > 0)            
            //    return true;            
            //else            
            //    return false;


            // return nbLigne > 0 ? true : false;

            return nbLigne > 0;
        }

        public static Compte RechercherCompte(int id)
        {
            Compte compte = null;
            SqlConnection connection = DataBase.Connection;
            string request = "SELECT CB.Id, CB.nom, CB.prenom, CB.telephone, c.solde, c.taux, c.coutOperation FROM compte AS C INNER JOIN clientCompte AS CC ON C.Id = CC.IdCompte INNER JOIN clientBanque AS CB ON CC.IdClient = CB.Id WHERE CC.IdCompte = @Idcompte ";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Idcompte", SqlDbType.Int) { Value = id });
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetDecimal(5) > 0)
                {
                    compte = new CompteEpargne(reader.GetDecimal(5));
                }
                else if (reader.GetDecimal(6) > 0)
                {
                    compte = new ComptePayant(reader.GetDecimal(6));
                }
                else
                {
                    compte = new Compte();
                }
                if (compte != null)
                {
                    compte.Client = new Client() { Id = reader.GetInt32(0), Nom = reader.GetString(1), Prenom = reader.GetString(2), Telephone = reader.GetString(3) };
                    compte.Id = id;
                    compte.Solde = reader.GetDecimal(4);
                    compte.Operations = Operation.ChercherOperationParCompte(compte);
                    compte.ADecouvert += ActionNotificationADecouvert;
                }
            }
            reader.Close();
            command.Dispose();
            connection.Close();

            return compte;
        }

        public virtual bool Depot(Operation operation)
        {
            if (operation.Montant > 0)
            {
                if (operation.AjouterOperation(Id) > 0)
                {
                    Solde += operation.Montant;
                    if (MiseAJourCompte()>0)
                        return true;                   
                    else
                        return false;
                }
                else
                    return false;
            }
            return false;
        }
        public virtual bool Retrait(Operation operation)
        {
            if (operation.Montant < 0)
            {
                if (operation.AjouterOperation(Id) > 0)
                {
                    Solde += operation.Montant;
                    if (MiseAJourCompte() > 0)
                    {
                        if (Solde < 0)
                        {
                            if (ADecouvert != null)
                            {
                                ADecouvert(Solde, Id);
                            }                            
                        }
                        return true;
                    }                        
                    else
                        return false;
                }
                else
                    return false;
            }
            return false;
        }

        public int MiseAJourCompte()
        {
            SqlConnection connection = DataBase.Connection;
            string request = "UPDATE compte Set solde = @Solde WHERE id = @Id";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Solde", Solde));
            command.Parameters.Add(new SqlParameter("@id", Id));
            connection.Open();
            int nbLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbLigne;
        }
        public static void ActionNotificationADecouvert(decimal solde, int compte)
        {
            Console.WriteLine($"Le compte numéro {compte} est à découvert, voici le nouveau solde : {solde} €uros");
        }

        public override string ToString()
        {
            string result = $"\nClient : {Client}\n";
            result += $"\nSolde : {Solde} Euros\n";
            result += $"\n------- Liste des operations -------\n";
            Operations.ForEach(o =>
            {
                result += $"{o}\n";
            }
            );
            result += $"------------------------------\n";

            return result;
        }
    }
}
