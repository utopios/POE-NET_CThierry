﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEtudiant.ModelsDAO;

namespace CrudEtudiant.Models
{
    public class Student
    {
        private int id;
        private string gender;
        private string firstName;
        private string lastName;
        private string email;
        private int studentNumber;

        public Student()
        {

        }

        public Student(string gender,string firstName, string lastName,string email, int studentNumber)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            StudentNumber = studentNumber;
        }

        public int Id { get => id; set => id = value; }
        public string Gender { get => gender; set => gender = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        
        
        public override string ToString()
        {
            return base.ToString();
        }

        public bool Add()
        {
            
            return StudentMySqlDAO.AddStudent(this);
            // return StudentDAO.AddStudent(this);
        }

        public static List<Student> Get()
        {
            return StudentMySqlDAO.GetStudents();
        }

        public static Student Get(int Id)
        {
            return StudentMySqlDAO.GetStudent(Id);
        }

        public bool Update()
        {
            return StudentMySqlDAO.UpdateStudent(this);
        }

        public static bool Delete(int Id)
        {
            return StudentMySqlDAO.DeleteStudent(Id);
        }
    }
}
