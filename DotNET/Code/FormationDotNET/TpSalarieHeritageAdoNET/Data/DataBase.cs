using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpSalarieHeritageAdoNET.Data
{
    internal class DataBase
    {
        private static string chaine = @"Data Source=(LocalDB)\M2iCT;Integrated Security=True";

        public static SqlConnection Connection { get => new SqlConnection(chaine); }
    }
}
