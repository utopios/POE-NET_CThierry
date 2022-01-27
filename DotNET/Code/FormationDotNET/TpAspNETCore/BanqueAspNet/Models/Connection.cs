using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BanqueWeb.Models
{
    public class Connection 
    {
        private static string connectionString = @"Data Source=(LocalDB)\M2iCT;Integrated Security=True";
        public static SqlConnection New => new SqlConnection(connectionString);
    }
}
