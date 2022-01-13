using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpSalarieHeritageAdoNET.Data;

namespace TpSalarieHeritageAdoNET.Classes
{
    internal class Salarie
    {
        private int id;
        string nom;
        string matricule;
        string categorie;
        string service;
        double salaire;
        //private static int compteur = 0;

        public Salarie()
        {
            //compteur++;
        }
        public Salarie(string matricule, string categorie, string service, string nom, double salaire) : this()
        {
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Nom = nom;
            Salaire = salaire;
        }

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public double Salaire { get => salaire; set => salaire = value; }
        public int Id { get => id; set => id = value; }

        public virtual void CalculerSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de {Salaire} euros");
        }        

        public void Afficher()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de {Salaire} Euros");
        }

        public override string ToString()
        {
            return $"Je suis salarié";
        }

        public virtual int Ajouter()
        {
            // Instance de l'objet SqlConnection (Classe DataBase)
            SqlConnection connection = DataBase.Connection;
            // Redaction de la requete
            string request = "INSERT INTO SALARIE (nom,matricule,categorie,service,salaire) OUTPUT INSERTED.Id VALUES (@Nom,@Mat,@Categorie,@Service,@Salaire)";
            // Instanciation de l'objet Command avec la requete et la connection;
            SqlCommand command = new SqlCommand(request, connection);
            // Rédaction des Parameters
            command.Parameters.Add(new SqlParameter("@Nom", Nom));
            command.Parameters.Add(new SqlParameter("@Mat", Matricule));
            command.Parameters.Add(new SqlParameter("@Categorie", Categorie));
            command.Parameters.Add(new SqlParameter("@Service", Service));
            command.Parameters.Add(new SqlParameter("@Salaire", Salaire));
            // Ouvrir la connection vers la BDD
            connection.Open();
            // Execution de la requête
            int Id = (int)command.ExecuteScalar();
            command.Dispose();
            // Fermeture de la connection vers la BDD
            connection.Close();
            return Id;
        }

        public static List<Salarie> ListSalaries()
        {
            List<Salarie> liste = new List<Salarie>();
            SqlConnection connection = DataBase.Connection;
            string request = "SELECT * FROM SALARIE";
            SqlCommand command = new SqlCommand(request, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Salarie s = new Salarie() { Id = reader.GetInt32(0), Nom=reader.GetString(1),Matricule = reader.GetString(2),Categorie = reader.GetString(3),Service = reader.GetString(4), Salaire=reader.GetDouble(5) };
                liste.Add(s);
            }
            reader.Close();
            command.Dispose();
            request = "SELECT * FROM COMMERCIAL";
            command = new SqlCommand(request, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Salarie s = new Commercial() { Id = reader.GetInt32(0), Nom = reader.GetString(1), Matricule = reader.GetString(2), Categorie = reader.GetString(3), Service = reader.GetString(4), Salaire = reader.GetDouble(5), ChiffreAffaire =reader.GetDouble(6), Commission = reader.GetDouble(7)};
                liste.Add(s);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return liste;
        } 
    }
}
