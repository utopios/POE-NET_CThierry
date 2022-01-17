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
    internal class CompteEpargne : Compte
    {
        private decimal taux;

        public CompteEpargne(decimal taux)
        {
            Taux = taux;
        }

        public CompteEpargne(decimal solde, Client client, decimal taux):base(solde,client)
        {
            Taux = taux;
        }
        public decimal Taux { get => taux; set => taux = value; }

        public override bool AjouterCompte()
        {
            SqlConnection connection = DataBase.Connection;
            string request = "INSERT INTO compte (solde,taux,coutOperation) OUTPUT INSERTED.id VALUES (@Solde,@Taux,@CoutOperation)";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Solde", Solde));
            command.Parameters.Add(new SqlParameter("@Taux", SqlDbType.Decimal) { Value = Taux });
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

            return nbLigne > 0;
        }

        public bool CalculInteret()
        {
            return base.Depot(new Operation(Solde*Taux/100));
        }
    }
}
