using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class RecibosDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<RecibosEntidad> MtdConsultar()
        {
            List<RecibosEntidad> listaRecibos = new List<RecibosEntidad>();

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
                                listaRecibos.Add(new RecibosEntidad
                                {
                                    IdRecibo = Convert.ToInt32(rd["IdRecibo"]),
                                    IdEmpleado = rd["IdEmpleado"] == DBNull.Value ? (int?)null : Convert.ToInt32(rd["IdEmpleado"]),
                                    IdProveedor = rd["IdProveedor"] == DBNull.Value ? (int?)null : Convert.ToInt32(rd["IdProveedor"]),
                                    CorrelativoInterno = Convert.ToString(rd["CorrelativoInterno"]) ?? string.Empty,
                                    Fecha = Convert.ToDateTime(rd["Fecha"]),
                                    MontoTotalQuetzales = Convert.ToDecimal(rd["MontoTotalQuetzales"]),
                                    Concepto = Convert.ToString(rd["Concepto"]) ?? string.Empty
                                });
                            }
                        }
                    }
                }
                return listaRecibos;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Recibos", ex);
            }
        }
    }
}
