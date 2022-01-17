using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageAdoNET.Data;

namespace TpCompteBancaireHeritageAdoNET.Classes
{
    internal class Operation
    {
        private int id;
        private int idCompte;
        private decimal montant;
        private DateTime dateOperation;

        public Operation(decimal montant)
        {
            Montant = montant;
            DateOperation = DateTime.Now;
        }
        public Operation(int Id, int idCompte, DateTime dateOperation, decimal montant ) :this(montant)
        {
            this.Id = Id;
            this.idCompte = idCompte;
            this.montant = montant;
            this.dateOperation = dateOperation;
        }

        public int Id { get => id; set => id = value; }
        public int IdCompte { get => idCompte; set => idCompte = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateOperation { get => dateOperation; set => dateOperation = value; }

        public override string ToString()
        {
            return $"Id : {Id}, Date : {dateOperation}, Montant : {Montant} Euros";
        }

        public int AjouterOperation(int id)
        {
            SqlConnection connection = DataBase.Connection;
            string request = "INSERT INTO operation (idCompte,dateOperation,montant) VALUES (@IdCompte,@DateOpe,@Montant)";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@IdCompte", id));
            command.Parameters.Add(new SqlParameter("@DateOpe", DateOperation));
            command.Parameters.Add(new SqlParameter("@Montant", Montant));

            connection.Open();
            int NbLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return NbLigne;
        }

        public static List<Operation> ChercherOperationParCompte(Compte c)
        {
            List<Operation> liste = new List<Operation>();
            SqlConnection connection = DataBase.Connection;
            string request = "SELECT * FROM operation WHERE idCompte= @IdCompte ";
            SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@IdCompte", c.Id));
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Operation o = new Operation(reader.GetInt32(0), c.Id, reader.GetDateTime(2), reader.GetDecimal(3));
                liste.Add(o);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return liste;            
        }
    }
}
