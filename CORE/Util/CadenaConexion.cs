using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Util
{
    public class CadenaConexion
    {
        public static string GetCadena()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "SPOVEDAVHP",
                InitialCatalog = "Pruebas",
                IntegratedSecurity = true,
                TrustServerCertificate = true
            };

            return sqlConnectionStringBuilder.ConnectionString;
        }
    }
}
