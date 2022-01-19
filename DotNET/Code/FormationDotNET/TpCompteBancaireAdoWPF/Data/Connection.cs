using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritageAdoNET.Data
{
    internal class Connection
    {
        private static string chaine = @"Data Source=(LocalDB)\M2iCT;Integrated Security=True";

        public static SqlConnection New { get => new SqlConnection(chaine); }
    }
}
