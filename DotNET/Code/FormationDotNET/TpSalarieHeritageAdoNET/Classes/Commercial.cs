using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpSalarieHeritageAdoNET.Data;

namespace TpSalarieHeritageAdoNET.Classes
{
    internal class Commercial : Salarie
    {
        double chiffreAffaire;
        double commission;

        public Commercial():base()
        {

        }
        public Commercial(string matricule, string categorie, string service, string nom, double salaire,double chiffreAffaire, double commission):base(matricule, categorie, service,nom,salaire)
        {
            this.chiffreAffaire = chiffreAffaire;
            this.commission = commission;
        }

        public double ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public double Commission { get => commission; set => commission = value; }

        public override void CalculerSalaire()
        {
            base.CalculerSalaire();
            double salaireReel = Salaire + (ChiffreAffaire * Commission / 100);
            Console.WriteLine($"Le salaire avec commission de {Nom} est de {salaireReel} euros");
        }

        public void AfficherCommercial()
        {
            Console.WriteLine($"Je suis un super commercial");
        }

        public override int Ajouter()
        {
            // Instance de l'objet SqlConnection (Classe DataBase)
            SqlConnection connection = DataBase.Connection;
            // Redaction de la requete
            string request = "INSERT INTO COMMERCIAL (nom,matricule,categorie,service,salaire,chiffre,commission) OUTPUT INSERTED.id VALUES (@Nom,@Mat,@Categorie,@Service,@Salaire,@Ca,@Com)";
            // Instanciation de l'objet Command avec la requete et la connection;
            SqlCommand command = new SqlCommand(request, connection);
            // Rédaction des Parameters
            command.Parameters.Add(new SqlParameter("@Nom", Nom));
            command.Parameters.Add(new SqlParameter("@Mat", Matricule));
            command.Parameters.Add(new SqlParameter("@Categorie", Categorie));
            command.Parameters.Add(new SqlParameter("@Service", Service));
            command.Parameters.Add(new SqlParameter("@Salaire", Salaire));
            command.Parameters.Add(new SqlParameter("@Ca", ChiffreAffaire));
            command.Parameters.Add(new SqlParameter("@Com", Commission));
            // Ouvrir la connection vers la BDD
            connection.Open();
            // Execution de la requête
            int Id = (int)command.ExecuteScalar();
            command.Dispose();
            // Fermeture de la connection vers la BDD
            connection.Close();
            return Id;
        }

        public override string ToString()
        {
            return $"Je suis commercial";
        }
    }
}
