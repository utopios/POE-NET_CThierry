using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TpListPersonAspNETCore.Data
{
    internal class DataBase
    {
        private static string chaine = @"Data Source=(LocalDb)\M2iCT;Integrated Security=True";

        public static SqlConnection Connection { get => new SqlConnection(chaine); }        
    }
}
