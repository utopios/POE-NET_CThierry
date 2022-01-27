
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEtudiant.Tools
{
    public class DataBaseConnection
    {
        private static string chaine = @"Data Source=(LocalDB)\M2iCT;Integrated Security=True";

        public static SqlConnection Connection { get => new SqlConnection(chaine); }
    }
}
