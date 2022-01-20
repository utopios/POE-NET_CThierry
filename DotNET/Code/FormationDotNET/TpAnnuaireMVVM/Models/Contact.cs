using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAnnuaireMVVM.DAO;
using TpAnnuaireMVVM.Tools;

namespace TpAnnuaireMVVM.Models
{
    internal class Contact
    {
        private int id;
        private string firstName;  
        private string lastName;  
        private string phone;  
        private string email;
        private static SqlCommand command;
        private static string request;
        private static SqlConnection connection;

        public int Id { get => id; set => id = value; }
        [Required]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required]
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public bool Save()
        {
            AbstractDAO<Contact> dao = new ContactDAO();
            return dao.Create(this);
        }

        public bool Update()
        {
            AbstractDAO<Contact> dao = new ContactDAO();
            return dao.Update(this);
        }

        public bool Delete()
        {
            AbstractDAO<Contact> dao = new ContactDAO();
            return dao.Delete(this);
        }

        public static Contact GetContactById(int id)
        {
            AbstractDAO<Contact> dao = new ContactDAO();
            return dao.Find(id);
        }

        public List<Contact> GetAll()
        {
            AbstractDAO<Contact> dao = new ContactDAO();
            return dao.FindAll();
        }

        public static List<Contact> SearchContact(string search)
        {
            AbstractDAO<Contact> dao = new ContactDAO();
            return dao.Find(c => c.Phone.Contains(search) || c.FirstName.Contains(search) || c.LastName.Contains(search));
        }
    }
}
