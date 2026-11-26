using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class FacturasDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<FacturasEntidad> MtdConsultar()
        {
            List<FacturasEntidad> listaFacturas = new List<FacturasEntidad>();

            try
            {
                using(SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryConsultar = @"";

                    using(SqlCommand cmd = new SqlCommand(QueryConsultar, conn))
                    {
                        conn.Open();

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaFacturas.Add(new FacturasEntidad
                                {
                                    IdFactura = Convert.ToInt32(rd["IdFactura"]),                                   
                                    IdVenta = rd["IdVenta"] == DBNull.Value ? (int?)null : Convert.ToInt32(rd["IdVenta"]),                                   
                                    IdCompra = rd["IdCompra"] == DBNull.Value ? (int?)null : Convert.ToInt32(rd["IdCompra"]),  
                                    UuidFel = Convert.ToString(rd["UuidFel"]) ?? string.Empty,
                                    Serie = Convert.ToString(rd["Serie"]) ?? string.Empty,
                                    Numero = Convert.ToString(rd["Numero"]) ?? string.Empty,
                                    FechaEmision = Convert.ToDateTime(rd["FechaEmision"]),
                                    MontoTotal = Convert.ToDecimal(rd["MontoTotal"])
                                });

                                //FacturasEntidad facturas = new FacturasEntidad();

                                //facturas.IdFactura = Convert.ToInt32(rd["IdFactura"]);
                                //    //Convert.ToInt32(rd["IdVenta"]),                             
                                //    //Convert.ToInt32(rd["IdCompra"]),
                                //facturas.IdVenta = rd["IdVenta"] == DBNull.Value ? (int?)null : Convert.ToInt32(rd["IdVenta"]);
                                //facturas.IdCompra = rd["IdCompra"] == DBNull.Value ? (int?)null : Convert.ToInt32(rd["IdCompra"]);
                                //facturas.UuidFel = Convert.ToString(rd["UuidFel"]) ?? string.Empty;
                                //facturas.Serie = Convert.ToString(rd["Serie"]) ?? string.Empty;
                                //facturas.Numero = Convert.ToString(rd["Numero"]) ?? string.Empty;
                                //facturas.FechaEmision = Convert.ToDateTime(rd["FechaEmision"]);
                                //facturas.MontoTotal = Convert.ToDecimal(rd["MontoTotal"]);

                                //listaFacturas.Add(facturas);
                            }
                        }
                    }
                }

                return listaFacturas;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Facturas", ex);
            }
        }
    }
}
