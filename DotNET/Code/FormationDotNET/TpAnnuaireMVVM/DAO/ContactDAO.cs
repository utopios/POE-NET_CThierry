using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAnnuaireMVVM.Models;
using TpAnnuaireMVVM.Tools;

namespace TpAnnuaireMVVM.DAO
{
    internal class ContactDAO : AbstractDAO<Contact>
    {
        public override bool Create(Contact element)
        {
            request = "INSERT INTO contact (firstname, lastname, phone, email) OUTPUT INSERTED.Id VALUES(@Firstname, @lastname, @Phone, @Email)";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Firstname", element.FirstName));
            command.Parameters.Add(new SqlParameter("@Lastname", element.LastName));
            command.Parameters.Add(new SqlParameter("@Phone", element.Phone));
            command.Parameters.Add(new SqlParameter("@Email", element.Email));
            connection.Open();
            element.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return element.Id > 0;
        }

        public override bool Delete(Contact element)
        {
            request = "DELETE FROM contact WHERE id = @Id";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Id", element.Id));            
            connection.Open();
            int NbLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return NbLigne > 0;
        }

        public override Contact Find(int index)
        {
            Contact contact = null;
            request = "SELECT (id,firstname, lastname, phone, email) FROM contact WHERE id = @Id";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Id", index));
            
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                contact = new Contact
                {
                    Id = index,
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Phone = reader.GetString(3),
                    Email = reader.GetString(4)
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contact;
        }        

        public override List<Contact> FindAll()
        {
            List<Contact> contacts = new List<Contact>();
            request = "SELECT id, firstname, lastname, phone, email FROM contact";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Phone = reader.GetString(3),
                    Email = reader.GetString(4)
                };
                contacts.Add(contact);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }

        public override bool Update(Contact element)
        {
            request = "UPDATE contact SET firstname=@FirstName, lastname=@LastName, phone=@Phone, email = @Email WHERE id=@Id";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@Id", element.Id));
            command.Parameters.Add(new SqlParameter("@Firstname", element.FirstName));
            command.Parameters.Add(new SqlParameter("@Lastname", element.LastName));
            command.Parameters.Add(new SqlParameter("@Phone", element.Phone));
            command.Parameters.Add(new SqlParameter("@Email", element.Email));
            connection.Open();
            int NbLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return NbLigne == 1;
        }
        public override List<Contact> Find(Func<Contact, bool> criteria)
        {
            List<Contact> contacts = new List<Contact>();
            FindAll().ForEach(c =>
            {
                if (criteria(c))                
                    contacts.Add(c);                
            });
            return contacts;
        }
    }
}
