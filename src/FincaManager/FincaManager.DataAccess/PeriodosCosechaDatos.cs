using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class PeriodosCosechaDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<PeriodosCosechaEntidad> MtdConsultar()
        {
            List<PeriodosCosechaEntidad> listaPeriodosCosecha = new List<PeriodosCosechaEntidad>();

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
                                listaPeriodosCosecha.Add(new PeriodosCosechaEntidad
                                {
                                    IdPeriodo = Convert.ToInt32(rd["IdPeriodo"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    FechaInicio = Convert.ToDateTime(rd["FechaInicio"]),
                                    FechaFin = Convert.ToDateTime(rd["FechaFin"]),
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaPeriodosCosecha;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Periodos de Cosecha", ex);
            }
        }
    }
}
