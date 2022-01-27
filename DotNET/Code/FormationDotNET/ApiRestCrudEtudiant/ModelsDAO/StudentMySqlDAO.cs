﻿//using CrudEtudiant.Tools;
//using CrudEtudiant.Models;
//using System.Collections.Generic;

//namespace ApiRestCrudEtudiant.ModelsDAO
//{
//    public class StudentMySqlDAO 
//    {
//        public static bool AddStudent(Student s)
//        {
//            MySqlConnection connection = DataBaseConnection.Connection;
//            MySqlCommand command = new MySqlCommand("INSERT INTO students gender, firstName, lastName, email, student_number VALUES @Gender, @FirstName, @LastName, @Email, @StudentNumber", connection);
//            command.Parameters.Add(new MySqlParameter("@Gender", s.Gender));
//            command.Parameters.Add(new MySqlParameter("@FirstName", s.FirstName));
//            command.Parameters.Add(new MySqlParameter("@LastName", s.LastName));
//            command.Parameters.Add(new MySqlParameter("@Email", s.Email));
//            command.Parameters.Add(new MySqlParameter("@StudentNumber", s.StudentNumber));

//            connection.Open();
//            int nbLigne = command.ExecuteNonQuery();
//            command.Dispose();
//            connection.Close();
//            if (nbLigne > 0)            
//                return true;            
//            else
//                return false;
//        }

//        public static List<Student> GetStudents()
//        {
//            List<Student> liste = new List<Student>();
//            MySqlConnection connection = DataBaseConnection.Connection;
//            MySqlCommand command = new MySqlCommand("SELECT id, gender, firstName, lastName, email, student_number FROM students", connection);
//            connection.Open();
//            MySqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                Student s = new Student { Id = reader.GetInt32(0), Gender = reader.GetString(1), FirstName = reader.GetString(2), LastName = reader.GetString(3), Email = reader.GetString(4), StudentNumber = reader.GetInt32(5) };
//                liste.Add(s);
//            }
//            return liste;
//        }

//        public static Student GetStudent(int id)
//        {
//            Student s = null;
//            MySqlConnection connection = DataBaseConnection.Connection;
//            MySqlCommand command = new MySqlCommand("SELECT gender, firstName, lastName, email, student_number FROM students WHERE id = @Id", connection);
//            command.Parameters.Add(new MySqlParameter("@Id", id));
//            connection.Open();
//            MySqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//               s = new Student { Id = id, Gender = reader.GetString(0), FirstName = reader.GetString(1), LastName = reader.GetString(2), Email = reader.GetString(3), StudentNumber = reader.GetInt32(4) };
//            }
//            return s;
//        }

//        public static bool UpdateStudent(Student s)
//        {
//            MySqlConnection connection = DataBaseConnection.Connection;
//            MySqlCommand command = new MySqlCommand("UPDATE students SET gender = @Gender, firstName = @FirstName, lastName = @LastName, email = @Email, student_number = @StudentNumber WHERE id = @Id", connection);
//            command.Parameters.Add(new MySqlParameter("@Id", s.Id));
//            command.Parameters.Add(new MySqlParameter("@Gender", s.Gender));
//            command.Parameters.Add(new MySqlParameter("@FirstName", s.FirstName));
//            command.Parameters.Add(new MySqlParameter("@LastName", s.LastName));
//            command.Parameters.Add(new MySqlParameter("@Email", s.Email));
//            command.Parameters.Add(new MySqlParameter("@StudentNumber", s.StudentNumber));

//            connection.Open();
//            int nbLigne = command.ExecuteNonQuery();
//            command.Dispose();
//            connection.Close();
//            if (nbLigne > 0)            
//                return true;
//            else
//                return false;
//        }

//        public static bool DeleteStudent(int id)
//        {
//            MySqlConnection connection = DataBaseConnection.Connection;
//            MySqlCommand command = new MySqlCommand("DELETE FROM students WHERE id = @Id", connection);
//            command.Parameters.Add(new MySqlParameter("@Id", id));            
//            connection.Open();
//            int nbLigne = command.ExecuteNonQuery();
//            command.Dispose();
//            connection.Close();
//            if (nbLigne > 0)            
//                return true;
//            else
//                return false;
//        }
//    }
//}
