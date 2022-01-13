using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageAdoNET.Data;

namespace TpCompteBancaireHeritageAdoNET.Classes
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;

        public Client() 
        {
        
        }

        public Client(string nom, string prenom, string telephone):this()
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom 
        { 
            get => nom;

            set
            {
                if (Tools.IsName(value))                
                    nom = value;                
                else
                    throw new FormatException("Erreur nom");
            } 
        }
        public string Prenom 
        { 
            get => prenom;
            set
            {
                if (Tools.IsName(value))
                    prenom = value;
                else
                    throw new FormatException("Erreur prénom");
            }
        }
        public string Telephone 
        { 
            get => telephone;
            set
            {
                if (Tools.IsPhone(value))
                    telephone = value;
                else
                    throw new FormatException("Erreur téléphone");
            }
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prénom : {prenom}, Téléphone : {Telephone}"; 
        }

        public int Add()
        {
            SqlConnection connection = DataBase.Connection;
            string request = "INSERT INTO clientBanque (nom,prenom,telephone) OUTPUT INSERTED.id VALUES (@Nom,@Prenom,@Telephone)";
            SqlCommand command = new SqlCommand( request, connection);
            command.Parameters.Add(new SqlParameter("@Nom",Nom));
            command.Parameters.Add(new SqlParameter("@Prenom",Prenom));
            command.Parameters.Add(new SqlParameter("@Telephone",Telephone));

            connection.Open();
            int Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id;
        }
    }
}
