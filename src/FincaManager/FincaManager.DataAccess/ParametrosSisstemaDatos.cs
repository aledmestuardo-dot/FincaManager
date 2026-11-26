using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class ParametrosSisstemaDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<ParametrosSistemaEntidad> MtdConsultar()
        {
            List<ParametrosSistemaEntidad> listaParametrosSistema = new List<ParametrosSistemaEntidad>();

            try
            {
                using(SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string queryConsultar = @"";

                    using(SqlCommand cmd = new SqlCommand(queryConsultar, conn))
                    {
                        conn.Open();

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaParametrosSistema.Add(new ParametrosSistemaEntidad
                                {
                                    IdParametro = Convert.ToInt32(rd["IdParametro"]),
                                    Clave = Convert.ToString(rd["Clave"]) ?? string.Empty,
                                    Valor = Convert.ToString(rd["Valor"]) ?? string.Empty,
                                    Descripcion = Convert.ToString(rd["Descripcion"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaParametrosSistema;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Parametros del Sistema", ex);
            }
        }
    }
}
