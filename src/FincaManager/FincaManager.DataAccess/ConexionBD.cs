using Microsoft.Data.SqlClient;
using System.Configuration;

namespace FincaManager.DataAccess
{
    public class ConexionBD
    {
        //Variable que almacenará la cadena de conexión en tipo string.
        private string _cadenaConexion;

        //Constructor que obtiene la cadena de conexión de app config y la almacena en la variable.
        public ConexionBD() => _cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionSQLServer"].ConnectionString;

        //Método que devolverá un objeto de tipo SqlConnection (que contiene la cadena de conexión) cuando este sea llamado.
        public SqlConnection MtdObtenerConexion() => new SqlConnection(_cadenaConexion);
    }
}
