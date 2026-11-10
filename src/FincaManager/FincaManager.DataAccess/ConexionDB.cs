using Microsoft.Data.SqlClient;
using System.Configuration;

namespace FincaManager.DataAccess
{
    public class ConexionDB
    {
        private string _cadenaConexion;

        public ConexionDB() => _cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionSQLServer"].ConnectionString;

        public SqlConnection MtdObtenerConexion() => new SqlConnection(_cadenaConexion);
    }
}
