using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class MovimientosFinancierosDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<MovimientosFinancierosEntidad> MtdConsultar()
        {
            List<MovimientosFinancierosEntidad> listaMovimientosFinancieros = new List<MovimientosFinancierosEntidad>();

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
                                listaMovimientosFinancieros.Add(new MovimientosFinancierosEntidad
                                {
                                    IdMovimientoFinanciero = Convert.ToInt32(rd["IdMovimientoFinanciero"]),
                                    IdCuentaFinanciera = Convert.ToInt32(rd["IdCuentaFinanciera"]),
                                    TipoMovimiento = Convert.ToString(rd["TipoMovimiento"]) ?? string.Empty,
                                    MetodoPago = Convert.ToString(rd["MetodoPago"]) ?? string.Empty,
                                    NumeroBoletaReferencia = Convert.ToString(rd["NumeroBoletaReferencia"]) ?? string.Empty,
                                    MontoQuetzales = Convert.ToDecimal(rd["MontoQuetzales"]),
                                    Fecha = Convert.ToDateTime(rd["Fecha"]),
                                    Concepto = Convert.ToString(rd["Concepto"]) ?? string.Empty
                                });
                            }
                        }
                    }
                }
                return listaMovimientosFinancieros;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar los Movimientos Finanieros", ex);
            }
        }
    }
}
