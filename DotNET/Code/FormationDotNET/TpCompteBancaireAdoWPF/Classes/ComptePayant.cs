using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageAdoNET.Data;

namespace TpCompteBancaireAdoWPF.Classes
{
    internal class ComptePayant : Compte
    {
        private decimal coutOperation;

        public ComptePayant(decimal coutOperation)
        {
            CoutOperation = coutOperation;
        }

        public ComptePayant(decimal solde, Client client, decimal coutOperation):base(solde, client)
        {
            CoutOperation = coutOperation;
        }

        public decimal CoutOperation { get => coutOperation; set => coutOperation = value; }

        public override bool AjouterCompte()
        {
            SqlConnection connection = Connection.New;
            string request = "INSERT INTO compte (solde,taux,coutOperation) OUTPUT INSERTED.id VALUES (@Solde,@Taux,@CoutOperation)";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Solde", Solde));
            command.Parameters.Add(new SqlParameter("@Taux", SqlDbType.Decimal) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@CoutOperation", SqlDbType.Decimal) { Value = CoutOperation });

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

        public override bool Depot(Operation operation)
        {
            if (operation.Montant>coutOperation)
            {
                if (base.Depot(operation))
                {
                    return base.Retrait(new Operation(CoutOperation * -1));
                }
            }
            return false;
        }
        public override bool Retrait(Operation operation)
        {
            if (Solde >= Math.Abs(operation.Montant) + CoutOperation)
            {
                if (base.Retrait(operation))
                {
                    return base.Retrait(new Operation(CoutOperation * -1));
                }
            }
            return false;
        }
    }
}
