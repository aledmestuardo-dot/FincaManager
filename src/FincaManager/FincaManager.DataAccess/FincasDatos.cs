using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class FincasDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<FincasEntidad> MtdConsultar()
        {
            List<FincasEntidad> listaFincas = new List<FincasEntidad>();

            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string queryConsultar = @"";

                    using(SqlCommand cmd = new SqlCommand(queryConsultar, conn))
                    {
                        conn.Open();

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaFincas.Add(new FincasEntidad
                                {
                                    IdFinca = Convert.ToInt32(rd["IdFinca"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Ubicacion = rd["Ubicacion"] == DBNull.Value ? string.Empty : Convert.ToString(rd["Ubicacion"]) ?? string.Empty,
                                    AreaTotal = Convert.ToDecimal(rd["AreaTotalManzanas"]),
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaFincas;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Fincas", ex);
            }
        }
    }
}
