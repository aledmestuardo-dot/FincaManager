using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class RegistrosJornadaDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<RegistrosJornadaEntidad> MtdConsultar()
        {
            List<RegistrosJornadaEntidad> listaRegistros = new List<RegistrosJornadaEntidad>();

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
                                listaRegistros.Add(new RegistrosJornadaEntidad
                                {
                                    IdRegistroJornada = Convert.ToInt32(rd["IdRegistroJornada"]),
                                    IdEmpleado = Convert.ToInt32(rd["IdEmpleado"]),
                                    IdLoteSector = Convert.ToInt32(rd["IdLoteSector"]),
                                    IdTipoLabor = Convert.ToInt32(rd["IdTipoLabor"]),
                                    IdPeriodoCosecha = Convert.ToInt32(rd["IdPeriodoCosecha"]),
                                    Fecha = Convert.ToDateTime(rd["Fecha"]),
                                    CantidadRealizada = Convert.ToDecimal(rd["CantidadRealizada"]),
                                    TotalPagadoQuetzales = Convert.ToDecimal(rd["TotalPagadoQuetzales"])
                                });
                            }
                        }
                    }
                }
                return listaRegistros;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar los Registros de Jornadas", ex);
            }
        }
    }
}
