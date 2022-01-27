//using System.Collections.ObjectModel;
//using Microsoft.Data.SqlClient;
//using TpListPersonAspNETCore.Data;
//using TpListPersonneAspNETCore.Models;

//namespace TpListPersonneAspNETCore.ModelsDAO
//{
//    public class PersonDAO
//    {
//        public static int AjouterPersonne(Person p)
//        {
//            SqlConnection connection = DataBase.Connection;
//            SqlCommand command = new SqlCommand("INSERT INTO personne (titre,nom,prenom,email,telephone) OUTPUT INSERTED.id VALUES (@Titre,@Nom,@Prenom,@Email,@Telephone)", connection);
//            command.Parameters.Add(new SqlParameter("@Titre", p.Title));
//            command.Parameters.Add(new SqlParameter("@Nom", p.LastName));
//            command.Parameters.Add(new SqlParameter("@Prenom", p.FirstName));
//            command.Parameters.Add(new SqlParameter("@Email", p.Email));
//            command.Parameters.Add(new SqlParameter("@Telephone", p.Phone));
//            connection.Open();
//            int id = (int)command.ExecuteScalar();
//            command.Dispose();
//            connection.Close();

//            return id;
//        }
//        public static Person TrouverPersonne(string nom, string prenom)
//        {
//            SqlConnection connection = DataBase.Connection;
//            Person p = null;
//            SqlCommand command = new SqlCommand("SELECT * FROM personne WHERE prenom = @Prenom AND nom = @Nom", connection);
//            command.Parameters.Add(new SqlParameter("@Nom", nom));
//            command.Parameters.Add(new SqlParameter("@Prenom", prenom));
//            connection.Open();
//            SqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                p = new Person()
//                {
//                    Id = reader.GetInt32(0),
//                    Title = reader.GetString(1),
//                    LastName = reader.GetString(2),
//                    FirstName = reader.GetString(3),
//                    Email = reader.GetString(4),
//                    Phone = reader.GetString(5)
//                };
//            }
//            reader.Close();
//            command.Dispose();
//            connection.Close();
//            return p;
//        }
//        public static Person TrouverPersonne(int id)
//        {
//            SqlConnection connection = DataBase.Connection;
//            Person p = null;
//            SqlCommand command = new SqlCommand("SELECT * FROM personne WHERE id = @id", connection);
//            command.Parameters.Add(new SqlParameter("@Id", id));
            
//            connection.Open();
//            SqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                p = new Person()
//                {
//                    Id = reader.GetInt32(0),
//                    Title = reader.GetString(1),
//                    LastName = reader.GetString(2),
//                    FirstName = reader.GetString(3),
//                    Email = reader.GetString(4),
//                    Phone = reader.GetString(5)
//                };
//            }
//            reader.Close();
//            command.Dispose();
//            connection.Close();
//            return p;
//        }
//        public static bool SupprimerPersonne(Person p)
//        {
//            SqlConnection connection = DataBase.Connection;
//            SqlCommand command = new SqlCommand("DELETE FROM personne WHERE id = @Id", connection);
//            command.Parameters.Add(new SqlParameter("@Id", p.Id));
//            connection.Open();
//            int nbLigne = command.ExecuteNonQuery();
//            command.Dispose();
//            connection.Close();
//            if (nbLigne > 0)
//                return true;
//            else
//                return false;
//        }
//        public static bool UpdatePersonne(Person p)
//        {
//            SqlConnection connection = DataBase.Connection;
//            string request = "UPDATE personne SET titre = @Titre, nom = @Nom, prenom = @Prenom, email = @Email, telephone = @Telephone WHERE id = @Id";
//            SqlCommand command = new SqlCommand(request, connection);
//            command.Parameters.Add(new SqlParameter("@Id", p.Id));
//            command.Parameters.Add(new SqlParameter("@Titre", p.Title));
//            command.Parameters.Add(new SqlParameter("@Nom", p.LastName));
//            command.Parameters.Add(new SqlParameter("@Prenom", p.FirstName));
//            command.Parameters.Add(new SqlParameter("@Email", p.Email));
//            command.Parameters.Add(new SqlParameter("@Telephone", p.Phone));
//            connection.Open();
//            int nbLigne = command.ExecuteNonQuery();
//            command.Dispose();
//            connection.Close();
//            if (nbLigne > 0)
//                return true;
//            else
//                return false;
//        }

//        public static ObservableCollection<Person> AvoirListePersonne()
//        {
//            SqlConnection connection = DataBase.Connection;
//            ObservableCollection<Person> liste = new ObservableCollection<Person>();
//            SqlCommand command = new SqlCommand("SELECT * FROM personne ORDER BY nom ASC", connection);
//            connection.Open();
//            SqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                Person p = new Person()
//                {
//                    Id = reader.GetInt32(0),
//                    Title = reader.GetString(1),
//                    LastName = reader.GetString(2),
//                    FirstName = reader.GetString(3),
//                    Email = reader.GetString(4),
//                    Phone = reader.GetString(5)
//                };
//                liste.Add(p);
//            }
//            reader.Close();
//            command.Dispose();
//            connection.Close();
//            return liste;
//        }
//    }
//}
