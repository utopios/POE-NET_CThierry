using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestCrudEtudiant.ModelsDAO
{
    public abstract class BaseDAO
    {
        protected MySqlCommand command;
        protected MySqlDataReader reader;
        protected MySqlTransaction _transaction;
        protected MySqlConnection _connection;
        protected string request;
        public BaseDAO(MySqlConnection connection)
        {
            _connection = connection;
        }

        public BaseDAO(MySqlConnection connection, MySqlTransaction transaction) : this(connection)
        {
            _transaction = transaction;
        }
    }
}
