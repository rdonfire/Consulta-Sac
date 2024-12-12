using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaSql
{
    static class Conn
    {
        private static string server = @"DATA01\INPRD";
        private static string dataBase = "BDSONHO_PRODUCAO";
        private static string user = "readonly";
        private static string password = "read#only";


        public static string StrCon //propriedade
        {
            //get { return "Data Soucer=" + server + "; Integrated Security=False;Initial Catalog" + dataBase + "; User ID=" + user + "; Password" + password; }

            get { return $"Data Source={server}; Integrated Security = false; Initial Catalog={dataBase}; User ID={user}; Password={password}"; }

        }












    }
}
