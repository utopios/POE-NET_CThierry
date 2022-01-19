using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListePersonneWPF.Classes;

namespace TpListePersonneWPF.Data
{
    internal class DataBase
    {
        private static string chaine = @"Data Source=(LocalDb)\M2iCT;Integrated Security=True";

        public static SqlConnection Connection { get => new SqlConnection(chaine); }        
    }
}
