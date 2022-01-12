using System;
using System.Data.SqlClient;

namespace CoursAdoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Connexion a la base de données
            string connectionString = @"Data Source=(LocalDB)\M2iCT;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Executer une requêtes =>On utilise un objet de commande
            // Préparation de la commande
            // string request = "INSERT INTO Utilisateur (nom,prenom,email,telephone) VALUES ('Toto', 'Titi', 'tata@gmail.com','+33 6 12 34 56 78')";
            //string request = "INSERT INTO Utilisateur (nom,prenom,email,telephone) OUTPUT INSERTED.Id VALUES ('Doe', 'John', 'tata@gmail.com','+33 6 24 56 78 91')";
            //string request = "SELECT TOP 5 * FROM Utilisateur";

            // Instanciation de l'objet commande
            //SqlCommand command = new SqlCommand(request, connection);

            // Ouverture de la connection
            //connection.Open();

            // 1ere méthode d'éxecution d'une commande => Retourne le nombre de lignes affectées par la commande ( abusif = sans retour)
            //int nbLigne = command.ExecuteNonQuery();

            // 2eme méthode d'éxecution d'une commande => Retourne l'id de la ligne une fois inserée
            //int id = (int)command.ExecuteScalar();

            // 3eme méthode d'éxécution de la commande => Utilisation du reader pour retourner l'ensemble des lignes correspondantes
            //SqlDataReader reader = command.ExecuteReader();

            // Lire la totalité des lignes
            //while (reader.Read())
            //{
            //    Console.WriteLine($"Id:{reader.GetInt32(0)}, Nom:{reader.GetString(1)}, Prénom:{reader.GetString(2)}, Email:{reader.GetString(3)}, Téléphone:{reader.GetString(4)}");
            //}

            // Fermeture du reader
            //reader.Close();

            //Console.WriteLine(id);

            // Executer une requete contenant des variables => on utilise pour cela une requête avec des parametres
            Console.Write("Veuillez saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Veuillez saisir votre email : ");
            string email = Console.ReadLine();
            Console.Write("Veuillez saisir votre telephone : ");
            string telephone = Console.ReadLine();

            // Préparation de la commande
            string request = "INSERT INTO Utilisateur (nom,prenom,email,telephone) VALUES (@Nom, @Prenom, @Email, @Telephone)";
            SqlCommand cmd = new SqlCommand(request, connection);

            // Ajouter des parametres à la commande
            cmd.Parameters.Add(new SqlParameter("@Nom", nom));
            cmd.Parameters.Add(new SqlParameter("@Prenom", prenom));
            cmd.Parameters.Add(new SqlParameter("@Email", email));
            cmd.Parameters.Add(new SqlParameter("@Telephone", telephone));


            // Ouverture de la connection
            connection.Open();

            // Execution de la requete
            int nbLigne = cmd.ExecuteNonQuery();

            // Liberation de l'objet command
            cmd.Dispose();

            // Ouverture de la connection
            connection.Close();

            Console.WriteLine(nbLigne);






            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}
